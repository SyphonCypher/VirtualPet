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
            VirtualPet virtualPet = new VirtualPet();

            do
            {

                Console.WriteLine("Shoober the Shiba Inu");
                Console.WriteLine("Hunger: " + virtualPet.GetHunger);
                Console.WriteLine("Thirst: " + virtualPet.GetThirst);
                Console.WriteLine("Boredom: " + virtualPet.GetBoredom);
                Console.WriteLine("Fatigue: " + virtualPet.GetFatigue);
                Console.WriteLine(" ");

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Type \"Feed\" to feed Shoober.");
                Console.WriteLine("Type \"Water\" to give Shoober water.");
                Console.WriteLine("Type \"Play\" to play with Shoober.");
                Console.WriteLine("Type \"Rest\" to tuck Shoober into bed.");
                Console.ReadLine().ToLower();
                

                string input = Console.ReadLine().ToLower(); 

                if (input == "feed")
                {
                    virtualPet.GetFood();
                }
                else if (input == "water")
                {
                    virtualPet.GetWater();
                }
                else if (input == "play")
                {
                    virtualPet.GetPlay();
                }
                else if (input == "rest")
                {
                    virtualPet.GetRest();
                }
                else
                {

                }
                virtualPet.Tick();

            } while ((virtualPet.GetHunger <= 10) && (virtualPet.GetThirst <= 10));
        }
    }
}
