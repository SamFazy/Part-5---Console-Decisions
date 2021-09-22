using System;

namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Age:");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age >= 18)
            {
                Console.WriteLine("You are an Adult");
            }

            else if (Age <= 0)
            {
                Console.WriteLine("Error: That is not a real age!");
            }

            else if (Age <= 5)
            {
                Console.WriteLine("You are a Toddler");
            }

            else if (Age <= 10)
            {
                Console.WriteLine("You are a Child");
            }

            else if (Age <= 12)
            {
                Console.WriteLine("You are a Preteen");
            }

            else if (Age > 12)
            {
                Console.WriteLine("You are an Teen");
            }

            
            

        }
    }
}
