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
        
    }
}
