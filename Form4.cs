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
    public partial class Form4 : Form
    {
      
        // Instantiate a new object of Form2
        Form3 testForm = new Form3();
        public Form4()
        {
            InitializeComponent();
          
        }

        private void manageCustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Show the customer form
            myCustomerForm myCustomerFormDB = new myCustomerForm();
            myCustomerFormDB.ShowDialog();

        }

        private void manageBooksButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            // Show the new form
            testForm.ShowDialog();

        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 placeOrder = new Form6();
            placeOrder.ShowDialog();
        }
    }
}
