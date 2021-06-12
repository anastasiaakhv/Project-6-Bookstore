using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace BookStore
{
    public partial class Form2 : Form
    {
        List<Customer> customerList = new List<Customer>();
        bool containsNum;
        bool isNumber;

        public Form2()
        {
            InitializeComponent();
        
            
           

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        
        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            customerComboBox.Enabled = false;

            // Clear all of the textboxes so that the user is able to input new data
            firstNameText.Text = String.Empty;
            lastNameText.Text = String.Empty;
            addressText.Text = String.Empty;
            cityText.Text = String.Empty;
            stateText.Text = String.Empty;
            zipText.Text = String.Empty;
            phoneText.Text = String.Empty;
            emailText.Text = String.Empty;

            // Focus the firstname field
            this.ActiveControl = firstNameText;


        }

        private void zipText_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            

            // If none of the textboxes are empty

            if (!((String.IsNullOrEmpty(firstNameText.Text)) &&
               (String.IsNullOrEmpty(lastNameText.Text)) &&
               (String.IsNullOrEmpty(addressText.Text)) &&
               (String.IsNullOrEmpty(cityText.Text)) &&
               (String.IsNullOrEmpty(stateText.Text)) &&
               (String.IsNullOrEmpty(zipText.Text)) &&
               (String.IsNullOrEmpty(phoneText.Text)) &&
               (String.IsNullOrEmpty(emailText.Text))))
            {
                

                // if the first- and lastname textboxes dont contain any numbers 
                containsNum = firstNameText.Text.Any(char.IsDigit);
                if (containsNum == false)
                {
                    containsNum = lastNameText.Text.Any(char.IsDigit);
                    if (containsNum == false)
                    {
                        // No selection provided for address since it can contain characters as well as numbers 

                        /* 
                         * The store is available in two states: CA and NY
                         * The store is available in three cities: San Diego, Los Angeles and New York
                         */

                        
                        // If the state is CA or NY
                        if ((stateText.Text == "california") ||
                           (stateText.Text == "ca") ||
                           (stateText.Text == "CA") ||
                           (stateText.Text == "California") ||
                           (stateText.Text == "CALIFORNIA") ||
                           (stateText.Text == "ny") ||
                           (stateText.Text == "NY") ||
                           (stateText.Text == "New York") ||
                           (stateText.Text == "NEW YORK") ||
                           (stateText.Text == "new york"))

                        {
                            // If the state is CA
                            if ((stateText.Text == "california") || (stateText.Text == "ca") || (stateText.Text == "CA") || (stateText.Text == "California") || (stateText.Text == "CALIFORNIA"))
                            {
                                // If the city is LA or San Diego
                                if ((cityText.Text == "la") ||
                                  (cityText.Text == "los angeles") ||
                                  (cityText.Text == "LA") ||
                                  (cityText.Text == "Los Angeles") ||
                                  (cityText.Text == "LOS ANGELES") ||
                                  (cityText.Text == "san diego") ||
                                  (cityText.Text == "San Diego")||
                                  (cityText.Text == "SAN DIEGO"))
                                {
                                    //  Check if the Zip is a number with 5 digits
                                    isNumber = zipText.Text.All(char.IsDigit);
                                    if ((isNumber == true) && (zipText.Text.Length == 5))
                                    {
                                        // Standard American telephone number contains ten digits 
                                        isNumber = phoneText.Text.All(char.IsDigit);

                                        //  Check if the phone number is a NUMBER with 10 digits
                                        if ((isNumber == true) && (phoneText.Text.Length == 10))
                                        {
                                            //  standard email contains "@"
                                            /* Check if the string contains "@" */
                                            if (emailText.Text.Contains("@"))
                                            {
                                                /* If one wants to edit the customer */
                                                if (MessageBox.Show("Is this a new user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                {
                                                    // Instantiate new object
                                                     Customer myCustomer = new Customer(firstNameText.Text,
                                                                                       lastNameText.Text,
                                                                                       addressText.Text,
                                                                                       cityText.Text,
                                                                                       stateText.Text,
                                                                                       zipText.Text,
                                                                                       phoneText.Text,
                                                                                       emailText.Text);

                                                    // Add object to list
                                                    customerList.Add(myCustomer);
                                                    try
                                                    {
                                                        // Set enabled property of combobox to true
                                                        customerComboBox.Enabled = true;
                                                        customerComboBox.Items.Add(myCustomer.FirstName + " " + myCustomer.LastName);
                                                    }
                                                    catch 
                                                    {
                                                        MessageBox.Show("The task could not be completed");
                                                    }

                                                    
                                                }
                                                else
                                                {
                                                    if (MessageBox.Show("Do you want to modify this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                    {
                                                        int a = customerComboBox.SelectedIndex;
                                                        try
                                                        {
                                                            Customer c = customerComboBox.SelectedItem as Customer;
                                                            // Remove from list at index a
                                                            customerList.RemoveAt(a);
                                                            //  Remove from ComboBox at a
                                                            customerComboBox.Items.RemoveAt(customerComboBox.SelectedIndex);

                                                            // Instantiate new object editedCustomer with the edited data
                                                            Customer editedCustomer = new Customer(firstNameText.Text,
                                                                                                lastNameText.Text,
                                                                                                addressText.Text,
                                                                                                cityText.Text,
                                                                                                stateText.Text,
                                                                                                zipText.Text,
                                                                                                phoneText.Text,
                                                                                                emailText.Text);
                                                            // Insert the edited object in the list at index a
                                                            customerList.Add(editedCustomer);
                                                            //  Load Combobox with the customerList
                                                            customerComboBox.Items.Add(editedCustomer.FirstName + " " + editedCustomer.LastName);


                                                            
                                                        }
                                                        catch
                                                        {
                                                            MessageBox.Show("The task was unable to perform.\nPlease choose an user from combobox");
                                                        }

                                                        
                                                    }
                                                    else 
                                                    {
                                                        MessageBox.Show("The user has not been modified");
                                                    }
                                                }

                                                // Write the Customer data into file "customers.txt"
                                                using (StreamWriter myStreamWriter = new StreamWriter("customers.txt"))
                                                {

                                                    foreach (Customer C in customerList)
                                                    {
                                                        myStreamWriter.WriteLine("--------------------------------------");

                                                        myStreamWriter.WriteLine("Firstname: " + C.FirstName);

                                                        myStreamWriter.WriteLine("Lastname: " + C.LastName);

                                                        myStreamWriter.WriteLine("Address: " + C.Address);

                                                        myStreamWriter.WriteLine("City: " + C.City);

                                                        myStreamWriter.WriteLine("State: " + C.State);

                                                        myStreamWriter.WriteLine("Zip: " + C.Zip);

                                                        myStreamWriter.WriteLine("Phone: " + C.Phone);

                                                        myStreamWriter.WriteLine("Email: " + C.Email);

                                                        myStreamWriter.WriteLine("--------------------------------------\n");
                                                    }
                                                }

                                                
                                            }
                                            else
                                            {
                                                
                                                MessageBox.Show("Please provide a valid email adress");
                                                this.ActiveControl = emailText;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("The phone number is not valid.\nStandard American phone number consists of 10 digits.");
                                            this.ActiveControl = phoneText;
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("This Zipcode is not valid.\n The zipcode is a five digit number.");
                                        this.ActiveControl = zipText;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("The bookstore is available in LA or San Diego in this state.");
                                    this.ActiveControl = cityText;
                                }
                            }
                            // If the state is NY
                            else if ((stateText.Text == "ny") || (stateText.Text == "new york")|| (stateText.Text == "NY")|| (stateText.Text == "New York")|| (stateText.Text == "NEW YORK"))
                            {
                                
                                // If the city is NY
                                if ((cityText.Text == "ny") || (cityText.Text == "new york") || (cityText.Text == "NY") || (cityText.Text == "New York") || (cityText.Text == "NEW YORK"))
                                {
                                    isNumber = zipText.Text.All(char.IsDigit);
                                    if ((isNumber == true) && (zipText.Text.Length == 5))
                                    {
                                        // Standard American telephone number contains ten digits 
                                        isNumber = phoneText.Text.All(char.IsDigit);

                                        //  Check if the phone number is a NUMBER with 10 digits
                                        if ((isNumber == true) && (phoneText.Text.Length == 10))
                                        {
                                            //  standard email contains "@"
                                            /* Check if the string contains "@" */
                                            if (emailText.Text.Contains("@"))
                                            {
                                                /* If one wants to edit the customer */
                                                if (MessageBox.Show("Is this a new user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                {
                                                    // Instantiate customer object
                                                    Customer myCustomer = new Customer(firstNameText.Text,
                                                                                       lastNameText.Text,
                                                                                       addressText.Text,
                                                                                       cityText.Text,
                                                                                       stateText.Text,
                                                                                       zipText.Text,
                                                                                       phoneText.Text,
                                                                                       emailText.Text);
                                                    // Add the object to the list
                                                    customerList.Add(myCustomer);

                                                    try
                                                    {
                                                        // Set enabled property of combobox to true
                                                        customerComboBox.Enabled = true;
                                                        customerComboBox.Items.Add(myCustomer.FirstName + " " + myCustomer.LastName);
                                                    }
                                                    catch 
                                                    {
                                                        MessageBox.Show("The task could not be performed");
                                                    }

                                                }
                                                else
                                                {
                                                    // If the answer to the question is yes then ...
                                                    if (MessageBox.Show("Do you want to modify this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                    {
                                                        int a = customerComboBox.SelectedIndex;
                                                        try
                                                        {
                                                            Customer c = customerComboBox.SelectedItem as Customer;
                                                            // Remove from list at index a
                                                            customerList.RemoveAt(a);
                                                            //  Remove from ComboBox at a
                                                            customerComboBox.Items.RemoveAt(customerComboBox.SelectedIndex);

                                                            // Instantiate new object editedCustomer with the edited data
                                                            Customer editedCustomer = new Customer(firstNameText.Text,
                                                                                                lastNameText.Text,
                                                                                                addressText.Text,
                                                                                                cityText.Text,
                                                                                                stateText.Text,
                                                                                                zipText.Text,
                                                                                                phoneText.Text,
                                                                                                emailText.Text);
                                                            // Insert the edited object in the list at index a
                                                            customerList.Add(editedCustomer);
                                                            customerComboBox.Items.Add(editedCustomer.FirstName + " " + editedCustomer.LastName);
 
                                                        }
                                                        catch
                                                        {
                                                            MessageBox.Show("The task was unable to perform.\nPlease choose an user from combobox");
                                                        }


                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("The user has not been modified");
                                                    }
                                                    
                                                }

                                                // Write the data into file "customers.txt"
                                                using (StreamWriter myStreamWriter = new StreamWriter("customers.txt"))
                                                {

                                                    foreach (Customer C in customerList)
                                                    {
                                                        myStreamWriter.WriteLine("--------------------------------------");

                                                        myStreamWriter.WriteLine("Firstname: " + C.FirstName);

                                                        myStreamWriter.WriteLine("Lastname: " + C.LastName);

                                                        myStreamWriter.WriteLine("Address: " + C.Address);

                                                        myStreamWriter.WriteLine("City: " + C.City);

                                                        myStreamWriter.WriteLine("State: " + C.State);

                                                        myStreamWriter.WriteLine("Zip: " + C.Zip);

                                                        myStreamWriter.WriteLine("Phone: " + C.Phone);

                                                        myStreamWriter.WriteLine("Email: " + C.Email);

                                                        myStreamWriter.WriteLine("--------------------------------------\n");
                                                    }
                                                }

                                            }

                                            else
                                            {
                                                MessageBox.Show("Please provide a valid email adress");
                                                this.ActiveControl = emailText;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("The phone number is not valid.\nStandard American phone number consists of 10 digits.");
                                            this.ActiveControl = phoneText;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("This Zipcode is not valid.\n The zipcode is a five digit number.");
                                        this.ActiveControl = zipText;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("The bookstore is available in NY in this state.");
                                    this.ActiveControl = cityText;
                                }
                            }
                            else
                            {
                                MessageBox.Show("This bookstore is available only in 2 states.\nThese states are: California and New York");
                                this.ActiveControl = stateText;
                            }
                        }
                        else 
                        {
                            MessageBox.Show("The bookstore is available only in two states: NY and CA");
                            this.ActiveControl = stateText;
                        }


                    }
                    else
                    {
                        MessageBox.Show("Lastname contains a number.\nPlease provide a valid last name!");
                        this.ActiveControl = lastNameText;
                    }
                }
                else
                {
                    MessageBox.Show("Firstname contains a number.\nPlease provide a valid first name!");
                    this.ActiveControl = firstNameText;
                }


            }

            else 
            {
                
                MessageBox.Show("Please fill the entire form out!");

                /* Focus on the empty textbox */ 

                if (String.IsNullOrEmpty(firstNameText.Text))
                {
                    this.ActiveControl = firstNameText;
                }
                if (String.IsNullOrEmpty(lastNameText.Text))
                {
                    this.ActiveControl = lastNameText;
                }
                if (String.IsNullOrEmpty(addressText.Text))
                {
                    this.ActiveControl = addressText;
                }
                if (String.IsNullOrEmpty(cityText.Text))
                {
                    this.ActiveControl = cityText;
                }
                if (String.IsNullOrEmpty(stateText.Text))
                {
                    this.ActiveControl = stateText;
                }
                if (String.IsNullOrEmpty(zipText.Text))
                {
                    this.ActiveControl = zipText;
                }
                if (String.IsNullOrEmpty(phoneText.Text))
                {
                    this.ActiveControl = phoneText;
                }
                if (String.IsNullOrEmpty(emailText.Text))
                {
                    this.ActiveControl = emailText;
                }

            }

        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /* Show the data that has been saved already */ 
                firstNameText.Text = customerList[customerComboBox.SelectedIndex].FirstName;
                lastNameText.Text = customerList[customerComboBox.SelectedIndex].LastName;
                addressText.Text = customerList[customerComboBox.SelectedIndex].Address;
                cityText.Text = customerList[customerComboBox.SelectedIndex].City;
                stateText.Text = customerList[customerComboBox.SelectedIndex].State;
                zipText.Text = customerList[customerComboBox.SelectedIndex].Zip;
                phoneText.Text = customerList[customerComboBox.SelectedIndex].Phone;
                emailText.Text = customerList[customerComboBox.SelectedIndex].Email;

               

            }
            catch 
            {
                MessageBox.Show("An error has occured");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            customerComboBox.Enabled = true;
            // If the answer to this question is yes ...
            if (MessageBox.Show("Are you sure you want to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Your data has not been saved");
            }
            else 
            {
                MessageBox.Show("Press save if you want to save this user");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // If Back button is clicked hide the current form
            this.Hide();

            // Instantiate object of Form1
            Form1 oldForm = new Form1();

            // Go back to previous page
            oldForm.ShowDialog();
        }
    }

    public class Customer 
    {
        
        /* Auto-implemented properties of a customer */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Default Constructor => empty body
        public Customer()
        {

        }

        //Explicit value Constructor 
        public Customer(string myFirstName,
                        string myLastName, 
                        string myAddress, 
                        string myCity, 
                        string myState, 
                        string myZip,
                        string myPhone,
                        string myEmail)
        {
            this.FirstName = myFirstName;
            this.LastName = myLastName;
            this.Address = myAddress;
            this.City = myCity;
            this.State = myState;
            this.Zip = myZip;
            this.Phone = myPhone;
            this.Email = myEmail;
        }
         


        public override string ToString()
        {
            // returning the title of the book so that the combobox displayis the titles of the book objects
            return this.FirstName + " " + this.LastName;
        }
    }
}
