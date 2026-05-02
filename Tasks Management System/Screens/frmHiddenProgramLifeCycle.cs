using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Project.Screens
{
    public partial class frmHiddenProgramLifeCycle : Form
    {
        public frmHiddenProgramLifeCycle() => InitializeComponent();

        private void frmHiddenMainForm_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
            Form frmLogin=new frmLoginPage(this);
            frmLogin.Show();
        }
    }
}
