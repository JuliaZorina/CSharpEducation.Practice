using System;

namespace Practice6.Task2
{
  public class WithdrawalLimitExceededException : Exception
  {
    #region Конструкторы

    public WithdrawalLimitExceededException(string message) 
    : base(message) { }

    #endregion
  }
}
