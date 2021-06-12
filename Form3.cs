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

namespace BookStore
{
    public partial class Form3 : Form
    {
           
        SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-225LFGP\SQLEXPRESS;Initial Catalog=MyBookstore;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter myAdapter;
        SqlDataReader myReader;
        int ISBN = 0;

        public Form3()
        {
            InitializeComponent();
            FillMyComboBox();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fill textboxes with corresponding data
            PopulateTextBoxses();
            isbnText.Enabled = true;
        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbnText_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearData()
        {   
            // Clear the textboxes

            titleText.Text = "";
            authorText.Text = "";
            isbnText.Text = "";
            priceText.Text = "";
            numLinesText.Text = "";
            ISBN = 0;
        }

        /* insertion */
        private void myInsertFunction()
        {
            cmd = new SqlCommand("insert into Table_1_Books(TiTle, Author, ISBN, Price, Lines) values(@TiTle, @Author, @ISBN, @Price, @Lines)", myConnection);
            myConnection.Open();
            cmd.Parameters.AddWithValue("@TiTle", titleText.Text);
            cmd.Parameters.AddWithValue("@Author", authorText.Text);
            cmd.Parameters.AddWithValue("@ISBN", isbnText.Text);
            cmd.Parameters.AddWithValue("@Price", priceText.Text);
            cmd.Parameters.AddWithValue("@Lines", numLinesText.Text);
            cmd.ExecuteNonQuery();
            myConnection.Close();
            ClearData();
            MessageBox.Show("Record has been inserted successfully!");

            /* refresh the data of combobox */
            BookComboBox.Items.Clear();
            FillMyComboBox();
        }

        /* update */
        private void myUpdateFunction()
        {
            
            cmd = new SqlCommand("update Table_1_Books set Title = @TiTle, Author = @Author, ISBN = @ISBN, Price = @Price where ISBN = @ISBN", myConnection);
            myConnection.Open();
            cmd.Parameters.AddWithValue("@TiTle", titleText.Text);
            cmd.Parameters.AddWithValue("@Author", authorText.Text);
            cmd.Parameters.AddWithValue("@ISBN", isbnText.Text);
            cmd.Parameters.AddWithValue("@Price", priceText.Text);
            cmd.Parameters.AddWithValue("@Lines", numLinesText.Text);
            cmd.ExecuteNonQuery();
            myConnection.Close();
            ClearData();
            MessageBox.Show("Record has been updated successfully!");

            /* refresh the data of combobox */
            BookComboBox.Items.Clear();
            FillMyComboBox();
        }

        /* Transfers data from Table_1_Books -> DataTable */ 
        private  DataTable TransferFunction() 
        {
            SqlCommand myCommand = new SqlCommand("select * from Table_1_Books", myConnection);
            DataTable dataTable = new DataTable();
            myConnection.Open();
            SqlDataAdapter theAdapter = new SqlDataAdapter(myCommand);
            theAdapter.Fill(dataTable);
            myConnection.Close();
            theAdapter.Dispose();

            /* reusing the code for FillMyComboBox and PopulateTextBoxes*/
            return dataTable;
        }
        private void FillMyComboBox()
        {   
            // Call transfer function
            DataTable dataTable = new DataTable();
            dataTable = TransferFunction();

            // Fill each row with the data of each row
            foreach (DataRow myRow in dataTable.Rows)
            {
                BookComboBox.Items.Add(myRow["TiTle"].ToString());
            }

        }

        private void PopulateTextBoxses()
        {
            BookComboBox.Enabled = true;

            DataTable dataTable = new DataTable();
            dataTable = TransferFunction();

            // Populate the textboxes with the corresponding data
            titleText.Text = dataTable.Rows[BookComboBox.SelectedIndex]["TiTle"].ToString();
            authorText.Text = dataTable.Rows[BookComboBox.SelectedIndex]["Author"].ToString();
            isbnText.Text = dataTable.Rows[BookComboBox.SelectedIndex]["ISBN"].ToString();
            priceText.Text = dataTable.Rows[BookComboBox.SelectedIndex]["Price"].ToString();
            numLinesText.Text = dataTable.Rows[BookComboBox.SelectedIndex]["Lines"].ToString();

        }

        /* Back Button */
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 mainMenu = new Form4();
            this.Hide();

            // Go to main menu
            mainMenu.ShowDialog();
          
        }

