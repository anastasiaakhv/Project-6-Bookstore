namespace BookStore
{
    partial class myCustomerForm
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
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.zipText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backButtonCustomer = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.mySaveBtnCustomer = new System.Windows.Forms.Button();
            this.myCancelButtonCustomer = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(101, 94);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(478, 21);
            this.CustomerComboBox.TabIndex = 33;
            this.CustomerComboBox.Text = "Edit an existing customer";
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(226, 161);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(212, 20);
            this.firstNameText.TabIndex = 34;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(226, 187);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(212, 20);
            this.lastNameText.TabIndex = 35;
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(226, 239);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(212, 20);
            this.stateText.TabIndex = 36;
            this.stateText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(226, 343);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(353, 20);
            this.emailText.TabIndex = 37;
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(226, 265);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(212, 20);
            this.zipText.TabIndex = 38;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(226, 291);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(212, 20);
            this.phoneText.TabIndex = 39;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(226, 317);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(353, 20);
            this.addressText.TabIndex = 40;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(226, 213);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(212, 20);
            this.cityText.TabIndex = 41;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.White;
            this.firstName.Location = new System.Drawing.Point(97, 161);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(105, 21);
            this.firstName.TabIndex = 42;
            this.firstName.Text = "First Name: ";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "City: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Last Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "State: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Zip: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Email: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(97, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Address: ";
            // 
            // backButtonCustomer
            // 
            this.backButtonCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButtonCustomer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonCustomer.ForeColor = System.Drawing.Color.Black;
            this.backButtonCustomer.Location = new System.Drawing.Point(621, 94);
            this.backButtonCustomer.Name = "backButtonCustomer";
            this.backButtonCustomer.Size = new System.Drawing.Size(109, 45);
            this.backButtonCustomer.TabIndex = 50;
            this.backButtonCustomer.Text = "Back";
            this.backButtonCustomer.UseVisualStyleBackColor = false;
            this.backButtonCustomer.Click += new System.EventHandler(this.backButtonCustomer_Click);
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newCustomerButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerButton.ForeColor = System.Drawing.Color.Black;
            this.newCustomerButton.Location = new System.Drawing.Point(621, 177);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(109, 45);
            this.newCustomerButton.TabIndex = 51;
            this.newCustomerButton.Text = "New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = false;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // mySaveBtnCustomer
            // 
            this.mySaveBtnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mySaveBtnCustomer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mySaveBtnCustomer.ForeColor = System.Drawing.Color.Black;
            this.mySaveBtnCustomer.Location = new System.Drawing.Point(621, 265);
            this.mySaveBtnCustomer.Name = "mySaveBtnCustomer";
            this.mySaveBtnCustomer.Size = new System.Drawing.Size(109, 45);
            this.mySaveBtnCustomer.TabIndex = 52;
            this.mySaveBtnCustomer.Text = "Save";
            this.mySaveBtnCustomer.UseVisualStyleBackColor = false;
            this.mySaveBtnCustomer.Click += new System.EventHandler(this.mySaveBtnCustomer_Click);
            // 
            // myCancelButtonCustomer
            // 
            this.myCancelButtonCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myCancelButtonCustomer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCancelButtonCustomer.ForeColor = System.Drawing.Color.Black;
            this.myCancelButtonCustomer.Location = new System.Drawing.Point(621, 345);
            this.myCancelButtonCustomer.Name = "myCancelButtonCustomer";
            this.myCancelButtonCustomer.Size = new System.Drawing.Size(109, 45);
            this.myCancelButtonCustomer.TabIndex = 53;
            this.myCancelButtonCustomer.Text = "Cancel";
            this.myCancelButtonCustomer.UseVisualStyleBackColor = false;
            this.myCancelButtonCustomer.Click += new System.EventHandler(this.myCancelButtonCustomer_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(226, 369);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(353, 20);
            this.idText.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(97, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "ID:";
            // 
            // myCustomerForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.myCancelButtonCustomer);
            this.Controls.Add(this.mySaveBtnCustomer);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.backButtonCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.CustomerComboBox);
            this.Name = "myCustomerForm";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backButtonCustomer;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button mySaveBtnCustomer;
        private System.Windows.Forms.Button myCancelButtonCustomer;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label8;
    }
}