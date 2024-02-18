using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LinePaint2
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/Create LevelData", order = 1)]
    public class LevelScriptableData : ScriptableObject
    {
        public int width, height;
        public Vector2Int brushStartCoords;
        public List<Conection> completePattern = new List<Conection>();

    }
}
