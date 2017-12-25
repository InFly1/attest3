using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Game
    {
        public bool[,] GameMap { get; private set; }

        public Game(bool[,] gameMap)
        {
            GameMap = gameMap;
        }
        public Game(int n)
        {
            GameMap = FileLevels.GetLevel(n);
        }
        private bool CheckWin()
        {
            foreach (bool item in GameMap)
            {
                if (item)
                    return false;
            }
            return true;
        }
        public void Switch(int Row, int Column, out bool Win)
        {
            GameMap[Row, Column] = !GameMap[Row, Column];
            if (Row != 0)
                GameMap[Row - 1, Column] = !GameMap[Row - 1, Column];
            if (Row != GameMap.GetLength(0) - 1)
                GameMap[Row + 1, Column] = !GameMap[Row + 1, Column];
            if (Column != 0)
                GameMap[Row, Column - 1] = !GameMap[Row, Column - 1];
            if (Column != GameMap.GetLength(1) - 1)
                GameMap[Row, Column + 1] = !GameMap[Row, Column + 1];
            Win = CheckWin();
        }
    }
}
