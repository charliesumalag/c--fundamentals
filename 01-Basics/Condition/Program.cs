using System;


namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string message;

            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());



            if (age <= 18)
            {
                message = "youre cant drive";
                Console.WriteLine(message);
            }
            else if (age >= 18 && age <= 59)
            {
                message = "you can drive";
                Console.WriteLine(message);
            }
            else
            {
                message = "youre so old to drive, please staty at home.";
                Console.WriteLine(message);
            }
        }
    }
}