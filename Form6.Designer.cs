namespace BookStore
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookCombo = new System.Windows.Forms.ComboBox();
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseBook = new System.Windows.Forms.Label();
            this.chooseCustomer = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.TextBox();
            this.BookAutor = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.BookISBN = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.BookQuantity = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.myTax = new System.Windows.Forms.TextBox();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.subTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addTitleButton = new System.Windows.Forms.Button();
            this.ExtraCredit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookCombo
            // 
            this.bookCombo.FormattingEnabled = true;
            this.bookCombo.Location = new System.Drawing.Point(184, 28);
            this.bookCombo.Name = "bookCombo";
            this.bookCombo.Size = new System.Drawing.Size(412, 21);
            this.bookCombo.TabIndex = 0;
            this.bookCombo.SelectedIndexChanged += new System.EventHandler(this.bookCombo_SelectedIndexChanged);
            // 
            // customerCombo
            // 
            this.customerCombo.FormattingEnabled = true;
            this.customerCombo.Location = new System.Drawing.Point(184, 67);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(412, 21);
            this.customerCombo.TabIndex = 1;
            this.customerCombo.SelectedIndexChanged += new System.EventHandler(this.customerCombo_SelectedIndexChanged);
            // 
            // myDataGridView
            // 
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Location = new System.Drawing.Point(184, 99);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.Size = new System.Drawing.Size(412, 221);
            this.myDataGridView.TabIndex = 2;
            this.myDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chooseBook
            // 
            this.chooseBook.AutoSize = true;
            this.chooseBook.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseBook.ForeColor = System.Drawing.Color.White;
            this.chooseBook.Location = new System.Drawing.Point(25, 25);
            this.chooseBook.Name = "chooseBook";
            this.chooseBook.Size = new System.Drawing.Size(139, 21);
            this.chooseBook.TabIndex = 43;
            this.chooseBook.Text = "Choose a book ->";
            // 
            // chooseCustomer
            // 
            this.chooseCustomer.AutoSize = true;
            this.chooseCustomer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCustomer.ForeColor = System.Drawing.Color.White;
            this.chooseCustomer.Location = new System.Drawing.Point(15, 67);
            this.chooseCustomer.Name = "chooseCustomer";
            this.chooseCustomer.Size = new System.Drawing.Size(164, 21);
            this.chooseCustomer.TabIndex = 44;
            this.chooseCustomer.Text = "Choose a customer->";
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(29, 161);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(150, 20);
            this.authorText.TabIndex = 45;
            this.authorText.TextChanged += new System.EventHandler(this.authorText_TextChanged);
            // 
            // BookAutor
            // 
            this.BookAutor.AutoSize = true;
            this.BookAutor.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAutor.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BookAutor.Location = new System.Drawing.Point(25, 137);
            this.BookAutor.Name = "BookAutor";
            this.BookAutor.Size = new System.Drawing.Size(67, 21);
            this.BookAutor.TabIndex = 46;
            this.BookAutor.Text = "Author:";
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(29, 206);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(150, 20);
            this.isbnText.TabIndex = 47;
            // 
            // BookISBN
            // 
            this.BookISBN.AutoSize = true;
            this.BookISBN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookISBN.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BookISBN.Location = new System.Drawing.Point(25, 184);
            this.BookISBN.Name = "BookISBN";
            this.BookISBN.Size = new System.Drawing.Size(50, 19);
            this.BookISBN.TabIndex = 48;
            this.BookISBN.Text = "ISBN:";
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPrice.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BookPrice.Location = new System.Drawing.Point(25, 229);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(52, 21);
            this.BookPrice.TabIndex = 49;
            this.BookPrice.Text = "Price:";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(29, 253);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(150, 20);
            this.priceText.TabIndex = 50;
            // 
            // BookQuantity
            // 
            this.BookQuantity.AutoSize = true;
            this.BookQuantity.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookQuantity.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BookQuantity.Location = new System.Drawing.Point(25, 276);
            this.BookQuantity.Name = "BookQuantity";
            this.BookQuantity.Size = new System.Drawing.Size(80, 21);
            this.BookQuantity.TabIndex = 51;
            this.BookQuantity.Text = "Quantity:";
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(29, 300);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(150, 20);
            this.quantityText.TabIndex = 52;
            // 
            // myTax
            // 
            this.myTax.Location = new System.Drawing.Point(238, 370);
            this.myTax.Name = "myTax";
            this.myTax.Size = new System.Drawing.Size(150, 20);
            this.myTax.TabIndex = 53;
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(446, 370);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(150, 20);
            this.totalAmount.TabIndex = 54;
            // 
            // subTotal
            // 
            this.subTotal.Location = new System.Drawing.Point(29, 370);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(150, 20);
            this.subTotal.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(70, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(295, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(493, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Total";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(646, 99);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 45);
            this.backButton.TabIndex = 59;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.Location = new System.Drawing.Point(646, 158);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(109, 45);
            this.confirmButton.TabIndex = 60;
            this.confirmButton.Text = "Confirm Order";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(646, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 45);
            this.cancelButton.TabIndex = 61;
            this.cancelButton.Text = "Cancel Order";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addTitleButton
            // 
            this.addTitleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addTitleButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTitleButton.ForeColor = System.Drawing.Color.Black;
            this.addTitleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTitleButton.Location = new System.Drawing.Point(646, 276);
            this.addTitleButton.Name = "addTitleButton";
            this.addTitleButton.Size = new System.Drawing.Size(109, 45);
            this.addTitleButton.TabIndex = 62;
            this.addTitleButton.Text = "Add Title";
            this.addTitleButton.UseVisualStyleBackColor = false;
            this.addTitleButton.Click += new System.EventHandler(this.addTitleButton_Click);
            // 
            // ExtraCredit
            // 
            this.ExtraCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ExtraCredit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraCredit.ForeColor = System.Drawing.Color.Black;
            this.ExtraCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExtraCredit.Location = new System.Drawing.Point(646, 336);
            this.ExtraCredit.Name = "ExtraCredit";
            this.ExtraCredit.Size = new System.Drawing.Size(109, 45);
            this.ExtraCredit.TabIndex = 63;
            this.ExtraCredit.Text = "Order Report";
            this.ExtraCredit.UseVisualStyleBackColor = false;
            this.ExtraCredit.Click += new System.EventHandler(this.ExtraCredit_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExtraCredit);
            this.Controls.Add(this.addTitleButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.myTax);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.BookQuantity);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BookISBN);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.BookAutor);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.chooseCustomer);
            this.Controls.Add(this.chooseBook);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.customerCombo);
            this.Controls.Add(this.bookCombo);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookCombo;
        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.Label chooseBook;
        private System.Windows.Forms.Label chooseCustomer;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Label BookAutor;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.Label BookISBN;
        private System.Windows.Forms.Label BookPrice;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label BookQuantity;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.TextBox myTax;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.TextBox subTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addTitleButton;
        private System.Windows.Forms.Button ExtraCredit;
    }
}