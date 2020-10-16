using System;
using System.Collections.Generic;

namespace PythonRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> list = Analyzing.BinaryDeserialization();
                do
                {
                    Console.Clear();
                    string pathFrom = Analyzing.Menu("Укажите полный путь до файла, который следует классифицировать:");
                    string pathTo = pathFrom.Substring(0, pathFrom.LastIndexOf(".apk", StringComparison.Ordinal)) + "Smali";

                    // дизассемблирование инструментом baksmali
                    Analyzing.Bash($"baksmali disassemble {pathFrom} -o {pathTo}");
                    Dictionary<string, int> dict = Analyzing.ExtractingOpcode(pathTo, list);
                    string pathCSV = Analyzing.CreateFile(dict);
                    Analyzing.Bash($"rm -r {pathTo}");

                    // запускаем скрипт, посылаем классификатор и .csv файл
                    string a = Analyzing.PythonScript("/Users/imrantimkanov/Projects/cs21_03_2020/cs21_03_2020/bin/Debug/netcoreapp3.0/script.py",
                        "/Users/imrantimkanov/Projects/cs21_03_2020/cs21_03_2020/bin/Debug/netcoreapp3.0/finalized_model.sav", pathCSV);

                    Analyzing.Bash($"rm -r {pathCSV}");
                    Console.WriteLine(a);
                    Console.WriteLine("Чтобы выйти, нажмите Escape, повторить операцию - любую клавишу");
                } while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Что-то пошло не так!");
            }
        }
    }

}