        /* New Book Button*/
        private void newBook_Click(object sender, EventArgs e)
        {
            /* Clearing textboxes */
            isbnText.Enabled = true;
            titleText.Text = String.Empty;
            authorText.Text = String.Empty;
            isbnText.Text = String.Empty;
            priceText.Text = String.Empty;
            numLinesText.Text = String.Empty;

            /* Set Combobox Enable to False */

            BookComboBox.Enabled = false;
        }

        /* Save Button */
        private void saveButton_Click(object sender, EventArgs e)
        {
            /* 
             * If all of the textboxes are empty
             * then insert a book
             */

            if (BookComboBox.Enabled == false) 
            {
                try
                {
                    // If all of the textboxes are filled out 
                    if (!(String.IsNullOrEmpty(titleText.Text)))
                    {
                        if (!(String.IsNullOrEmpty(authorText.Text)))
                        {
                            if ((!(String.IsNullOrEmpty(isbnText.Text))) && (isbnText.Text.Length == 13))
                            {
                                if (!(String.IsNullOrEmpty(priceText.Text)))
                                {
                                    // Ensure that the user wants to save the record
                                    if (MessageBox.Show("Do you want to save the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        myInsertFunction();
                                        MessageBox.Show("Your data has been saved");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Press save if you want to save this user");
                                    }

                                    BookComboBox.Enabled = true;
                                }
                            }
                            else 
                            {
                                MessageBox.Show("ISBN is 13 digits");
                            }
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Please Fill all of the textboxes");
                    }
                }
                catch 
                {
                    MessageBox.Show("Unable to insert the record");
                }
            }

            /* edit an existing book => update */
            else 
            {
                if (MessageBox.Show("Is this a new book?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BookComboBox.Enabled = false;
                    try
                    {
                        // If all of the textboxes are filled out 
                        if (!(String.IsNullOrEmpty(titleText.Text)))
                        {
                            if (!(String.IsNullOrEmpty(authorText.Text)))
                            {
                                if ((!(String.IsNullOrEmpty(isbnText.Text))) && (isbnText.Text.Length == 13))
                                {
                                    if (!(String.IsNullOrEmpty(priceText.Text)))
                                    {
                                        // Ensure that the user wants to save the record
                                        if (MessageBox.Show("Do you want to save the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            myInsertFunction();
                                            MessageBox.Show("Your data has been saved");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Press save if you want to save this user");
                                        }

                                        BookComboBox.Enabled = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ISBN is 13 digits");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Fill all of the textboxes");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to insert the record");
                    }
                }
                else
                {
                   
                    // user can not change ISBN since it serves as an ID (unique identifier)
                    isbnText.Enabled = false;
                    /* If there is a book selected from combobox */
                    try
                    {
                        // If all of the textboxes are filled out 
                        if (!(String.IsNullOrEmpty(titleText.Text)))
                        {
                            if (!(String.IsNullOrEmpty(authorText.Text)))
                            {
                                if ((!(String.IsNullOrEmpty(isbnText.Text))) && (isbnText.Text.Length == 13))
                                {
                                    if (!(String.IsNullOrEmpty(priceText.Text)))
                                    {
                                        // Ensure that the user wants to save the record
                                        if (MessageBox.Show("Do you want to update the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {

                                            myUpdateFunction();
                                            MessageBox.Show("Updated successfully");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Press save if you want to update this record");
                                        }

                                        BookComboBox.Enabled = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Fill all of the textboxes");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to update the record");
                    }
                }
            }
        }

        /* Cancel Button */
            private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    FillMyComboBox();
                    PopulateTextBoxses();
                    MessageBox.Show("Canceled successfully");
                }
                catch
                {
                    MessageBox.Show("No book was chosen");
                }
            }
            else
            {
                MessageBox.Show("Cancel denied");
            }
        }

    } 

    
}
