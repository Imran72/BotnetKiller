using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PythonRunner
{

    /// <summary>
    /// статический клас для методов изпользуемых в основной программе
    /// </summary>
    public static class Analyzing
    {
        static BinaryFormatter formatter = new BinaryFormatter();
        public static int n = 3;
        public static string Menu(string info)
        {
            string path;
            while (true)
            {
                try
                {
                    Console.WriteLine(info);
                    path = Console.ReadLine();
                    if (!File.Exists(path))
                        throw new ArgumentException("Такого файла не существует!");
                    if (Path.GetExtension(path) != ".apk")
                        throw new ArgumentException("Расширение файла не .apk!");
                    break;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Что-то пошло не так!");
                }
            }
            return path;
        }

        public static List<string> BinaryDeserialization()
        {
            List<string> list;
            using (FileStream fs = new FileStream("/Users/imrantimkanov/Projects/cs21_03_2020/cs21_03_2020/bin/Debug/netcoreapp3.0/list.dat", FileMode.OpenOrCreate))
            {
                list = (List<string>)formatter.Deserialize(fs);
            }

            return list;

        }

        /// <summary>
        /// метод для взаимодействия с операционными процессами -  выполнения комманд с помощью bash
        /// </summary>
        /// <param name="cmd">команда</param>
        public static void Bash(string cmd)
        {
            // преобразования команды в правильный формат
            var escapedArgs = cmd.Replace("\"", "\\\"");
            Process proc = new Process();
            // Имя запускаемого приложения
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            // рабочая директория
            proc.StartInfo.WorkingDirectory = "/Users/imrantimkanov/Desktop";
            // объявление выполняемой команды
            proc.StartInfo.Arguments = $"-c \"{escapedArgs}\"";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            // выполнение 
            proc.Start();
            proc.StandardInput.Flush();
            proc.StandardInput.Close();
            proc.WaitForExit();
            
        }

        public static Dictionary<string, int> ExtractingOpcode(string sourceDirectory, List<string> list)
        {
            Dictionary<string, int> openWith = new Dictionary<string, int>();
            foreach (var el in list)
                openWith.Add(el, 0);

            StringBuilder tmp = new StringBuilder();
            foreach (string file in Directory.EnumerateFiles(sourceDirectory, "*.smali", SearchOption.AllDirectories))
            {
                int iter = 0;
                using (StreamReader sr = new StreamReader(file))
                {
                    string st = sr.ReadLine();
                    while (st != null)
                    {
                        string alp = PreProcessCode(st);
                        if (alp != "")
                        {
                            try
                            {
                                tmp.Append(Codes.codes[alp]);
                                if (iter % n == n - 1)
                                {
                                    if (openWith.ContainsKey(tmp.ToString()))
                                        openWith[tmp.ToString()]++;
                                    tmp.Clear();
                                }
                                iter++;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        st = sr.ReadLine();
                    }
                }
                tmp.Clear();
            }

            return openWith;
        }

        public static string PreProcessCode(string st)
        {
            // обрезаем пробелы справа и слева
            st = st.Trim(' ');
            // проверка наличия ключа
            if (Codes.codes.ContainsKey(st))
                return st;
            // взятие первого слова в строке и повторная проверка ключа
            if (st.IndexOf(' ') != -1 && Codes.codes.ContainsKey(st.Substring(0, st.IndexOf(' '))))
                return st.Substring(0, st.IndexOf(' '));
            // в случае отсутствия - пустая строка
            return "";
        }

        /// <summary>
        /// Бинарная сериализация
        /// </summary>
        /// <param name="list">лист для сериализации</param>
        public static void BinarySerialization(List<string> list)
        {
            using (FileStream fs = new FileStream("list.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
        public static string CreateFile(Dictionary<string, int> dict)
        {
            StringBuilder st1 = new StringBuilder();
            StringBuilder st2 = new StringBuilder();
            using (StreamWriter sw = new StreamWriter(@"/Users/imrantimkanov/Desktop/data.csv", false, System.Text.Encoding.Default))
            {
                foreach (var key in dict)
                {
                    st1.Append(key.Key + ",");
                    st2.Append(key.Value + ",");
                }
                st1.Length--;
                st2.Length--;
                sw.WriteLine(st1.ToString());
                sw.WriteLine(st2.ToString());
            }
            return "/Users/imrantimkanov/Desktop/data.csv";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="script"></param>
        /// <param name="classifier"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string PythonScript(string script, string classifier, string file)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            // Имя запускаемого приложения - python3.7
            start.FileName = "/usr/local/bin/python3.7";
            // объявление выполняемой команды
            start.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\"", script, classifier, file);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardInput = true;
            start.RedirectStandardOutput = true;
            string result;
            // непосредственно процесс выполнения скрипта
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    // вывод скрипт записывается в переменную result
                    result = reader.ReadToEnd();
                }
            }
            // возвращаем вывод скрипта
            return result;
        }
    }
}
