using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_List_Project;

namespace Core
{
    internal class clsTask
    {
        internal enum enMode : byte
        {
            LightMode = 1,
            DarkMode = 2
        }

        internal struct stTaskInfo
        {
            public string Task;
            public string DeadLine;
            public bool MarkForDelete;
            public bool IsFinished;
        }

        internal static List<stTaskInfo> LoadFileDate(string FileName)
        {
            List<stTaskInfo> lTasks = new List<stTaskInfo>();
            List<string> slTasks = new List<string>();

            clsTask.stTaskInfo TaskInfo;

            using (StreamReader MyFile = new StreamReader(FileName))
            {
                string Line;
                while ((Line = MyFile.ReadLine()) != null)
                {
                    slTasks = Line.Split(new String[] { "#//#" }, StringSplitOptions.RemoveEmptyEntries).Where(s => !String.IsNullOrEmpty(s)).ToList();
                    TaskInfo.Task = slTasks.ElementAt(0);
                    TaskInfo.DeadLine = slTasks.ElementAt(1);
                    if (slTasks.ElementAt(2) == "0")
                        TaskInfo.IsFinished = false;
                    else
                        TaskInfo.IsFinished = true;

                    TaskInfo.MarkForDelete = false;

                    lTasks.Add(TaskInfo);

                    slTasks.Clear();

                }

            }

            //Second Way:
            //string[] arrTasks = File.ReadAllLines(FileName);//Automatically closes file after open it
            //lTasks.AddRange(arrTasks);

            return lTasks;
        }

        internal static void _UpdateDataToFile(List<stTaskInfo> lTasks,string FileName)
        {
            //using(StreamWriter MyFile=new StreamWriter(FileName,append:true))//will not clear the file but it will append and if the file not exist it will create it 
            using (StreamWriter MyFile = new StreamWriter(FileName))//will Clear File,apend defalut parameter -> false
            {
                //MyFile.Flush();// the text is not directly will by written on file but it will be stored at memory in : buffer , and when the file closed , disposed , it will writes the texts in buffer to disk, flush () here will force to write what inside buffer now to be written in file in harddisk, .dispose automatically flush -> to make the buffer data be written on the file
                foreach (stTaskInfo Task in lTasks)
                {
                    if (!Task.MarkForDelete && !Task.IsFinished)
                    {//Writing data to memory (buffer) is much faster than write it to disk rightaway -> better prefomance for writing data to buffer in memory and afte closeing the file it will write to file in harddisk
                        //If you flush every time you write a line, the program makes many slow disk writes.
                        //Flushing Frequently can wear out ssd's if done excessively
                        MyFile.WriteLine(Task.Task + "#//#" + Task.DeadLine + "#//#" + 0);
                    }
                    else if (!Task.MarkForDelete && Task.IsFinished)
                    {
                        MyFile.WriteLine(Task.Task + "#//#" + Task.DeadLine + "#//#" + +1);
                    }
                }
            }
        }

        internal static void _DeleteTaskFromFile(string TaskToDelete,string FileName)
        {
            List<stTaskInfo> lTasks = new List<stTaskInfo>();
            lTasks = LoadFileDate(FileName);

            stTaskInfo Task;

            for (short i = 0; i < lTasks.Count; i++)
            {
                if (lTasks[i].Task == TaskToDelete || lTasks[i].DeadLine == TaskToDelete)
                {
                    Task.MarkForDelete = true;
                    Task.Task = TaskToDelete;
                    Task.DeadLine = lTasks[i].DeadLine;
                    Task.IsFinished = lTasks[i].IsFinished;
                    lTasks[i] = Task;
                }
            }
            _UpdateDataToFile(lTasks,FileName);
        }

