using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class Cut :IComparable
    {
        public double A { get; }
        public double B { get; }

        public Cut(double a, double b)
        {
            if (a >= b)
                throw new Exception("отрезок не существует");
            A = a;
            B = b;
        }

        public int CompareTo(object obj)
        {
            if (A > ((Cut)obj).A)
                return 1;
            if (A < ((Cut)obj).A)
                return -1;
            return 0;
        }
        public bool CanCombine(Cut cut)
        {
            if (B < cut.A || A > cut.B)
                return false;
            return true;
        }
        public Cut Combine(Cut cut)
        {
            if (CanCombine(cut))
                return new Cut(Math.Min(A, cut.A), Math.Max(B, cut.B));
            else
                throw new Exception("невозможно оъеденить линии");
        }
        public static List<Cut> Combine(List<Cut> cuts)
        {
            if (cuts.Count == 0) return new List<Cut>();
            List<Cut> SortCuts = new List<Cut>();
            foreach (Cut item in cuts)
                SortCuts.Add(item);
            SortCuts.Sort();
            List<Cut> CombineCuts = new List<Cut> { SortCuts[0] };
            for (int i = 1; i < SortCuts.Count;i++)
            {
                if (CombineCuts[CombineCuts.Count - 1].CanCombine(SortCuts[i]))
                    CombineCuts[CombineCuts.Count - 1] = CombineCuts[CombineCuts.Count - 1].Combine(SortCuts[i]);
                else
                    CombineCuts.Add(SortCuts[i]);
            }
            return CombineCuts;
        }
        public override string ToString()
        {
            return "(" + A + ";" + B + ")";
        }
    }
}
