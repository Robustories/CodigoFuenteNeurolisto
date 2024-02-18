using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LinePaint2
{
    public static class GameLineManager 
    {
        public static GameStatus gameStatus = GameStatus.Playing;
        public static int currentLevel = 0;
        public static int totalDiamonds;
    }

    public enum GameStatus
    {
        Playing,Complete
    }
}
