using System;

namespace CSharpTutorial2
{
   class MainClass
   {
      public static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");

         BankAccount bankAccount = new BankAccount();

         Console.WriteLine("Initialization: " + bankAccount.Balance);

         bankAccount.Balance = 123.4f;
         Console.WriteLine("First Assigned Value: " + bankAccount.Balance);

         //bankAccount.Balance = -1234.5f;
         //Console.WriteLine("Second Assigned Value: " + bankAccount.Balance);

         string username;
         var credit = bankAccount.GetCredit(out username);
         Console.WriteLine(username + ", your Credit is: " + credit);
      }
   }
}
