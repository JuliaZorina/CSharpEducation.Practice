using System;
using System.Linq;
using System.Text;

namespace Practice7.Task6
{
  public static class StringExtentions
  {
    public static bool IsPalindrome(this string str)
    {
      var temp = str.Trim();
      var k = 0;
      for (int i = 0; i < temp.Length; i++)
      {
        if(temp[i] == temp[temp.Length - i - 1])
        {
          k++;
        }
      }
      if (k == temp.Length)
        return true;
      else return false;
    }

    public static string ToTitleCase(this string str) 
    {
      var strArray = str.Split(' ');
      var s = string.Empty;
      for (int i = 0; i < strArray.Length; i++)
      {
        var temp = strArray[i].ToCharArray();
        temp[0] = temp[0].ToString().ToUpper().ToCharArray()[0];
        strArray[i] = string.Join("", temp);
      }
      
      return s = string.Join(" ", strArray);
    }

  }
}
