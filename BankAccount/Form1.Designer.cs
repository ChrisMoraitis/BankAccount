namespace BankAccount
{
    partial class Form1
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
            this.rbtn_deposit = new System.Windows.Forms.RadioButton();
            this.rbtn_withdrawl = new System.Windows.Forms.RadioButton();
            this.rbtn_check = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_yuan = new System.Windows.Forms.RadioButton();
            this.rbtn_dollar = new System.Windows.Forms.RadioButton();
            this.rbtn_euro = new System.Windows.Forms.RadioButton();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_summary = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.accountBalBox = new System.Windows.Forms.TextBox();
            this.accountBal_convBox = new System.Windows.Forms.TextBox();
            this.btn_notes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_deposit
            // 
            this.rbtn_deposit.AutoSize = true;
            this.rbtn_deposit.Checked = true;
            this.rbtn_deposit.Location = new System.Drawing.Point(36, 24);
            this.rbtn_deposit.Name = "rbtn_deposit";
            this.rbtn_deposit.Size = new System.Drawing.Size(96, 27);
            this.rbtn_deposit.TabIndex = 0;
            this.rbtn_deposit.TabStop = true;
            this.rbtn_deposit.Text = "Deposit";
            this.rbtn_deposit.UseVisualStyleBackColor = true;
            this.rbtn_deposit.CheckedChanged += new System.EventHandler(this.rbtn_deposit_CheckedChanged);
            // 
            // rbtn_withdrawl
            // 
            this.rbtn_withdrawl.AutoSize = true;
            this.rbtn_withdrawl.Location = new System.Drawing.Point(36, 99);
            this.rbtn_withdrawl.Name = "rbtn_withdrawl";
            this.rbtn_withdrawl.Size = new System.Drawing.Size(120, 27);
            this.rbtn_withdrawl.TabIndex = 1;
            this.rbtn_withdrawl.Text = "Withdrawl";
            this.rbtn_withdrawl.UseVisualStyleBackColor = true;
            this.rbtn_withdrawl.CheckedChanged += new System.EventHandler(this.rbtn_withdrawl_CheckedChanged);
            // 
            // rbtn_check
            // 
            this.rbtn_check.AutoSize = true;
            this.rbtn_check.Location = new System.Drawing.Point(36, 166);
            this.rbtn_check.Name = "rbtn_check";
            this.rbtn_check.Size = new System.Drawing.Size(160, 27);
            this.rbtn_check.TabIndex = 2;
            this.rbtn_check.Text = "Check Account";
            this.rbtn_check.UseVisualStyleBackColor = true;
            this.rbtn_check.CheckedChanged += new System.EventHandler(this.rbtn_check_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(916, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.rbtn_check);
            this.panel1.Controls.Add(this.rbtn_withdrawl);
            this.panel1.Controls.Add(this.rbtn_deposit);
            this.panel1.Location = new System.Drawing.Point(61, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 226);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose your action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose your currency";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.rbtn_yuan);
            this.panel2.Controls.Add(this.rbtn_dollar);
            this.panel2.Controls.Add(this.rbtn_euro);
            this.panel2.Location = new System.Drawing.Point(505, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 226);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rbtn_yuan
            // 
            this.rbtn_yuan.AutoSize = true;
            this.rbtn_yuan.Location = new System.Drawing.Point(36, 166);
            this.rbtn_yuan.Name = "rbtn_yuan";
            this.rbtn_yuan.Size = new System.Drawing.Size(184, 27);
            this.rbtn_yuan.TabIndex = 2;
            this.rbtn_yuan.Text = "Chinese Yuan - 元";
            this.rbtn_yuan.UseVisualStyleBackColor = true;
            this.rbtn_yuan.CheckedChanged += new System.EventHandler(this.rbtn_yuan_CheckedChanged);
            // 
            // rbtn_dollar
            // 
            this.rbtn_dollar.AutoSize = true;
            this.rbtn_dollar.Location = new System.Drawing.Point(36, 99);
            this.rbtn_dollar.Name = "rbtn_dollar";
            this.rbtn_dollar.Size = new System.Drawing.Size(151, 27);
            this.rbtn_dollar.TabIndex = 1;
            this.rbtn_dollar.Text = "U.S. Dollar - $";
            this.rbtn_dollar.UseVisualStyleBackColor = true;
            this.rbtn_dollar.CheckedChanged += new System.EventHandler(this.rbtn_dollar_CheckedChanged);
            // 
            // rbtn_euro
            // 
            this.rbtn_euro.AutoSize = true;
            this.rbtn_euro.Checked = true;
            this.rbtn_euro.Location = new System.Drawing.Point(36, 24);
            this.rbtn_euro.Name = "rbtn_euro";
            this.rbtn_euro.Size = new System.Drawing.Size(99, 27);
            this.rbtn_euro.TabIndex = 0;
            this.rbtn_euro.TabStop = true;
            this.rbtn_euro.Text = "Euro - €";
            this.rbtn_euro.UseVisualStyleBackColor = true;
            this.rbtn_euro.CheckedChanged += new System.EventHandler(this.rbtn_euro_CheckedChanged);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(916, 336);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(284, 41);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_summary
            // 
            this.btn_summary.Location = new System.Drawing.Point(916, 420);
            this.btn_summary.Name = "btn_summary";
            this.btn_summary.Size = new System.Drawing.Size(284, 41);
            this.btn_summary.TabIndex = 9;
            this.btn_summary.Text = "Summary";
            this.btn_summary.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(916, 571);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(284, 41);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Transaction Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Account Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Auto Convertion";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Location = new System.Drawing.Point(505, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 226);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(184, 27);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Chinese Yuan - 元";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(36, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "U.S. Dollar - $";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(36, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 27);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Euro - €";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(97, 420);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(228, 32);
            this.amountBox.TabIndex = 16;
            this.amountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // accountBalBox
            // 
            this.accountBalBox.Location = new System.Drawing.Point(97, 577);
            this.accountBalBox.Name = "accountBalBox";
            this.accountBalBox.ReadOnly = true;
            this.accountBalBox.Size = new System.Drawing.Size(228, 32);
            this.accountBalBox.TabIndex = 17;
            this.accountBalBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // accountBal_convBox
            // 
            this.accountBal_convBox.Location = new System.Drawing.Point(531, 577);
            this.accountBal_convBox.Name = "accountBal_convBox";
            this.accountBal_convBox.ReadOnly = true;
            this.accountBal_convBox.Size = new System.Drawing.Size(228, 32);
            this.accountBal_convBox.TabIndex = 18;
            this.accountBal_convBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_notes
            // 
            this.btn_notes.Location = new System.Drawing.Point(916, 495);
            this.btn_notes.Name = "btn_notes";
            this.btn_notes.Size = new System.Drawing.Size(284, 41);
            this.btn_notes.TabIndex = 19;
            this.btn_notes.Text = "Notes";
            this.btn_notes.UseVisualStyleBackColor = true;
            this.btn_notes.Click += new System.EventHandler(this.btn_notes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 653);
            this.Controls.Add(this.btn_notes);
            this.Controls.Add(this.accountBal_convBox);
            this.Controls.Add(this.accountBalBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_summary);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Bank Account Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_deposit;
        private System.Windows.Forms.RadioButton rbtn_withdrawl;
        private System.Windows.Forms.RadioButton rbtn_check;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtn_yuan;
        private System.Windows.Forms.RadioButton rbtn_dollar;
        private System.Windows.Forms.RadioButton rbtn_euro;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_summary;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox accountBalBox;
        private System.Windows.Forms.TextBox accountBal_convBox;
        private System.Windows.Forms.Button btn_notes;
    }
}

