using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using To_Do_List_Project.Screens;

namespace To_Do_List_Project
{
    public partial class frmDailyToDoTasks : Form
    {
        Form frmProgramLife;
        frmMain frmMainScreen;

        bool CloseProgram = true;
        clsUser.stUserInfo CurrentUser = new clsUser.stUserInfo();

        public frmDailyToDoTasks(frmMain frmMain, Form frmFirst, clsUser.stUserInfo CurrentUser)
        {
            InitializeComponent();
            frmProgramLife = frmFirst;
            frmMainScreen = frmMain;
            this.CurrentUser = CurrentUser;
        }
       
        internal void RefreshTreeView()
        {
            trvTasks.Nodes.Clear();
            _AddTasks();
            ExpandAllNodes();
            trvTasks.Refresh();
        }

        private string _FileName = "Daily Tasks.txt";

        internal clsTask.enMode NextMode=clsTask.enMode.LightMode;

        int TreeNodesCounter = 0;

        private void AddNodeToTreeView(string RootNodeTask, string ChildNodeDeadLine,bool isFinished)
        {
            if (RootNodeTask != null)
            {
                trvTasks.Nodes.Add(RootNodeTask);
               
                trvTasks.Nodes[trvTasks.Nodes.Count - 1].ForeColor = Color.FromArgb(240,240,240);
                trvTasks.Nodes[trvTasks.Nodes.Count - 1].NodeFont = new Font("Times New Roman", 22, FontStyle.Bold);
            
            }

            if (ChildNodeDeadLine != null)
            {
                trvTasks.Nodes[(trvTasks.Nodes.Count) - 1].Nodes.Add(ChildNodeDeadLine);
                trvTasks.Nodes[(trvTasks.Nodes.Count) - 1].Nodes[(trvTasks.Nodes[(trvTasks.Nodes.Count) - 1].Nodes.Count) - 1].ForeColor = Color.FromArgb(240,240,240);
                trvTasks.Nodes[trvTasks.Nodes.Count - 1].Nodes[trvTasks.Nodes[trvTasks.Nodes.Count - 1].Nodes.Count - 1].NodeFont = new Font("Times New Roman", 20, FontStyle.Bold);
            }              
                if (isFinished)
                {
                    trvTasks.Nodes[TreeNodesCounter].Checked = true;                  

            }
            TreeNodesCounter++;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmNewTask = new frmNewTaskInfo(this,CurrentUser);
            frmNewTask.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen.Show();
            CloseProgram = false;
            frmMainScreen.CloseProgram = true;
            this.Close();
        }

        void AddCheckedNodesToButtom()
        {
            int index = 0;
            foreach(TreeNode Node in trvTasks.Nodes)
            {
                if(Node.Checked)
                {
                    clsTask._TransferCheckedNode(trvTasks,Node,index,true, CurrentUser.UserName+_FileName);
                }
                index++;
            }
            clsTask.RecolorFirstCheckedNode(trvTasks, Color.DarkGreen);//because aftercheck worked here and did'nt handle the first Node BackColor so to reset it to green we called recolor here
        }

        private void _AddTasks()
        {
            if (File.Exists(CurrentUser.UserName + _FileName))
            {
                List<clsTask.stTaskInfo> lTasks = new List<clsTask.stTaskInfo>();
                lTasks = clsTask.LoadFileDate(CurrentUser.UserName + _FileName);

                foreach (clsTask.stTaskInfo Info in lTasks)
                {
                    AddNodeToTreeView(Info.Task, Info.DeadLine,Info.IsFinished);
                }
                TreeNodesCounter = 0;
            }

        }

        private void ExpandAllNodes()
        {
            trvTasks.ExpandAll();
        }

        private void frmDailyToDoTasks_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
         
            _AddTasks();
            ExpandAllNodes();
            ChangeColors();

            //RecolorFirstCheckedNode(trvTasks,Color.LawnGreen);
            //We Called Recolor function here to recolor the Checked nodes , because :
            /*
             WinForm whether we are in load event or shawn event , it will after asigning the back color to node aftercheck it it will put selection on it
            so the selection color here overrides the green color and the back will be replaced by the back color of the treeview , 
            this happens only to the first checked node in treeview , the other nodes back color will not be replaced because 
            for later nodes the aftercheck will be handle it so system wont after selection wont set the back color to default after selection goes from it
             */
            //So the problem is not timing(Load vs Shown).
            //The after check alwyas won't handle the First Node back color so the system will always reset it to default 
        }

