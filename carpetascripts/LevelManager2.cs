using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LinePaint2
{
    public class LevelManager2 : MonoBehaviour
    {
        //[SerializeField] private CameraZoom gameCamera;
        //[SerializeField] private CameraZoom solutionCamera;
        [SerializeField] private Cell blockprefab;
        [SerializeField] private BrushController brush;
        [SerializeField] private LinePainScript linePaintPrefab;
        [SerializeField] private float cellSize;
        [SerializeField] private List<LevelScriptableData> levelScriptables;
        [SerializeField] private Vector3 gridOriginPos;

        private int width;
        private int height;
        private Cell[,] cells;
        private Grid grid;
        private SwipeController swipeController;
        private BrushController currentBrush;
        private List<Conection> inProgressPattern = new List<Conection>();
        private List<LinePainScript> connectedLinePaints = new List<LinePainScript>();
        
        

        private void Start()
        {
            swipeController = new SwipeController();
            swipeController.SetLevelManager(this);

            width = levelScriptables[GameLineManager.currentLevel].width;
            height = levelScriptables[GameLineManager.currentLevel].height;

            grid = new Grid();

            CompleteBoard();

            grid.Initialize(width, height, cellSize, gridOriginPos);
            cells = new Cell[width, height];

            CreateGrid(Vector3.zero);

            currentBrush = Instantiate(brush, grid.GetCellWorldPosition(levelScriptables[GameLineManager.currentLevel].brushStartCoords.x,
            levelScriptables[GameLineManager.currentLevel].brushStartCoords.y), Quaternion.identity);
            currentBrush.coords = new Vector2Int(0,0);


            //gameCamera.ZoomPerspectiveCamera(width, height);
        }

        private void CreateGrid(Vector3 originPos)
        {
            for (int x = 0; x < grid.GridArray.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GridArray.GetLength(1); y++)
                {
                    cells[x, y] = CreateCell(x, y, originPos);
                }

            }
        }

        private Cell CreateCell(int x, int y, Vector3 originPos)
        {
            Cell cell = Instantiate(blockprefab);
            cell.coords = new Vector2Int(x, y);
            cell.transform.localScale = new Vector3(cellSize, 0.25f, cellSize);
            cell.transform.position = originPos + grid.GetCellWorldPosition(x,y);
            return cell;

        }

        public void MoveBrush(Swipe direction)
        {
            Vector2Int newCoords = grid.GetCellXZBySwipe(currentBrush.coords.x, currentBrush.coords.y, direction);

            if (newCoords != new Vector2Int(-1, -1))
            {
                Vector3 finalPos = grid.GetCellWorldPosition(newCoords.x, newCoords.y);
                
                if(ConnectionAlreadyDone(currentBrush.coords, newCoords, true) == false)
                {

                
                inProgressPattern.Add(new Conection(currentBrush.coords, newCoords));
                cells[currentBrush.coords.x, currentBrush.coords.y].CellCenterPaint.gameObject.SetActive(true);

                LinePainScript linepaint = Instantiate(linePaintPrefab, new Vector3(0, 0.2f, 0), Quaternion.identity);
                linepaint.SetRendererPosition(currentBrush.transform.position + new Vector3(0,0.2f,0),
                finalPos + new Vector3(0, 0.2f, 0));
                linepaint.SetConnectedCoords(currentBrush.coords, newCoords);
                connectedLinePaints.Add(linepaint);
                }
                else
                {
                    RemoveConnectLinePaint(currentBrush.coords, newCoords);
                }

                if(levelScriptables[GameLineManager.currentLevel].completePattern.Count <= inProgressPattern.Count)
                {
                    if(IsLevelComplete())
                    {
                        GameLineManager.gameStatus = GameStatus.Complete;
                        Debug.Log("Level Completed");
                    }
                }

                currentBrush.transform.position = finalPos;
                currentBrush.coords = newCoords;
            }
        }

        private bool ConnectionAlreadyDone(Vector2Int startCoord, Vector2Int endCoord, bool RemoveItem)
        {
            bool connected = false;
            for (int i = 0; i < inProgressPattern.Count; i++)
            {
                if (inProgressPattern[i].StartCoords == startCoord && inProgressPattern[i].EndCoords == endCoord ||
                    inProgressPattern[i].EndCoords == endCoord && inProgressPattern[i].StartCoords == startCoord)
                {
                    if (RemoveItem)
                    {
                        inProgressPattern.RemoveAt(i);
                    }

                    connected = true;
                }
                    

                connected = true;
                
            }

            return connected;
        }

        private void RemoveConnectLinePaint(Vector2Int startCoord, Vector2Int endCoord)
        {
            for (int i = 0; i < connectedLinePaints.Count; i++)
            {
                if (connectedLinePaints[i].StartCoord == startCoord && connectedLinePaints[i].EndCoord == endCoord ||
                    connectedLinePaints[i].EndCoord == endCoord && connectedLinePaints[i].StartCoord == startCoord)
                {
                    LinePainScript line = connectedLinePaints[i];
                    connectedLinePaints.RemoveAt(i);
                    Destroy(line.gameObject);

                    cells[endCoord.x, endCoord.y].CellCenterPaint.gameObject.SetActive(false);
                    return;
                }
            }
        }

        private bool IsLevelComplete()
        {
            if (levelScriptables[GameLineManager.currentLevel].completePattern.Count != inProgressPattern.Count)
            {
                return false;

            }

            for (int i = 0; i < levelScriptables[GameLineManager.currentLevel].completePattern.Count; i++)
            {
                if (ConnectionAlreadyDone(levelScriptables[GameLineManager.currentLevel].completePattern[i].StartCoords, levelScriptables[GameLineManager.currentLevel].completePattern[i].EndCoords, false))
                {
                    return false;
                }
            }

            return true;
        }

        private void CompleteBoard()
        {
            grid.Initialize(width, height, cellSize, gridOriginPos);
            Vector3 offset = new Vector3((levelScriptables[GameLineManager.currentLevel].width - cellSize) / 2, 0, (levelScriptables[0].height - cellSize) / 2);
            //solutionCamera.transform.position += offset;

            //solutionCamera.ZoomOrthographicSizeCamera(leveldataArray[GameManager.currentLevel].width, leveldataArray[GameManager.currentLevel].height);

            for (int i = 0; i < levelScriptables[0].completePattern.Count; i++)
            {
                Vector3 startPos = grid.GetCellWorldPosition(levelScriptables[0].completePattern[i].StartCoords.x,
                levelScriptables[0].completePattern[i].StartCoords.y);
                Vector3 endPos = grid.GetCellWorldPosition(levelScriptables[0].completePattern[i].EndCoords.x,
                levelScriptables[0].completePattern[i].EndCoords.y);
                LinePainScript linePaint = Instantiate(linePaintPrefab, new Vector3(0, 0.2f, 0), Quaternion.identity);
                linePaint.SetRendererPosition(startPos, endPos);
            }
        }

        private void Update()
        {
            if( swipeController != null && GameLineManager.gameStatus == GameStatus.Playing)
            {
                swipeController.OnUpdate();

            }
        }
    }
}
