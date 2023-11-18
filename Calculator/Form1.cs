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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        string message = "Please fill necessary value";
        double firstNumber = 0, secondNumber = 0;
        bool control = false;

        void setPara1(string text)
        {
            if(text.Trim() != "")
            {
                control = true;
                firstNumber=Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }
        }
        void setPara2(string text1, string text2)
        {
            if(text1.Trim() != "" && text2.Trim()!="")
            {
                control = true;
                firstNumber = Convert.ToDouble(text1);
                secondNumber = Convert.ToDouble(text2);
            }
            else
            {
                control = false;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {

            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void AbsBtn_Click(object sender, EventArgs e)
        {
            setPara1(txtBox1.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            txtBox3.Text = Math.Abs(firstNumber).ToString();
        }

        private void ExpBtn_Click(object sender, EventArgs e)
        {
            setPara1(txtBox1.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            txtBox3.Text = Math.Exp(firstNumber).ToString();
        }

        private void SinBtn_Click(object sender, EventArgs e)
        {
            setPara1(txtBox1.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber / (Math.PI)) / 180;
                txtBox3.Text = Math.Sin(temp).ToString();
            }
            
        }

        private void CosBtn_Click(object sender, EventArgs e)
        {
            setPara1(txtBox1.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber / (Math.PI)) / 180;
                txtBox3.Text = Math.Cos(temp).ToString();
            }
        }

        private void TanBtn_Click(object sender, EventArgs e)
        {
            setPara1(txtBox1.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber / (Math.PI)) / 180;
                txtBox3.Text = Math.Tan(temp).ToString();
            }
        }

        private void PowBtn_Click(object sender, EventArgs e)
        {
            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = Math.Pow(firstNumber, secondNumber).ToString();
            }
        }

        private void SqrtBtn_Click(object sender, EventArgs e)
        {
            setPara1(txtBox1.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            txtBox3.Text = Math.Sqrt(firstNumber).ToString();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = Math.Log(firstNumber, secondNumber).ToString();
            }
        }

        private void Log10Btn_Click(object sender, EventArgs e)
        {
            setPara1(txtBox1.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = Math.Log10(firstNumber).ToString();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = (Convert.ToDecimal(firstNumber)+Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = (Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = (Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            setPara2(txtBox1.Text, txtBox2.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtBox3.Text = (Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            control = false;
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();

            firstNumber = 0;
            secondNumber = 0;
        }

        
    }
}
