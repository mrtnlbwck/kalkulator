using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace kalkulatorxd
{

    public partial class Form3 : Form
    {       

    

        Bitmap clock, hour, minute, second;

        private void secondBox_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            int Hour = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            Single AngleSecond = Second * 6;
            Single AngleMinute = Minute * 6 + AngleSecond / 60;
            Single AngleHour = Hour * 30 + AngleMinute / 12;

            clockBox.Image = clock;
            clockBox.Location = new Point(25, 24);

            clockBox.Controls.Add(hourBox);
            hourBox.Location = new Point(0, 0);
            hourBox.Image = rotate(hour, AngleHour);


            hourBox.Controls.Add(minuteBox);
            minuteBox.Location = new Point(0, 0);
            minuteBox.Image = rotate(minute, AngleMinute);

            minuteBox.Controls.Add(secondBox);
            secondBox.Location = new Point(0, 0);
            secondBox.Image = rotate(second, AngleSecond);

            GC.Collect();

        }

        public Form3(Form2 Okno1)
        {
            InitializeComponent();
            this.okno3 = Okno1;
            InitializeComponent();

            clock = new Bitmap(".\\zegar.png");
            hour = new Bitmap(".\\godzinnik.png");
            minute = new Bitmap(".\\minutnik.png");
            second = new Bitmap(".\\sekundnik.png");
        }

        private Bitmap rotate(Bitmap rotateHand, float angle)
        {
            Bitmap rotateClock = new Bitmap(rotateHand.Width, rotateHand.Height);

            using (Graphics g = Graphics.FromImage(rotateClock))
            {
                g.TranslateTransform(rotateHand.Width / 2, rotateHand.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateHand.Width / 2, -rotateHand.Height / 2);
                g.DrawImage(rotateHand, new Point(0, 0));
            }

            return rotateClock;
        }


    }
}
