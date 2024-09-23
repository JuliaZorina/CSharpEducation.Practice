using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice7.Task4
{
  public class MyDictionary : IEnumerator
  {
    public Dictionary<string, int> Items { get; set; }
    private int position = -1;

    public object Current {
      get
      {
        if(position == -1 || position>=Items.Count) 
          throw new ArgumentOutOfRangeException();
        return this.Items.ElementAt(position);
      }
    }

    public bool MoveNext()
    {
      if(position >= Items.Count - 1)
      {
        position++;
        return true;
      }
      else
      {
        return false;
      }
    }

    public void Reset()
    {
      position = -1;
    }

    public MyDictionary()
    {
      this.Items = new Dictionary<string, int>();
    }
  }
}
