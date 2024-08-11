using System;
using Practice4.Task3;

namespace Practice4.Task3A
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var julia = new Person("Julia", 22);
      julia.Print();

      var oleg = new Person("Олег", 45);
      oleg.Print();
    }
  }
}
