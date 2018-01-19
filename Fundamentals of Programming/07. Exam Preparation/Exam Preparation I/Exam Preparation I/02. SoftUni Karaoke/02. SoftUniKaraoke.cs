using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Person
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person{Name="pesho",LanguageId=1},
                new Person{Name="sasho",LanguageId=2}
            };

            Language[] languages = new Language[]
            {
                new Language{Name="bg",Id=1},
                new Language{Name="ru",Id=2},

            };

            var res = persons.GroupJoin(persons,lang=>lang.LanguageId,persons.);
            foreach (var name in res)
            {
                Console.WriteLine(name.Name); 
            }
        }
    }
}
