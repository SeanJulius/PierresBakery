using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

[TestClass]
  public class BreadTests
  {
    
    [TestMethod]
    public void GetBread_CreateBreadInstance_Bread()
    {
        Bread newBread = new Bread(0, 0);
        Assert.AreEqual(typeof(Bread), new Bread.GetType());
    }
  }