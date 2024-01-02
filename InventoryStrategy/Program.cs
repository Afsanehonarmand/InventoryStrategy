using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
   static void Main(string[] args)
   {
      //for FIFO
      InventoryWrapper fifoList = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);
      {
         new Product(1, "mobile1");
         new Product(2, "mobile2");
         new Product(1, "mobile3");
         new Product(1, "mobile4");
         new Product(1, "mobile5");
      }

      Console.WriteLine("Enumerating products using a stack approach (FIFO):");
      foreach (var product in fifoList)
      {
         Console.WriteLine(product);
      }



      //for LIFO
      InventoryWrapper lifoList = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);
      {
         new Product(1, "TV1");
         new Product(2, "TV2");
         new Product(1, "TV3");
         new Product(1, "TV4");
         new Product(1, "TV");
      }

      Console.WriteLine("Enumerating products using a stack approach (LIFO):");
      foreach (var product in lifoList)
      {
         Console.WriteLine(product);
      }

   }
}
