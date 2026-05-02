namespace To_Do_List_Project
{
    partial class frmDailyToDoTasks
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
            this.components = new System.ComponentModel.Container();
            this.trvTasks = new System.Windows.Forms.TreeView();
            this.lblDailyTasks = new System.Windows.Forms.Label();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteAllTasks = new System.Windows.Forms.Button();
            this.btntreeviewcolor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlResponsiveDesign = new System.Windows.Forms.Panel();
            this.pnlResponsiveDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvTasks
            // 
            this.trvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.trvTasks.CheckBoxes = true;
            this.trvTasks.Font = new System.Drawing.Font("Tahoma", 20F);
            this.trvTasks.Indent = 50;
            this.trvTasks.ItemHeight = 40;
            this.trvTasks.LineColor = System.Drawing.Color.Lime;
            this.trvTasks.Location = new System.Drawing.Point(-7, 137);
            this.trvTasks.Name = "trvTasks";
            this.trvTasks.Size = new System.Drawing.Size(895, 462);
            this.trvTasks.TabIndex = 0;
            this.trvTasks.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvTasks_AfterCheck);
            // 
            // lblDailyTasks
            // 
            this.lblDailyTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDailyTasks.AutoSize = true;
            this.lblDailyTasks.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.lblDailyTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblDailyTasks.Location = new System.Drawing.Point(259, 16);
            this.lblDailyTasks.Name = "lblDailyTasks";
            this.lblDailyTasks.Size = new System.Drawing.Size(364, 71);
            this.lblDailyTasks.TabIndex = 1;
            this.lblDailyTasks.Text = "Daily Tasks";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTask.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTask.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnDeleteTask.Location = new System.Drawing.Point(54, 668);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(232, 65);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTask.BackColor = System.Drawing.Color.Purple;
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddTask.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnAddTask.Location = new System.Drawing.Point(592, 668);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(232, 65);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnBack.Location = new System.Drawing.Point(54, 810);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 65);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnEditTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTask.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnEditTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnEditTask.Location = new System.Drawing.Point(323, 668);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(232, 65);
            this.btnEditTask.TabIndex = 2;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteAllTasks
            // 
            this.btnDeleteAllTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAllTasks.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteAllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllTasks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAllTasks.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAllTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnDeleteAllTasks.Location = new System.Drawing.Point(542, 806);
            this.btnDeleteAllTasks.Name = "btnDeleteAllTasks";
            this.btnDeleteAllTasks.Size = new System.Drawing.Size(282, 69);
            this.btnDeleteAllTasks.TabIndex = 4;
            this.btnDeleteAllTasks.Text = "Delete all tasks";
            this.btnDeleteAllTasks.UseVisualStyleBackColor = false;
            this.btnDeleteAllTasks.Click += new System.EventHandler(this.btnDeleteAllTasks_Click);
            // 
            // btntreeviewcolor
            // 
            this.btntreeviewcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntreeviewcolor.BackColor = System.Drawing.Color.Purple;
            this.btntreeviewcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntreeviewcolor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btntreeviewcolor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btntreeviewcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntreeviewcolor.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btntreeviewcolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btntreeviewcolor.Location = new System.Drawing.Point(725, 167);
            this.btntreeviewcolor.Name = "btntreeviewcolor";
            this.btntreeviewcolor.Size = new System.Drawing.Size(156, 77);
            this.btntreeviewcolor.TabIndex = 1;
            this.btntreeviewcolor.Text = "Dark Mode";
            this.btntreeviewcolor.UseVisualStyleBackColor = false;
            this.btntreeviewcolor.Click += new System.EventHandler(this.btntreeviewcolor_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlResponsiveDesign
            // 
            this.pnlResponsiveDesign.AutoScroll = true;
            this.pnlResponsiveDesign.Controls.Add(this.btnDeleteAllTasks);
            this.pnlResponsiveDesign.Controls.Add(this.btnEditTask);
            this.pnlResponsiveDesign.Controls.Add(this.btnBack);
            this.pnlResponsiveDesign.Controls.Add(this.btnAddTask);
            this.pnlResponsiveDesign.Controls.Add(this.btnDeleteTask);
            this.pnlResponsiveDesign.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResponsiveDesign.Location = new System.Drawing.Point(0, 0);
            this.pnlResponsiveDesign.Name = "pnlResponsiveDesign";
            this.pnlResponsiveDesign.Size = new System.Drawing.Size(880, 922);
            this.pnlResponsiveDesign.TabIndex = 6;
            // 
            // frmDailyToDoTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(897, 598);
            this.Controls.Add(this.btntreeviewcolor);
            this.Controls.Add(this.lblDailyTasks);
            this.Controls.Add(this.trvTasks);
            this.Controls.Add(this.pnlResponsiveDesign);
            this.MinimumSize = new System.Drawing.Size(913, 615);
            this.Name = "frmDailyToDoTasks";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Your Tasks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MinimumSizeChanged += new System.EventHandler(this.frmDailyToDoTasks_MinimumSizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDailyToDoTasks_FormClosed);
            this.Load += new System.EventHandler(this.frmDailyToDoTasks_Load);
            this.Shown += new System.EventHandler(this.frmDailyToDoTasks_Shown);
            this.pnlResponsiveDesign.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvTasks;
        private System.Windows.Forms.Label lblDailyTasks;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteAllTasks;
        private System.Windows.Forms.Button btntreeviewcolor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlResponsiveDesign;
    }
}

