using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str = "";
        double  FirstNumber;
        double SecondNumber;
        double Answer;
        string operators = "";
        private void button5_Click(object sender, EventArgs e)
        {
            
            str = str + button5.Text;
            textBox1.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            str = str + button6.Text;
            textBox1.Text = str;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            str = str + button7.Text;
            textBox1.Text = str;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            str = str + button9.Text;
            textBox1.Text = str;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            str = str + button10.Text;
            textBox1.Text = str;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            str = str + button11.Text;
            textBox1.Text = str;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            str = str + button13.Text;
            textBox1.Text = str;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            str = str + button14.Text;
            textBox1.Text = str;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            str = str + button15.Text;
            textBox1.Text = str;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            str = str + button17.Text;
            textBox1.Text = str;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            str = str + button18.Text;
            textBox1.Text = str;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            str = str + button19.Text;
            textBox1.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = double.Parse(textBox1.Text);
                str = "";
                label1.Text = label1.Text + " " + textBox1.Text;
                textBox1.Clear();
                operators = button4.Text;
                textBox1.Text =operators;
                label1.Text = label1.Text + " " + textBox1.Text;

            }
            catch(Exception )
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                FirstNumber = double.Parse(textBox1.Text);
                str = "";
                label1.Text = label1.Text + " " + textBox1.Text;
                textBox1.Clear();
                operators = button8.Text;
                textBox1.Text = operators;
                label1.Text = label1.Text + " " + textBox1.Text;

            }
            catch(Exception )
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            try
            {
                FirstNumber = double.Parse(textBox1.Text);
                str = "";
                label1.Text = label1.Text + " " + textBox1.Text;
                textBox1.Clear();
                operators = button12.Text;
                textBox1.Text = operators;
                label1.Text = label1.Text + " " + textBox1.Text;

            }
            catch (Exception )
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            try
            {
                FirstNumber = double.Parse(textBox1.Text);
                str = "";
                label1.Text = label1.Text + " " + textBox1.Text;
                textBox1.Clear();
                operators = button16.Text;
                textBox1.Text = operators;
                label1.Text = label1.Text + " " + textBox1.Text;

            }
            catch (Exception )
            {

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if(FirstNumber >0)
                {
                    SecondNumber = double.Parse(textBox1.Text);
                    label1.Text = label1.Text + " " + textBox1.Text;
                }
                switch(operators)
                {
                    case "/":
                        Answer =FirstNumber/SecondNumber;
                        break;


                    case "-":
                        Answer = FirstNumber - SecondNumber;
                        break;


                    case "+":
                        Answer = FirstNumber + SecondNumber;
                        break;


                    case "*":
                        Answer = FirstNumber * SecondNumber;
                        break;

                        default:
                        break;
                }
                textBox1.Text = Answer.ToString();
                str = "";
                label1.Text = label1.Text + "=" + textBox1.Text;


            }
            catch(Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                s = s.Substring(0, textBox1.Text.Length - 1);
                textBox1.Text = s;
                str = str.Substring(0, textBox1.Text.Length - 1);
            }
            catch(Exception)
            {

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = "";
            textBox1.Clear();
            FirstNumber = 0;
            SecondNumber = 0;
            label1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            str = "";
            textBox1.Clear();
            FirstNumber = 0;
            SecondNumber = 0;
            label1.Text = "";
        }
    }
}
