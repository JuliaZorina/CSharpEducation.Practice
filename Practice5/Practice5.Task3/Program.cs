using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Practice5.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Animal> animals = new List<Animal>() { new Dog("Шарик", 5), new Cat("Пушок", 4) , new Parrot("Кеша", 2) };
      /*Dog dog = new Dog("Шарик", 5);
      Cat cat = new Cat("Пушок", 4);
      Parrot parrot = new Parrot("Кеша", 2);

      cat.MakeSound();
      dog.MakeSound();*/
      foreach(Animal animal in animals)
        PrintAnimalSound(animal);
    }

    public static void PrintAnimalSound(Animal animal)
    {
      if(animal is Animal)
      {
        animal.MakeSound();
      }
      if(animal is Cat)
      {
        var cat = animal as Cat;
        cat.MakeSound();
      }
      if(animal is Dog)
      {
        var dog = animal as Dog;
        dog.MakeSound();
      }
      if(animal is Parrot)
      {
        var parrot = animal as Parrot;
        parrot.MakeSound();

        Console.WriteLine("Введите слово");
        parrot.MakeSound(Console.ReadLine());
      }
    }
  }
}
