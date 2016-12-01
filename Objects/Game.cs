using System.Collections.Generic;
using System;

namespace Scrabble.Objects
{
  public class Game
  {
    private string _inputWord;
    private int _score;
    private int[] dictKeys = {1, 2, 3, 4, 5, 8, 10};
    private string[] dictVals = {"AEIOULNRST", "DG", "BCMP", "FHVWY", "K", "JX", "QZ"};

    public Game(string userInput)
    {
      _inputWord = userInput;
      _score = 0;
    }

    public int GetStringVal()
    {
      string letter = "";
      for (int i = 0; i < _inputWord.Length; i++)
      {
        letter = _inputWord[i].ToString().ToUpper();
        for (int j = 0; j < dictVals.Length; j++)
        {
          if (dictVals[j].Contains(letter))
          {
            _score += dictKeys[j];
          }
        }
      }
      return _score;
    }
  }
}