         private void _DeleteTask()
        {
            if (trvTasks.Nodes.Count == 0)
            {
                MessageBox.Show("You did'nt set your daily tasks yet", "Choose a task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(trvTasks.SelectedNode==null)
            {
                MessageBox.Show("You did'nt select task you want to delete", "Choose a task to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             
                clsTask._DeleteTaskFromFile(trvTasks.SelectedNode.Text, CurrentUser.UserName + _FileName);

                foreach (TreeNode node in trvTasks.Nodes)
                {
                    if (node == trvTasks.SelectedNode)
                    {
                        node.Remove();
                        return;
                    }

                }
                trvTasks.SelectedNode.Parent.Remove();
            }
        

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            _DeleteTask();
        }

        private void btnDeleteAllTasks_Click(object sender, EventArgs e)
        {
            clsTask.DeleteAllNodes(trvTasks, CurrentUser.UserName + _FileName);
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (trvTasks.Nodes.Count == 0)
            {
                MessageBox.Show("Add a task first then you can edit", "Choose a task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (trvTasks.SelectedNode == null)
            {
                MessageBox.Show("You did'nt select task you want to edit", "Choose a task to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (trvTasks.SelectedNode.Checked)
                MessageBox.Show("This task is finished , uncheck it to edit", "Finished Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Form frmEdit;
                if (!clsTask.IsChildNode(trvTasks.SelectedNode.Text, CurrentUser.UserName + _FileName))
                    frmEdit = new frmEditTask(trvTasks.SelectedNode.Text, trvTasks.SelectedNode.Nodes[0].Text,this, CurrentUser);
                                
                else
                    frmEdit = new frmEditTask(trvTasks.SelectedNode.Parent.Text, trvTasks.SelectedNode.Text,this,CurrentUser);
               
                frmEdit.Show();
                this.Hide();

            }
        }

        internal void ChangeNodesColorByMode(object sender,string Mode)
        {
            if(Mode=="Light Mode")
            foreach(TreeNode Node in ((TreeView)sender).Nodes)
            {
                    if (!Node.Checked)
                        Node.BackColor = Color.FromArgb(255, 235, 235, 235);
                    else
                        Node.BackColor = Color.LawnGreen;

                    Node.ForeColor = Color.FromArgb(255, 18, 18, 18);

                    trvTasks.LineColor = Color.Purple;
                    btntreeviewcolor.FlatAppearance.BorderColor = Color.FromArgb(255,20,20,20);

                    foreach (TreeNode ChildNode in Node.Nodes)
                    {
                            ChildNode.ForeColor = Color.FromArgb(255, 18, 18, 18);
          
                    }
                }
            else
                foreach (TreeNode Node in ((TreeView)sender).Nodes)
                {
                    if (!Node.Checked)
                        Node.BackColor = Color.FromArgb(255, 18, 18, 18);
                    else
                        Node.BackColor = Color.DarkGreen;

                    Node.ForeColor = Color.FromArgb(255, 250, 250, 250);

                    trvTasks.LineColor = Color.LawnGreen;

                    btntreeviewcolor.FlatAppearance.BorderColor = Color.FromArgb(255,235,235,235);


                    foreach (TreeNode ChildNode in Node.Nodes)
                    {
                        ChildNode.ForeColor = Color.FromArgb(255, 250, 250, 250);
                    }
                }
        }

        public void ChangeColors()
        {
            if (NextMode == clsTask.enMode.LightMode)
            {
                NextMode = clsTask.enMode.DarkMode;
                trvTasks.BackColor = Color.FromArgb(255, 18, 18, 18);
                btntreeviewcolor.Text = "Dark Mode";
                btntreeviewcolor.BackColor = Color.Purple;
                btntreeviewcolor.ForeColor = Color.FromArgb(255, 240, 240, 240);
                ChangeNodesColorByMode(trvTasks, "Dark Mode");
            }
            else
            {
                NextMode = clsTask.enMode.LightMode;
                trvTasks.BackColor = Color.FromArgb(255, 235, 235, 235);
                btntreeviewcolor.Text = "Light Mode";
                btntreeviewcolor.BackColor = Color.Purple;
                btntreeviewcolor.ForeColor = Color.FromArgb(255,240,240,240);
                ChangeNodesColorByMode(trvTasks, "Light Mode");
            }
        }

        private void btntreeviewcolor_Click(object sender, EventArgs e)
        {
            ChangeColors();
        }


        bool _Transfer = true;
        internal void TransferToChecked(object sender)
        {

            foreach (TreeNode Node in ((TreeView)sender).Nodes)
            {
                clsTask._TransferCheckedNode(trvTasks, Node, Node.Index, Node.Checked, CurrentUser.UserName + _FileName);
                 
                foreach(TreeNode ChN in Node.Nodes)
                {
                    if(ChN.Checked&& !Node.Checked)
                        {
                            MessageBox.Show("Check the Task name to mark the task as completed", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                            _Transfer = false;
                          ChN.Checked = false;

                }
            }
            _Transfer = true;
        }

        private void trvTasks_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if(_Transfer)
            TransferToChecked(trvTasks);

        }

        private void frmDailyToDoTasks_Shown(object sender, EventArgs e)
        {
            timer1.Start();
            AddCheckedNodesToButtom();//we called it here because it is to ealy to call it in load because window form still running its own logic and won't execute it right
            Form frmLoad = new frmLoading();
            frmLoad.Show();
        }

        private void frmDailyToDoTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(CloseProgram)
                frmProgramLife.Close();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1.0;
        }

        private void frmDailyToDoTasks_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }  
    }
