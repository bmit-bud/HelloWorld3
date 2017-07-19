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
            bool AutoUpdate = false;
            bool ShowTime = true;
            int ClickCount = 0;

            Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           t.Interval = 1000;
           t.Tick += new EventHandler(this.t_Tick);
           t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (AutoUpdate && ShowTime)
            {
                this.label1.Text = "Time " + DateTime.Now.ToLongTimeString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Time " + DateTime.Now.ToLongTimeString();
            ShowTime = true;
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
        }

        private void wow_Click(object sender, EventArgs e)
        {
            this.label1.Text = "wow, such time" ;
            ShowTime = false;
        }

        private void autoUpdateTime_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AutoUpdate = !AutoUpdate;
        }
    }
}
