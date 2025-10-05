namespace To_Do_List_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewDailyTasks = new System.Windows.Forms.Button();
            this.btnAddTimer = new System.Windows.Forms.Button();
            this.lblTitlwMainScreen = new System.Windows.Forms.Label();
            this.lblAboveTimer = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.linklabel = new System.Windows.Forms.LinkLabel();
            this.lblDeveloperName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewDailyTasks
            // 
            this.btnViewDailyTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnViewDailyTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDailyTasks.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnViewDailyTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnViewDailyTasks.Location = new System.Drawing.Point(253, 172);
            this.btnViewDailyTasks.Name = "btnViewDailyTasks";
            this.btnViewDailyTasks.Size = new System.Drawing.Size(294, 65);
            this.btnViewDailyTasks.TabIndex = 4;
            this.btnViewDailyTasks.Text = "View Daily Tasks";
            this.btnViewDailyTasks.UseVisualStyleBackColor = false;
            this.btnViewDailyTasks.Click += new System.EventHandler(this.btnViewDailyTasks_Click);
            // 
            // btnAddTimer
            // 
            this.btnAddTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAddTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTimer.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnAddTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnAddTimer.Location = new System.Drawing.Point(284, 360);
            this.btnAddTimer.Name = "btnAddTimer";
            this.btnAddTimer.Size = new System.Drawing.Size(232, 65);
            this.btnAddTimer.TabIndex = 6;
            this.btnAddTimer.Text = "Add Timer";
            this.btnAddTimer.UseVisualStyleBackColor = false;
            this.btnAddTimer.Click += new System.EventHandler(this.btnAddTimer_Click);
            // 
            // lblTitlwMainScreen
            // 
            this.lblTitlwMainScreen.AutoSize = true;
            this.lblTitlwMainScreen.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.lblTitlwMainScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblTitlwMainScreen.Location = new System.Drawing.Point(84, 22);
            this.lblTitlwMainScreen.Name = "lblTitlwMainScreen";
            this.lblTitlwMainScreen.Size = new System.Drawing.Size(636, 71);
            this.lblTitlwMainScreen.TabIndex = 7;
            this.lblTitlwMainScreen.Text = "Organize Your Tasks";
            // 
            // lblAboveTimer
            // 
            this.lblAboveTimer.AutoSize = true;
            this.lblAboveTimer.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblAboveTimer.ForeColor = System.Drawing.Color.White;
            this.lblAboveTimer.Location = new System.Drawing.Point(51, 293);
            this.lblAboveTimer.Name = "lblAboveTimer";
            this.lblAboveTimer.Size = new System.Drawing.Size(699, 39);
            this.lblAboveTimer.TabIndex = 8;
            this.lblAboveTimer.Text = "To Recharge Your Power  , set a rest time :";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Maroon;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnLogOut.Location = new System.Drawing.Point(595, 513);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(168, 52);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linklabel
            // 
            this.linklabel.AutoSize = true;
            this.linklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklabel.Font = new System.Drawing.Font("Tahoma", 21F);
            this.linklabel.LinkColor = System.Drawing.Color.White;
            this.linklabel.Location = new System.Drawing.Point(190, 522);
            this.linklabel.Name = "linklabel";
            this.linklabel.Size = new System.Drawing.Size(266, 34);
            this.linklabel.TabIndex = 10;
            this.linklabel.TabStop = true;
            this.linklabel.Text = "Abdulghani Alhamwi";
            this.linklabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_LinkClicked);
            // 
            // lblDeveloperName
            // 
            this.lblDeveloperName.AutoSize = true;
            this.lblDeveloperName.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblDeveloperName.ForeColor = System.Drawing.Color.White;
            this.lblDeveloperName.Location = new System.Drawing.Point(27, 523);
            this.lblDeveloperName.Name = "lblDeveloperName";
            this.lblDeveloperName.Size = new System.Drawing.Size(149, 33);
            this.lblDeveloperName.TabIndex = 11;
            this.lblDeveloperName.Text = "Made By :";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnViewDailyTasks;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(787, 584);
            this.ControlBox = false;
            this.Controls.Add(this.lblDeveloperName);
            this.Controls.Add(this.linklabel);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblAboveTimer);
            this.Controls.Add(this.lblTitlwMainScreen);
            this.Controls.Add(this.btnAddTimer);
            this.Controls.Add(this.btnViewDailyTasks);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 623);
            this.MinimumSize = new System.Drawing.Size(803, 39);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Your Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewDailyTasks;
        private System.Windows.Forms.Button btnAddTimer;
        private System.Windows.Forms.Label lblTitlwMainScreen;
        private System.Windows.Forms.Label lblAboveTimer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.LinkLabel linklabel;
        private System.Windows.Forms.Label lblDeveloperName;
    }
}