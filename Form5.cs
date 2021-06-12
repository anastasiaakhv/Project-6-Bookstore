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



namespace BookStore
{
    public partial class myCustomerForm : Form
    {
        SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-225LFGP\SQLEXPRESS;Initial Catalog=MyBookstore;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter myAdapter;
        SqlDataReader myReader;
        int ID = 1;
        public myCustomerForm()
        {
            InitializeComponent();
            FillMyComboBox();
            idText.Enabled = false;
        }
        private void ClearData()
        {
            // Clear all of the textboxes

            firstNameText.Text = "";
            lastNameText.Text = "";
            addressText.Text = "";
            stateText.Text = "";
            cityText.Text = "";
            zipText.Text = "";
            phoneText.Text = "";
            emailText.Text = "";
            idText.Text = "";
        }

        private DataTable TransferFunction()
        {
            // Select data from Table_1_Customers and add it to dataTable 

            SqlCommand myCommand = new SqlCommand("select * from Table_1_Customers", myConnection);
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
            DataTable dataTable = new DataTable();
            dataTable = TransferFunction();

            // Add data into combobox from each row of the table 
            foreach (DataRow myRow in dataTable.Rows)
            {
                string tempVar = String.Concat(myRow["firstName"].ToString(), " ", myRow["lastName"].ToString());
                CustomerComboBox.Items.Add(tempVar.ToString()); 
            }

        }

        private void PopulateTextBoxses()
        {
            CustomerComboBox.Enabled = true;

            DataTable dataTable = new DataTable();
            dataTable = TransferFunction();

            // populate textboxes based on the table data

            firstNameText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["firstName"].ToString();
            lastNameText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["lastName"].ToString();
            cityText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["city"].ToString();
            stateText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["states"].ToString();
            zipText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["zip"].ToString();
            phoneText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["homePhone"].ToString();
            addressText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["address"].ToString();
            emailText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["email"].ToString();
            idText.Text = dataTable.Rows[CustomerComboBox.SelectedIndex]["id"].ToString();

            myConnection.Close();
        }

        // Function performing insertion
        private void myInsertFunction()
        {
            // SQL INSERT 

            cmd = new SqlCommand("insert into Table_1_Customers(firstName, lastName, city, states, zip, homePhone, address, email) values(@firstName, @lastName, @city, @states, @zip, @homePhone, @address, @email)", myConnection);
            myConnection.Open();
            cmd.Parameters.AddWithValue("@firstName", firstNameText.Text);
            cmd.Parameters.AddWithValue("@lastName", lastNameText.Text);
            cmd.Parameters.AddWithValue("@email", emailText.Text); ;
            cmd.Parameters.AddWithValue("@city", cityText.Text);
            cmd.Parameters.AddWithValue("@states", stateText.Text);
            cmd.Parameters.AddWithValue("@zip", zipText.Text);
            cmd.Parameters.AddWithValue("@homePhone", phoneText.Text);
            cmd.Parameters.AddWithValue("@address", addressText.Text);
            // id marked as identity in SSMS
            //cmd.Parameters.AddWithValue("@id", idText.Text);
            cmd.ExecuteNonQuery();
            myConnection.Close();
            ClearData();
            MessageBox.Show("Record has been inserted successfully!");

            /* refresh the data of combobox */
            CustomerComboBox.Items.Clear();
            FillMyComboBox();
        }

