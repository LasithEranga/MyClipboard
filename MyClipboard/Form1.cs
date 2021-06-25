using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClipboard
{
    public partial class Form1 : Form
    {
        bool p1 = true;
        bool p2 = true;
        bool p3 = true;
        public Form1()
        {
            InitializeComponent();
            area1.Text = " ";
            area2.Text = " ";
            area3.Text = " ";
        }

        private void coptBtn_Click(object sender, EventArgs e)
        {
            if (area1.Text.ToString().Equals(" ") && p1)
            {
                area1.Text = Clipboard.GetText();
            }
            else if (area2.Text.ToString().Equals( " ") && p2)
            {
                area2.Text = Clipboard.GetText();
            }
            else
            {
                area3.Text = Clipboard.GetText();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pin1_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                pin1.Image = Properties.Resources.Unpin;
                p1 = false;
            }
            else
            {
                pin1.Image = Properties.Resources.Pin;
                p1 = true;
            }
        }

        private void pin2_Click(object sender, EventArgs e)
        {
            if (p2)
            {
                pin2.Image = Properties.Resources.Unpin;
                p2 = false;
            }
            else
            {
                pin2.Image = Properties.Resources.Pin;
                p2 = true;
            }
        }
        private void pin3_Click(object sender, EventArgs e)
        {
            if (p3)
            {
                pin3.Image = Properties.Resources.Unpin;
                p3 = false;
            }
            else
            {
                pin3.Image = Properties.Resources.Pin;
                p3 = true;
            }
        }
        private void delete1_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                area1.Text = " ";
            }
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            if (p2)
            {
                area2.Text = " ";
            }
        }
        private void delete3_Click(object sender, EventArgs e)
        {
            if (p3)
            {
                area3.Text = " ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                area1.Text = " ";
            }

            if (p2)
            {
                area2.Text = " ";
            }

            if (p3)
            {
                area3.Text = " ";
            }
        }

        private void area1_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)area1.Text);
            SendKeys.Send("%{TAB}");
        }

        private void area1_click(object sender, MouseEventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)area1.Text);
            SendKeys.Send("%{TAB}");
            Thread.Sleep(100);
            SendKeys.SendWait("^{v}");
        }
    }
}
