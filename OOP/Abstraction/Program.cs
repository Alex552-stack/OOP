using OOP.Abstraction.Interfaces;
using OOP.Abstraction.Classes;

namespace OOP.Abstraction
{
    //This program uses the abstractization IPerson
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson person = new Person();

            SetPersonDetails(person, "first person");

            Console.WriteLine("This is the first person you created: ");
            Console.WriteLine(person.getName() + " and he/she has an age of " + person.getAge() + " years");
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