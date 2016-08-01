using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet grumpyBear = new VirtualPet();
            string something;
            string bearName;
            Console.WriteLine("Welcome to the Grumpy Bear App! ");
            //bearName = Console.ReadLine();
            int typeOfBear;
            Console.WriteLine("What kind of bear do you want to be?");
            Console.WriteLine("Press 1 for Polar, Press 2 for Grizzly, Press 3 for Panda, or Press 4 for Koala");
            typeOfBear = int.Parse(Console.ReadLine());
            do
            {
                grumpyBear.Tick();
                grumpyBear.PrintStats();
                Console.WriteLine("What do you want to do? Earn Money, Drink Beer, Eat, or Sleep?");
                Console.WriteLine("Press 1 to earn money, 2 to drink beer, 3 to eat, or 4 to sleep");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    grumpyBear.Raise();

                }

                else if (answer == "2")
                {
                    grumpyBear.DrinkBeer();
                }

                else if (answer == "3")
                {
                    grumpyBear.Eat();
                }

                else if (answer == "4")
                {
                    grumpyBear.Sleep();
                }

                else
                {
                    grumpyBear.DrinkBeer();

                }

                grumpyBear.PrintStats();

                Console.WriteLine("Do you want to go again?");
                something = Console.ReadLine();
                something = something.ToUpper();
                something = something.Substring(0, 1);

            } while (something == "Y");
            Console.ReadKey();


        }
    }
}
