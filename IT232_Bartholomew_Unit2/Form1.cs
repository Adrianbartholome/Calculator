using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT232_Bartholomew_Unit2
{
    public partial class Form1 : Form
    {
        //initiate required variables
        bool dot = false;
        bool err = false;
        bool equaled = false;
        string op = "";
        string first = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void button_1(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "1";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "1";
                    }
                }
            }
        }

        private void button_2(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "2";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "2";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "2";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "2";
                    }
                }
            }
        }

        private void button_3(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "3";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "3";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";
                    }
                }
            }
        }
        private void button_4(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "4";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "4";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "4";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "4";
                    }
                }
            }
        }

        private void button_5(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "5";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "5";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "5";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "5";
                    }
                }
            }
        }

        private void button_6(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "6";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "6";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "6";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "6";
                    }
                }
            }
        }

        private void button_7(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "7";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "7";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "7";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "7";
                    }
                }
            }
        }

        private void button_8(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "8";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "8";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "8";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "8";
                    }
                }
            }
        }

        private void button_9(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "9";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "9";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "9";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "9";
                    }
                }
            }
        }

        private void button_0(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (op == "")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "0";
                    }
                }
                else
                {
                    if (textBox1.Text + op == first)
                    {
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "0";
                    }
                }
            }
        }

        //dot variable only allows one decimal per number
        private void button_Dot(object sender, EventArgs e)
        {
            if ((err == false) && (equaled == false))
            {
                if (textBox1.Text.Contains('.'))
                {
                    dot = true;
                }
                if (dot == false)
                {
                    textBox1.Text = textBox1.Text + ".";
                    dot = true;
                }
            }
        }

        private void button_Divide(object sender, EventArgs e)
        {
            if (err == false)
            {
                if (first.Contains('+') || first.Contains('-') || first.Contains('*') || first.Contains('/'))
                {
                    first = first + textBox1.Text;
                    textBox1.Text = Convert.ToString(new DataTable().Compute(first, null));
                    first = textBox1.Text;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else
                {
                    dot = false;
                    op = "/";
                    first = textBox1.Text + op;
                }
                equaled = false;
            }
        }

        private void button_Multiply(object sender, EventArgs e)
        {
            if (err == false)
            {
                if (first.Contains('+') || first.Contains('-') || first.Contains('*') || first.Contains('/'))
                {
                    first = first + textBox1.Text;
                    textBox1.Text = Convert.ToString(new DataTable().Compute(first, null));
                    first = textBox1.Text;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else
                {
                    dot = false;
                    op = "*";
                    first = textBox1.Text + op;
                }
                equaled = false;
            }
        }

        private void button_Subtract(object sender, EventArgs e)
        {
            if (err == false)
            {
                if (first.Contains('+') || first.Contains('-') || first.Contains('*') || first.Contains('/'))
                {
                    first = first + textBox1.Text;
                    textBox1.Text = Convert.ToString(new DataTable().Compute(first, null));
                    first = textBox1.Text;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else
                {
                    dot = false;
                    op = "-";
                    first = textBox1.Text + op;
                }
                equaled = false;
            }
        }

        private void button_Add(object sender, EventArgs e)
        {
            if (err == false)
            {
                if (first.Contains('+') || first.Contains('-') || first.Contains('*') || first.Contains('/'))
                {
                    first = first + textBox1.Text;
                    textBox1.Text = Convert.ToString(new DataTable().Compute(first, null));
                    first = textBox1.Text;
                }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0";
                }
                else
                {
                    dot = false;
                    op = "+";
                    first = textBox1.Text + op;
                }
                equaled = false;
            }
        }

        //resets all variables to beginning state
        private void button_Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            dot = false;
            err = false;
            equaled = false;
            first = "";
            op = "";
        }

        //error if digits go past screen. This is to help keep results readable and lower the
        //number of possible stack overflows on large calculations
        private void overflow_Error(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 19)
            {
                textBox1.Text = "ERROR";
                err = true;
            }
        }

        //equaled variable keeps the result from being manipulated until another operator is pressed
        private void button_Equals(object sender, EventArgs e)
        {
            if (err == false)
            {
                if (textBox1.Text != first)
                {
                    first = first + textBox1.Text;
                    textBox1.Text = Convert.ToString(new DataTable().Compute(first, null));
                    first = textBox1.Text;
                    op = "";
                }
                else
                {
                    textBox1.Text = first;
                }
                equaled = true;
            }
        }
    }
}
