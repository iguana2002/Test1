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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                listBox1.Items.Add("Один из параметров не задан!");
            }
            else
            {
                try
                {
                    double x0 = Convert.ToDouble(textBox1.Text);
                    double x2 = Convert.ToDouble(textBox2.Text);
                    double step = Convert.ToDouble(textBox3.Text);
                    double y;
                    if (x0 < x2)
                    {
                        while (x0 <= x2)
                        {
                            double d = Math.Pow(x0, 2) - 1;
                            if (d != 0)
                            {
                                y = 5 * Math.Pow(x0, 3) / (Math.Pow(x0, 2) - 1);
                                listBox1.Items.Add(string.Format($"при х={x0:f3}, y = {y:f3}"));
                            }
                            else
                            {
                                listBox1.Items.Add(string.Format($"при х={x0:f3} - не существует"));
                            }
                            x0 += step;
                        }
                    }
                    else
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Начальное значение больше конечного!");
                    }
                }
                catch
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Один из параметров задан не числом!");
                }
            }
        }
    }
}
