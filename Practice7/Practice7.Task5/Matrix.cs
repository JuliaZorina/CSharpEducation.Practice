using System;

namespace Practice7.Task5
{
  public class Matrix
  {
    public int[,] Data { get; set; }

    public int this[int i, int j]
    {
      get => this.Data[i, j];
      set => this.Data[i, j] = value;
    }
  }
}
