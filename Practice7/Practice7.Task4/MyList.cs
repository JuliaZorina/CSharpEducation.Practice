using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice7.Task4
{
  public class MyList : IEnumerable
  {
    public List<int> Items {  get; set; }

    public IEnumerator GetEnumerator()
    {
      return this.Items.GetEnumerator();
    }
  }
}
