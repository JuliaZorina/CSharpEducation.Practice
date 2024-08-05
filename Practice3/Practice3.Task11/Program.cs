using System;

namespace Practice3.Task11
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var book = new Book()
      {
        title = "Руслан и Людмила",
        author = "А.С. Пушкин"
      };

      Console.WriteLine(BookInfo(book));
    }

    public static string BookInfo(Book book)
    {
      return ($"Название книги: {book.title}, автор: {book.author}");
    }
  }
}
