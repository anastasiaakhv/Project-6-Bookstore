namespace BookStore
{
    partial class Form4
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
            this.manageCustomersButton = new System.Windows.Forms.Button();
            this.manageBooksButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageCustomersButton
            // 
            this.manageCustomersButton.BackColor = System.Drawing.Color.White;
            this.manageCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manageCustomersButton.Location = new System.Drawing.Point(280, 42);
            this.manageCustomersButton.Name = "manageCustomersButton";
            this.manageCustomersButton.Size = new System.Drawing.Size(214, 88);
            this.manageCustomersButton.TabIndex = 28;
            this.manageCustomersButton.Text = "Manage Customers";
            this.manageCustomersButton.UseVisualStyleBackColor = false;
            this.manageCustomersButton.Click += new System.EventHandler(this.manageCustomersButton_Click);
            // 
            // manageBooksButton
            // 
            this.manageBooksButton.BackColor = System.Drawing.Color.White;
            this.manageBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBooksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manageBooksButton.Location = new System.Drawing.Point(280, 145);
            this.manageBooksButton.Name = "manageBooksButton";
            this.manageBooksButton.Size = new System.Drawing.Size(214, 88);
            this.manageBooksButton.TabIndex = 29;
            this.manageBooksButton.Text = "Manage Books";
            this.manageBooksButton.UseVisualStyleBackColor = false;
            this.manageBooksButton.Click += new System.EventHandler(this.manageBooksButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.White;
            this.placeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.placeOrderButton.Location = new System.Drawing.Point(280, 251);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(214, 88);
            this.placeOrderButton.TabIndex = 30;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.manageBooksButton);
            this.Controls.Add(this.manageCustomersButton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageCustomersButton;
        private System.Windows.Forms.Button manageBooksButton;
        private System.Windows.Forms.Button placeOrderButton;
    }
}