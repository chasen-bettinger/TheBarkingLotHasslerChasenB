using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBarkingLotHasslerChasenB
{
    class Program
    { 
        static void Main(string[] args)
        {
            int id = HandleIntInput("Please enter your Owner ID");
            String name = HandleStringInput("Please enter the name of your dog");
            String breed = HandleStringInput("Please enter the breed of your dog");
            int age = HandleIntInput("Please enter the age of your dog");
            double weight = HandleDoubleInput("Please enter the weight of your dog");

            DogOwner dogOwner = new DogOwner(id);

            Dog newDog = new Dog(age, name, breed, weight);

            double cost = DetermineCost(newDog.GetDogWeight());

            PrintWeeklyBill(cost);

            Console.Read();
        }

        private static int HandleIntInput(String input)
        {
            int output = 0;

            bool isValid = false;

            Console.WriteLine(input);

            while(!isValid || output < 0)
            {
                String buffer = Console.ReadLine();
                isValid = int.TryParse(buffer, out output);
                if(!isValid || output < 0)
                {
                    Console.WriteLine("Please enter a positive integer value\n");
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine("");
            return output;
        }

        private static String HandleStringInput(String input)
        {
            String output = "";

            Console.WriteLine(input);
            String buffer = Console.ReadLine();

            while (String.IsNullOrEmpty(buffer))
            {
                output = buffer;
                if(String.IsNullOrEmpty(buffer))
                {
                    Console.WriteLine("Please enter valid input\n");
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine("");

            return output;
        }

        private static double HandleDoubleInput(String input)
        {
            double output = 0.0;
            bool isValid = false;
            Console.WriteLine(input);

            while(!isValid || output < 0)
            {
                String buffer = Console.ReadLine();
                isValid = double.TryParse(buffer, out output);
                if(!isValid || output < 0)
                {
                    Console.WriteLine("Please enter a positive decimal value\n");
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine("");

            return output;
        }

        private static double DetermineCost(double weight)
        {
            double billAmount;

            if (weight < 15.0)
            {
                billAmount = 55.00;
            }
            else if (weight > 15.0 && weight <= 30.0)
            {
                billAmount = 75.00;
            }
            else if (weight > 30.0 && weight <= 80.0)
            {
                billAmount = 105.00;
            }
            else
            {
                billAmount = 125.00;
            }

            return billAmount;
        }

        private static void PrintWeeklyBill(double costPerWeek)
        {
            Console.WriteLine($"Your bill for weekly day care is going to be: ${costPerWeek:0.00}");
        }
    }
}
