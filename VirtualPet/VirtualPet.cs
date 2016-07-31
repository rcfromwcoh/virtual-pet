using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //At least three properties will go here for an MVP project
        //  1.  Type of bear
        //          a. Grizzly
        //          b. Polar
        //          c. Panda
        //          d. Sloth
        //          e. Black
        //  2.  Sound it makes
        //  3.  Food it likes to eat
        //At least three methods will go here for an MVP project
        //  1.  Actions it takes
        //          a. Sleep
        //          b. Poop
        //          c. Drink Beer
        //Fields
        private string typeOfBear;
        private int money;
        private int hunger;
        private int happiness;
        private int sleepiness;
        private string name;
        private string bearName;

        //Properties
        public string TypeOfBear
        {
            get { return this.typeOfBear; }
            set { this.typeOfBear = value; }
        }
        public int Money
        {
            get { return this.money; }
            set { this.money = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Happiness
        {
            get { return this.happiness; }
            set { this.hunger = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Sleepiness
        {
            get { return this.sleepiness; }
            set { this.sleepiness = value; }
        }

        public string BearName
        {
            get { return this.bearName; }
            set { this.bearName = value; }
        }

        //Constructors
        public VirtualPet()
        {
            this.typeOfBear = "Grizzly";
            this.money = 10000;
            this.hunger = 50;
            this.happiness = 20;
            this.name = bearName;
            this.sleepiness = 25;
        }

        //Methods

        public void Raise()
        {
            money = money + 5000;
        }

        public void Eat()
        {
            hunger = hunger - 15;
            money = money - 2000;
            happiness = happiness + 10;
        }

        public void DrinkBeer()
        {
            money = money - 500;
            happiness = happiness + 20;
            sleepiness = sleepiness + 25;
        }

        public void Sleep()
        {
            sleepiness = sleepiness - 50;
            hunger = hunger + 20;
            happiness = happiness + 15;
        }

        public void PrintStats()
        {
            Console.WriteLine("Your Grumpy Bear's Name is: " + this.name);
            Console.WriteLine("Money: " + this.money);
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Happiness: " + this.happiness);
            Console.WriteLine("Sleepiness: " + this.sleepiness);
        }

        public void Tick()
        {
            money = money - 1000;
            hunger = hunger + 5;
            happiness = happiness - 5;
            sleepiness = sleepiness + 10;

        }
        
    }
}
