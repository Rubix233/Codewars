using NUnit.Framework;
using System;
[TestFixture]


public class CustomMathTest
{
  [Test]
  public void ShouldMultiple()
  {
    Assert.AreEqual(2, CustomMath.multiply(2, 1));
    Assert.AreEqual(8, CustomMath.multiply(2, 4));
  }
}

//Solution

public class CustomMath {
    public static int multiply(int a, int b) {
        return a * b;
    }
}

