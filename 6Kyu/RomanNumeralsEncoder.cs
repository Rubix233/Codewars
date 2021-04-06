//Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.

using System;
using NUnit.Framework;

[TestFixture]
public class RomanConvertTests
{
	[TestCase(1, "I")]
	[TestCase(2, "II")]
	[TestCase(4, "IV")]
	[TestCase(500, "D")]
	[TestCase(1000, "M")]
	[TestCase(1954, "MCMLIV")]
	[TestCase(1990, "MCMXC")]
	[TestCase(2008, "MMVIII")]
	[TestCase(2014, "MMXIV")]
	public void Test(int value, string expected)
	{
		Assert.AreEqual(expected, RomanConvert.Solution(value));
	}
}

//Solucion

public class RomanConvert
{
  public static string Solution(int n)
  {
    
    string miles = "";
    string quintos = "";
    string cientos = "";
    string quentas = "";
    string misDieses = "";
    string chinco = "";
    string unos = "";
    string output = "";
    
    if  ((n < 0) || (n > 3999))  throw new NotImplementedException("Wadafaaa");
    if (n < 1) return string.Empty;  
    while (n > 0){    
    while (n >= 1000){
      miles += "M";
      n -= 1000;
    } 
    if (n >= 900 && n < 1000){
      miles += "CM";
      n -= 900;
    }
    if (n >= 500 && n < 900){
      quintos += "D";
      n -= 500;
    } 
    if (n >= 400 && n < 500){
      quintos += "CD";
      n -= 400;
    } 
    if (n >= 100 && n < 500){
      cientos += "C" ;
      n -= 100;
    } 
    if (n >= 90 && n < 100){
      cientos += "XC";
      n -= 90;
    }
    if (n >= 50 && n < 90){
      quentas += "L";
      n -= 50;
    }
    if (n >= 40 && n < 50){
      quentas += "XL";
      n -= 40;
    }
    if (n >= 10 && n < 50){
      misDieses += "X";
      n -= 10;
    }
    if (n == 9){
      misDieses += "IX";
      n -= 9;
    }
    if (n >= 5 && n < 9){
      chinco += "V";
      n -= 5;
    }
    if ( n == 4){
      unos += "IV";
      n -= 4;
    }
    if (n >= 1 && n < 5){
      unos += "I";
      n -= 1;
    } 
    }

    output = miles + quintos + cientos + quentas + misDieses + chinco + unos;
    return output;
    throw new NotImplementedException("END YOURSELF");
  }
}