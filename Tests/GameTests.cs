using System.Collections.Generic;
using System;
using Scrabble.Objects;
using Xunit;

namespace ScrabbleTests
{
  public class GameTest
  {
    [Theory]
    [InlineData("a", 1)]
    [InlineData("tool", 4)]
    [InlineData("family", 14)]
    [InlineData("FaMiLY", 14)]
    [InlineData("f4am!ily;", 14)]
    public void Test1_LoopThroughInput_ReturnScore(string testString, int expectedScore)
    {
      Game newGame = new Game(testString);
      Assert.Equal(expectedScore, newGame.GetStringVal());
    }
  }
}
