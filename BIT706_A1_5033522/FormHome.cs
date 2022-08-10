using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A1_5033522
{
    public partial class FormHome : Form
    {
        private List<Account> myAccounts = new List<Account>();

        public FormHome()
        {
            InitializeComponent();
            CreateAccounts();
            DisplayAccounts();
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }

        // set the values for the accounts 
        private void CreateAccounts()
        {
            myAccounts.Add(new Everyday());
            myAccounts.Add(new Investment(5, 2)); //(interest rate, failed transaction fee).
            myAccounts.Add(new Omni(5, 2, -500)); //(interest rate, failed transaction fee, overdraft limit).
            myAccounts[0].Balance = 100;  // balance value for everyday account.
            myAccounts[1].Balance = 500;  //balance value for investment account.
            myAccounts[2].Balance = 1200; //balance value for omni account.
        }

        private void DisplayAccounts()
        {
            listBoxAccounts.Items.Clear();

            foreach (Account acc in myAccounts)
            {
                listBoxAccounts.Items.Add(acc); //.NameAndBalance()
            }
            listBoxAccounts.SelectedIndex = 0;
        }

        // shows the last transaction in the listbox.
        private void ButtonLastTrans_Click(object sender, EventArgs e)
        {
            Account account = (Account)listBoxAccounts.SelectedItem;
            textBoxTransHistory.Text = account.GetLastTransaction();
        }

        // gets value from up down selector and adds to balance on selected account.
        private void ButtonDeposit_Click(object sender, EventArgs e)
        {
            Account account = (Account)listBoxAccounts.SelectedItem;
            account.Deposit(upDown.Value);
            textBoxTransHistory.Text = account.GetLastTransaction();
            upDown.Value = 0;
        }

        // gets value for un down selector and removes from balance on selected account.
        private void ButtonWithdraw_Click(object sender, EventArgs e)
        {
            Account account = (Account)listBoxAccounts.SelectedItem;
            account.Withdraw(upDown.Value);
            textBoxTransHistory.Text = account.GetLastTransaction();
            upDown.Value = 0;
        }

        //  shows the selected account details in a message box.
        private void ButtonAccountInfo_Click(object sender, EventArgs e)
        {
            Account account = (Account)listBoxAccounts.SelectedItem;
            MessageBox.Show(account.Details(), "Account info");
        }

        // adds interest amount to selected account balance.
        private void ButtonInterest_Click(object sender, EventArgs e)
        {
            Account account = (Account)listBoxAccounts.SelectedItem;
            account.Interest();
            textBoxTransHistory.Text = account.GetLastTransaction();
        }

        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void upDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}