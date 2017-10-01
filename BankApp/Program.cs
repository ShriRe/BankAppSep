using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program

    {
        static void Main(string[] args)
    {
         {
            #region Main Methods
            
            {
             //Instantiate an object use Var 
             var account = new Account();
           //account.AccountNumber = 1234;
             account.EmailAddress = "shreerekha@northwestu.edu";
             account.AccountType = TypeOfAccount.Savings;
             // Account method
             var newBalance = account.Deposit(100);
             
             //Inline FOrmatting 

             Console.WriteLine($"AN : {account.AccountNumber}) ,EA: {account.EmailAddress} , BL : {account.Balance} ,AT :{account.AccountType} ");

            var account2 = new Account();

            Console.WriteLine($"AN : {account2.AccountNumber}) ,EA: {account.EmailAddress} , BL : {account2.Balance} ,AT :{account2.AccountType} ");
                #endregion
            }
        }
    }
       
        }
    }

