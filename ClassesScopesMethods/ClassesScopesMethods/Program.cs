using System;

namespace ClassesScopesMethods
{
    
    class Person // Creating Class Props and Methods
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        public void PrintMethod()
        {
            Console.WriteLine(PrintMethodHelper());
        }

        private string PrintMethodHelper()
        {
            return "Hello Puma";
        }
        public Person(int age, string name, string gender, string city)
        {
            Age = age;
            Name = name;
            Gender = gender;
            City = city;
        }
        
        public Person()
        {

        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {


            
            Person myPerson = new Person();
            Person myOtherPerson;
            myOtherPerson = myPerson;       // Passing Refrence to Another Object
            myPerson.Age = 22;              // Using Class Props
            myPerson.Name = "Puma";
            myPerson.Gender = "Male";
            myPerson.City = "Jaipur";

            Console.WriteLine("Name - {0} \nAge - {1} \nCity - {2}\nGender - {3}", 
                myPerson.Name, 
                myPerson.Age, 
                myPerson.City, 
                myPerson.Gender);

            Console.WriteLine("Name - {0} \nAge - {1} \nCity - {2}\nGender - {3}",
               myOtherPerson.Name,
               myOtherPerson.Age,
               myOtherPerson.City,
               myOtherPerson.Gender);

            myPerson.PrintMethod();     // Using Class Methods & Accessing Public Method which recieves data from private Method


            Person someOtherPerson = new Person(23, "God", "Jaipur", "Male");
            Console.WriteLine("Name - {0} \nAge - {1} \nCity - {2}\nGender - {3}",
               someOtherPerson.Name,
               someOtherPerson.Age,
               someOtherPerson.City,
               someOtherPerson.Gender);
            Console.Read();
        }
    }
}