        // function for update - uses the same logic as the insert function but with UPDATE command
        private void myUpdateFunction()
        {
            // SQL UPDATE 
            TransferFunction();
            cmd = new SqlCommand("update Table_1_Customers set firstName = @firstName, lastName = @lastName, city = @city, states = @states, zip = @zip, homePhone = @homePhone, address = @address, email = @email where id = @id", myConnection);
            myConnection.Open();
           
            cmd.Parameters.AddWithValue("@firstName", firstNameText.Text);
            cmd.Parameters.AddWithValue("@lastName", lastNameText.Text);
            cmd.Parameters.AddWithValue("@email", emailText.Text);
            cmd.Parameters.AddWithValue("@city", cityText.Text);
            cmd.Parameters.AddWithValue("@states", stateText.Text);
            cmd.Parameters.AddWithValue("@zip", zipText.Text);
            cmd.Parameters.AddWithValue("@homePhone", phoneText.Text);
            cmd.Parameters.AddWithValue("@address", addressText.Text);
            cmd.Parameters.AddWithValue("@id", idText.Text);

            cmd.ExecuteNonQuery();
            myConnection.Close();
            ClearData();
            CustomerComboBox.Items.Clear();
            FillMyComboBox(); 
            int a = Convert.ToInt32(CustomerComboBox.SelectedItem);
            //MessageBox.Show(a.ToString()) ;
            /* refresh the data of combobox */
            CustomerComboBox.Items.Clear();
            FillMyComboBox();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        /* Back Button */
        private void backButtonCustomer_Click(object sender, EventArgs e)
        {
            Form4 mainMenu = new Form4();
            this.Hide();
            /* Show main menu */
            mainMenu.ShowDialog();
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            idText.Enabled = false;

            /* Clearing textboxes */
            firstNameText.Text = String.Empty;
            lastNameText.Text = String.Empty;
            cityText.Text = String.Empty;
            stateText.Text = String.Empty;
            zipText.Text = String.Empty;
            phoneText.Text = String.Empty;
            addressText.Text = String.Empty;
            emailText.Text = String.Empty;

            /* Set Combobox Enable to False */

            CustomerComboBox.Enabled = false;
        }

        private void mySaveBtnCustomer_Click(object sender, EventArgs e)
        {

            if (CustomerComboBox.Enabled == false)
            {
                try
                {
                    /*
                     * Preconditions
                     * all of the fields are filled out
                     * correct format is used
                     */

                    if (!(String.IsNullOrEmpty(firstNameText.Text)))
                    {
                        if ((!(String.IsNullOrEmpty(lastNameText.Text))) && (!(String.IsNullOrEmpty(emailText.Text))))
                        {
                            if ((!(String.IsNullOrEmpty(cityText.Text))) && (!(String.IsNullOrEmpty(stateText.Text))))
                            {
                                if ((!(String.IsNullOrEmpty(phoneText.Text))) && (!(String.IsNullOrEmpty(addressText.Text))))
                                {

                                    //Checking first- and lastname format
                                    if (((Regex.Match(firstNameText.Text, "^[A-Z][a-zA-Z]*$").Success)) && (Regex.Match(lastNameText.Text, "^[A-Z][a-zA-Z]*$").Success))
                                    {

                                        // Checking city and state format
                                        if ((Regex.Match(cityText.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success) && (Regex.Match(stateText.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success))
                                        {
                                            // Checking zipcode
                                            if ((Regex.Match(zipText.Text, @"^\d{5}$").Success))
                                            {
                                                if ((phoneText.Text.Length == 9))
                                                {
                                                    if ((Regex.Match(emailText.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success))
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
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter a valid email address");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid phone number\nIt has to be 9 digit number");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a valid zipcode\nIt has to be five digit number");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a valid city or state");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid name\nThe name must begin with a capital letter");
                                    }

                                    CustomerComboBox.Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill out all of the fields / Use the correct format");
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to insert the record");
                }
            }
            // 2nd part

            /* edit an existing book => update */
            else
            {
                if (MessageBox.Show("Is this a new customer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CustomerComboBox.Enabled = false;
                    try
                    {
                        /*
                         * Preconditions
                         * all of the fields are filled out
                         * correct format is used
                         */

                        if (!(String.IsNullOrEmpty(firstNameText.Text)))
                        {
                            if ((!(String.IsNullOrEmpty(lastNameText.Text))) && (!(String.IsNullOrEmpty(emailText.Text))))
                            {
                                if ((!(String.IsNullOrEmpty(cityText.Text))) && (!(String.IsNullOrEmpty(stateText.Text))))
                                {
                                    if ((!(String.IsNullOrEmpty(phoneText.Text))) && (!(String.IsNullOrEmpty(addressText.Text))))
                                    {

                                        //Checking first- and lastname format
                                        if (((Regex.Match(firstNameText.Text, "^[A-Z][a-zA-Z]*$").Success)) && (Regex.Match(lastNameText.Text, "^[A-Z][a-zA-Z]*$").Success))
                                        {

                                            // Checking city and state format
                                            if ((Regex.Match(cityText.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success) && (Regex.Match(stateText.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success))
                                            {
                                                // Checking zipcode
                                                if ((Regex.Match(zipText.Text, @"^\d{5}$").Success))
                                                {
                                                    if ((phoneText.Text.Length == 9))
                                                    {
                                                        if ((Regex.Match(emailText.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success))
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
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter a valid email address");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter a valid phone number\nIt has to be 9 digit number");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid zipcode\nIt has to be five digit number");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a valid city or state");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a valid name\nThe name must begin with a capital letter");
                                        }

                                        CustomerComboBox.Enabled = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fill out all of the fields / Use the correct format");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to insert the record");
                    }
                }
                else
                {
                    


                    try
                    {
                        /*
                         * Preconditions
                         * all of the fields are filled out
                         * correct format is used
                         */

                        if (!(String.IsNullOrEmpty(firstNameText.Text)))
                        {
                            if ((!(String.IsNullOrEmpty(lastNameText.Text))) && (!(String.IsNullOrEmpty(emailText.Text))))
                            {
                                if ((!(String.IsNullOrEmpty(cityText.Text))) && (!(String.IsNullOrEmpty(stateText.Text))))
                                {
                                    if ((!(String.IsNullOrEmpty(phoneText.Text))) && (!(String.IsNullOrEmpty(addressText.Text))))
                                    {

                                        //Checking first- and lastname format
                                        if (((Regex.Match(firstNameText.Text, "^[A-Z][a-zA-Z]*$").Success)) && (Regex.Match(lastNameText.Text, "^[A-Z][a-zA-Z]*$").Success))
                                        {

                                            // Checking city and state format
                                            if ((Regex.Match(cityText.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success) && (Regex.Match(stateText.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success))
                                            {
                                                // Checking zipcode
                                                if ((Regex.Match(zipText.Text, @"^\d{5}$").Success))
                                                {
                                                    if ((phoneText.Text.Length == 9))
                                                    {
                                                        if ((Regex.Match(emailText.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success))
                                                        {
                                                            // Ensure that the user wants to save the record
                                                            if (MessageBox.Show("Do you want to update the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                            {
                                                                myUpdateFunction();
                                                                MessageBox.Show("Updated successfully");
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Press save if you want to update this user");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter a valid email address");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter a valid phone number\nIt has to be 9 digit number");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid zipcode\nIt has to be five digit number");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a valid city or state");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a valid name\nThe name must begin with a capital letter");
                                        }

                                        CustomerComboBox.Enabled = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fill out the field / Use the correct format");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Unable to insert the record");
                    }
                }
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fill the textboxes with corresponding data
            PopulateTextBoxses();

            // disable idText since id is primary key
            idText.Enabled = false;
        }

        // Cancel Button
        private void myCancelButtonCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CustomerComboBox.Enabled = true;
                    FillMyComboBox();
                    PopulateTextBoxses();
                    MessageBox.Show("Canceled successfully");
                }
                catch 
                {
                    MessageBox.Show("No customer was selected");
                }
               
            }
            else
            {
                MessageBox.Show("Cancel denied");
            }
        }
    }
}
