using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        public void disable()// create one method to disable calculator
        {
            // following are disabled when we call disable function
            TextBox1.Enabled = false;
            button1.Show();
            button3.Hide();
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button19.Enabled = false;
            button17.Enabled = false;
        }
        public void Enable()// create one method to disable calculator
        {
            // following are disabled when we call disable function
            TextBox1.Enabled = true;
            button1.Show();
            button3.Hide();
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button18.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button19.Enabled = true;
            button17.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            // diplayed dot (.) in text box when press . button with red
            TextBox1.Text = TextBox1.Text + ".";
            TextBox1.ForeColor = Color.Red;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // diplayed 0 in text box when press 0  button with red
            TextBox1.Text = TextBox1.Text + 0;
            TextBox1.ForeColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // diplayed 0 in text box when press 0  button with red
            TextBox1.Text = TextBox1.Text + 1;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // diplayed 2 in text box when press 2 button with red
            TextBox1.Text = TextBox1.Text + 2;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // diplayed 3 in text box when press 3  button with red
            TextBox1.Text = TextBox1.Text + 3;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // diplayed 4 in text box when press 4  button with red
            TextBox1.Text = TextBox1.Text + 4;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // diplayed 5 in text box when press 5  button with red
            TextBox1.Text = TextBox1.Text + 5;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // diplayed 6 in text box when press 6  button with red
            TextBox1.Text = TextBox1.Text + 6;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // diplayed 7 in text box when press 7  button with red
            TextBox1.Text = TextBox1.Text + 7;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // diplayed 8 in text box when press 8  button with red
            TextBox1.Text = TextBox1.Text + 8;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // diplayed 9 in text box when press 9 button with red
            TextBox1.Text = TextBox1.Text + 9;
            TextBox1.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)// off button 
        {
            disable();    //call disa ble 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enable();   // call enable function to enable the calculator
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            TextBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            num = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            TextBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            TextBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            num = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            TextBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            compute();    // call compute method 
            label1.Text = "";    // clear the text 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int length = TextBox1.TextLength - 1;
            string text = TextBox1.Text;
            TextBox1.Clear();
            for (int i = 0; i < length; i++)
                TextBox1.Text = TextBox1.Text + text[i];
        }

        public void compute()
        { 
        switch(count)
            {
                case 1:
                    ans = num + float.Parse(TextBox1.Text);
                    TextBox1.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(TextBox1.Text);
                    TextBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(TextBox1.Text);
                    TextBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(TextBox1.Text);
                    TextBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }



        }

    }
}
