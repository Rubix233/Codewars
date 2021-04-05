//Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.


  using NUnit.Framework;
  using System;
  using System.Linq;

  [TestFixture]
  public class Sample_Test
  {
    [Test]
    public void Test()
    {
      Assert.AreEqual(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
    }
  }

  //Solution

  public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  { 
    var resultList = new List<int>();
    int [] result = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++){
      if (arr[i] != 0){
        resultList.Add(arr[i]);
      }
    }
    for (int i = 0; i < arr.Length; i++){
      if (arr[i] == 0){
        resultList.Add(arr[i]);
      }
    }
    result = resultList.ToArray();
    
    return result;
   
  }
}