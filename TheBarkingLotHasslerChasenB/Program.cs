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

        static int id = 0;
        static int age = 0;
        static String name = "";
        static String breed = "";
        static double weight = 0.0;

        static void Main(string[] args)
        {
            HandleInput("Please enter your Owner ID", id);
            HandleInput("Please enter the name of your dog", name);
            HandleInput("Please enter the breed of your dog", breed);
            HandleInput("Please enter the age of your dog", age);
            HandleInput("Please enter the weight of your dog", weight);

            DogOwner dogOwner = new DogOwner(id);

            Dog fido = new Dog(age, name, breed, weight);

            DetermineCost(fido.GetDogWeight());



            Console.Read();
        }

        private static void HandleInput(String input, int output)
        {
            do
            {
                Console.WriteLine(input);
                isInt = int.TryParse(Console.ReadLine(), out output);
                if (!isInt)
                {
                    Console.WriteLine("Please enter an integer value\n");
                }
                // If the user didn't enter an integer, they are asked for input once again
                else
                {
                    Console.WriteLine("");
                }
            } while (!isInt);
           
        }

        private static void HandleInput(String input, String output)
        {
            Console.WriteLine(input);
            output = Console.ReadLine();
            Console.WriteLine("");
        }

        private static void HandleInput(String input, double output)
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
                }
            } while (!isDouble);

        }

        private static void DetermineCost(double weight)
        {
            if (weight < 15.0)
            {
                Console.WriteLine("Your bill for weekly day care is going to be: $55");
            }
            else if (weight > 15.0 && weight <= 30)
            {
                Console.WriteLine("Your bill for weekly day care is going to be: $75");
            }
            else if (weight > 30 && weight <= 80)
            {
                Console.WriteLine("Your bill for weekly day care is going to be: $105");
            }
            else
            {
                Console.WriteLine("Your bill for weekly day care is going to be: $125");
            }
        }
    }
}
