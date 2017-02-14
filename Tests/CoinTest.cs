using Xunit;
using System.Collections.Generic;
using CoinApp.Objects;

namespace CoinApp
{
  public class CoinTest
  {
    [Fact]
    public void Change_n_ExactCoins()

    {
      //Arrange
      Coins testObject = new Coins();



      //Act
      string test = testObject.Change(97);

      //Assert
      Assert.Equal(test, "2");
    }
  }
}
