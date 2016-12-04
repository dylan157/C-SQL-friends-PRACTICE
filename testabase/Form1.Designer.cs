namespace testabase
{
    partial class Friends
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.Addstuff = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.surnamebox = new System.Windows.Forms.TextBox();
            this.addrbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(60, 154);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(77, 132);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(144, 154);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(81, 132);
            this.lb2.TabIndex = 1;
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.ItemHeight = 16;
            this.lb3.Location = new System.Drawing.Point(231, 154);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(224, 132);
            this.lb3.TabIndex = 2;
            // 
            // Addstuff
            // 
            this.Addstuff.Location = new System.Drawing.Point(380, 11);
            this.Addstuff.Name = "Addstuff";
            this.Addstuff.Size = new System.Drawing.Size(75, 67);
            this.Addstuff.TabIndex = 3;
            this.Addstuff.Text = "Add Friend";
            this.Addstuff.UseVisualStyleBackColor = true;
            this.Addstuff.Click += new System.EventHandler(this.button1_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(124, 12);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(250, 22);
            this.namebox.TabIndex = 4;
            // 
            // surnamebox
            // 
            this.surnamebox.Location = new System.Drawing.Point(124, 41);
            this.surnamebox.Name = "surnamebox";
            this.surnamebox.Size = new System.Drawing.Size(250, 22);
            this.surnamebox.TabIndex = 5;
            // 
            // addrbox
            // 
            this.addrbox.Location = new System.Drawing.Point(124, 69);
            this.addrbox.Multiline = true;
            this.addrbox.Name = "addrbox";
            this.addrbox.Size = new System.Drawing.Size(250, 47);
            this.addrbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete Friend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addrbox);
            this.Controls.Add(this.surnamebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.Addstuff);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Friends";
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Friends_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.Button Addstuff;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox surnamebox;
        private System.Windows.Forms.TextBox addrbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

