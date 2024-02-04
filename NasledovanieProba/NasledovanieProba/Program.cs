using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledovanieProba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            List <Person> person=new List <Person> ();

            // for (int i = 0; i < n; i++)
            // {
            //     string surname = Console.ReadLine();
            //     string name = Console.ReadLine();
            //     string otchestvo = Console.ReadLine();
            //     person.Add(new Person(surname, name, otchestvo));
            // }
            //foreach (Person p in person)
            //{
            //    Console.WriteLine($"Данные о людях-{p.ToString()}");
            //}

            List<Person> staffs = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string surname = Console.ReadLine();
                string name = Console.ReadLine();
                string otchestvo = Console.ReadLine();
                DateTime hb = DateTime.Parse(Console.ReadLine());
                string dol = Console.ReadLine();
                int oklad = int.Parse(Console.ReadLine());
                DateTime startJob = DateTime.Parse(Console.ReadLine());
                person.Add(new Person(surname, name, otchestvo,hb));
                staffs.Add(new Microsoft(surname, name, otchestvo, dol, oklad, startJob));
                Console.WriteLine("Хотите добавить еще работника-да/нет");
                string yn = Console.ReadLine();
                if(yn =="да")
                {
                    n++;
                }
                else if(yn =="нет")
                {
                    Console.Clear();
                }
            }

            foreach (Person p in staffs)
            {
                Console.WriteLine($"Данные о сотруднике:\n{p}");
            }
            foreach(Person person1 in person)
            {
                Console.WriteLine($"Данные о человеке:\n{person1}");
            }
           

            Console.ReadLine();
        }
    }
}
