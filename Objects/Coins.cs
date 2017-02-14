using System;
using System.Collections.Generic;

namespace CoinApp.Objects

{
  public class Coins
  {
    public int _penny;
    public int _nickel;
    public int _dime;
    public int _quarter;

    public int _quarterCount;
    public int _dimeCount;
    public int _nickelCount;
    public int _pennyCount;


    public Coins()
    {
      _penny = 1;
      _nickel = 5;
      _dime = 10;
      _quarter = 25;
    }

    public string Change(int userVal)
    {
      while (userVal != 0)
      {
        _quarterCount =  userVal / _quarter;
        int quarterSum = _quarterCount * _quarter;
        userVal = userVal - quarterSum;

        _dimeCount = userVal / _dime;
        int dimeSum = _dimeCount * _dime;
        userVal = userVal - dimeSum;

        _nickelCount = userVal / _nickel;
        int nickelSum = _nickelCount * _nickel;
        userVal = userVal - nickelSum;

        _pennyCount = userVal / _penny;
        int pennySum = _pennyCount * _penny;
        userVal = userVal - pennySum;
      }

      string output = "Quarters = " + _quarterCount.ToString() + " " + "Dimes = " + _dimeCount.ToString() + " " + "Nickels: " + _nickelCount.ToString() + " " + "Pennies: " + _pennyCount.ToString();
      
      return output;
    }




  }
}
