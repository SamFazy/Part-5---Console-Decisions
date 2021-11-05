using System;

namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1 - Stages");
            Console.WriteLine("");

            int Age;

            Console.WriteLine("Please Enter Your Age:");

            if (Int32.TryParse(Console.ReadLine(), out Age))
            {

                if (Age >= 18)
                {
                    Console.WriteLine("You are an Adult!");
                }

                else if (Age <= 0)
                {
                    Console.WriteLine("Error: That is not a real age!");
                }

                else if (Age <= 5)
                {
                    Console.WriteLine("You are a Toddler!");
                }

                else if (Age <= 10)
                {
                    Console.WriteLine("You are a Child!");
                }

                else if (Age <= 12)
                {
                    Console.WriteLine("You are a Preteen!");
                }

                else if (Age > 12)
                {
                    Console.WriteLine("You are an Teen!");
                }
            }
            else
            {
                Console.WriteLine("An age is a NUMBER!!!!!");
            }

            Console.WriteLine();




            Console.WriteLine("Part 2 - Hurricane");
            Console.WriteLine("");


            Console.WriteLine("Enter a category of a hurricane:");
            Console.WriteLine("(Hurricanes range from category 1 - 5)");

            int category;

            category = Convert.ToInt32(Console.ReadLine());

            switch (category)
            {

                case 1:
                    Console.WriteLine("Category 1: 74-95mph or 64-82kt or 119-153km/hr");
                    break;

                case 2:
                    Console.WriteLine("Category 2: 96-110mph or 83-95kt or 154-177km/hr");
                    break;

                case 3:
                    Console.WriteLine("Category 3: 111-130mph or 96-113kt or 178-209km / hr");
                    break;

                case 4:
                    Console.WriteLine("Category 4: 131-155mph or 114-135kt or 210-249km/hr");
                    break;

                case 5:
                    Console.WriteLine("Category 5: Greater than 155mph or 138 kt or 249km/hr");
                    break;

                default:
                    Console.WriteLine("You did not enter a hurricane category!!!");
                    break;

            }

            Console.WriteLine();



            Console.WriteLine("Part 3 - Random Divisible");
            Console.WriteLine("");

            Random generator = new Random();
            int randomNum = generator.Next(2 , 6);
            int userInput;
            int divisible = 0;

            Console.WriteLine("Please Enter a Number Higher Than " + randomNum + ":");

            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                divisible = (userInput % randomNum);
            }

                if (userInput <= randomNum)
                {
                    Console.WriteLine("Error: You Entered a Number Lower Than " + randomNum);
                }

                else if (divisible == 0)
                {
                    Console.WriteLine("Divisible");
                }

                else if (divisible >= 1)
                {
                    Console.WriteLine("Not Divisible");
                }

            else
            {
                Console.WriteLine("That is no number!");
            }


            Console.ReadLine();

            Console.WriteLine("");


        }
    }
}
