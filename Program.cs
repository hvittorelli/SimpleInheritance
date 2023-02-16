using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }
    // derived class1
    class Bear : Animal 
    {
        public string type;
        public int age;
        public double weight;

        // constructor
        public Bear() 
            :base() 
        {
            type = " ";
            age = 0;
            weight = 0;
        }
        // paramaterized constructor
        public Bear(string name, string type, int age, double weight) 
            :base(name)
        {
            this.type = type;
            this.age = age;
            this.weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Here is some information about our bears:");
            Console.WriteLine($"My nickname is {name}");
            Console.WriteLine($"I am a {type}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"I weigh {weight} pounds");
        }
    }
    // derived class2
    class Sloth : Animal
    {
        public string type;
        public int age;
        public string favFood;
        
        // constructor
        public Sloth() 
        {
            type = " ";
            age = 0;
            favFood= " ";
        }

        // paramaterized constructor
        public Sloth (string name, string type, int age,string favFood)
            :base(name)
        {
            this.type = type;
            this.age = age;
            this.favFood= favFood;
        }
        public void DisplayInfo() 
        {
            Console.WriteLine();
            Console.WriteLine("Here is some information about our sloths:");
            Console.WriteLine($"My nickname is {name}");
            Console.WriteLine($"I am a {type}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"My favorite food is {favFood}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparkles";
            myPet.display();

            // derived class1 object using default constructor
            Bear brownBear = new Bear();
            brownBear.name = "Beary";
            brownBear.type = "Brown Bear";
            brownBear.age = 10;
            brownBear.weight = 200;
            brownBear.DisplayInfo();

            //derived class1 object using parameterized constructor
            Bear pandaBear = new Bear("Spot", "Panda Bear", 4, 310);
            pandaBear.DisplayInfo();

            // derived class2 object using default constructor
            Sloth slothOne = new Sloth();
            slothOne.name = "Slow Poke";
            slothOne.type = "Two-Toed Sloth";
            slothOne.age = 8;
            slothOne.favFood = "lemon leaves";
            slothOne.DisplayInfo();

            //derived class2 object using parameterized constructor
            Sloth slothTwo = new Sloth("Sam", "Ground Sloth", 15, "bananas");
            slothTwo.DisplayInfo();
        }

    }
}
