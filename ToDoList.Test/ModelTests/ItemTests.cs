using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("potato");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_returnsDescription_String()
    {

      //Arrange
      string kindOfChore = "Walk the dog.";
      Item newItem = new Item(kindOfChore);
      //Act
      string result = newItem.Description;
      //Assert
      Assert.AreEqual(kindOfChore, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string kindOfChore = "Walk the dog.";
      Item newItem = new Item(kindOfChore);

      //Act
      string updatedKindOfChore = "Do the dishes.";
      newItem.Description = updatedKindOfChore;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedKindOfChore, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      //Arrange
      List<Item> newList = new List<Item> { };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnItems_ItemList()
    {
      //Arrange
      string kindOfChore01 = "Walk the dog.";
      string kindOfChore02 = "Do the dishes.";
      Item newItem1 = new Item(kindOfChore01);
      Item newItem2 = new Item(kindOfChore02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}