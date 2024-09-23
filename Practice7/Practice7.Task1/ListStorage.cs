using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice7.Task1
{
  public class ListStorage<T> : IStorage<T>
  {
    #region Поля и свойства

    public int Count { 
      get
      {
        return StorageCollection.Count;
      }
    }
    public List<T> StorageCollection { get; set; }

    #endregion

    #region Методы
    public void Add(T item)
    {
      if (!this.StorageCollection.Contains(item))
        this.StorageCollection.Add(item);
      else
        throw new ArgumentException("Такой элемент уже существует");
    }

    public T Get(int index)
    {
      return this.StorageCollection[index];
    }

    #endregion

    #region Конструкторы

    public ListStorage()
    {
      this.StorageCollection = new List<T>();
    }

    #endregion
  }
}
