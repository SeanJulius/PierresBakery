using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

[TestClass]
  public class BreadTests
  {
    
        [TestMethod]
    public void BreadCost_ShowCostOfOneLoaf_1()
    {
      Assert.AreEqual(5, Bread.BreadCost(1));
    }

    [TestMethod]
      public void BreadPrice_ShowPriceOfThreeLoavesOfBread_3()
      {
        Assert.AreEqual(18, Bread.BreadPrice(3));
      }
  }