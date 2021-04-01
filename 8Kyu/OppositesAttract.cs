//Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.

using NUnit.Framework;
  using System;
  [TestFixture]
  public class LoveTests
  { 
    [Test]
    public void Test1()
    {
      Assert.AreEqual(true, LoveDetector.lovefunc(1,4));
    }

    [Test]
    public void Test2()
    {
      Assert.AreEqual(false, LoveDetector.lovefunc(2,2));
    }

    [Test]
    public void Test3()
    {
     Assert.AreEqual(true, LoveDetector.lovefunc(0,1));
    }

    [Test]
    public void Test4()
    {
      Assert.AreEqual(false, LoveDetector.lovefunc(0,0));
    }
}

//Solution

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 

      if ((flower1 + flower2)% 2 != 0 ) {
        return true;
      } else { 
      return false;
      }
      
    }
}