using System;

namespace Practice7.Task1
{
  public interface IStorage<T>
  {
    void Add(T item);
    T Get(int index);
    int Count { get; }
  }
}
