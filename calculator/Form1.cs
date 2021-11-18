using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class formMain : Form
    {
        bool flagPoint;
        bool flagSymbol;
        bool flagAns;
        double _tempDouble;
        double value1, value2, ans, memory;
        public formMain()
        {
            InitializeComponent();
            InitializeTextAndManer();

        }

        private void InitializeTextAndManer()
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "0";
            ans = 0;
            flagAns = false;
            flagSymbol = false;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.IndexOf('0') == 0 && flagPoint == false)
            {
               
            }
            else if (textBox3.Text == "除数不能为0,按C清除")
            {
                textBox3.Text = "0";
            }
            else if (textBox3.Text.Length <= 22)
            {
                textBox3.Text += number0.Text;
            }
        }
        private void number1_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number1.Text);
        }

        private void number2_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number2.Text);
        }
        private void number3_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number3.Text);
        }

        private void number4_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number4.Text);
        }

        private void number5_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number5.Text);
        }

        private void number6_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number6.Text);
        }
        private void number7_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number7.Text);
        }

        private void number8_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number8.Text);
        }

        private void number9_Click(object sender, EventArgs e)
        {
            buttonNumberFunction(number9.Text);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "除数不能为0,按C清除")
            {
                textBox3.Text = buttonPoint.Text;
            }
            else if (textBox3.Text.IndexOf('.') == -1)
            {
                textBox3.Text += buttonPoint.Text;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0 || textBox3.Text == "0")
            {
                InitializeTextAndManer();
            }
            else textBox3.Text = "0";

        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            InitializeTextAndManer();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            if(textBox3.Text == "除数不能为0,按C清除")
            {
                textBox3.Text = "0";
            }
            else if (textBox3.Text.Length > 1 && textBox3.Text != "0")
            {
                textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
            }
            else if (textBox3.Text.Length == 1)
            {
                textBox3.Text = "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            buttonSymbolFunction(buttonPlus.Text);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            buttonSymbolFunction(buttonSub.Text);
        }

        private void buttonMemory_Click(object sender, EventArgs e)
        {
            if (flagAns)
            {
                memory = ans;
                buttonMemory.BackColor = Color.MediumSpringGreen;
            }
            else if (!flagAns)
            {
                textBox1.Text = memory.ToString("G");
                ans = memory;
                flagAns = true;
            }
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" && flagAns)
            {
                buttonMemory.BackColor = Color.MediumSpringGreen;
                memory += ans;
                textBox1.Text = memory.ToString("G");
            }
        }

        private void buttonMsub_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" && flagAns)
            {
                buttonMemory.BackColor = Color.MediumSpringGreen;
                memory -= ans;
                textBox1.Text = memory.ToString("G");
            }
        }

        private void buttonMc_Click(object sender, EventArgs e)
        {
            memory = 0;
            buttonMemory.BackColor = buttonMc.BackColor;
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {

            }
            else
            {
                _tempDouble = double.Parse(textBox3.Text);
                _tempDouble = 0 - _tempDouble;
                textBox3.Text = _tempDouble.ToString("G");
                _tempDouble = 0;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            buttonSymbolFunction(buttonDiv.Text);
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            buttonSymbolFunction(buttonTimes.Text);
        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "除数不能为0,按C清除")
            {

            }
            else switch (textBox2.Text)
            {
                case "":
                        if (textBox3.Text.Length != 0)
                        {
                            ans = double.Parse(textBox3.Text);
                            flagAns = true;
                            textBox2.Text = "";
                            flagSymbol = false;
                            textBox3.Text = "";
                            textBox1.Text = ans.ToString("G");
                            break;
                        }
                        break;
                case "+":
                        if (textBox3.Text.Length != 0)
                        {
                            value2 = double.Parse(textBox3.Text);
                            ans = value1 + value2;
                            flagAns = true;
                            textBox2.Text = "";
                            flagSymbol = false;
                            textBox3.Text = "";
                            textBox1.Text = ans.ToString("G");
                            break;
                        }
                        break;
                case "-":
                        if (textBox3.Text.Length != 0)
                        {
                        value2 = double.Parse(textBox3.Text);
                        ans = value1 - value2;
                        flagAns = true;
                        textBox2.Text = "";
                        flagSymbol = false;
                        textBox3.Text = "";
                        textBox1.Text = ans.ToString("G");
                        break;
                        }
                        break;
                case "*":
                        if (textBox3.Text.Length != 0)
                        {
                        value2 = double.Parse(textBox3.Text);
                        ans = value1 * value2;
                        flagAns = true;
                        textBox2.Text = "";
                        flagSymbol = false;
                        textBox3.Text = "";
                        textBox1.Text = ans.ToString("G");
                        break;
                        }
                        break;
                case "/":
                        if (textBox3.Text.Length != 0)
                        {
                            if(double.Parse(textBox3.Text) == 0)
                            {
                                textBox3.Text = "除数不能为0,按C清除";
                            }
                            else
                            {
                                value2 = double.Parse(textBox3.Text);
                                ans = value1 / value2;
                                flagAns = true;
                                textBox2.Text = "";
                                flagSymbol = false;
                                textBox3.Text = "";
                                textBox1.Text = ans.ToString("G");
                            }
                            break;
                        }
                        break;
            }
        }

        private void buttonNumberFunction (string buttonText)
        {
            if (textBox3.Text == "0" || textBox3.Text == "除数不能为0,按C清除")
            {
                textBox3.Text = buttonText;
            }
            else if (textBox3.Text.Length <= 22) textBox3.Text += buttonText;
        }

        private void buttonSymbolFunction (string buttonText)
        {
            if (!flagSymbol && textBox3.Text == "" && flagAns)
            {
                value1 = ans;
                textBox2.Text = buttonText;
                flagSymbol = true;
            }
            else if (!flagSymbol)
            {
                value1 = double.Parse(textBox3.Text);
                textBox1.Text = value1.ToString("G");
                textBox2.Text = buttonText;
                textBox3.Text = "";
                flagSymbol = true;
            }
            else if (flagSymbol)
            {
                buttonEqual_Click(null, null);
                value1 = ans;
                textBox2.Text = buttonText;
                flagSymbol = true;
            }
        }
    }
}
