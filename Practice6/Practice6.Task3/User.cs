using System;

namespace Practice6.Task3
{
  public class User
  {
    #region Поля и свойства

    public int Age { get; set; }

    public string Name { get; set; }

    #endregion

    #region Методы

    public void GetUserAge()
    {
      var counter = 10;
      for(int i=0; i<=counter; i++)
      {
        Console.WriteLine("Введите свой возраст");
        var age = int.Parse(Console.ReadLine());
        if (i == 10)
        {
          throw new TooManyAttemptsException("Слишком много попыток");
        }
        if (age < 18)
        {
          Console.WriteLine("Возраст был введен некорректно. Попробуйте еще раз. Номер попытки: " + i+1);
        }
        else
        {
          this.Age = age;
          Console.WriteLine($"{this.Name}, добро пожаловать в систему! Ваш возраст: {this.Age}");
          break;
        }
      }
      
    }

    #endregion

    #region Конструкторы

    public User(string name) 
    {
      this.Name = name;
    }

    #endregion

  }
}
