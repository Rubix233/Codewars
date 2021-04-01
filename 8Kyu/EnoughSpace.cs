/*You have to write a function that accepts three parameters:

cap is the amount of people the bus can hold excluding the driver.
on is the number of people on the bus excluding the driver.
wait is the number of people waiting to get on to the bus excluding the driver.
If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.*/


using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest{
   
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual(0, Kata.Enough(10, 5, 5));
      Assert.AreEqual(10, Kata.Enough(100, 60, 50));
      Assert.AreEqual(0, Kata.Enough(20, 5, 5));
    }
  }


 // solution

public static class Kata{
  public static int Enough(int cap, int on, int wait)
  {
    
    int total = (cap - on - wait);
    int answer = 0;
    
    if (total >= 0) answer = 0;
    else if (total <0) answer = total* (-1);
    
    return answer;
  }
}