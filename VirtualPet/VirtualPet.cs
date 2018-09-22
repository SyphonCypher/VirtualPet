using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {



        //Fields
        private int hunger;
        private int thirst;
        private int boredom;
        private int fatigue;

        //Properties
        public int GetHunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int GetThirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int GetBoredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int GetFatigue
        {
            get { return this.fatigue; }
            set { this.fatigue = value; }
        }

        //Constructors
        public VirtualPet()
        {
            //Default constructor
        }

        public VirtualPet(int hunger, int thirst, int boredom, int fatigue, int sickness)
        {
            this.GetHunger = hunger;
            this.GetThirst = thirst;
            this.GetBoredom = boredom;
            this.GetFatigue = fatigue;
        }

        //Methods
        public void GetFood()
        {
            Console.WriteLine("You give Shoober a bowl of cronch pellets.");
            GetHunger = 0;
            GetThirst++;
        }

        public void GetWater()
        {
            Console.WriteLine("You give Shoober a bowl of water.");
            GetThirst = 0;
        }

        public void GetPlay()
        {
            Console.WriteLine("You play fetch with Shoober.");
            GetBoredom = 0;
            GetFatigue++;
        }

        public void GetRest()
        {
            Console.WriteLine("You tuck Shoober into bed.");
            GetFatigue = 0;
            GetHunger++;
            GetThirst++;
            GetBoredom++;
        }

        public void Tick()
        {
            GetHunger = GetHunger++;
            GetThirst = GetThirst++;
            GetBoredom = GetBoredom++;
            GetFatigue = GetFatigue++;
            string input = Console.ReadLine().ToLower();

            if (GetHunger >= 8)
            {
                Console.WriteLine("Shoober is getting hungry and needs to be fed."); 
                if(input == "feed")
                {
                    GetHunger = 0;
                    GetThirst++;
                }
                else if (GetHunger == 10)
                {
                    Console.WriteLine("You didn't feed Shoober so he scavenged for food himself.");
                    GetHunger = 2;
                }
                else
                {

                }
            }

            if (GetThirst >= 8)
            {
                Console.WriteLine("Shoober is getting thirsty and needs to be given water.");
                if (input == "water")
                {
                    GetThirst = 0;
                }
                else if (GetThirst == 10)
                {
                    Console.WriteLine("You didn't give Shoober water so he drank from a leaky faucet");
                    GetThirst = 2;
                }
                else
                {

                }
            }

            if (GetBoredom >= 8)
            {
                Console.WriteLine("Shoober is getting bored and needs to be played with.");
                if (input == "play")
                {
                    GetBoredom = 0;
                }
                else if(GetBoredom == 10)
                {
                    Console.WriteLine("You didn't play with Shoober so he played fetch with himself.");
                    GetBoredom = 2;
                }
                else
                {

                }
            }

            if (GetFatigue >= 8)
            {
                Console.WriteLine("Shoober is getting bored and needs to be played with.");
                if (input == "rest")
                {
                    GetFatigue = 0;
                }
                else if (GetFatigue == 10)
                {
                    Console.WriteLine("You didn't put Shoober to bed so he curled up on the hard floor to sleep.");
                    GetFatigue = 2;
                }
                else
                {

                }
            }

        }





    }
}
