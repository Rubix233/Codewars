/*You are going to be given a word. Your job is to return the middle character of the word. 
If the word's length is odd, return the middle character. 
If the word's length is even, return the middle 2 characters.*/

using NUnit.Framework;  
using System;
[TestFixture]
public class GetMiddleTest
{
  [Test]
  public void GenericTests()
  {
    Assert.AreEqual("es",Kata.GetMiddle("test"));
    Assert.AreEqual("t",Kata.GetMiddle("testing"));
    Assert.AreEqual("dd",Kata.GetMiddle("middle"));
    Assert.AreEqual("A",Kata.GetMiddle("A"));
  }
}

// Solution

public class Kata
{
  public static string GetMiddle(string s)
  {
    string str = s;
    int x = s.Length -1;
    int y = s.Length;
    
    if ((s.Length % 2) != 0) {
      while (y > 1){
        string temp = str.Remove(x);
        str = temp;
        temp = str.Remove(0, 1);
        str = temp;
        y -= 2;
        x -= 2;
      }    
    } else {
        while (y > 2){
          string temp = str.Remove(x);
          str = temp;
          temp = str.Remove(0, 1);
          str = temp;
          y -= 2;
          x -= 2;
        }
      }
    
    return str;
  }
}