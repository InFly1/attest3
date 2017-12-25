using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public static class CutConvert
    {
        public static Cut StrToCut(string str)
        {
            try
            {
                string[] split = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return new Cut(double.Parse(split[0]), double.Parse(split[1]));
            }
            catch (Exception)
            {
                throw new Exception("некорректная строка");
            }
        }
        public static List<Cut> StrToListCuts(string str)
        {
            string[] split = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            List<Cut> cuts = new List<Cut>();
            foreach (string item in split)
            {
                cuts.Add(StrToCut(item));
            }
            return cuts;
        }
        public static string CutsListToStr(List<Cut> cuts)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cut item in cuts)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        public static double[,] CutsListToMatrix(List<Cut> cuts)
        {
            double[,] Matrix = new double[cuts.Count, 2];
            for (int i = 0; i < cuts.Count; i++)
            {
                Matrix[i, 0] = cuts[i].A;
                Matrix[i, 1] = cuts[i].B;
            }
            return Matrix;
        }
        public static List<Cut> MatrixToCutsList(double[,] Matrix)
        {
            List<Cut> cuts = new List<Cut>();
            if (Matrix.GetLength(1) != 2)
                throw new Exception("невозможно преобразовать");
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                cuts.Add(new Cut(Matrix[i, 0], Matrix[i, 1]));
            }
            return cuts;
        }
    }
}
