  using NUnit.Framework;
  using System;

//Your task is to create functionisDivideBy (or is_divide_by) to check if an integer number is divisible by each out of two arguments.


  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual(true, Kata.is_divide_by(-12, 2, 6));
      Assert.AreEqual(false, Kata.is_divide_by(-12, 2, -5));
      Assert.AreEqual(false, Kata.is_divide_by(-45, 1, 6));
      Assert.AreEqual(true, Kata.is_divide_by(45, 5, 15));
      Assert.AreEqual(true, Kata.is_divide_by(4, 1, 4));
      Assert.AreEqual(true, Kata.is_divide_by(15, -5, 3));
    }
  }

//Solution
public class Kata
{
    public static bool is_divide_by(int number, int a, int b)
    {
      if ((number % a) == 0 && (number % b) == 0) return true;
      else return false;
    }
}