using OOP.Encapsulation.Classes;

namespace OOP.Encapsulation
{
    internal class Program
    {
        //This program uses Encapsulation for hiding the Name and Age fields from the Person class
        static void Main(string[] args)
        {
            Person person = new Person();

            SetPersonDetails(person, "first person");

            Console.WriteLine("This is the first person you created: ");
            Console.WriteLine(person.getName() + " and he/she has an age of " + person.getAge() + " years");
        }

        static void SetPersonDetails(Person person, string personType)
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