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
      public void BreadCost_ShowCostOfThreeLoavesOfBread_3()
      {
        Assert.AreEqual(10, Bread.BreadCost(3));
      }
      
      [TestMethod]
      public void BreadCost_ShowCostOfFiveLoavesOfBread_5()
      {
        Assert.AreEqual(20, Bread.BreadCost(5));
      }

      [TestMethod]
      public void SetObject_SetObject_Bread()
      {
        int quant = 0;
            int cost = 0;
            Bread newBread = new Bread(quant, cost);

            int updatedQuant = 2;
            newBread.Quant = updatedQuant;
            int finalQuant = newBread.Quant;
            int updatedCost = 2;
            newBread.Cost = updatedCost;
            int finalCost = newBread.Cost;

            
            Assert.AreEqual(updatedQuant, finalQuant);
            Assert.AreEqual(updatedCost, finalCost);
      }
  }
  