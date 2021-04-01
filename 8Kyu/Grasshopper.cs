//Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.

using System;
using NUnit.Framework;

[TestFixture]
public static class KataTests 
{
    [Test]
    public static void BasicTests() 
    {
        Assert.AreEqual(1, Kata.summation(1));
        Assert.AreEqual(36, Kata.summation(8));
        Assert.AreEqual(253, Kata.summation(22));
        Assert.AreEqual(5050, Kata.summation(100));
        Assert.AreEqual(22791, Kata.summation(213));
    }
}

//Solution

public static class Kata 
{
    public static int summation(int num)
    {
      //Code here
      int total = 0;
      for (int i = 1; i <= num; i++ ){
        total = total + i;
      }
      return total;
    }
}