       internal static void DeleteAllNodes(TreeView sender,string FileName)
        {
      
            if (sender.Nodes.Count == 0)
                MessageBox.Show("You did'nt set your daily tasks yet", "Choose a task", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {

                File.Delete(FileName);

                sender.Nodes.Clear();

            }
    }

        internal static void _ChangeFileRecordbyRootNode(string RootNodeName, bool isFinished,string FileName)
        {
            if (RootNodeName != null)
            {
                List<stTaskInfo> lTasks = new List<stTaskInfo>();
                lTasks = LoadFileDate(FileName);

                int Counter = 0;
                foreach (stTaskInfo TaskInfo in lTasks)
                {
                    if (TaskInfo.Task == RootNodeName)
                    {
                        //lTasks[Counter].IsFinished=true;/error:
                        /*
                         If stTaskInfo was a class, you could do lTasks[Counter].IsFinished = true; directly., class is a reference type , struct is a value type

                        Since it’s a struct, TaskInfo in the foreach loop is just a copy. You cannot modify the item inside the list through the copy.
                         */
                        stTaskInfo Task = lTasks[Counter];
                        Task.IsFinished = isFinished;
                        lTasks[Counter] = Task;
                        _UpdateDataToFile(lTasks,FileName);
                        return;
                    }
                    Counter++;
                }
            }
        }

        internal static void _TransferCheckedNode(TreeView sender,TreeNode Node, int index, bool Checked,string FileName)
        {
            if (Checked)
            {
                Node.BackColor = Color.LawnGreen;
                sender.Nodes[index].Remove();
                sender.Nodes.Add(Node);
                _ChangeFileRecordbyRootNode(Node.Text, true,FileName);
            }
            else
            {
                _ChangeFileRecordbyRootNode(Node.Text, false,FileName);
                Node.BackColor = sender.BackColor;
            }

        }

        internal static bool SaveDataToFile(TextBox Task,TextBox DeadLine,string FileName)
        {

            if (String.IsNullOrWhiteSpace(Task.Text) || String.IsNullOrWhiteSpace(DeadLine.Text))
            {
                MessageBox.Show("Please enter task and deadline to add the task to your daily tasks", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (String.IsNullOrWhiteSpace(Task.Text))
                    Task.Focus();
                else
                    DeadLine.Focus();

                return false;
            }

            else
            {
                List<stTaskInfo> lTasks = new List<stTaskInfo>();
                lTasks = clsTask.LoadFileDate(FileName);

                using (StreamWriter MyFile = new StreamWriter(FileName))
                {
                    foreach (stTaskInfo T in lTasks)
                    {
                        if (!T.IsFinished)
                            MyFile.WriteLine(T.Task + "#//#" + T.DeadLine + "#//#" + 0);
                        else
                            MyFile.WriteLine(T.Task + "#//#" + T.DeadLine + "#//#" + 1);
                    }
                }
                return true;

            }
        }


        internal struct stCurrentDetails
        {
            public string CurrentTask;
            public string CurrentDeadLine;
        }

        internal static List<stTaskInfo> _EditTask(TextBox EditedTask, TextBox EditeDeadLine,stCurrentDetails Details,string FileName)
        {
            List<stTaskInfo> lTasks = new List<stTaskInfo>();

            lTasks =LoadFileDate(FileName);

            stTaskInfo NewTask;

            for (short i = 0; i < lTasks.Count; i++)
            {
                if (lTasks[i].Task == Details.CurrentTask || lTasks[i].DeadLine == Details.CurrentDeadLine)
                {
                    NewTask.Task = EditedTask.Text;
                    NewTask.DeadLine = EditeDeadLine.Text;
                    NewTask.IsFinished = false;
                    NewTask.MarkForDelete = false;

                    lTasks[i] = NewTask;


                }
            }
            return lTasks;
        }

        internal static void RecolorFirstCheckedNode(TreeView sender, Color Color)
        {
            foreach (TreeNode Node in (sender).Nodes)
            {
                if (Node.Checked)
                {
                    Node.BackColor = Color;
                    return;
                }
            }
        }

     
    }
}
