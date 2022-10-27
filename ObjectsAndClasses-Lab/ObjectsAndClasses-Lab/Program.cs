using System;

namespace ObjectsAndClasses_Lab
{
    internal class Program
    {
        static void Main()
        {
            //Demo 02
            /*  Random random = new Random();   

              int randomNumber = random.Next(0, 10);
              Console.WriteLine(randomNumber);*/

            /*   //Demo 01
               //1st way for creating an object
               Dog dog = new Dog()
               {
                   Name = "Sharo",
                   Breed = "Pitbull",
                   Age = 12,
               };

               //2th way for creating an object
               Dog dog2 = new Dog();
               dog2.Name = "Sharo";
               dog2.Breed = "PitBull";
               dog2.Age = 12;
               dog2.Bark();

               Console.WriteLine(dog.Name);
               Console.WriteLine(dog.Breed);
               Console.WriteLine(dog.Age);*/

            //Demo 04
            //1st way
            /*Dice dice = new Dice();
            dice.Sides = 6;
            dice.Roll();

            Dice dice2 = new Dice();
            dice2.Sides = 2;
            dice2.Roll();   */

            //2th way 
            Dice dice = new Dice(6);
            dice.Roll();
            Console.WriteLine(dice.Name);
        }
    }

    //Demo 01
    /*  public class Dog
      {
          public string Breed
          {
              get;
              set;
          }
          public string Name
          { 
              get;
              set;
          }

          public int Age
          { 
              get;
              set;
          }
          public void Bark()
          {
              Console.WriteLine("bark bark ....");
          }
      }*/

    //Demo 03
    public class Dice
    {
        public Dice(int sides)
        {
            Sides = sides;
        }   

        public string Name
        {
            get
            {
                return $"My name is {Sides}";
            }
        }
        public int Sides { get; set; }

        public void Roll()
        {
            Random random = new Random();
            int rndNumber = random.Next(1, Sides + 1);
            Console.WriteLine(rndNumber);
        }
    }
}
