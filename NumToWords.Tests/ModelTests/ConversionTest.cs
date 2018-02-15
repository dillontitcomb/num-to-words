using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWords;
using System.Collections.Generic;
using NumToWords.Models;

namespace NumToWords.Tests
{
  [TestClass]
  public class ConversionTest
  {
    [TestMethod]
    public void GetInputNum_ReturnNum_Long()
    {
      Conversion newConversion = new Conversion(5);
      Assert.AreEqual(5, newConversion.GetInputNum());
    }
  }
}
