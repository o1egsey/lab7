using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            const int size = 2030; const int variant = 4;
            Random rnd = new Random();

            //заполнение списка случайными числами
            for (int i = 0; i < size; i++)
                list.Add((int)(rnd.Next(300, 500)));
            Console.WriteLine("Начальные данные созданного списка:");
            Console.Write("List(300...500)=");
            foreach (int x in list)
                Console.Write("\t" + x);
            //отсортированный в порядке возростания список
            list.Sort();
            Console.WriteLine("\n\nОтсортированный в порядке возростания список:");
            Console.Write("List(300...500)=");
            foreach (int x in list)
                Console.Write("\t" + x);
            //занесение номера варианта в список 
            list[variant] = variant;
            Console.WriteLine("\n\nСписок с элементов {0} на позиции list[{0}]:", variant);
            Console.Write("List(300...500)=");
            foreach (int x in list)
                Console.Write("\t" + x);
            //генерирование нового значения и проверка его наличия
            int newVariant = rnd.Next(0, variant + 1000);
            int index = list.IndexOf(newVariant);
            if (index == -1)
                Console.WriteLine("\n\nЧисло {0} не найдено в списке <list>;", newVariant);
            else Console.WriteLine("\n\nЧисло {0} найдено в списке <list>, оно находится на позиции {1};", newVariant, index);
            //удаление случайно сгенерированого элемента списка
            int element = rnd.Next(0, size);
            index = list.IndexOf(element);
            if (index == -1)
                Console.WriteLine("Число {0} не найдено в списке <list>;", element);
            else
            {
                list.Remove(element);
                Console.WriteLine("Число {0} удалено из списка <list>;", element);
            }
            //удаленние всех элементов списка
            list.Clear();
            Console.WriteLine("Список <list> после удаления всех его элементов:");
            foreach (int x in list)
                Console.Write("\t" + x);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
