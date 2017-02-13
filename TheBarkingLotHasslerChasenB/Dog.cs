using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBarkingLotHasslerChasenB
{
    class Dog
    {
        private int age;
        private string name, breed;
        private double weight;

        public Dog(int age, String name, String breed, double weight)
        {
            this.age = age;
            this.name = name;
            this.breed = breed;
            this.weight = weight;
        }

        public double GetDogWeight()
        {
            return weight;
        }
    }
}
