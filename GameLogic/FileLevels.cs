using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLogic
{
    public static class FileLevels
    {
        public static bool[,] GetLevel(int number)
        {
            try
            {
                string[] data = File.ReadAllText("level" + number + ".txt").Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                bool[,] GameMap = new bool[5, 5];
                string[] T;
                for (int i = 0; i < 5; i++)
                {
                    T = data[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < 5; j++)
                        switch (T[j])
                        {
                            case "0":
                                GameMap[i, j] = false;
                                break;
                            case "1":
                                GameMap[i, j] = true;
                                break;
                            default:
                                throw new Exception();
                        }
                }
                return GameMap;
            }
            catch (Exception)
            {
                throw new Exception("уровень не найден");
            }
        }
    }
}
