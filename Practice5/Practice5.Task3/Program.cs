using System;
using System.Collections.Generic;

namespace Practice5.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Animal> animals = new List<Animal>() { new Dog("Шарик", 5), new Cat("Пушок", 4) , new Parrot("Кеша", 2) };
      IFlyable[] flyables = new IFlyable[2] { new Parrot("Толик", 2), new Eagle("Орел", 7)};
      
      foreach(Animal animal in animals)
        PrintAnimalSound(animal);

      foreach (IFlyable flyable in flyables)
        flyable.Fly();
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
