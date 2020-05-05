using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            string stroka;
            char separator = ' ';
            Console.WriteLine("Цифры, прочитанные с файла <Numbers(reading.txt)>:");
            using (StreamReader MyFile = new StreamReader("D:\\program\\vs_projects\\lab7\\Task4\\Numbers(reading).txt"))
            {
                while ((stroka = MyFile.ReadLine()) != null)
                {
                    string[] info = stroka.Split(separator);
                    for (int i = 0; i < info.Length; i++)
                    {
                        numbers.Push(int.Parse(info[i]));
                        Console.Write(info[i] + " ");
                    }
                }
            }
            Console.WriteLine("\nЦифры, записанные в файл <Numbers(writing).txt> в обратном порядке:");
            using (StreamWriter MyFile = new StreamWriter("D:\\program\\vs_projects\\lab7\\Task4\\Numbers(writing).txt"))
            {
                while (numbers.Count != 0)
                {
                    int number = numbers.Pop();
                    MyFile.Write(number + " ");
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
