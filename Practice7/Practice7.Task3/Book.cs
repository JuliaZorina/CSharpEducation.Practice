using System;

namespace Practice7.Task3
{
  public class Book : IComparable
  {
    public string Title {  get; set; }
    public string Author { get; set; }

    public int CompareTo(object obj)
    {
      if (obj is Book book)
      {
        return book.Author.CompareTo(Author);
      }
      else
      {
        throw new ArgumentException("Введено некорректное значение");
      }
    }
  }
}
