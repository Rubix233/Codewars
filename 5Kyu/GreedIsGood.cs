/* Three 1's => 1000 points
 Three 6's =>  600 points
 Three 5's =>  500 points
 Three 4's =>  400 points
 Three 3's =>  300 points
 Three 2's =>  200 points
 One   1   =>  100 points
 One   5   =>   50 point*/

 /*A single die can only be counted once in each roll.
  For example, a given "5" can only count as part of a triplet (contributing to the 500 points)
   or as a single 50 points, but not both in the same roll.*/

 using System;
using NUnit.Framework;

public static class ScoreChecker
{
  [Test]
  public static void ShouldBeWorthless()
  {
    Assert.AreEqual(0, Kata.Score(new int[] {2, 3, 4, 6, 2}), "Should be 0 :-(");
  }
  
  [Test]
  public static void ShouldValueTriplets()
  {
    Assert.AreEqual(400, Kata.Score(new int[] {4, 4, 4, 3, 3}), "Should be 400");
  }
  
  [Test]
  public static void ShouldValueMixedSets()
  {
    Assert.AreEqual(450, Kata.Score(new int[] {2, 4, 4, 5, 4}), "Should be 450");
  }
}  

//Solution 

public static class Kata
{
  public static int Score(int[] dice) {
    // Fill me in!
    int ones = 0;
    int twos = 0;
    int threes = 0;
    int fours = 0;
    int fives = 0;
    int sixes = 0;
    int points = 0;
    
    for (int i = 0; i < dice.Length; i++){
      switch (dice[i]){
          case 1: 
            ones += 1;
            break;
          case 2: 
            twos += 1;
            break;
          case 3: 
            threes += 1;
            break;
          case 4: 
            fours += 1;
            break;
          case 5: 
            fives += 1;
            break;
          case 6: 
            sixes += 1;
            break;
      }
      }
      while (ones > 0) {
      if (ones >= 3){
        points += 1000;
        ones -= 3;
      }
      if (ones >= 1){
        points += 100;
        ones -= 1;
      }
      }
      while (fives > 0) {
      if (fives >= 3){
        points += 500;
        fives -= 3;
      }
      if (fives >= 1){
        points += 50;
        fives -= 1;
      }
      }
      
      if (twos >= 3){
        points += 200;
      }
      if (threes >= 3){
        points += 300;
      }
      if (fours >= 3){
        points += 400;
      }
      if (sixes >= 3){
        points += 600;
      }

    return points;
  }
}