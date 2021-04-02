//write a function that takes a string and return a new string with all vowels removed.

using System;
using NUnit.Framework;

[TestFixture]
public class DisemvowelTest
{
  [Test]
  public void ShouldRemoveAllVowels()
  {
    Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
  }
}


// Solution


public static class Kata
{
  public static string Disemvowel(string str)
  {

      string final = Regex.Replace (str, "[aeiouAEIOU]", "");
      
    return final;
  }
}