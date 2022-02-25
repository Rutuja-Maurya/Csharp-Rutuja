using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{ 


class Animal  // Base class (parent) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cow : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: moo moo");
    }
}

class Cat : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The cat says: meow meow");
    }
}

class PolymorphismDemo
{
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myCow = new Cow();  // Create a Cow object
            Animal myCat = new Cat();  // Create a Cat object

            myAnimal.animalSound();
            myCow.animalSound();
            myCat.animalSound();
        }
    }
}