using System;
using ToDoList.Models;
using System.Collections.Generic;


namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List.");
      Console.WriteLine("Would you like to add an item to your list? ['Y' for yes, 'Enter' for no]");
      string userInput = Console.ReadLine();
      if (userInput == "Y" || userInput == "y")
      {
        AddNewItems();
      }
      else
      {
        Console.WriteLine("Would you like to view your list of items? ['Y' for yes, 'Enter' for no]")
        string viewItems = Console.ReadLine();
        if (finishedAnswer == "Y" || finishedAnswer == "y")
      {
        ListAllItems();
      }
      else
      {
        Main();
      }
    }  
    
      public static void AddNewItems();
      {
        Console.WriteLine("What would you like to add?"); 
        string itemAdded = Console.ReadLine();
        Item newItem = new Item(itemAdded);
        ListAllItems();
      }
          

      public static void ListAllItems()
    {
      List<Item> allThings = Item.GetAll();
      
    }
    
  }
} 

