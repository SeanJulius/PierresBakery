using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]

    public class PastryTests
    {
    [TestMethod]
        public void PastryCost_ShowCostOfOnePastry_1()
        {
        Assert.AreEqual(2, Pastry.PastryCost(1));

        }
    [TestMethod]
        public void PastryCost_ShowCostOfThreePastry_3()
        {
        Assert.AreEqual(5, Pastry.PastryCost(3));

        }
    [TestMethod]
    public void SetObject_SetObject_Pastry()
    {
        int quant = 0;
            int cost = 0;
            Pastry newPastry = new Pastry(quant, cost);

            int updatedQuant = 2;
            newPastry.Quant = updatedQuant;
            int finalQuant = newPastry.Quant;
            int updatedCost = 2;
            newPastry.Cost = updatedCost;
            int finalCost = newPastry.Cost;

            
            Assert.AreEqual(updatedQuant, finalQuant);
            Assert.AreEqual(updatedCost, finalCost);
    }   
    }
} 
