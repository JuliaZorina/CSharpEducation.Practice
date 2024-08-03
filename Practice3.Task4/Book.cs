using System;

namespace Practice3.Task4
{
  class Book
  {
    private string Author;
    private string Title;
    
    public Book()
    {
      this.Author = "Имя Автора";
      this.Title = "Название по умолчанию, которое я не придумала";
    }

    public Book(string author, string title)
    {
      this.Author = author;
      this.Title = title;
    }

    public void BookInfo()
    {
      Console.WriteLine($"Автор: {this.Author}\nНазвание: {this.Title}");
    }
  }
}
