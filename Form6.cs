using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;

namespace BookStore
{
    public partial class Form6 : Form
    {
        SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-225LFGP\SQLEXPRESS;Initial Catalog=MyBookstore;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter myAdapter;
        SqlDataReader myReader;
        
        public Form6()
        {
            InitializeComponent();
            FillMyComboBox("Table_1_Books");
            FillMyComboBox("Table_1_Customers");
            //MessageBox.Show("Please fill the quantity field first!");
            //DisplayPricing();
            
            
        }

        private void DisplayFunction() 
        {
            myConnection.Open();
            SqlCommand myCommandVol2 = new SqlCommand("select * from Table_1_Books", myConnection);
            DataTable dataTableVol2 = new DataTable();
            SqlDataAdapter theAdapterVol2 = new SqlDataAdapter(myCommandVol2);
            theAdapterVol2.Fill(dataTableVol2);
            theAdapterVol2.Dispose();

            string myISBN = dataTableVol2.Rows[bookCombo.SelectedIndex]["ISBN"].ToString();

            
            DataTable dataTable = new DataTable();
            
            myAdapter = new SqlDataAdapter("select * from Table_1_Books where ISBN='" + myISBN + "' ", myConnection);
            
            myAdapter.Fill(dataTable);

           
            myDataGridView.DataSource = dataTable;
            myConnection.Close();

            if (!(quantityText.Text == String.Empty)) 
            {
                subTotal.Text = CalculateSubTotal().ToString();
                myTax.Text = CalculateTax().ToString();
                totalAmount.Text = CalculateTotal().ToString();
            }
        }

        /*
         * universal transferfunction 
         * parameter - table name 
         */

        private DataTable TransferFunction(string myTable)
        {
 
                string partialCommand = "select * from ";
                DataTable dataTable = new DataTable();
                string fullCommand = String.Concat(partialCommand, myTable);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(fullCommand, myConnection);
                SqlDataAdapter theAdapter = new SqlDataAdapter(myCommand);
                theAdapter.Fill(dataTable);
                myConnection.Close();
                theAdapter.Dispose();
            if (myConnection.State == ConnectionState.Open) 
            {
                myConnection.Close();
            }
                return dataTable;


            /* reusing the code for FillMyComboBox and PopulateTextBoxes*/
        }

        /*
         * universal fill combobox function
         * parameter - table name 
         */
        private void FillMyComboBox(string myTable)
        {
            DataTable dataTable = new DataTable();
            dataTable = TransferFunction(myTable);
            myConnection.Close();
            if (myTable == "Table_1_Books")
            {
                foreach (DataRow myRow in dataTable.Rows)
                {
                    bookCombo.Items.Add(myRow["TiTle"].ToString());
                }
            }

            if (myTable == "Table_1_Customers")
            if (myTable == "Table_1_Customers")
                {
                foreach (DataRow myRow in dataTable.Rows)
                {
                    // Concat first and last name 
                    string tempVar = String.Concat(myRow["firstName"].ToString(), " ", myRow["lastName"].ToString());
                    customerCombo.Items.Add(tempVar.ToString());
                }
            }
        }

        // Populate textboxes - relating books
        private void PopulateTextBoxses()
        {
            bookCombo.Enabled = true;

            DataTable dataTable = new DataTable();
            dataTable = TransferFunction("Table_1_Books");
            myConnection.Close();

            //titleText.Text = dataTable.Rows[BookComboBox.SelectedIndex]["TiTle"].ToString();
            authorText.Text = dataTable.Rows[bookCombo.SelectedIndex]["Author"].ToString();
            isbnText.Text = dataTable.Rows[bookCombo.SelectedIndex]["ISBN"].ToString();
            priceText.Text = dataTable.Rows[bookCombo.SelectedIndex]["Price"].ToString();

        }

        private double CalculateSubTotal() 
        {
            if (!(quantityText.Text == ""))
            {
                // Get quantity of books
                int quantity = Convert.ToInt32(quantityText.Text.ToString());

                // get price of the book
                double price = Convert.ToDouble(myDataGridView.Rows[0].Cells[3].Value);

                // get subtotal
                double mySum = quantity * price;

                return mySum;
            }
            else 
            {
                return 0;
            }
        }

        private double CalculateTax() 
        {
            double myTaxx = (double)CalculateSubTotal() / (double)10;
            return myTaxx;
        }

        private double CalculateTotal() 
        {
            double myTotal = CalculateSubTotal() + CalculateTax();
            return myTotal;
        }

        private void DisplayPricing() 
        {
            //  Display the values into the corresponding textboxes
            subTotal.Text = CalculateSubTotal().ToString() + " $";
            myTax.Text = CalculateTax().ToString() + " $";
            totalAmount.Text = CalculateTotal().ToString() + " $";
        }


        private void bookCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTextBoxses();
            DisplayPricing(); 
            DisplayFunction();
            
        }

