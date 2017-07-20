using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld2
{
    public partial class Form1 : Form
    {
            bool AutoUpdate = true;
            bool ShowTime = false;
            bool AutoUpdateFirstClick = false;
            int ClickCount = 0;
            Random randomColor = new Random();

        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           t.Interval = 10;
           t.Tick += new EventHandler(this.t_Tick);
           t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (AutoUpdate && ShowTime)
            {
                this.label1.Text = "Time " + DateTime.Now.ToLongTimeString();
            }

            if (ClickCount < 0)
            {
                displayClickCount.Text = "Dude, WTF?!";

            }
            if (ClickCount > 0)
            {
                displayClickCount.Text = ClickCount.ToString();
            }

            if (ShowTime)
            {
                if (AutoUpdate)
                {
                    displayToggle.Text = "on";
                }
                else
                {
                    displayToggle.Text = "off";
                }
            }
            else
            {
                displayToggle.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Time " + DateTime.Now.ToLongTimeString();
            ShowTime = true;
            AutoUpdateFirstClick = true;
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
            randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.displayClickCount.ForeColor = Color.FromArgb((255 - randomColor.Next(0, 256)),
            (255 - randomColor.Next(0, 256)), (255 - randomColor.Next(0, 256)));
            if (displayToggle.Text == "on")
            {
                this.displayToggle.ForeColor = Color.FromArgb(randomColor.Next(0, 65),
            randomColor.Next(128, 256), randomColor.Next(0, 65));
            }
            else
            {
                this.displayToggle.ForeColor = Color.FromArgb(randomColor.Next(128, 256),
            randomColor.Next(0, 65), randomColor.Next(0, 65));
            }

            /*
            Random randomColor2 = new Random(1516648886 + DateTime.Ticks);
            this.displayClickCount.ForeColor = Color.FromArgb(randomColor2.Next(0, 256),
            randomColor2.Next(0, 256), randomColor2.Next(0, 256));
            */

            ClickCount++;
        }

        private void wow_Click(object sender, EventArgs e)
        {
            this.label1.Text = "wow, such time" ;
            ShowTime = false;
            AutoUpdate = false;
            AutoUpdateFirstClick = true;

        }

        private void autoUpdateTime_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowTime = true;

            if (!AutoUpdateFirstClick)
            {
                AutoUpdate = true;
                AutoUpdateFirstClick = true;
                this.displayToggle.ForeColor = Color.FromArgb(randomColor.Next(0, 65),
randomColor.Next(128, 256), randomColor.Next(0, 65));
            }
            else
            {
                AutoUpdate = !AutoUpdate;
                if (AutoUpdate)
                {
                    this.displayToggle.ForeColor = Color.FromArgb(randomColor.Next(0, 65),
                randomColor.Next(128, 256), randomColor.Next(0, 65));
                }
                else
                {
                    this.displayToggle.ForeColor = Color.FromArgb(randomColor.Next(128, 256),
                randomColor.Next(0, 65), randomColor.Next(0, 65));
                }
            }
        }

        private void displayClickCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
