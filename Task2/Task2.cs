using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Person
    {
        private string name;
        private string secondName;
        private string surname;
        private int age;
        private double weight;
        public Person(string a, string b, string c, int d, double e)
        {
            this.name = a; this.secondName = b; this.surname = c;
            this.age = d; this.weight = e;
        }
        public int Age { get { return age; } }
        public override string ToString()
        {
            string line = string.Empty;
            line += ("Фамилия, Имя, Отчество: " + surname);
            line += (" " + name);
            line += (" " + secondName);
            line += ("\nВозраст, Вес: " + age);
            line += (", " + weight);
            return line;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> persons = new Queue<Person>();
            string stroka;
            char separator = ' ';
            using (StreamReader MyFile = new StreamReader("D:\\program\\vs_projects\\lab7\\Task2\\Task2.txt"))
            {
                while ((stroka = MyFile.ReadLine()) != null)
                {
                    string[] info = stroka.Split(separator);
                    if (info.Length == 5)
                    {
                        Person person = new Person(info[2], info[0], info[1], int.Parse(info[3]), double.Parse(info[4]));
                        persons.Enqueue(person);
                    }
                }
            }
            Console.WriteLine("Люди младше 40 лет (age < 40):");
            int c = persons.Count;
            while (c != 0)
            {
                if (persons.Peek().Age < 40)
                    Console.WriteLine(persons.Dequeue());
                else persons.Enqueue(persons.Dequeue());
                c--;
            }
            if (persons.Count != 0)
            {
                Console.WriteLine("\nЛюди старше 40 лет (age > 40):");
                while (persons.Count != 0)
                {
                    Console.WriteLine(persons.Dequeue());
                }
            }
            Console.ReadKey();
        }
    }
}
