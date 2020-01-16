using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HawksbeakPOS
{
    public partial class NewItemForm : Form
    {
        const int MAX_LENGTH = 10; //max length a UPC code entered can be
        const int MAX_DESCR = 50;  //max char length for product description
        const int MAX_QUANTITY = 3; //3 chars, max quantity is less than 1000
        const int MAX_PRICE = 3; //3 chars, max price is less than 1000
        int periodLocation = -1; //location of period in price, if existent

        bool period = false; //price should and can have at most one period in value
        /*
        int MaxRows;
        int inc = 0;

        DatabaseConnection objConnect;

        DataSet ds;
        */
        MainForm mainForm;

        public NewItemForm(MainForm mainForm, String UPC)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            NewUPC_TextBox.Text = UPC;
        }

        private void NewItemForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if (NewUPC_TextBox.Focused && NewUPC_TextBox.Text.Length < MAX_LENGTH)
                    NewUPC_TextBox.Text += e.KeyChar;
                else if (NewProdDescr_TextBox.Focused && NewProdDescr_TextBox.Text.Length < MAX_LENGTH)
                    NewProdDescr_TextBox.Text += e.KeyChar;
                else if (NewItemPrice_TextBox.Focused && NewItemPrice_TextBox.Text.Length < MAX_LENGTH)
                    NewItemPrice_TextBox.Text += e.KeyChar;
                else if (NewItemQuantity_TextBox.Focused && NewItemQuantity_TextBox.Text.Length < MAX_LENGTH)
                    NewItemQuantity_TextBox.Text += e.KeyChar;
            }
        }

        private void NewUPC_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && NewUPC_TextBox.Text.Length < MAX_LENGTH)
                NewUPC_TextBox.Text += e.KeyChar;
            else if (e.KeyChar == (char)08)
            { //check if key is a backspace key
                if (NewUPC_TextBox.Text.Length > 1)
                    NewUPC_TextBox.Text = NewUPC_TextBox.Text.Substring(0, NewUPC_TextBox.Text.Length - 1);
                else
                    NewUPC_TextBox.Text = "";
            }
        }

        private void NewProdDescr_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' && NewProdDescr_TextBox.Text.Length < MAX_DESCR)
                NewProdDescr_TextBox.Text += e.KeyChar;
            else if (e.KeyChar == (char)08)
            { //check if key is a backspace key
                if (NewProdDescr_TextBox.Text.Length > 1)
                    NewProdDescr_TextBox.Text = NewProdDescr_TextBox.Text.Substring(0, NewProdDescr_TextBox.Text.Length - 1);
                else
                    NewProdDescr_TextBox.Text = "";
            }
        }

        private void NewItemPrice_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && !period && NewItemPrice_TextBox.Text.Length > 0)
            {
                periodLocation = NewItemPrice_TextBox.Text.Length;
                NewItemPrice_TextBox.Text += e.KeyChar;
                period = true;
            }
            else if (!period && Char.IsDigit(e.KeyChar) && NewItemPrice_TextBox.Text.Length < MAX_PRICE)
                NewItemPrice_TextBox.Text += e.KeyChar;
            else if (period && Char.IsDigit(e.KeyChar) && NewItemPrice_TextBox.Text.Length <= periodLocation+2)
                NewItemPrice_TextBox.Text += e.KeyChar;
            else if (e.KeyChar == (char)08)
            { //check if key is a backspace key
                if (NewItemPrice_TextBox.Text.Length > 1 && !period)
                    NewItemPrice_TextBox.Text = NewItemPrice_TextBox.Text.Substring(0, NewItemPrice_TextBox.Text.Length - 1);
                else
                {
                    NewItemPrice_TextBox.Text = "";
                    period = !period;
                }
            }
        }

        private void NewItemQuantity_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && NewItemQuantity_TextBox.Text.Length < MAX_QUANTITY)
                NewItemQuantity_TextBox.Text += e.KeyChar;
            else if (e.KeyChar == (char)08)
            { //check if key is a backspace key
                if (NewItemQuantity_TextBox.Text.Length > 1)
                    NewItemQuantity_TextBox.Text = NewItemQuantity_TextBox.Text.Substring(0, NewItemQuantity_TextBox.Text.Length - 1);
                else
                    NewItemQuantity_TextBox.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = mainForm.ds.Tables[0].NewRow();
            row[0] = NewUPC_TextBox.Text;
            row[1] = NewProdDescr_TextBox.Text;
            row[2] = NewItemQuantity_TextBox.Text;
            row[3] = NewItemPrice_TextBox.Text;

            mainForm.ds.Tables[0].Rows.Add(row);

            try
            {

                mainForm.objConnect.UpdateDatabase(mainForm.ds);
                mainForm.MaxRows = mainForm.MaxRows + 1;
                mainForm.inc = mainForm.MaxRows - 1;

                NewUPC_TextBox.Clear();
                NewProdDescr_TextBox.Clear();
                NewItemQuantity_TextBox.Clear();
                NewItemPrice_TextBox.Clear();

                mainForm.NavigateRecords();

                MessageBox.Show("Database updated");

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }
    }
}
