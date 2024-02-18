using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LinePaint2
{
public class LinePainScript : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
        

        private Vector2Int _startCoord;
        private Vector2Int _endCoord;

        public Vector2Int StartCoord { get => _startCoord; }
        public Vector2Int EndCoord { get => _endCoord; }

        public void SetConnectedCoords(Vector2Int startCoord, Vector2Int endCoord)
        {
            _startCoord = startCoord;
            _endCoord = endCoord;
        }

        public void SetRendererPosition(Vector3 startPos, Vector3 endPos)
        {
            
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, startPos);
            lineRenderer.SetPosition(1, endPos);
        }
    
}
}
