namespace To_Do_List_Project
{
    partial class frmEditTask
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDeadLine = new System.Windows.Forms.TextBox();
            this.lblDeadLine = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnCancel.Location = new System.Drawing.Point(30, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 65);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnSave.Location = new System.Drawing.Point(353, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 63);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDeadLine
            // 
            this.txtDeadLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDeadLine.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.txtDeadLine.Location = new System.Drawing.Point(216, 207);
            this.txtDeadLine.MaxLength = 30;
            this.txtDeadLine.Multiline = true;
            this.txtDeadLine.Name = "txtDeadLine";
            this.txtDeadLine.Size = new System.Drawing.Size(175, 40);
            this.txtDeadLine.TabIndex = 25;
            // 
            // lblDeadLine
            // 
            this.lblDeadLine.AutoSize = true;
            this.lblDeadLine.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.lblDeadLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblDeadLine.Location = new System.Drawing.Point(30, 207);
            this.lblDeadLine.Name = "lblDeadLine";
            this.lblDeadLine.Size = new System.Drawing.Size(176, 36);
            this.lblDeadLine.TabIndex = 24;
            this.lblDeadLine.Text = "DeadLine :";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.lblTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblTasks.Location = new System.Drawing.Point(28, 138);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(134, 46);
            this.lblTasks.TabIndex = 23;
            this.lblTasks.Text = "Task :";
            // 
            // txtTask
            // 
            this.txtTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTask.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.txtTask.Location = new System.Drawing.Point(216, 145);
            this.txtTask.MaxLength = 180;
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(478, 40);
            this.txtTask.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblTitle.Location = new System.Drawing.Point(243, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(357, 48);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Edit Task Details";
            // 
            // frmEditTask
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDeadLine);
            this.Controls.Add(this.lblDeadLine);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmEditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Task";
            this.Load += new System.EventHandler(this.frmEditTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDeadLine;
        private System.Windows.Forms.Label lblDeadLine;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
    }
}