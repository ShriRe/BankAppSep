using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    /// <summary>
    /// Create Enum for own reference type 
    /// Value type are those which store values more than one
    /// Create outside the class inside Enum
    /// </summary>
        public enum TypeOfAccount
        {
            Checking,
            Savings,
            Loan,
            Fixed,
            
        }
         /// <summary>
        /// This is Add new  bank account application 
        /// </summary>
        public class Account
        {
            private static int LastAccountNumber = 0;
        
            #region Properties
            /// <summary>
            /// This holds the New Account number
            /// </summary>
            public int AccountNumber { get; }
            /// <summary>
            /// This holds the BAnk Account holder Email address
            /// </summary>
            public string EmailAddress { get; set; }
            /// <summary>
            /// This holds the balance
            /// </summary>
            public decimal Balance { get; private set; }
            /// <summary>
            /// This holds the account type..
            /// Use Enum as a Type of Account
            /// </summary>
            public TypeOfAccount AccountType { get; set; }
            /// <summary>
            /// This holds the new account application created date
            /// </summary>
            public DateTime CreatedDate { get; set; }
            #endregion
        /// <summary>
        /// Constructor has no return type name of constructer same as class name
        /// Here Constructer is looking for the memory
        /// </summary>
            #region constructor

            public Account()
            {

             AccountNumber = ++LastAccountNumber;
            }

            #endregion

            #region Methods
        /// <summary>
        /// Methods for Deposit and Withdraw
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
            public decimal Deposit(decimal amount)
            {
                Balance += amount; //take my existing account balance and add 
                return Balance;
            }
            /// <summary>
            /// This method holds for  withdraw
            /// </summary>
            /// <param name="criteria"></param>

            public void Withdraw (decimal amount)
            {
            Balance -= amount;
                
            }

            #endregion

        }
    }

    