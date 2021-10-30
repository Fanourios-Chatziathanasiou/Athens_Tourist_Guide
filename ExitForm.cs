using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;

namespace WinFormsApp3
{
    public partial class ExitForm : Form
    {
        
        public ExitForm()
        {
            InitializeComponent();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            StaticFieldsClass.save_user_data();
            Environment.Exit(0);
            
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
