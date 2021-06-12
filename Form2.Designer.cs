namespace BookStore
{
    partial class Form2
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
            this.firstName = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.zipText = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.Blue;
            this.firstName.Location = new System.Drawing.Point(22, 129);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(105, 21);
            this.firstName.TabIndex = 10;
            this.firstName.Text = "First Name: ";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(133, 132);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(150, 20);
            this.firstNameText.TabIndex = 11;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Blue;
            this.lastName.Location = new System.Drawing.Point(308, 132);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(101, 21);
            this.lastName.TabIndex = 13;
            this.lastName.Text = "Last Name: ";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(415, 135);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(150, 20);
            this.lastNameText.TabIndex = 14;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.Blue;
            this.Address.Location = new System.Drawing.Point(22, 173);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(82, 21);
            this.Address.TabIndex = 15;
            this.Address.Text = "Address: ";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(133, 176);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(432, 20);
            this.addressText.TabIndex = 16;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.ForeColor = System.Drawing.Color.Blue;
            this.City.Location = new System.Drawing.Point(22, 211);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(45, 21);
            this.City.TabIndex = 17;
            this.City.Text = "City:";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(133, 214);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(150, 20);
            this.cityText.TabIndex = 18;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.ForeColor = System.Drawing.Color.Blue;
            this.State.Location = new System.Drawing.Point(308, 214);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(57, 21);
            this.State.TabIndex = 19;
            this.State.Text = "State:";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(415, 217);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(150, 20);
            this.stateText.TabIndex = 20;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip.ForeColor = System.Drawing.Color.Blue;
            this.Zip.Location = new System.Drawing.Point(22, 252);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(39, 21);
            this.Zip.TabIndex = 21;
            this.Zip.Text = "Zip:";
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(133, 255);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(150, 20);
            this.zipText.TabIndex = 22;
            this.zipText.TextChanged += new System.EventHandler(this.zipText_TextChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.Blue;
            this.Phone.Location = new System.Drawing.Point(22, 292);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(58, 21);
            this.Phone.TabIndex = 23;
            this.Phone.Text = "Phone:";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(133, 295);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(150, 20);
            this.phoneText.TabIndex = 24;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Blue;
            this.Email.Location = new System.Drawing.Point(26, 331);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 21);
            this.Email.TabIndex = 25;
            this.Email.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(133, 334);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(432, 20);
            this.emailText.TabIndex = 26;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.GreenYellow;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Blue;
            this.backButton.Location = new System.Drawing.Point(643, 22);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 33);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.BackColor = System.Drawing.Color.GreenYellow;
            this.newCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerButton.ForeColor = System.Drawing.Color.Blue;
            this.newCustomerButton.Location = new System.Drawing.Point(643, 73);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(100, 33);
            this.newCustomerButton.TabIndex = 28;
            this.newCustomerButton.Text = "New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = false;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.GreenYellow;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Blue;
            this.saveButton.Location = new System.Drawing.Point(643, 125);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 33);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.GreenYellow;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Blue;
            this.cancelButton.Location = new System.Drawing.Point(643, 173);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 33);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // customerComboBox
            // 
            this.customerComboBox.BackColor = System.Drawing.Color.Aqua;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(133, 73);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(432, 21);
            this.customerComboBox.TabIndex = 31;
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.State);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.City);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox customerComboBox;
    }
}