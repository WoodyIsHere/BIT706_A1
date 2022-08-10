using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1_5033522
{
    class Account
    {
        static int nextAccountID = 1;
        protected int accountID;
        protected string typeName;
        protected decimal balance;
        protected string lastTransaction;

        public Account()
        {
            accountID = nextAccountID;
            nextAccountID++;
            balance = 0;
            lastTransaction = "No transactions.";
        }

        public virtual string Details()
        {
            return (accountID + " " + typeName + ", Balance: $" + balance);
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string GetLastTransaction()
        {
            return lastTransaction;
        }


        // adds deposit amount to balance.
        public void Deposit(decimal depositAmount)
        {
            balance = (balance + depositAmount);
            lastTransaction = (typeName + " " + accountID.ToString() + ", Deposited: $" + depositAmount + ", Balance: $" + balance);
        }

        public virtual void Withdraw(decimal withdrawAmount)
        {
            if((balance - withdrawAmount) >= 0)
            {
                balance = (balance - withdrawAmount);
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawn: $" + withdrawAmount + ", Balance: $" + balance);
            }
            else
            {
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawal failure - Not enough balance ");
            }
        }

        public virtual void Interest()
        {
            lastTransaction = (typeName + " " + accountID.ToString() + ", Account type does not provide interest.");
        }
    }
    
    // the everyday account class.

    class Everyday : Account
    {
        public Everyday()
        {
            typeName = "Everyday";
        }
    }

    // the investment account class.

    class Investment : Account
    {
        protected decimal interestRate;
        protected decimal failedTransFee;

       
        // sets the type name, interest rate and the failed transfer fee (values gotten from formHome class).
        public Investment(decimal newInterestRate, decimal newFailedTransFee)
        {
            typeName = "Investment";
            interestRate = newInterestRate;
            failedTransFee = newFailedTransFee;
        }

        public override string Details()
        {
            return (typeName + " " + accountID.ToString() + ", Balance: $" + balance + ", Interest Rate: " + interestRate + "%" + ", Failed Transaction Fee: $" + failedTransFee);
        }

        // calculate fees for failed transaction fee.
        private void Fee()
        {
            if ((balance - failedTransFee) >= 0)
            {
                balance = (balance - failedTransFee);
            }
            else
            {
                balance = 0;
            }
        }

        // method to calculate withdrawal and fees if withdraw amount is higher than balance.
        public override void Withdraw(decimal withdrawAmount)
        {
            if ((balance - withdrawAmount) >= 0)
            {
                balance = (balance - withdrawAmount);
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawn: $" + withdrawAmount + ", Balance: $" + balance);
            }
            else
            {
                Fee();
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawal failure - Not enough balance" + ", $" + failedTransFee + " fee incurred");
            }
        }

        // method to calculate interest (values set in formHome class).
        public override void Interest()
        {
            decimal interestTotal = Math.Round(((balance / 100) * interestRate), 2);
            balance += interestTotal;
            lastTransaction = (typeName + " " + accountID.ToString() + ", Interest added: $" + interestTotal + ", Balance: $" + balance);
        }
    }

    // the omni account class.
    class Omni : Account
    {
        protected decimal interestRate;
        protected decimal failedTransFee;
        protected decimal overdraftLimit;

        // sets the type name, interest rate and the failed transfer fee (values gotten from formHome class).
        public Omni(decimal newInterestRate, decimal newFailedTransFee, decimal newOverdraftLimit)
        {
            typeName = "Omni";
            interestRate = newInterestRate;
            failedTransFee = newFailedTransFee;
            overdraftLimit = newOverdraftLimit;
        }

        public override string Details()
        {
            return (typeName + " " + accountID.ToString() + ", Balance: $" + balance + ", Interest Rate: " + interestRate + "% on balances over $1000" + ", Failed Transaction Fee: $" + failedTransFee);
        }

        // calculate fees for failed transaction fee.
        private void Fee()
        {
            if((balance - failedTransFee) >= overdraftLimit)
            {
                balance = (balance - failedTransFee);
            }
            else
            {
                balance = overdraftLimit;
            }
        }

        // method to calculate withdrawal and fees if withdraw amount is higher than balance.
        public override void Withdraw(decimal withdrawAmount)
        {
            if ((balance - withdrawAmount) >= overdraftLimit)
            {
                balance = (balance - withdrawAmount);
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawn: $" + withdrawAmount + ", Balance: $" + balance);
            }
            else
            {
                Fee();
                lastTransaction = (typeName + " " + accountID.ToString() + ", Withdrawal failure - Not enough balance" + ", $" + failedTransFee + " fee incurred");
            }
        }
        // method to calculate interest (values set in formHome class).
        public override void Interest()
        {
            if (balance >= 1000)
            {
                decimal interestTotal = Math.Round(((balance / 100) * interestRate), 2);
                balance += interestTotal;
                lastTransaction = (typeName + " " + accountID.ToString() + ", Interest added: $" + interestTotal + ", Balance: $" + balance);
            }
            else
            {
                lastTransaction = (typeName + " " + accountID.ToString() + ", Balance of $1000 required for interest payment, Balance: $" + balance);
            }
        }
    }
}