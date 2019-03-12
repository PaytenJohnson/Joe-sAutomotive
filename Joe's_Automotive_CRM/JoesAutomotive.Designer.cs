namespace Joe_s_Automotive_CRM
{
    partial class JoesAutomotive
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
            this.CustomersBtn = new System.Windows.Forms.Button();
            this.Vehiclebtn = new System.Windows.Forms.Button();
            this.Partsbtn = new System.Windows.Forms.Button();
            this.Invoicesbtn = new System.Windows.Forms.Button();
            this.Dnttouch = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CustomersBtn.Location = new System.Drawing.Point(0, 153);
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(355, 90);
            this.CustomersBtn.TabIndex = 0;
            this.CustomersBtn.Text = "Customers";
            this.CustomersBtn.UseVisualStyleBackColor = true;
            this.CustomersBtn.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Vehiclebtn
            // 
            this.Vehiclebtn.Location = new System.Drawing.Point(0, 239);
            this.Vehiclebtn.Name = "Vehiclebtn";
            this.Vehiclebtn.Size = new System.Drawing.Size(355, 90);
            this.Vehiclebtn.TabIndex = 1;
            this.Vehiclebtn.Text = "Vehicles";
            this.Vehiclebtn.UseVisualStyleBackColor = true;
            this.Vehiclebtn.Click += new System.EventHandler(this.Vehiclebtn_Click);
            // 
            // Partsbtn
            // 
            this.Partsbtn.Location = new System.Drawing.Point(0, 325);
            this.Partsbtn.Name = "Partsbtn";
            this.Partsbtn.Size = new System.Drawing.Size(355, 102);
            this.Partsbtn.TabIndex = 2;
            this.Partsbtn.Text = "Parts";
            this.Partsbtn.UseVisualStyleBackColor = true;
            this.Partsbtn.Click += new System.EventHandler(this.Partsbtn_Click);
            // 
            // Invoicesbtn
            // 
            this.Invoicesbtn.Location = new System.Drawing.Point(0, 423);
            this.Invoicesbtn.Name = "Invoicesbtn";
            this.Invoicesbtn.Size = new System.Drawing.Size(355, 90);
            this.Invoicesbtn.TabIndex = 3;
            this.Invoicesbtn.Text = "Invoices";
            this.Invoicesbtn.UseVisualStyleBackColor = true;
            this.Invoicesbtn.Click += new System.EventHandler(this.Invoicesbtn_Click);
            // 
            // Dnttouch
            // 
            this.Dnttouch.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dnttouch.ForeColor = System.Drawing.Color.FloralWhite;
            this.Dnttouch.Location = new System.Drawing.Point(12, 20);
            this.Dnttouch.Name = "Dnttouch";
            this.Dnttouch.Size = new System.Drawing.Size(428, 76);
            this.Dnttouch.TabIndex = 4;
            this.Dnttouch.Text = "Joe\'s Automotive Services";
            
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, -3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(936, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // JoesAutomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dnttouch);
            this.Controls.Add(this.Invoicesbtn);
            this.Controls.Add(this.Partsbtn);
            this.Controls.Add(this.Vehiclebtn);
            this.Controls.Add(this.CustomersBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "JoesAutomotive";
            this.Text = "Joe\'s Automotive Services";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomersBtn;
        private System.Windows.Forms.Button Vehiclebtn;
        private System.Windows.Forms.Button Partsbtn;
        private System.Windows.Forms.Button Invoicesbtn;
        private System.Windows.Forms.Label Dnttouch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

