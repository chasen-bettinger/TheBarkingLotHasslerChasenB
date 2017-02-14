using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBarkingLotHasslerChasenB
{
    class Program
    {
        static bool isInt = false;
        static bool isDouble = false;

        static void Main(string[] args)
        {
            int id = 0;
            int age = 0;
            double weight = 0.0;

            id = HandleInput("Please enter your Owner ID", id);
            String name = HandleInput("Please enter the name of your dog");
            String breed = HandleInput("Please enter the breed of your dog");
            age = HandleInput("Please enter the age of your dog", age);
            weight = HandleInput("Please enter the weight of your dog", weight);

            DogOwner dogOwner = new DogOwner(id);

            Dog fido = new Dog(age, name, breed, weight);

            DetermineCost(fido.GetDogWeight());

            Console.Read();
        }

        private static int HandleInput(String input, int output)
        {
            do
            {
                Console.WriteLine(input);
                isInt = int.TryParse(Console.ReadLine(), out output);
                if (isInt)
                {
                    Console.WriteLine("");
                    return output;
                }

                Console.WriteLine("Please enter an integer value\n");


            } while (!isInt);

            return 0;
           
        }

        private static String HandleInput(String input)
        {
            String output;

            Console.WriteLine(input);

            output = Console.ReadLine();

            Console.WriteLine("");

            return output;
        }

        private static double HandleInput(String input, double output)
        {
            do
            {
                Console.WriteLine(input);
                isDouble = double.TryParse(Console.ReadLine(), out output);
                if (!isDouble)
                {
                    Console.WriteLine("Please enter a decimal value\n");
                }
                // If the user didn't enter a decimal, they are asked for input once again
                else
                {
                    Console.WriteLine("");
                    return output;
                }
            } while (!isDouble);

            return 0.0;
        }

        private static void DetermineCost(double weight)
        {
            double billAmount;

            if (weight < 15.0)
            {
                billAmount = 55.00;
                Console.WriteLine("Your bill for weekly day care is going to be: ${0}", billAmount);
            }
            else if (weight > 15.0 && weight <= 30.0)
            {
                billAmount = 75.00;
                Console.WriteLine("Your bill for weekly day care is going to be: ${0}", billAmount);
            }
            else if (weight > 30.0 && weight <= 80.0)
            {
                billAmount = 105.00;
                Console.WriteLine("Your bill for weekly day care is going to be: ${0}", billAmount);
            }
            else
            {
                billAmount = 125.00;
                Console.WriteLine("Your bill for weekly day care is going to be: ${0}", billAmount);
            }
        }
    }
}
