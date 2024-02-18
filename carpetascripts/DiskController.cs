using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskController : MonoBehaviour
{
 [SerializeField]
    private Camera _camera;

    [SerializeField]
    private Transform[] _moveTargets;
    
    [SerializeField]
    private float _moveSpeed;

    private bool _isMoving = false;

    private bool _canSaveMoveFromKey = true;
    private char _moveFromKey;
    private bool _canSaveMoveToKey = true;
    private char _moveToKey;

    // Disk components
    private GameObject _gameObject;
    private Rigidbody2D _rigidbody;
    private Transform _transform;

    private int[] _moveTargetsIndex = new int[2];
    private int _index = 0;

    //private float _waitTime = 0.1f;

    private bool _hasReachedSelectionPos = false;

    // Components of a selected disk.
    private Transform _selectionTransform;
    private Vector3 _selectionPosition;
    private Vector3 _deltaPosition = new Vector3(0f, 0.1f, 0f);
    [SerializeField]
    private float _risingSpeed = 1f;
    [SerializeField]
    private float _motionSpeed = 5f;

    private void Update()
    {
        if (HanoiTowerManager.HgameManager.CanPlay && !_isMoving)
        {
            if (HanoiTowerManager.HgameManager.IsAutoModeOn)
            {
                Debug.Log("Si has llegado hasta aquí, no hay autosolver");
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                {
                    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                    if (hit.collider != null)
                    {
                        

                        if (_canSaveMoveFromKey)
                        {
                            if (HanoiTowerManager.HgameManager.IsTowerSelectedValid(hit, true, _moveFromKey))
                            {
                                _moveFromKey = HanoiTowerManager.HgameManager.GetTowerKey(hit.collider.tag);

                                GameObject disk = HanoiTowerManager.HgameManager.PeekTower(_moveFromKey);
                                _selectionTransform = disk.GetComponent<Transform>();
                                _rigidbody = disk.GetComponent<Rigidbody2D>();

                                _rigidbody.bodyType = RigidbodyType2D.Kinematic;
                                _rigidbody.gravityScale = 0;
                                _rigidbody.angularDrag = 2;
                                _rigidbody.drag = 3;

                                _selectionPosition = new Vector3(_selectionTransform.position.x, _selectionTransform.position.y + 0.3f, _selectionTransform.position.z);

                                _canSaveMoveFromKey = false;
                            }
                        }
                        else if (_canSaveMoveToKey)
                        {
                            if (HanoiTowerManager.HgameManager.IsTowerSelectedValid(hit, false, _moveFromKey))
                            {
                                _moveToKey = HanoiTowerManager.HgameManager.GetTowerKey(hit.collider.tag);

                                _canSaveMoveToKey = false;

                                if (HanoiTowerManager.HgameManager.IsMoveSelectedValid(_moveFromKey, _moveToKey))
                                {
                                    // Allow the disc to move, and don't get user input
                                    // while it is still moving.
                                    _isMoving = true;

                                    _hasReachedSelectionPos = false;

                                    HanoiTowerManager.HgameManager.CurrentMoves++;
                                    HanoiTowerManager.HgameManager.RemainingMoves--;
                                    HanoiTowerUI.uIManager.UpdateCurrentMoves(HanoiTowerManager.HgameManager.CurrentMoves);
                                    HanoiTowerUI.uIManager.UpdateRemainingMoves(HanoiTowerManager.HgameManager.RemainingMoves);

                                    // Set up the moving disc components
                                    _gameObject = HanoiTowerManager.HgameManager.MoveTopDisk(_moveFromKey, _moveToKey);
                                    _transform = _gameObject.GetComponent<Transform>();
                                    _rigidbody = _gameObject.GetComponent<Rigidbody2D>();

                                    _rigidbody.gravityScale = 0;
                                    _rigidbody.angularDrag = 2;
                                    _rigidbody.drag = 3;
                                    _rigidbody.bodyType = RigidbodyType2D.Kinematic;


                                    SetMoveTargetsIndex();

                                    if (HanoiTowerManager.HgameManager.HasLevelFinished())
                                    {
                                        HanoiTowerUI.uIManager.ShowLevelCompletePanel();
                                        HanoiTowerUI.uIManager.HidePlaymodeUI();
                                        HanoiTowerManager.HgameManager.CanPlay = false;
                                        Debug.Log("Ha terminado");
                                    }
                                }
                                else
                                {
                                    

                                    _canSaveMoveFromKey = true;
                                    _canSaveMoveToKey = true;

                                    _rigidbody.bodyType = RigidbodyType2D.Dynamic;
                                    _rigidbody.gravityScale= 1;
                                    _rigidbody.angularDrag = 2;
                                    _rigidbody.drag = 3;

                                    _hasReachedSelectionPos = false;
                                    Debug.Log("3");
                                }
                            }
                            else
                            {
                                

                                _canSaveMoveFromKey = true;
                                _canSaveMoveToKey = true;

                                _rigidbody.bodyType = RigidbodyType2D.Dynamic;
                                _rigidbody.gravityScale = 1;
                                _rigidbody.angularDrag = 2;
                                _rigidbody.drag = 3;

                                _hasReachedSelectionPos = false;
                                Debug.Log("Objeto Soltado");
                            }
                        }
                    }
                    else
                    {
                        _canSaveMoveFromKey = true;
                        _canSaveMoveToKey = true;

                        if (_rigidbody != null)
                        {
                            _rigidbody.bodyType = RigidbodyType2D.Dynamic;
                            _rigidbody.gravityScale = 1;
                            _rigidbody.angularDrag = 2;
                            _rigidbody.drag = 3;
                            Debug.Log("Objeto no seleccionado");
                        }

                        _hasReachedSelectionPos = false;
                    }
                }
                else
                {
                    // If a disk has been selected but no tower destination
                    // has been specified, move it around.
                    if (_canSaveMoveFromKey == false && _canSaveMoveToKey == true)
                    {
                        if (!_hasReachedSelectionPos)
                        {
                            _selectionTransform.position = Vector3.MoveTowards(_selectionTransform.position, _selectionPosition, Time.deltaTime * _risingSpeed);

                            if (Vector3.Distance(_selectionTransform.position, _selectionPosition) <= 0.01)
                                _hasReachedSelectionPos = true;
                                Debug.Log("DiscoSeleccionado");
                        }
                        else
                        {
                            _selectionTransform.position = Vector3.Lerp(_selectionPosition, _selectionPosition + _deltaPosition, Mathf.PingPong(Time.timeSinceLevelLoad * _motionSpeed, 1f));
                        }
                    }
                }
            }
        }
        else
        {
            
            if (_isMoving)
                MoveDisc();
                
        }

        

        
    }

    

    // TODO: Change comment, does not define what is happening above
    // The disk is going to move to two position; first above its own tower, then above
    // the MoveTo tower.
    private void SetMoveTargetsIndex()
    {
        Debug.Log("Se han cambiado los indices");
        
        if (_moveFromKey == 'A')
            _moveTargetsIndex[0] = 0;
            
        else if (_moveFromKey == 'B')
            _moveTargetsIndex[0] = 1;
            
        else
            _moveTargetsIndex[0] = 2;
            

        if (_moveToKey == 'A')
            _moveTargetsIndex[1] = 0;
            
        else if (_moveToKey == 'B')
            _moveTargetsIndex[1] = 1;
            
        else
            _moveTargetsIndex[1] = 2;
            
    }

    private void MoveDisc()
    {
        _transform.position = Vector3.MoveTowards(
            _transform.position,
            _moveTargets[_moveTargetsIndex[_index]].position,
            Time.deltaTime * _moveSpeed);
            Debug.Log(Vector3.Distance(_moveTargets[_moveTargetsIndex[_index]].position, _transform.position));

        if (Vector3.Distance(_moveTargets[_moveTargetsIndex[_index]].position, _transform.position) <= 0.15)
        {
            Debug.Log("Se ha movido");
            if (_index == 1)
            {
                Debug.Log("Alla");
                _index = 0;
                _isMoving = false;
                _rigidbody.bodyType = RigidbodyType2D.Dynamic;
                _rigidbody.gravityScale = 1;
                _rigidbody.angularDrag = 2;
                _rigidbody.drag = 3;
                

                _canSaveMoveFromKey = true;
                _canSaveMoveToKey = true;
            }
            else
            {
                _index++;
                Debug.Log("Aquí");
                Debug.Log(_index);    
            }
        }
    }

    
}
