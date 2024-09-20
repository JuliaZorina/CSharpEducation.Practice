using System;

namespace Practice6.Task3
{
  public class TooManyAttemptsException : Exception
  {
    #region Конструкторы

    public TooManyAttemptsException(string message)
      : base(message) { }

    #endregion
  }
}
