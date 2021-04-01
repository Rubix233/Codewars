  using NUnit.Framework;
  using System;


  //Your goal in this kata is to determine which phrase the girls would say for a flower of a given number of petals, where nb_petals > 0.

  [TestFixture]
  public class Test
  {
    [Test]
    public void SampleTests()
    {
      Assert.AreEqual("I love you", Kata.HowMuchILoveYou(7));
      Assert.AreEqual("a lot", Kata.HowMuchILoveYou(3));
      Assert.AreEqual("not at all", Kata.HowMuchILoveYou(6));
    }
  }

//Solution
public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    // your code
    string [] phrases;
    int x = nb_petals - 1;
    
    phrases = new string[6] {"I love you", "a little", "a lot","passionately", "madly", "not at all" };
    
    
    
    return new String(phrases[x % 6]);
  }
}