using System;
using System.Collections.Generic;

namespace CSharpTutorial2
{
   class MainClass
   {
      static List<BankAccount> list;

      public static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");

         list = new List<BankAccount>();

         BankAccount bankAccount = new BankAccount("John Doe", 42.88f);

         Console.WriteLine("Initialization: " + bankAccount.Balance);

         //bankAccount.Balance = 123.4f;
         //Console.WriteLine("First Assigned Value: " + bankAccount.Balance);

         //bankAccount.Balance = -1234.5f;
         //Console.WriteLine("Second Assigned Value: " + bankAccount.Balance);

         string username;
         var credit = bankAccount.GetCredit(out username);
         Console.WriteLine(username + ", your Credit is: " + credit);

         testCollection();
      }

      static void testCollection()
      {
         BankAccount bankAccount = new BankAccount("John Doe", 42.88f);
         BankAccount bankAccount1 = new BankAccount("Jane Doe", 11.88f);
         BankAccount bankAccount2 = new BankAccount("Mad Max", 22.88f);
         BankAccount bankAccount3 = new BankAccount("John Smith", 33.88f);
         list.Add(bankAccount);
         list.Add(bankAccount1);
         list.Add(bankAccount2);
         list.Add(bankAccount3);

         foreach (var account in list)
         {
            Console.WriteLine($"{account.name}: {account.Balance}");
         }
      }
   }
}
