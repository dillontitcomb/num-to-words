using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace NumToWords.Models
{
  public class Conversion
  {
    private long _inputNum;
    private string _displayString;
    public List<long> inputNumList = new List<long>(){};
    public List<string> outputString = new List<string>(){};

    public Dictionary<long, string> ones = new Dictionary<long, string>()
    {
      {0, ""},
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

    public Dictionary<long, string> teens = new Dictionary<long, string>()
    {
      {0, "ten"},
      {1, "eleven"},
      {2, "twelve"},
      {3, "thirteen"},
      {4, "fourteen"},
      {5, "fifteen"},
      {6, "sixteen"},
      {7, "seventeen"},
      {8, "eighteen"},
      {9, "nineteen"},
    };

    public Dictionary<long, string> tens = new Dictionary<long, string>()
    {
      {0, ""},
      {2, "twenty"},
      {3, "thirty"},
      {4, "forty"},
      {5, "fifty"},
      {6, "sixty"},
      {7, "seventy"},
      {8, "eighty"},
      {9, "ninety"},
    };

    public Dictionary<long, string> hundreds = new Dictionary<long, string>()
    {
      {0, ""},
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

    public Dictionary<long, string> thousands = new Dictionary<long, string>()
    {
      {0, "thousand,"},
      {1, "one thousand,"},
      {2, "two thousand,"},
      {3, "three thousand,"},
      {4, "four thousand,"},
      {5, "five thousand,"},
      {6, "six thousand,"},
      {7, "seven thousand,"},
      {8, "eight thousand,"},
      {9, "nine thousand,"},
    };

    public Dictionary<long, string> millions = new Dictionary<long, string>()
    {
      {0, "million,"},
      {1, "one million,"},
      {2, "two million,"},
      {3, "three million,"},
      {4, "four million,"},
      {5, "five million,"},
      {6, "six million,"},
      {7, "seven million,"},
      {8, "eight million,"},
      {9, "nine million,"},
    };

    public Dictionary<long, string> billions = new Dictionary<long, string>()
    {
      {0, "billion,"},
      {1, "one billion,"},
      {2, "two billion,"},
      {3, "three billion,"},
      {4, "four billion,"},
      {5, "five billion,"},
      {6, "six billion,"},
      {7, "seven billion,"},
      {8, "eight billion,"},
      {9, "nine billion,"},
    };

    public Dictionary<long, string> trillions = new Dictionary<long, string>()
    {
      {0, ""},
      {1, "one trillion,"},
      {2, "two trillion,"},
      {3, "three trillion,"},
      {4, "four trillion,"},
      {5, "five trillion,"},
      {6, "six trillion,"},
      {7, "seven trillion,"},
      {8, "eight trillion,"},
      {9, "nine trillion,"},
    };

    public Conversion (long number)
    {
      _inputNum = number;
    }
    public string GetDictionaryWord(Dictionary<long, string> dictName, long number)
    {
      return dictName[number];
    }

    public void CreateWordList()
    {
      var inputArray = _inputNum.ToString().ToCharArray();
      foreach (var item in inputArray)
      {
        long newNum = Convert.ToInt64(Char.GetNumericValue(item));
        inputNumList.Add(newNum);
      }
      for (long i=0; i<inputNumList.Count; i++)
      {
        if (inputNumList.Count > 13)
        {
          outputString.Clear();
          outputString.Add("Whoops, it broke. Please input a smaller number.");
        }
        if (inputNumList.Count == 13)
        {
          string newWord = GetDictionaryWord(trillions, inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 12)
        {
          string newWord = GetDictionaryWord(hundreds,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 11 && inputNumList[0] == 1)
        {
          string newWord = GetDictionaryWord(teens,inputNumList[1]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
          inputNumList.RemoveAt(0);
        }
        else if (inputNumList.Count == 11)
        {
          string newWord = GetDictionaryWord(tens,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 10)
        {
          string newWord = GetDictionaryWord(billions,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 9)
        {
          string newWord = GetDictionaryWord(hundreds,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 8 && inputNumList[0] == 1)
        {
          string newWord = GetDictionaryWord(teens,inputNumList[1]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
          inputNumList.RemoveAt(0);
        }
        else if (inputNumList.Count == 8)
        {
          string newWord = GetDictionaryWord(tens,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 7)
        {
          string newWord = GetDictionaryWord(millions,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 6)
        {
          string newWord = GetDictionaryWord(hundreds,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 5 && inputNumList[0] == 1)
        {
          string newWord = GetDictionaryWord(teens,inputNumList[1]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
          inputNumList.RemoveAt(0);
        }
        else if (inputNumList.Count == 5)
        {
          string newWord = GetDictionaryWord(tens,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 4)
        {
          string newWord = GetDictionaryWord(thousands,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 3)
        {
          string newWord = GetDictionaryWord(hundreds,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 2 && inputNumList[0] == 1)
        {
          string newWord = GetDictionaryWord(teens,inputNumList[1]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
          inputNumList.RemoveAt(0);
        }
        else if (inputNumList.Count == 2)
        {
          string newWord = GetDictionaryWord(tens,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
        if (inputNumList.Count == 1)
        {
          string newWord = GetDictionaryWord(ones,inputNumList[0]);
          outputString.Add(newWord);
          inputNumList.RemoveAt(0);
        }
      }
      _displayString = String.Join(" ", outputString);
    }

    public long GetInputNum()
    {
      return _inputNum;
    }

    public string GetDisplayString()
    {
      return _displayString;
    }
  }
}
