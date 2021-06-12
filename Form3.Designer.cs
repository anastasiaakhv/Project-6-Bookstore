namespace BookStore
{
    partial class Form3
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
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newBook = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numLinesText = new System.Windows.Forms.TextBox();
            this.numLines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookComboBox
            // 
            this.BookComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(162, 63);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(440, 21);
            this.BookComboBox.TabIndex = 32;
            this.BookComboBox.Text = "Edit an existing book";
            this.BookComboBox.SelectedIndexChanged += new System.EventHandler(this.BookComboBox_SelectedIndexChanged);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(162, 110);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(432, 20);
            this.titleText.TabIndex = 33;
            this.titleText.TextChanged += new System.EventHandler(this.titleText_TextChanged);
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(162, 159);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(432, 20);
            this.authorText.TabIndex = 34;
            this.authorText.TextChanged += new System.EventHandler(this.authorText_TextChanged);
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(162, 203);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(432, 20);
            this.isbnText.TabIndex = 35;
            this.isbnText.TextChanged += new System.EventHandler(this.isbnText_TextChanged);
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(162, 242);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(432, 20);
            this.priceText.TabIndex = 36;
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.title.Location = new System.Drawing.Point(88, 110);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(50, 21);
            this.title.TabIndex = 37;
            this.title.Text = "Title:";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.author.Location = new System.Drawing.Point(71, 156);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(67, 21);
            this.author.TabIndex = 38;
            this.author.Text = "Author:";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.isbn.Location = new System.Drawing.Point(82, 203);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(56, 21);
            this.isbn.TabIndex = 39;
            this.isbn.Text = "ISBN:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.price.Location = new System.Drawing.Point(86, 242);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 21);
            this.price.TabIndex = 40;
            this.price.Text = "Price:";
            this.price.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(656, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 41;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newBook
            // 
            this.newBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newBook.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBook.ForeColor = System.Drawing.Color.Black;
            this.newBook.Location = new System.Drawing.Point(656, 114);
            this.newBook.Name = "newBook";
            this.newBook.Size = new System.Drawing.Size(109, 45);
            this.newBook.TabIndex = 42;
            this.newBook.Text = "New Book";
            this.newBook.UseVisualStyleBackColor = false;
            this.newBook.Click += new System.EventHandler(this.newBook_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(656, 165);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 45);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(656, 218);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 45);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // numLinesText
            // 
            this.numLinesText.Location = new System.Drawing.Point(162, 278);
            this.numLinesText.Name = "numLinesText";
            this.numLinesText.Size = new System.Drawing.Size(432, 20);
            this.numLinesText.TabIndex = 45;
            // 
            // numLines
            // 
            this.numLines.AutoSize = true;
            this.numLines.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numLines.Location = new System.Drawing.Point(0, 275);
            this.numLines.Name = "numLines";
            this.numLines.Size = new System.Drawing.Size(138, 21);
            this.numLines.TabIndex = 46;
            this.numLines.Text = "Number of Lines:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numLines);
            this.Controls.Add(this.numLinesText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.BookComboBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newBook;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox numLinesText;
        private System.Windows.Forms.Label numLines;
    }
}