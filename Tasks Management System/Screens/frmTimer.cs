using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using NAudio.CoreAudioApi;
using System.Xml;

namespace To_Do_List_Project
{
    public partial class frmTimer : Form
    {
        public frmTimer() => InitializeComponent();

        private long TimeLeft { get; set; }

        private MMDeviceEnumerator enumerator;
        private MMDevice device;
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMainScreen = new frmMain();
            frmMainScreen.Show();
            this.Close();
        }

        void EnableControls(bool status)
        {
            btnBack.Enabled = status;
            numericupdownmin.ReadOnly = !status;
            numericupdownmin.Enabled = status;
        }

        private void PlaySound(bool Play=true)
        {
            SoundPlayer Sound = new SoundPlayer("alarmSound.wav");
            if (Play)
            {
                Sound.Play();
                Sound.PlayLooping();
            }
            else
            {
                Sound.Stop();
            }
        }

        private void _EndOfTimer()
        {
                if(TimeLeft==1)
                {
                timer1.Stop();
                 PlaySound();
                DialogResult dialogresult = MessageBox.Show("Time is up","Alarm", MessageBoxButtons.OK);

                if (dialogresult == DialogResult.OK)
                    {
                        PlaySound(false);
                        btnStart.Text = "Start";
                        EnableControls(true);
                    lblMinutes.Text = "Minutes";
                    }
                }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            if (btnStart.Text == "Start")
            {
                lblMinutes.Text = "Seconds Left :";
                TimeLeft = 60 * Convert.ToInt64(numericupdownmin.Value);
                numericupdownmin.Maximum = TimeLeft;
                timer1.Start();
                btnStart.Text = "Stop";
            }
            else if(btnStart.Text == "Stop")
            {
                btnStart.Text = "Pause";
                timer1.Enabled = false;
               
            }
            else
            {
                btnStart.Text = "Stop";
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeLeft--;
            numericupdownmin.Value = TimeLeft;//Minimum must be 1
            _EndOfTimer();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = (trackBar1.Value / 100.0f);
            label1.Text = trackBar1.Value.ToString();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            enumerator = new MMDeviceEnumerator();

            device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            trackBar1.Value = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);

            label1.Text = trackBar1.Value.ToString();
            
        }

    }
}
