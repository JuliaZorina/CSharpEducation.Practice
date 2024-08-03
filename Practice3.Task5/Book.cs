using System;

namespace Practice3.Task5
{
  class Book
  {
    private string Author;
    private string Title;
    private int PublicationDate;
    
    public Book()
    {
      this.Author = "Имя Автора";
      this.Title = "Название по умолчанию, которое я не придумала";
    }

    public Book(string title): this(title, "Какой-то автор")
    {
      this.Title = title;
    }

    public Book(string title, string author) :this(title, author, 2020)
    {
      this.Title = title;
      this.Author = author;
    }

    public Book(string author, string title, int publicationDate)
    {
      this.Author = author;
      this.Title = title;
      this.PublicationDate = publicationDate;
    }

    public void BookInfo()
    {
      Console.WriteLine($"Автор: {this.Author}\nНазвание: {this.Title}\nГод публикации: {PublicationDate}");
    }
  }
}
