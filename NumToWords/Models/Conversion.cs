using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace NumToWords.Models
{
  public class Conversion
  {
    private int _inputNum;

    public Dictionary<int, string> ones = new Dictionary<int, string>()
    {
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"},
    };

    public Dictionary<int, string> teens = new Dictionary<int, string>()
    {
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"},
    };

    public Dictionary<int, string> tens = new Dictionary<int, string>()
    {
      {2, "twenty"},
      {3, "thirty"},
      {4, "forty"},
      {5, "fifty"},
      {6, "sixty"},
      {7, "seventy"},
      {8, "eighty"},
      {9, "ninety"},
    };

    public Dictionary<int, string> hundreds = new Dictionary<int, string>()
    {
      {1, "one hundred"},
      {2, "two hundred"},
      {3, "three hundred"},
      {4, "four hundred"},
      {5, "five hundred"},
      {6, "six hundred"},
      {7, "seven hundred"},
      {8, "eight hundred"},
      {9, "nine hundred"},
    };

    public Conversion (int number)
    {
      _inputNum = number;
    }

    public string GetDictionaryWord(Dictionary<int, string> dictName, int number)
    {
      return dictName[number];
    }

    public int GetInputNum()
    {
      return _inputNum;
    }
  }
}
