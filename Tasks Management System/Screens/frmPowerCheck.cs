using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Project.Screens
{
    public partial class frmPowerCheck : Form
    {
        Form frmProgramLifeControl , frmMainForm;
        bool CloseProgram = true;
        public frmPowerCheck(Form frmProgramLife,frmMain frmMain)
        {
            InitializeComponent();
            frmProgramLifeControl = frmProgramLife;
            frmMainForm = frmMain;  
        }

        bool allowcheck = true;
        SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");

        async Task CheckAsync()
        {
            while (allowcheck)
            {
                bool pluggedIn = SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online;

                while (!pluggedIn && allowcheck)
                {
                    // play sound without blocking
                    player.Play();

                    // wait before checking again
                    await Task.Delay(6000);

                    pluggedIn = SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online;
                }

                // small delay to avoid CPU overuse
                await Task.Delay(1000);
            }
        }

        private async void btnStartCheck_Click(object sender, EventArgs e)
        {
            allowcheck = true;
            await CheckAsync();
        }

        private void btnStopCheck_Click(object sender, EventArgs e)
        {
            allowcheck = false;
            player.Stop();
        }

        private void frmPowerCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(CloseProgram)
                frmProgramLifeControl.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseProgram = false;
            this.Close();
            frmMainForm.Show();
        }
    }
}
