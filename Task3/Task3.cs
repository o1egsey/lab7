using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Task3
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

    class PersonComparer : IComparer
    {
        public int Compare(object a, object b)
        {
            Person A = (Person)a;
            Person B = (Person)b;
            return A.Age.CompareTo(B.Age);
        }
    }

    class Task3
    {
        static void Main(string[] args)
        {
            ArrayList persons = new ArrayList();
            string stroka;
            char separator = ' ';
            using (StreamReader MyFile = new StreamReader("D:\\program\\vs_projects\\lab7\\Task3\\Task3.txt"))
            {
                while ((stroka = MyFile.ReadLine()) != null)
                {
                    string[] info = stroka.Split(separator);
                    if (info.Length == 5)
                    {
                        Person person = new Person(info[2], info[0], info[1], int.Parse(info[3]), double.Parse(info[4]));
                        persons.Add(person);
                    }
                }
            }
            persons.Sort(new PersonComparer());
            Console.WriteLine("Отсортированные по возрасту данные:");
            for (int i = 0; i < persons.Count; i++)
                Console.WriteLine(persons[i]);
            Console.ReadKey();
        }
    }
}
