using System;
using System.Windows.Forms;

namespace shuangpinnotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (this.Height == 293)
            {
                this.Height = 45;
                this.Width = 95;
                buttonHide.Text = "显示";
            }
            else
            {
                this.Height = 293;
                this.Width = 539;
                buttonHide.Text = "隐藏";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double opc = Convert.ToDouble(trackBar1.Value) / 100;
            this.Opacity = opc;
            label2.Text = opc.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = this.Opacity.ToString();
        }
    }
}
