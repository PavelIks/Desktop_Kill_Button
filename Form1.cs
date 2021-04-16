using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OffOnDesktopButtonWF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

                EnableBox.BackColor = Color.OrangeRed;
                EnableButton.Text = "Not enable";
                foreach (var item in Process.GetProcesses())
                {
                    if (item.ProcessName == "explorer")
                    {
                        item.Kill();
                    
                    }
                }
        }

        private void Button_Click1(object sender, MouseEventArgs e)
        {
            EnableBox.BackColor = Color.GreenYellow;
            EnableButton.Text = "ENABLE";
        }
    }
}