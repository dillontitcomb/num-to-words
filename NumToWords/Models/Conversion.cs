using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace NumToWords.Models
{
  public class Conversion
  {
    private int _inputNum;

    public Conversion (int number)
    {
      _inputNum = number;
    }

    public int GetInputNum()
    {
      return _inputNum;
    }
  }
}
