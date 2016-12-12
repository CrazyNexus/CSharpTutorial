using System;
namespace CSharpTutorial2
{
   public class BankAccount
   {
      public string name = "Jane";
      private float balance;

      public float Balance
      {
         get { return balance; }
         set
         {
            if (value >= 0)
            {
               balance = value;
            }
            else
            {
               balance = 0;
            }

         }
      }

      public BankAccount()
      {
         Balance = 22.2f;
      }

      public BankAccount(string name, float balance)
      {
         Balance = balance;
         this.name = name;
      }

      // this method returns two values
      // 1) a float value 
      // 2) the name of the bank user as OUT parameter of the prameters
      public float GetCredit(out string name)
      {
         name = this.name;
         return Balance * 5.1f;
      }
   }
}
