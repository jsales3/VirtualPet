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

            
            PetLion MyLion = new PetLion();
            

            Console.WriteLine("Hello!, let's create a virtual pet Lion!");
            Console.WriteLine("\nWhat would you like to name your pet?");
            Console.WriteLine("Enter a name below");
            MyLion.Name = Console.ReadLine();

            Console.WriteLine("\nNow let's choose a fur color for your pet Lion:");

            List<string> petColor = new List<string> { "Brown", "Tan", "Grey", "Black" };

            foreach(string color in petColor)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nSelect and enter a color from the list above" );

            MyLion.FurColor = Console.ReadLine();

            Console.WriteLine("\nGreat, now we can give your pet a weight!");
            Console.WriteLine("\nHow much would you like your pet to weigh in pounds?");

            MyLion.Weight = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCongrats!, you have sussefully created your virtual pet Lion.\nnow lets get started!");
            Console.WriteLine("\nHere are your current pet details:");
            Console.WriteLine("Pet Name: " + MyLion.Name + "\nFur Color: " + MyLion.FurColor + "\nWeight: "
                + MyLion.Weight + "\nHunger Level: " + MyLion.HungryLevel + "\nThirst Level: " + MyLion.ThirstLevel +
                "\nBored Level: " + MyLion.BoredLevel);
            int userAction;

            do
            {
               
                Console.WriteLine("\nWhat would you like to do?, Select a number that corresponds to an action");
                Console.WriteLine("1. Feed Pet \n2. Give Water \n3. Play with Pet \n4. Take to Bathroom \n5. See Pet Details \n6. Quit Program" );
                MyLion.tick();

                userAction = int.Parse(Console.ReadLine());

                switch (userAction)
                {
                    case 1:
                        if (MyLion.IsFull == true)
                        {
                            Console.WriteLine(MyLion.Name + " is full");
                        }
                        else
                        {
                            Console.WriteLine("What would you like to feed your pet?");
                            MyLion.Food();
                            MyLion.FoodChoice = Console.ReadLine().ToLower();
                            MyLion.Feed(MyLion.FoodChoice);
                        }
                        break;

                    case 2:
                        MyLion.GiveWater();
                        break;

                    case 3:
                        MyLion.PlayWith();
                        break;

                    case 4:
                        MyLion.ToBathroom();
                        break;

                    case 5:
                        Console.WriteLine("Pet Name: " + MyLion.Name + "\nFur Color: " + MyLion.FurColor + "\nWeight: "
               + MyLion.Weight + "\nHunger Level: " + MyLion.HungryLevel + "\nThirst Level: " + MyLion.ThirstLevel +
               "\nBored Level: " + MyLion.BoredLevel);
                        break;

                    default:
                        Console.WriteLine("Select a number that corresponds to an action");
                        break;
                }

                if (MyLion.HungryLevel == 4)
                {
                    Console.WriteLine(MyLion.Name + " is hungry!");
                   

                }
                else if (MyLion.ThirstLevel == 3)
                {
                    Console.WriteLine(MyLion.Name + " is getting thirsty!");
                   

                }
                else if (MyLion.BoredLevel == 2 || MyLion.BoredLevel == 6)
                {
                    Console.WriteLine(MyLion.Name + " is bored");
                   
                   
                }
                if(MyLion.FoodAmount == 2)
                {
                    MyLion.IsFull = true;
                }

                if ((MyLion.IsFull == true) || (MyLion.ThirstLevel  == 10))
                {
                    Console.WriteLine(MyLion.Name + " needs to use the bathroom!");
                    
                }

            }
            while (userAction != 6);


          
                
          
        }
    }
}
