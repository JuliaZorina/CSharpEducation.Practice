using System;

namespace Practice6.Task2
{
  public abstract class BaseBankAccount 
  {
    #region Поля и свойства

    public abstract decimal Money { get; set; }
    public abstract decimal DepositMoney { get; set; }

    #endregion

    #region Методы

    /// <summary>
    /// Внести деньги на депозит.
    /// </summary>
    public abstract void Deposit();
    /// <summary>
    /// Снять наличные.
    /// </summary>
    public abstract void GetCash();
    
    #endregion

    #region Конструкторы

    public BaseBankAccount(decimal money)
    {
      this.DepositMoney = 0;
      this.Money = money;
    }

    #endregion

  }
}
