using OOP.Inheritance.Interfaces;
using OOP.Inheritance.Classes;

namespace OOP.Inheritance
{

    internal class Program
    {
        //In this script all the fields from the Person class are inherited in the Worker class
        static void Main(string[] args)
        {
            IPerson person = new Person();
            IPerson worker = new Worker();

            SetPersonDetails(person, "first person");
            SetPersonDetails(worker, "worker");

            Console.WriteLine("This is the first person you created: ");
            Console.WriteLine(person.getName() + " and he/she has an age of " + person.getAge() + " years");

            Console.WriteLine("This is the worker you created: ");
            Console.WriteLine(worker.getName() + " and he/she has an age of " + worker.getAge() + " years");
        }

        static void SetPersonDetails(IPerson person, string personType)
        {
            Console.WriteLine($"Set the {personType}'s name: ");
            string name = Console.ReadLine();
            person.setName(name);

            Console.WriteLine($"Set the {personType}'s age: ");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            person.setAge(age);
        }
    }
}