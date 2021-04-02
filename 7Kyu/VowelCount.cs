// Return the number (count) of vowels in the given string.

using System;
using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
    }
}

//Solution

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        
        for (int x = 0; x < str.Length; x++){
            char y = Convert.ToChar(str[x]);

            if (y == 'a' || y == 'e' || y == 'i' || y == 'o' || y == 'u'){
              vowelCount += 1;
            } 
        }

        return vowelCount;
    }
}