//square every digit of a number and concatenate them.

using System;
using NUnit.Framework;

[TestFixture]
public class KataTest
{
  [Test]
  public void SquareDigitsTest()
  {
    Assert.AreEqual(811181, Kata.SquareDigits(9119));
    Assert.AreEqual(0, Kata.SquareDigits(0));
  }
}

//Solution

public class Kata
{
  public static int SquareDigits(int n)
  {
    int places = 0;
    int result = 0;
    
    while (n > 0){

      //example: 9119 / 10 = 911,9 => ,9
      int digit = n % 10;
      //digit = 9
      
      int square = digit * digit;
      // square = 9*9 = 81
      
      //Places starts at 0
      result += (int)Math.Pow(10, places) * square;
      //10 ^ 0 = 1
      
      places += square > 10? 2 : 1;
      //81 > 10 => places goes up by 2
      
      n /= 10;
      // 9119 / 10 = 911,9 => 911 (int)
    }
    return result;
  }
}