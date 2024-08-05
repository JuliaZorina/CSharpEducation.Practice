using System;

namespace Practice3.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var book = new Book(); //Конструктор по умолчанию

      book.BookInfo();

      var book2 = new Book("А.С. Пушкин", "Руслан и Людмила");

      book2.BookInfo();
    }
  }
}
