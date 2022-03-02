using Microsoft.VisualStudio.TestTools.UnitTesting;
using PYB.Models;
using System;
using System.Collections.Generic;

namespace PYB.Tests
{
  [TestClass]

  public class PlacesTests : IDisposable
  {
    public void Dispose()
    {
      Places.ClearAll();
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // --- Needed for good fail on test---
      // string description = "It was cool";
      // string cityName ="portland";
      // Places newPlace = new Places(cityName, description);
      // ------------------------------------------------------------
      List<Places> newPlaceList = new List<Places> {};
      List<Places> result = Places.GetAll();
      CollectionAssert.AreEqual(newPlaceList, result);
    }

    [TestMethod]
    public void Find_ReturnCorrectItem_Place()
    {
      string description = "It was cool";
      string cityName ="portland";
      string description1 = "It was wet";
      string cityName1 ="seattle";
      Places newPlace = new Places(cityName, description);
      Places newPlace1 = new Places(cityName1, description1);
      Places result = Places.Find(1); // change the number in Find() for good fail
      Assert.AreEqual(newPlace, result);
    }

    [TestMethod]
    public void GetId_InstantiatePlaceWithID_Int()
    {
      string description = "It was cool";
      string cityName ="portland";
      Places newPlace = new Places(cityName, description);
      int result = newPlace.Id; //set result to 0 for good fail
      Assert.AreEqual(1, result);
    }

  }
}