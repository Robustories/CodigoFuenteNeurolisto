using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LinePaint2
{
    [System.Serializable]

    public class Conection 
    {
        [SerializeField] private Vector2Int _startCoords;

        [SerializeField] private Vector2Int _endCoords;

        public Conection(Vector2Int startCoords, Vector2Int endCoords)
        {
            _startCoords = startCoords;
            _endCoords = endCoords;
        }

        public Vector2Int StartCoords { get => _startCoords; }

        public Vector2Int EndCoords { get => _endCoords; }
    
    }
}
