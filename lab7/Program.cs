using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> symbols = new List<char>();
            string stroka;
            using (StreamReader MyFile = new StreamReader("D:\\program\\vs_projects\\lab7\\lab7\\Example.txt"))
            {
                while ((stroka = MyFile.ReadLine()) != null)
                {
                    for (int i = 0; i < stroka.Length; i++)
                        symbols.Add(stroka[i]);
                }
            }
            int LeftBracket = 0, RightBracket = 0;
            Console.WriteLine("Текст, считаный с файла <Example.txt>:");
            for (int i = 0; i < symbols.Count; i++)
            {
                Console.Write(symbols[i]);
            }
            for (int i = 0; i < symbols.Count; i++)
            {
                if (symbols[i] == '(')
                    LeftBracket++;
                else if (symbols[i] == ')')
                    RightBracket++;
            }
            if (LeftBracket == RightBracket)
                Console.WriteLine("\nБаланс круглых скобок соблюден (<(> == <)> == {0});", LeftBracket);
            if (LeftBracket < RightBracket)
                Console.WriteLine("\nБаланс круглых скобок не соблюден (<(> < <)> = {0} < {1});", LeftBracket, RightBracket);
            if (LeftBracket > RightBracket)
                Console.WriteLine("\nБаланс круглых скобок не соблюден (<(> > <)> = {0} > {1});", LeftBracket, RightBracket);
            Console.ReadKey();
        }
    }
}
