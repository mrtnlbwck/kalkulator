using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorxd
{
    public partial class Kalkulator : Form
    {


        Double firstValue = 0; //pierwsza podana wartość
        Double secendValue = 0; //druga podana wartość
        Double Result = 0; //wynik
        String operationPerformed = ""; //
        bool isOperationPerformed = false;

        public Kalkulator()
        {
            KeyPreview = true;
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void trybLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBackColor(Color.LavenderBlush);
            changeButtonBackColor(button1, Color.Snow);
            changeButtonBackColor(button2, Color.Snow);
            changeButtonBackColor(button3, Color.Snow);
            changeButtonBackColor(button4, Color.Snow);
            changeButtonBackColor(button5, Color.Snow);
            changeButtonBackColor(button6, Color.Snow);
            changeButtonBackColor(button7, Color.Snow);
            changeButtonBackColor(button8, Color.Snow);
            changeButtonBackColor(button9, Color.Snow);
            changeButtonBackColor(button17, Color.Snow);
            changeButtonBackColor(button15, Color.Pink);
            textBox1.BackColor = Color.Snow;
            textBox1.ForeColor = Color.Black;
        }

        private void zegarCyfrowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.okno2 = new Cyfrowy(this);
            this.okno2.ShowDialog();
            
           
        }

        private void zegarAnalogowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analogowy okno4 = new Analogowy();
            okno4.Show();


        }

        

        private void NumberClickButton(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = string.Empty;
            }

            if  (isOperationPerformed)            {
                
                textBox1.Text = string.Empty;
            }

            isOperationPerformed = false;
            Button button = (Button)sender;         

            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text += button.Text;
                }
            }
            else 
            {
                textBox1.Text += button.Text;
            }            
        }

        private void operationClickButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            firstValue = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
            labelCurrentOperation.Text = firstValue + " " + operationPerformed;


        }

        private void kalkulator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                this.button1.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                this.button2.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                this.button3.PerformClick();
            }
            if (e.KeyChar == '4')
            {
                this.button4.PerformClick();
            }
            if (e.KeyChar == '5')
            {
                this.button5.PerformClick();
            }
            if (e.KeyChar == '6')
            {
                this.button6.PerformClick();
            }
            if (e.KeyChar == '7')
            {
                this.button7.PerformClick();
            }
            if (e.KeyChar == '8')
            {
                this.button8.PerformClick();
            }
            if (e.KeyChar == '9')
            {
                this.button9.PerformClick();
            }
            if (e.KeyChar == '%')
            {
                this.button10.PerformClick();
            }
            if (e.KeyChar == '/')
            {
                this.button11.PerformClick();
            }
            if (e.KeyChar == 'x')
            {
                this.button12.PerformClick();
            }
            if (e.KeyChar == '-')
            {
                this.button13.PerformClick();
            }
            if (e.KeyChar == '+')
            {
                this.button14.PerformClick();
            }
            if (e.KeyChar == '=')
            {
                this.button15.PerformClick();
            }
            if (e.KeyChar == ',')
            {
                this.button16.PerformClick();
            }
            if (e.KeyChar == '0')
            {
                this.button17.PerformClick();
            }


        }


        private void CEButtonClick(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            } 
            else 
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void ClearAllButtonClick(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstValue = 0;
        }
        
        private void ResultButtonClick(object sender, EventArgs e)
        {
            
            labelCurrentOperation.Text = "";           
            switch (operationPerformed)
            {               
                case "+":
                    textBox1.Text = (firstValue + Double.Parse(textBox1.Text)).ToString();                   
                    break;
                case "-":
                    textBox1.Text = (firstValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    secendValue = Double.Parse(textBox1.Text);
                    Result = firstValue / secendValue;
                    textBox1.Text = Result.ToString();

                    if (secendValue == 0) {
                        textBox1.Text = "Nie można dzielić przez zero!";
                    }

                    break;
                case "x":
                    textBox1.Text = (firstValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "%":
                    textBox1.Text = (firstValue % Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;              


            }
           


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Size = new Size(290, 490);
        }

        private void trybDarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBackColor(Color.Black);
            changeButtonBackColor(button1, Color.Silver);
            changeButtonBackColor(button2, Color.Silver);
            changeButtonBackColor(button3, Color.Silver);
            changeButtonBackColor(button4, Color.Silver);
            changeButtonBackColor(button5, Color.Silver);
            changeButtonBackColor(button6, Color.Silver);
            changeButtonBackColor(button7, Color.Silver);
            changeButtonBackColor(button8, Color.Silver);
            changeButtonBackColor(button9, Color.Silver);
            changeButtonBackColor(button17, Color.Silver);
            changeButtonBackColor(button15, Color.Gray);
            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Black;
            

        }




        private void changeBackColor(Color color)
            {
            if (this.BackColor == color)
            {
                BackColor = Color.MistyRose;
            }
            else
            {
                this.BackColor = color;
            }
            }

        private void changeButtonBackColor(Button button, Color color)
        {
            if (button.BackColor == color)
            {
                BackColor = Color.LavenderBlush;
            }
            else
            {
               button.BackColor = color;
            }
        }

        
    }
}
