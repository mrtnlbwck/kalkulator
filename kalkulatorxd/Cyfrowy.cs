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
    public partial class Cyfrowy : Form
    {
        public Cyfrowy(Kalkulator Okno)
        {
            InitializeComponent();
            this.okno1 = Okno;

        }

   
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Size = new Size(445, 263);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            changeColor(this.label1, Color.Brown);

        }

        private void changeFont(Label label, String font_name)
        {

            if (label.Font.Name == font_name)
            {
                
            label.Font = new Font("OCR A Extended", label.Font.Size);
            }
            else
            {
            label.Font = new Font(font_name, label.Font.Size);
            }
        }

        

        private void changeColor(Label label, Color color)
        {
            if (label.ForeColor == color)
            {
                if (BackColor == Color.Black)
                {
                    label.ForeColor = Color.White;

                }
                else { label.ForeColor = Color.Black; }
                
            }
            else
            {
                label.ForeColor = color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeColor(this.label1, Color.DarkOrchid);            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeColor(this.label1, Color.LightPink);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeColor(this.label1, Color.OrangeRed);

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            changeFont(this.label1, "Niagara Engraved");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            changeFont(this.label1, "Snap ITC"); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            changeFont(this.label1, "Rockwell Condensed"); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            changeFont(this.label1, "Bodoni MT Condensed"); 
        }

        private void button1_Click(object sender, EventArgs e)        {
            if (BackColor == Color.Black)
            {
                this.button1.Text = "Ciemny tryb";
            }
            else
            {
                this.button1.Text = "Jasny tryb";
            }
            changeBackColor(Color.Black);
            changeColor(this.label1, Color.White);
            
        }

        private void changeBackColor(Color color) 
        {
            if (this.BackColor == color)
            {
                BackColor = Color.LavenderBlush;
            }
            else {
                this.BackColor = color;
            }
        }

        
    }
}
