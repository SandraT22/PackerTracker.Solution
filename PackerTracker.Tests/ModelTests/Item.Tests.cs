using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests 
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      // Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreateAnItem_Item()
    {
      Item newItem = new Item("testName", "testStatus");
      string x = "not Item";
      Assert.AreEqual(typeof(Item), x.GetType());
    }


  }



}
