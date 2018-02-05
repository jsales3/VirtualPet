using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PetLion
    {
        //fields
        private string name;
        private string furColor;
        private int hungryLevel = 0;
        private int thirstLevel = 0;
        private int boredLevel = 0;
        private int foodAmount = 0;
        private int weight;
        private bool isFull = false;
        private string foodChoice;
        

        
        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FurColor
        {
            get { return furColor; }
            set { furColor = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int HungryLevel
        {
            get { return hungryLevel; }
            
        }

        public int ThirstLevel
        {
            get { return thirstLevel; }
           
        }

        public int BoredLevel
        {
            get { return boredLevel; }
           
        }

        public int FoodAmount
        {
            get { return foodAmount; }

        }

        public string FoodChoice
        {
            get { return foodChoice; }
            set { foodChoice = value; }
        }

        public bool IsFull
        {
            get { return isFull; }
            set { isFull = value; }
        }


        //constructors
        public PetLion()
        {

        }

        public PetLion(string name, string furColor, int weight)
        {
            this.name = name;
            this.furColor = furColor;
            this.weight = weight;
        }

        public void Feed(string foodType)
        {
            switch (foodType)
            {
                case "beef":
                    hungryLevel = 0;
                    thirstLevel ++;
                    foodAmount++;
                    Console.WriteLine("you feed " + name + " beef");
                    break;

                case "pork":
                    hungryLevel = 0 ;
                    thirstLevel ++;
                    foodAmount++;
                    Console.WriteLine("you feed " + name + " pork");
                    break;

                case "chicken":
                    hungryLevel = 0;
                    thirstLevel++;
                    foodAmount++;
                    Console.WriteLine("you feed " + name + " chicken" );
                    break;
            }
        }

        public void GiveWater()
        {
            thirstLevel = 0;
            Console.WriteLine("you gave " + name + " some water");

        }

        public void PlayWith()
        {
            boredLevel = 0;
            Console.WriteLine(name + " had a nice walk");
           
        }

        public void ToBathroom()
        {
            hungryLevel = 0;
            thirstLevel = 0;
            foodAmount = 0;
            isFull = false;
            Console.WriteLine(name + " has used the bathroom");
        }

        public void tick()
        {
                hungryLevel++;
                thirstLevel++;
                boredLevel++;
        }

        public void Food()
        {
            List<string> foodType = new List<string> { "Beef", "Pork", "Chicken" };

            foreach(string food in foodType)
            {
                Console.WriteLine(food);
                
            }
            
        }



        

        
        

    }
}
