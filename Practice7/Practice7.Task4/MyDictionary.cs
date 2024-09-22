using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice7.Task4
{
  public class MyDictionary : IEnumerator
  {
    public Dictionary<string, int> Items { get; set; }
    private IEnumerator<KeyValuePair<string, int>> enumerator;

    public object Current {
      get
      {
        return this.enumerator.Current;
      }
    }

    public bool MoveNext()
    {
      return this.enumerator.MoveNext();
    }

    public void Reset()
    {
      this.enumerator.Reset();
    }

    public MyDictionary()
    {
      this.Items = new Dictionary<string, int>();
      this.enumerator = Items.GetEnumerator();
    }
  }
}
