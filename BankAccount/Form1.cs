using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form
    {
        //variables
        public int amount = 0; //amountBox
        public int balance = 0; //accountBalBox
        public int balanceConv = 0; //accountBal_convBox
        public int clicks = 0; // hepler summary



        public Form1()
        {
            InitializeComponent();
            
        }     

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
           
              

        private void rbtn_deposit_CheckedChanged(object sender, EventArgs e)
        {
         

        }

        private void rbtn_withdrawl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_euro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_dollar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_yuan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            TextBox dynamicTextbox = new TextBox();
            this.Controls.Add(dynamicTextbox);
        }
    }
}
