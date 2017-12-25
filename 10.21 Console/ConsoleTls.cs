using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;

namespace _10._21_Console
{
    public class ConsoleTls
    {
        static List<Cut> ConsoleInput()
        {
            StringBuilder sb = new StringBuilder();
            string temp;
            temp = System.Console.ReadLine();
            while (temp != "")
            {
                sb.AppendLine(temp);
                temp = System.Console.ReadLine();
            }
            return CutConvert.StrToListCuts(sb.ToString());
        }
        static List<Cut> FileInput(string Path)
        {
            CutsFile file = new CutsFile(Path);
            return file.ReadCuts();
        }
        public static List<Cut> Input()
        {
            while (true)
            {
                System.Console.Write("Считать отрезки из файла ? (y/n)");
                ConsoleKeyInfo result = System.Console.ReadKey();
                System.Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        System.Console.Write("введите имя файла:");
                        try
                        {
                            return FileInput(System.Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    while (true)
                    {
                        System.Console.WriteLine("введите линии");
                        try
                        {
                            return ConsoleInput();
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
        static void FileOutput(List<Cut> Lines, string Path)
        {
            CutsFile file = new CutsFile(Path);
            file.WriteCuts(Lines);
        }
        static void ConsoleOutput(List<Cut> Lines)
        {
            System.Console.WriteLine(CutConvert.CutsListToStr(Lines));
        }
        public static void Output(List<Cut> Lines)
        {
            while (true)
            {
                System.Console.Write("записать отрезки в файл ? (y/n)");
                ConsoleKeyInfo result = System.Console.ReadKey();
                System.Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        System.Console.Write("введите имя файла:");
                        try
                        {
                            FileOutput(Lines, System.Console.ReadLine());
                            return;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    ConsoleOutput(Lines);
                    break;
                }
            }
        }
    }
}
