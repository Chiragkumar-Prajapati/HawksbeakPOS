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
    public partial class MainForm : Form
    {
        const int MIN_LENGTH = 6; //min length a UPC can be is 6
        const int MAX_LENGTH = 10; //max length a UPC code entered can be

        //bool exit = false;

        public MainForm()
        {
            InitializeComponent();
            UpdateDateTime(); //function call to update date and time displayed on form

            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.InventoryConnectionString;

                objConnect.connection_string = conString;

                objConnect.Sql = Properties.Settings.Default.SQL;

                ds = objConnect.GetConnection;

                MaxRows = ds.Tables[0].Rows.Count;

                NavigateRecords();
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        public void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];

            UPC_Label.Text = dRow.ItemArray.GetValue(0).ToString();
            lblProductDesc.Text = dRow.ItemArray.GetValue(1).ToString();
            lblQuantity.Text = dRow.ItemArray.GetValue(2).ToString();
            lblPPU.Text = dRow.ItemArray.GetValue(3).ToString();
        }

        public DatabaseConnection objConnect;
        string conString;

        public DataSet ds;
        DataRow dRow;

        public int MaxRows;
        public int inc = 0;

        private void Key_Pressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && UPC_Label.Text.Length == MIN_LENGTH || UPC_Label.Text.Length == MAX_LENGTH)
            {
                ItemNotFoundForm itemNotFoundForm = new ItemNotFoundForm();

                if (itemNotFoundForm.ShowDialog() == DialogResult.OK)
                {
                    NewItemForm newItemForm = new NewItemForm(this, UPC_Label.Text);
                    newItemForm.Show();
                }

                UPC_Label.ResetText();
            }
            else if (e.KeyChar == (char)08){ //check if key is a backspace key
                if (UPC_Label.Text.Length > 1)
                    UPC_Label.Text = UPC_Label.Text.Substring(0, UPC_Label.Text.Length - 1);
                else
                    UPC_Label.Text = "";
            }
            else if (Char.IsDigit(e.KeyChar) && UPC_Label.Text.Length < MAX_LENGTH)
                UPC_Label.Text += e.KeyChar;
        }

        private void UpdateDateTime() {
            DateTime localDate = DateTime.Now; //holds the current date/time

            //while (!exit) {

                //constantly update date/time
                Date_Label.Text = localDate.ToString("d");
                Time_Label.Text = localDate.ToString("t");

                //constantly scan bar codes
            //}
        }
    }
}