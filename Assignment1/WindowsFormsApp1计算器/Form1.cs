using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double n1, n2;//设置两个数字
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.BackColor = SystemColors.Control;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox3.Text = "请输入第一个数字";
            textBox4.Text = "请输入第二个数字";
            textBox5.Text = "计算结果为：";
            textBox7.Text = "请选择要进行的计算操作：";
            button1.Text = "开始";
            button2.Text = "  +  ";
            button3.Text = "  -  ";
            button4.Text = "  *  ";
            button5.Text = "  /  ";
            label1.Text = "点击开始键可重置";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.Gray;
            string s1 = "";
            s1 = textBox1.Text;
            if (textBox1.Text != "")
            {
                n1 = double.Parse(s1);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.BackColor = SystemColors.Control;
            string s1 = "";
            s1 = textBox2.Text;
            if (textBox1.Text != "")
            {
                n2 = double.Parse(s1);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = n1 + n2;
            string s = Convert.ToString(temp);
            textBox6.Text= s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double temp = n1 - n2;
            string s = Convert.ToString(temp);
            textBox6.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double temp = n1 * n2;
            string s = Convert.ToString(temp);
            textBox6.Text = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double temp = n1 / n2;
            string s = Convert.ToString(temp);
            textBox6.Text = s;
        }

    }
}
