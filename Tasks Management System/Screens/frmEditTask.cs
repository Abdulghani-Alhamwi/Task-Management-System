using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static To_Do_List_Project.frmDailyToDoTasks;
using Core;

namespace To_Do_List_Project
{
    public partial class frmEditTask : Form
    {
        public frmEditTask() => InitializeComponent();

        private string _FileName = "Daily Tasks.txt";

        
        clsTask.stCurrentDetails CurrentDetails;

        public frmEditTask(string CurrentTask, string CurrentDeadLine)
        {
            //In C# : when we use parametrized constructor , the default constructor will not be called automatically , so we must put initialize component in the parametrized constructor.
            //In C++ : When we define parametrized constructor , it will automatically excecute default constructor first whether we define it or not and the it will excecute the parametrized constructor.
            InitializeComponent();
            CurrentDetails.CurrentTask = CurrentTask;
            CurrentDetails.CurrentDeadLine = CurrentDeadLine;

        }

        private void Save()
        {
         
            if(clsTask._EditTask(txtTask, txtDeadLine, CurrentDetails, _FileName))
            {
            MessageBox.Show("Task Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                this.Close();
            Form frmDailyTasks = new frmDailyToDoTasks();
            frmDailyTasks.Show();
            }
            else
                MessageBox.Show("Please enter task and deadline to add the task to your daily tasks", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmEditTask_Load(object sender, EventArgs e)
        {
            txtTask.Text = CurrentDetails.CurrentTask;
            txtDeadLine.Text = CurrentDetails.CurrentDeadLine;
        }
     

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Form frmDailyTasks = new frmDailyToDoTasks();
            frmDailyTasks.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            
        }
    }
}
