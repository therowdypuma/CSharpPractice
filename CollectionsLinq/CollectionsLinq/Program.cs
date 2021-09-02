using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> myPeople = new List<Person>() //Collections Usage
            {
                new Person() {Age = 23, Name = "Puma", Gender = "Male", City = "Bathinda"},
                new Person() {Age = 24, Name = "Rohan", Gender = "Male", City = "Bathinda"},
                new Person() {Age = 21, Name = "Muskan", Gender = "Female", City = "jaipur"},
                new Person() {Age = 22, Name = "Tanwar", Gender = "Male", City = "jaipur"}
            };

            // Linq Query
            Console.WriteLine("Linq Query\n");
            var jaipurs = from ppl in myPeople
                          where ppl.City == "jaipur"
                          select ppl;

            foreach (var item in jaipurs)
            {
                Console.WriteLine("Name - {0} Age - {1}", item.Name , item.Age);
            }

            // Linq Method

            var Bathindas = myPeople.Where(p => p.City == "Bathinda");
            Console.WriteLine("\n\nLinq Method\n");
            foreach (var item in Bathindas)
            {
                Console.WriteLine("Name - {0} Age - {1}", item.Name, item.Age);
            }

            Console.Read();
        }

        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
        }
    }
}
