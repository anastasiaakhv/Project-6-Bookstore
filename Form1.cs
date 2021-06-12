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
    
    public partial class Form1 : Form
    {
        
        // false if add button was not pressed, true otherwise
        bool addButton = false;

        // Instantiate three book objects
        Book firstBook = new Book("J.K Rowling", "1234567891234", "20", "Harry Potter and the Philosopher's Stone");
        Book secondBook = new Book("K.Alexander", "2345678912341", "35", "Fundamentals of Electric Circuits");
        Book thirdBook = new Book("A.A Milne", "3456789123412", "80", "Winnie-the-Pooh");

        /* 
         * Instantiating more book objects
         * the information about these objects will be saved into .txt file
         */

        Book fileFirst = new Book("J.R.R Tolkien", "1122334455667", "42", "The Lord of the Rings");
        Book fileSecond = new Book("Miguel de Cervantes", "11122233310123", "63", "Don Quixote");
        Book fileThird = new Book("George Orwell", "1111111111111", "90", "1984");

        ArrayList myNewArrayList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();

            //  Add the three books to the combobox
            comboBox1.Items.Add(firstBook);
            comboBox1.Items.Add(secondBook);
            comboBox1.Items.Add(thirdBook);

            //  Create a list of books
            List<Book> myBooks = new List<Book>();
            myBooks.Add(firstBook);
            myBooks.Add(secondBook);
            myBooks.Add(thirdBook);

            // Create an arraylist containing three book objects which will later be imported into a .txt file
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(fileFirst);
            myArrayList.Add(fileSecond);
            myArrayList.Add(fileThird);

            // Write the info into a file
            using (StreamWriter myStreamWriter = new StreamWriter("book.txt"))
            {
                foreach (Book k in myArrayList)
                {   
                    // line by line
                    string myString = k.Author;
                    myStreamWriter.WriteLine(myString);
                    string myStringTwo = k.ISBN;
                    myStreamWriter.WriteLine(myStringTwo);
                    string myStringThree = k.Price;
                    myStreamWriter.WriteLine(myStringThree);
                    string myStringFour = k.Title;
                    myStreamWriter.WriteLine(myStringFour);
                }
            }

            
            int maxLines = 16;
            // reading the info from the file
            using (StreamReader sr = new StreamReader("book.txt"))
            {
                
                    string[] theLines = new string[maxLines];
                    for (int p = 0; p < maxLines; ++p)
                    {
                        // line by line
                        theLines[p] = sr.ReadLine();
                        
                    }

                    // Create new objects based on the file information
                    for (int a = 0; a < maxLines; a = a + 4) 
                    {
                         // try instantiating new objects
                          try
                        {
                            myNewArrayList.Add(new Book(theLines[a], theLines[a + 1], theLines[a + 2], theLines[a + 3]));
                        }
                          catch // if try block is not executed, execute this block 
                        {
                            Console.WriteLine("Error has occured\nThe task could not be performed");
                        }
                }
                
            }

            // Add each book to combobox
            foreach (Book myBook in myNewArrayList) 
            {
                try
                {
                    comboBox1.Items.Add(myBook.Title);
                }
                catch 
                {
                    Console.WriteLine("Error has occured\nThe task could not be performed");
                }
            }
            

        }

        /*private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {}*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Form1 myForm = new Form1();
            //this.MyFunction(fileFirst, fileSecond, fileThird);

            // Using as operator => returns null if the conversion is not possible
            Book b = comboBox1.SelectedItem as Book;

            comboBox1.Text = "Please select a book";
            //Console.WriteLine("{0}", b.Title);

            /*  Providing selections => Selecting with the title */
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Harry Potter and the Philosopher's Stone"))
            {
                Author.Text = firstBook.Author;
                ISBN.Text = firstBook.ISBN;
                Price.Text = firstBook.Price + " $";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Fundamentals of Electric Circuits"))
            {
                Author.Text = secondBook.Author;
                ISBN.Text = secondBook.ISBN;
                Price.Text = secondBook.Price + " $"; 
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Winnie-the-Pooh"))
            {
                Author.Text = thirdBook.Author;
                ISBN.Text = thirdBook.ISBN;
                Price.Text = thirdBook.Price + " $";
            }
            // Add three more options for the books imported from the file
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("The Lord of the Rings"))
            {
                // Cast explicitedly - avoiding errors
                Author.Text = ((Book) myNewArrayList[0]).Author;
                ISBN.Text = ((Book)myNewArrayList[0]).ISBN;
                Price.Text = ((Book)myNewArrayList[0]).Price + " $";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Don Quixote"))
            {
                Author.Text = ((Book)myNewArrayList[1]).Author;
                ISBN.Text = ((Book)myNewArrayList[1]).ISBN;
                Price.Text = ((Book)myNewArrayList[1]).Price + " $";
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("1984"))
            {
                Author.Text = ((Book)myNewArrayList[2]).Author;
                ISBN.Text = ((Book)myNewArrayList[2]).ISBN;
                Price.Text = ((Book)myNewArrayList[2]).Price + " $";
            }

        }

        private void BookPrice_Click(object sender, EventArgs e)
        {

        }

        private void Author_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {   

            addButton = true;
            int a = 0;

            /* 
             *  Providing a selection that the parse was successfull
             *  the value entered in the quantity box is an integer
             */

            if (comboBox1.SelectedIndex > -1) 
            {   
                //  4 Columns
                dataGridView1.ColumnCount = 4;

                //  Naming the columns
                dataGridView1.Columns[0].Name = "Author";
                dataGridView1.Columns[1].Name = "ISBN";
                dataGridView1.Columns[2].Name = "Price";
                dataGridView1.Columns[3].Name = "Title";

                // Row corresponding the first book
                string[] myRow0 = new string[]
                {
                 firstBook.Author,
                 firstBook.ISBN,
                 firstBook.Price,
                 firstBook.Title
                };

                // Row corresponding the second book
                string[] myRow1 = new string[]
                {
                 secondBook.Author,
                 secondBook.ISBN,
                 secondBook.Price,
                 secondBook.Title
                };

                // Row corresponding the third book
                string[] myRow2 = new string[]
                {
                 thirdBook.Author,
                 thirdBook.ISBN,
                 thirdBook.Price,
                 thirdBook.Title
                };

                /* 
                 * Add three more strings for the new books
                 */

                string[] myRow3 = new string[]
                {
                    ((Book) myNewArrayList[0]).Author,
                    ((Book)myNewArrayList[0]).ISBN,
                    ((Book)myNewArrayList[0]).Price,
                    ((Book)myNewArrayList[0]).Title
              
                };

                string[] myRow4 = new string[]
                {
                    ((Book) myNewArrayList[1]).Author,
                    ((Book)myNewArrayList[1]).ISBN,
                    ((Book)myNewArrayList[1]).Price,
                    ((Book)myNewArrayList[1]).Title
                };

                string[] myRow5 = new string[]
                {
                    ((Book) myNewArrayList[2]).Author,
                    ((Book)myNewArrayList[2]).ISBN,
                    ((Book)myNewArrayList[2]).Price,
                    ((Book)myNewArrayList[2]).Title
                };
                /*  The index of a combobox is -1 by default  */

                /*  Providing a selection according to which if something is selected do the following tasks */

                if ((Int32.TryParse(textBox1.Text, out a)) && (Convert.ToInt32(textBox1.Text) > 0))
                {
                    /* If the title of the book is Harry Potter and the Philosopher's Stone */ 
                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Harry Potter and the Philosopher's Stone"))
                    {
                        // Get input from the quantity box
                        int i = Convert.ToInt32(textBox1.Text);

                        /* Providing i number of rows of the selected book */
                        int n = 0;
                        while (n < i)
                        {
                            dataGridView1.Rows.Add(myRow0);
                            n++;
                        }
                    }

                    /* If the title of the book is Fundamentals of Electric Circuits */
                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Fundamentals of Electric Circuits"))
                    {
                        // Get input from the quantity box
                        int i = Convert.ToInt32(textBox1.Text);

                        /* Providing i number of rows of the selected book */
                        int n = 0;
                        while (n < i)
                        {
                            dataGridView1.Rows.Add(myRow1);
                            n++;
                        }
                    }

                    /* If the title of the book is Winnie-the-Pooh */
                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Winnie-the-Pooh"))
                    {
                        // Get input from the quantity box
                        int i = Convert.ToInt32(textBox1.Text);

                        /* Providing i number of rows of the selected book */
                        int n = 0;
                        while (n < i)
                        {
                            dataGridView1.Rows.Add(myRow2);
                            n++;
                        }
                    }

                    // Add three additional cases for the books imported from the file 


                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("The Lord of the Rings"))
                    {
                        // Get input from the quantity box
                        int i = Convert.ToInt32(textBox1.Text);

                        /* Providing i number of rows of the selected book */
                        int n = 0;
                        while (n < i)
                        {

                            dataGridView1.Rows.Add(myRow3);
                            n++;
                        }
                    }

                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Don Quixote"))
                    {
                        // Get input from the quantity box
                        int i = Convert.ToInt32(textBox1.Text);

                        /* Providing i number of rows of the selected book */
                        int n = 0;
                        while (n < i)
                        {
                            dataGridView1.Rows.Add(myRow4);
                            n++;
                        }
                    }

                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("1984"))
                    {
                        // Get input from the quantity box
                        int i = Convert.ToInt32(textBox1.Text);

                        /* Providing i number of rows of the selected book */
                        int n = 0;
                        while (n < i)
                        {
                            dataGridView1.Rows.Add(myRow5);
                            n++;
                        }
                    }

                    //  Create a list holding the prices of the books
                    List<int> Prices = new List<int>();

                    int m = 0;

                    //  Max number of rows
                    int maxRow = dataGridView1.Rows.Count - 1; 
                    while (m < maxRow)
                    {
                        //  Populating the list Prices with the prices
                        Prices.Add(Convert.ToInt32(dataGridView1.Rows[m].Cells[2].Value));
                        m++;
                    }

                    //  Sum up all the prices
                    int mySum = Prices.Sum();
                    //  Casting everything to double in order to get the correct value of the tax (10%)
                    double myTax = (double)mySum / (double)10;
                    double myTotal = mySum + myTax;
                    //  Display the values into the corresponding textboxes
                    Subtotal.Text = mySum.ToString() + " $";
                    textBox2.Text = myTax.ToString() + " $";
                    textBox3.Text = myTotal.ToString() + " $";
                }

                /* If parse was not successfull then ... */
                else
                {
                    //  Show a messagebox 
                    MessageBox.Show("Please enter a valid number\nYou have to add at least 1 book to your cart");
                    //  Focus on the quantity box
                    textBox1.Focus();
                }

            }

            
            else 
            {
                //  Show a messagebox 
                MessageBox.Show("Please select a book");
                //  Focus on the combobox
                comboBox1.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            // If the user did not press Add button
            if (addButton == false)
            {
                MessageBox.Show("Please add books in order to confirm the purchase");
            }
            else 
            {
                // If the order is confirmed ...
                int maxRowNum = dataGridView1.Rows.Count - 1;
                int columnCount = dataGridView1.Columns.Count;

                using (StreamWriter myStreamWriter = new StreamWriter("orders.txt"))
                {
                        // iterating over max number of rows
                        for (int i = 0; i < maxRowNum; i++)
                        {
                            myStreamWriter.Write("\nProduct N{0}\n", i+1);
                            myStreamWriter.Write("---------------\n");
                        // iterating over the columns
                        for (int l = 0; l < columnCount; l++)
                            {      
                                 /* Providing special format for output */

                                if (l == 0) myStreamWriter.Write("Author: ");
                                if (l == 1) myStreamWriter.Write("ISBN: ");
                                if (l == 2) myStreamWriter.Write("Price: ");
                                if (l == 3) myStreamWriter.Write("Title: ");
                            //import order information into orders.txt
                            string myInfo = String.Format("{0}", dataGridView1.Rows[i].Cells[l].Value.ToString());
                                myStreamWriter.WriteLine(myInfo);
                                
                        }
                                myStreamWriter.Write("---------------\n");
                    }
                    

                    myStreamWriter.WriteLine("\n");

                }
                MessageBox.Show("Your purchase is confirmed");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // If nothing has been added - ask the user to add something in order to confirm/cancel the order
            if (addButton == false)
            {
                MessageBox.Show("Please add books in order to confirm/cancel");
            }
            else
            {
                if (MessageBox.Show("Are you sure that you want to cancel the order?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    /* 
                     * Set subtotal
                     * tax
                     * and total back to 0
                     */

                    Subtotal.Text = "0";
                    textBox2.Text = "0";
                    textBox3.Text = "0";

                    /* Clear datagridview */ 
                    dataGridView1.Rows.Clear();
                }
            }

        }

        private void customerInfo_Click(object sender, EventArgs e)
        {
            // If Customer Information button is clicked hide the current form
            this.Hide();

            // Instantiate a new object of Form2
            Form2 newForm = new Form2();

            // Show the new form
            newForm.ShowDialog();

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /* private void label1_Click(object sender, EventArgs e)
         {

         }*/
    }

    public  class Book
    {
        /* Using Pascalcase for the properties as instructed throughout the course */

        /* Auto - implemented Properties */
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }

        // Default Constructor => empty body
        public Book()
        {

        }

        //Explicit value Constructor 
        public Book(string myAuthor, string myISBN, string myPrice, string myTitle)
        {
            this.Author = myAuthor;
            this.ISBN = myISBN;
            this.Price = myPrice;
            this.Title = myTitle;
        }


        // Overriding toString Method
        public override string ToString()
        {
            // returning the title of the book so that the combobox displayis the titles of the book objects
            return this.Title;
        }
    }
}
