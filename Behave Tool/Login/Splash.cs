using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static Behave_Tool.Rainbow;

namespace Behave_Tool
{
    public partial class Splash : Form
    {   // morning
        TimeSpan morningStart = new TimeSpan(02, 00, 00);
        TimeSpan morningEnd = new TimeSpan(11, 59, 59);
        // afternoon
        TimeSpan afternoonStart = new TimeSpan(13, 00, 00);
        TimeSpan afternoonEnd = new TimeSpan(17, 59, 59);
        // evening
        TimeSpan eveningStart = new TimeSpan(18, 00, 00);
        TimeSpan eveningEnd = new TimeSpan(22, 59, 59);
        TimeSpan nightStart = new TimeSpan(23, 00, 00);
        TimeSpan nightEnd = new TimeSpan(01, 59, 59);

        public static TimeSpan now = DateTime.Now.TimeOfDay;
        Image loading = (Image)Properties.Resources.Loading_Gif.Clone();

        public Splash()
        {
            InitializeComponent();
        }
        private void animation()
        {
            while (true)
            {
                for (double i = 0; i < 1; i += 0.01)
                {
                    ColorRGB c = HSL2RGB(i, 0.5, 0.5);
                    label1.ForeColor = c;
                    Thread.Sleep(30);
                }
            }
        }




        private void Splash_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Behave_Icon;
            SmartLabel.Text = remark();

            pictureBox1.Image = loading;
            new Thread(new ThreadStart(animation))
            {
                IsBackground = true
            }.Start();
        }

        private string remark()
        {
            string _name;
            string remark = null;
            Random rand = new Random();
            int randomNumber = rand.Next(0, 1);
            if (randomNumber == 0)
            {
                if ((now >= morningStart) && (now <= morningEnd)) { remark = "Good Morning"; }
                else if ((now >= afternoonStart) && (now <= afternoonEnd)) { remark = "Good Afternoon"; }
                else if ((now >= eveningStart) && (now <= eveningEnd)) { remark = "Good Evening"; }
                //else if ((now >= nightStart) && (now <= nightEnd)) { remark = "Late are we?"; }
                else
                {
                    remark = "Late Night Huh...";
                }
            }
            else
            {
                string[] greetings = { "Greetings", "Hello", "Howdy", "G'day" };
                remark = greetings[rand.Next(greetings.Length)];
            }
            if (Login._onlineMode == true)
            {
                 _name = Login.firstName;
            }
            else
            {
                _name = Login.loggedInAs;
            }
            return remark + " " + _name;
        }
    }
    class Rainbow
    {

        public struct ColorRGB
        {
            public byte R;
            public byte G;
            public byte B;

            public ColorRGB(Color value)
            {
                this.R = value.R;
                this.G = value.G;
                this.B = value.B;
            }
            public static implicit operator Color(ColorRGB rgb)
            {
                Color c = Color.FromArgb(rgb.R, rgb.G, rgb.B);
                return c;
            }
            public static explicit operator ColorRGB(Color c)
            {
                return new ColorRGB(c);
            }
        }
        public static ColorRGB HSL2RGB(double h, double sl, double l)
        {
            double v;
            double r, g, b;

            r = l;   // default to gray
            g = l;
            b = l;
            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);
            if (v > 0)
            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;
                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }
            ColorRGB rgb;
            rgb.R = Convert.ToByte(r * 255.0f);
            rgb.G = Convert.ToByte(g * 255.0f);
            rgb.B = Convert.ToByte(b * 255.0f);
            return rgb;
        }
    }
}
