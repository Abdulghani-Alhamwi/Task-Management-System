namespace To_Do_List_Project.Screens
{
    partial class frmPowerCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPowerCheck));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStartCheck = new System.Windows.Forms.Button();
            this.btnStopCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnBack.Location = new System.Drawing.Point(30, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 59);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStartCheck
            // 
            this.btnStartCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnStartCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCheck.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnStartCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnStartCheck.Location = new System.Drawing.Point(222, 70);
            this.btnStartCheck.Name = "btnStartCheck";
            this.btnStartCheck.Size = new System.Drawing.Size(381, 102);
            this.btnStartCheck.TabIndex = 11;
            this.btnStartCheck.Text = "Start Check";
            this.btnStartCheck.UseVisualStyleBackColor = false;
            this.btnStartCheck.Click += new System.EventHandler(this.btnStartCheck_Click);
            // 
            // btnStopCheck
            // 
            this.btnStopCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStopCheck.BackColor = System.Drawing.Color.Purple;
            this.btnStopCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopCheck.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnStopCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnStopCheck.Location = new System.Drawing.Point(222, 249);
            this.btnStopCheck.Name = "btnStopCheck";
            this.btnStopCheck.Size = new System.Drawing.Size(381, 102);
            this.btnStopCheck.TabIndex = 11;
            this.btnStopCheck.Text = "Stop Check";
            this.btnStopCheck.UseVisualStyleBackColor = false;
            this.btnStopCheck.Click += new System.EventHandler(this.btnStopCheck_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnStopCheck);
            this.panel1.Controls.Add(this.btnStartCheck);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 494);
            this.panel1.TabIndex = 12;
            // 
            // frmPowerCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPowerCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPowerCheck_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStartCheck;
        private System.Windows.Forms.Button btnStopCheck;
        private System.Windows.Forms.Panel panel1;
    }
}