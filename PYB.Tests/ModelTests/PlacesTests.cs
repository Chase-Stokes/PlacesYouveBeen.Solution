using Microsoft.VisualStudio.TestTools.UnitTesting;
using PYB.Models;
using System;
using System.Collections.Generic;

namespace PYB.Tests
{
  [TestClass]

  public class PlacesTests
  {
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      string description = "It was cool";
      string cityName ="portland";
      Places newPlace = new Places(cityName, description);
      List<Places> newPlaceList = new List<Places> {};
      List<Places> result = Places.GetAll();
      CollectionAssert.AreEqual(newPlaceList, result);
    }
  }
}