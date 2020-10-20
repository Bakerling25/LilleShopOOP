namespace LitlleShop_WF
{
    partial class Front
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNameTXT = new System.Windows.Forms.TextBox();
            this.LastNameTXT = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SubmitCustomerBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowCustomersBtn = new System.Windows.Forms.Button();
            this.NameOFCustomerLabel = new System.Windows.Forms.Label();
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.DeleteTXT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameTXT
            // 
            this.FirstNameTXT.Location = new System.Drawing.Point(6, 37);
            this.FirstNameTXT.Name = "FirstNameTXT";
            this.FirstNameTXT.Size = new System.Drawing.Size(100, 23);
            this.FirstNameTXT.TabIndex = 0;
            // 
            // LastNameTXT
            // 
            this.LastNameTXT.Location = new System.Drawing.Point(6, 81);
            this.LastNameTXT.Name = "LastNameTXT";
            this.LastNameTXT.Size = new System.Drawing.Size(100, 23);
            this.LastNameTXT.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 19);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(50, 15);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "Fornavn";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 63);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(57, 15);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Efternavn";
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(6, 125);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(100, 23);
            this.EmailTXT.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(6, 107);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 15);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // SubmitCustomerBtn
            // 
            this.SubmitCustomerBtn.Location = new System.Drawing.Point(6, 163);
            this.SubmitCustomerBtn.Name = "SubmitCustomerBtn";
            this.SubmitCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitCustomerBtn.TabIndex = 6;
            this.SubmitCustomerBtn.Text = "Submit Customer";
            this.SubmitCustomerBtn.UseVisualStyleBackColor = true;
            this.SubmitCustomerBtn.Click += new System.EventHandler(this.SubmitCustomerBtn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 239);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(60, 15);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "ErrorLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.SubmitCustomerBtn);
            this.groupBox1.Controls.Add(this.FirstNameTXT);
            this.groupBox1.Controls.Add(this.EmailTXT);
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Controls.Add(this.LastNameTXT);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 224);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tilføj Ny Kunde";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(13, 285);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(53, 15);
            this.MessageLabel.TabIndex = 9;
            this.MessageLabel.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowCustomersBtn);
            this.groupBox2.Controls.Add(this.NameOFCustomerLabel);
            this.groupBox2.Controls.Add(this.DeleteCustomerBtn);
            this.groupBox2.Controls.Add(this.DeleteTXT);
            this.groupBox2.Location = new System.Drawing.Point(214, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 224);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slet Kunde";
            // 
            // ShowCustomersBtn
            // 
            this.ShowCustomersBtn.Location = new System.Drawing.Point(7, 124);
            this.ShowCustomersBtn.Name = "ShowCustomersBtn";
            this.ShowCustomersBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowCustomersBtn.TabIndex = 3;
            this.ShowCustomersBtn.Text = "Vis kunder";
            this.ShowCustomersBtn.UseVisualStyleBackColor = true;
            this.ShowCustomersBtn.Click += new System.EventHandler(this.ShowCustomersBtn_Click);
            // 
            // NameOFCustomerLabel
            // 
            this.NameOFCustomerLabel.AutoSize = true;
            this.NameOFCustomerLabel.Location = new System.Drawing.Point(6, 19);
            this.NameOFCustomerLabel.Name = "NameOFCustomerLabel";
            this.NameOFCustomerLabel.Size = new System.Drawing.Size(94, 15);
            this.NameOFCustomerLabel.TabIndex = 2;
            this.NameOFCustomerLabel.Text = "Navn på kunden";
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(6, 163);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteCustomerBtn.TabIndex = 1;
            this.DeleteCustomerBtn.Text = "Slet";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = true;
            this.DeleteCustomerBtn.Click += new System.EventHandler(this.DeleteCustomerBtn_Click);
            // 
            // DeleteTXT
            // 
            this.DeleteTXT.Location = new System.Drawing.Point(6, 37);
            this.DeleteTXT.Name = "DeleteTXT";
            this.DeleteTXT.Size = new System.Drawing.Size(100, 23);
            this.DeleteTXT.TabIndex = 0;
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ErrorLabel);
            this.Name = "Front";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Front_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTXT;
        private System.Windows.Forms.TextBox LastNameTXT;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button SubmitCustomerBtn;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NameOFCustomerLabel;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.TextBox DeleteTXT;
        private System.Windows.Forms.Button ShowCustomersBtn;
    }
}