        private void customerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 mainMenu = new Form4();
            mainMenu.ShowDialog();
        }

        private void addTitleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 addTitle = new Form3();
            addTitle.ShowDialog();
        }

        private void authorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    FillMyComboBox("Table_1_Books");
                    FillMyComboBox("Table_1_Customers");
                    PopulateTextBoxses();
                    MessageBox.Show("Canceled successfully");
                }
                catch 
                {
                    MessageBox.Show("Unable to cancel");
                }
            }
            else
            {
                MessageBox.Show("Cancel denied");
            }
        }

        private void myInsertFunction()
        {
            // orderId identity

            SqlCommand myCommand = new SqlCommand("select * from Table_1_Customers", myConnection);
            DataTable dataTable = new DataTable();
            myConnection.Open();
            SqlDataAdapter theAdapter = new SqlDataAdapter(myCommand);
            theAdapter.Fill(dataTable);
            theAdapter.Dispose();
            try
            {
                string a = dataTable.Rows[customerCombo.SelectedIndex]["id"].ToString();
                cmd = new SqlCommand("insert into Table_1_Orders(customerId, subTotal, myTax, totalAmount, orderDate) values(@customerId, @subTotal, @myTax, @totalAmount, @orderDate)", myConnection);

                SqlCommand myCommandVol2 = new SqlCommand("select * from Table_1_Books", myConnection);
                DataTable dataTableVol2 = new DataTable();
                SqlDataAdapter theAdapterVol2 = new SqlDataAdapter(myCommandVol2);
                theAdapterVol2.Fill(dataTableVol2);
                theAdapterVol2.Dispose();

                string myISBN = dataTableVol2.Rows[bookCombo.SelectedIndex]["ISBN"].ToString();
                int bookQuantity = Convert.ToInt32(quantityText.Text);
                int getLines = Convert.ToInt32(dataTableVol2.Rows[bookCombo.SelectedIndex]["Lines"].ToString());
                int theLinesTotal = bookQuantity * getLines;

                string customerId = a;
                string mySubTotal = CalculateSubTotal().ToString();
                string myTaxAmount = CalculateTax().ToString();
                string myTotal = CalculateTotal().ToString();

                cmd.Parameters.AddWithValue("@customerId ", customerId);
                cmd.Parameters.AddWithValue("@subTotal", mySubTotal);
                cmd.Parameters.AddWithValue("@myTax", myTaxAmount);
                cmd.Parameters.AddWithValue("@totalAmount", myTotal);
                cmd.Parameters.AddWithValue("@orderDate", DateTime.UtcNow.Date.ToString());

                cmd.ExecuteNonQuery();

                SqlCommand cmdVol2 = new SqlCommand("insert into Table_1_OrderDetails(bookId, bookQuantity, totalLines) values(@bookId, @bookQuantity, @totalLines)", myConnection);

                string bookID = myISBN;
                cmdVol2.Parameters.AddWithValue("@bookId", bookID);
                cmdVol2.Parameters.AddWithValue("@bookQuantity", Convert.ToInt32(quantityText.Text.ToString()));
                cmdVol2.Parameters.AddWithValue("@totalLines", theLinesTotal.ToString());
                cmdVol2.ExecuteNonQuery();
                myConnection.Close();

                MessageBox.Show("Record has been inserted successfully!");
            }
            catch 
            {
                MessageBox.Show("Please choose a customer");
            }
            

        }
         
        private string GetMyCustomerID() 
        {
            SqlCommand myCommand = new SqlCommand("select * from Table_1_Customers", myConnection);
            DataTable dataTable = new DataTable();
            myConnection.Open();
            SqlDataAdapter theAdapter = new SqlDataAdapter(myCommand);
            theAdapter.Fill(dataTable);
            myConnection.Close();
            theAdapter.Dispose();

            string a = dataTable.Rows[customerCombo.SelectedIndex]["id"].ToString();

            return a;
        }

        private string GetmyISBN()
        {
            SqlCommand myCommand = new SqlCommand("select * from Table_1_Books", myConnection);
            DataTable dataTable = new DataTable();
            myConnection.Open();
            SqlDataAdapter theAdapter = new SqlDataAdapter(myCommand);
            theAdapter.Fill(dataTable);
            myConnection.Close();
            theAdapter.Dispose();

            string myISBN = dataTable.Rows[bookCombo.SelectedIndex]["ISBN"].ToString();

            return myISBN;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm the order?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                myInsertFunction();

            }
            else
            {
                MessageBox.Show("Press the button again in order to confirm order");
            }
        }

        private void ExtraCredit_Click(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand("select * from Table_1_Customers", myConnection);
            DataTable dataTable = new DataTable();
            myConnection.Open();
            SqlDataAdapter theAdapter = new SqlDataAdapter(myCommand);
            theAdapter.Fill(dataTable);
            theAdapter.Dispose();

            // Get customerId of the selected customer       
            string a = dataTable.Rows[customerCombo.SelectedIndex]["id"].ToString();

            //  Join the two tables 
            SqlCommand mySqlCommand = new SqlCommand("select Table_1_Orders.*, Table_1_Customers.* from Table_1_Customers inner join Table_1_Orders on Table_1_Customers.id = Table_1_Orders.customerId where Table_1_Customers.id = @id", myConnection);
            mySqlCommand.Parameters.AddWithValue("@id", a);
            mySqlCommand.ExecuteNonQuery();

            DataTable gridViewTable = new DataTable();
            SqlDataAdapter theGridAdapter = new SqlDataAdapter(mySqlCommand);
            theGridAdapter.Fill(gridViewTable);


            // Display the results in datagridview
            myDataGridView.DataSource = gridViewTable;
            myConnection.Close();

        }
    }
 }

