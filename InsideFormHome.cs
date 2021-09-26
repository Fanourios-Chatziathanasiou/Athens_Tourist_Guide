using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class InsideFormHome : Form
    {
        public InsideFormHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(":www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
            he UseShellExecute boolean property is related to the use of the windows ShellExecute function vs the CreateProcess function - 
            the short answer is that if UseShellExecute is true then the Process class will use the ShellExecute function, otherwise it will use CreateProcess.
            The longer answer is that the ShellExecute function is used to open a specified program or file - it is roughly equivalnt to typing the command to 
            be executed into the run dialog and clicking OK, which means that it can be used to (for example):
            1)*Open.html files or web using the default browser without needing to know what that browser is,
            2)Open a word document without needing to know what the installation path for Word is
            3)Run any command on the PATH
            */
            var ps = new ProcessStartInfo("https://www.youtube.com/watch?v=NJQpXiugmUg") { UseShellExecute = true };
            Process.Start(ps);
        }
    }
}