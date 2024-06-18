using System.Collections;
using System.Drawing;

namespace ProjectTempalte
{
    static public class Program
    {
        public static List<string> ReadFromFile(string filePath)
        {
            List<string> list = new List<string>();
            using (var sr = new StreamReader(filePath))
            {
                string s;
                while (!sr.EndOfStream)
                    list.Add(sr.ReadLine().ToLower());
            }
            return list;
        }

        public static List<int> ReadIntsFromBinaryFile(string path)
        {
            List<int> res = new();
            using (var fs = new FileStream(path, FileMode.Open))
            using (var bw = new BinaryReader(fs))
            {
                while (bw.BaseStream.Position + sizeof(int) < bw.BaseStream.Length)
                    res.Add(bw.ReadInt32());
            }
            return res;
        }

        // TODO:
        // Функция должная записывать целые числа в бинарный файл
        public static void WriteIntsToBinaryFile(string path, List<int> data)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            using (var sw = new StreamWriter(fs))
            {
                foreach (var n in data)
                {
                    sw.Write(n);
                }
            }
        }

        public static int MinDigit(int n)
        {
            return 0; // Заглушка
        }

        static void StackTask()
        {
            Console.WriteLine("Stack Task");

            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(12);
            st.Push(37);
            st.Push(9);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            st.Push(1234);
            Console.WriteLine(st.Peek());

            Console.WriteLine("-------");
        }
        static void DeepLookStackTask()
        {
            Console.WriteLine("DeepLookStack Task");
            
            DeepLookStack<int> deep = new DeepLookStack<int>();
            deep.Push(1);
            deep.Push(12);
            deep.Push(37);
            deep.Push(9);
            Console.WriteLine(deep.Pop());
            Console.WriteLine(deep.Peek(2));

            Console.WriteLine("-------");
        }
        static void QueueTask()
        {
            Console.WriteLine("Queue Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после реализации класса Queue
                                                        // и как-то протестируйте ваш код
            Console.WriteLine("-------");
        }
        // При работе с файлами, создавайте и наполняйте их сами. Но не забывайти использовать относительные пути
        static void StringTask()
        {
            Console.WriteLine("String Task");

        
            List<string> lst = ReadFromFile("D:\\--Common\\--Desktop\\Dobor\\ProjectTemplate\\ProjectTempalte\\abc.txt");
            foreach (var c in lst)
                Console.WriteLine(c);

            List<int> lst2 = ReadIntsFromBinaryFile("D:\\--Common\\--Desktop\\Dobor\\ProjectTemplate\\ProjectTempalte\\aaa.txt");
            foreach (var c in lst2)
                Console.WriteLine(c);

            List<int> data = new();
            data.Add(1);
            data.Add(3);
            data.Add(7);
            WriteIntsToBinaryFile("D:\\--Common\\--Desktop\\Dobor\\ProjectTemplate\\ProjectTempalte\\bbb.txt", data);


            // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: прочитать данные из файла (реализуйте и используйте функцию ReadFromFile из файла Functions.cs) и
            // Вывести:
            // * количество слов в тексте
            // * самое длинное слово
            // Можно считать, что слова разделены пробелами. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RegexTask()
        {
            Console.WriteLine("Regex Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: написать Regex, который сумеет распознать email адрес.
            // Прочитать данные из файла и вывести количество email адресов.
            // Слов (а потенциально и адресов) в строке может быть несколько
            // Можно считать, что слова разделены пробелами
            Console.WriteLine("-------");
        }
        static void BinaryTask()
        {
            Console.WriteLine("Binary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: реализовать функции чтения из бинароного файла и записи в него в Functions.cs.
            // Записать некоторое количество целых чисел в бинарный файл.
            // После прочитать этот же бинарный файл и вывести считанные значения на экран
            Console.WriteLine("-------");
        }
        static void DictionaryTask()
        {
            Console.WriteLine("Dictionary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: создать Dictionary, где ключ - имя студента, а значение - лист его оценок по предметам за семестр.
            // Заполните словарь для 3-4 студентов.
            // Запросите у пользователя строку - имя студента, по которому он хочет узнать среднюю оценку.
            // Выведите результат. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RecursionTask()
        {
            Console.WriteLine("Recursion Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: рекурсивно описать функцию MinDigit(int n) (находится в Functions.cs),
            // которая находит наименьшую цифру в десятичной записи неотрицательного целого числа N.
            // Например, MinDigit(27316) = 1.
            Console.WriteLine("-------");
        }
        static void Main(string[] args)
        {
            
            StackTask();
            DeepLookStackTask();
            QueueTask();
            StringTask();
            RegexTask();
            BinaryTask();
            DictionaryTask();
            RecursionTask();
        }
    }
}
