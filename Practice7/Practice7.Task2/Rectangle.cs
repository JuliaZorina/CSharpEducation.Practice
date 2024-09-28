using System;

namespace Practice7.Task2
{
  public class Rectangle : ICloneable
  {
    public int Width {  get; set; }
    public int Height { get; set; }

    public object Clone()
    {
      return MemberwiseClone(); 
    }
  }
}
