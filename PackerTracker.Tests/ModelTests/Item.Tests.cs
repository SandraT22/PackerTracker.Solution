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
      // string x;
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void ItemConstructor_ReturnName_String()
    {
      string name = "testName";
      string status = "testStatus";
      Item newItem = new Item(name, status);
      string result = newItem.Name;
      Assert.AreEqual(status, result);
    }


  }



}
