using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        const string x = "X";
        readonly string y;
        static void Main(string[] args)
        {
            //List<Person> names = new List<Person>
            //{
            //    new Person{Name = "A" },
            //    new Person{Name = "AA" },
            //    new Person{Name = "ABA" },
            //    new Person{Name = "AAAA" },
            //    new Person{Name = "ACBA" },
            //};
            //foreach (var item in names)
            //{
            //    item.Name = "S";
            //    Console.WriteLine(item.Name);
            //}
            // wer1
            Person person = new Person();
            try
            {
                Console.WriteLine(person.Name);
            }
            finally
            {
                person.Dispose();
            }
            // wer2
            using (Person person2 = new Person())
            {
                Console.WriteLine(person.Name);
            }
            Console.Read();
        }
    }
}
