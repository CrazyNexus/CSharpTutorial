using System;
namespace CSharpTutorial2
{
   public class BankAccount
   {
      private string name = "Jane";
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

      public float GetCredit(out string name)
      {
         name = this.name;
         return Balance * 5.1f;
      }
   }
}
