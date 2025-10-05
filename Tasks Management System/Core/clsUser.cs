using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    internal class clsUser
    {
        internal struct stUserInfo
        {
            public string UserName;
            public string Password;

        }


        internal static List<stUserInfo> LoadFileDate(string FileName)
        {
            List<stUserInfo> lUsers = new List<stUserInfo>();
            List<string> strusers = new List<string>();

            stUserInfo UserInfo;

            if (File.Exists(FileName))
                using (StreamReader MyFile = new StreamReader(FileName))
                {
                    string Line;
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        strusers = Line.Split(new String[] { "#//#" }, StringSplitOptions.RemoveEmptyEntries).Where(s => !String.IsNullOrEmpty(s)).ToList();
                        UserInfo.UserName = strusers.ElementAt(0);
                        UserInfo.Password = strusers.ElementAt(1);

                        lUsers.Add(UserInfo);

                        strusers.Clear();

                    }

                }

            //Second Way:
            //string[] arrTasks = File.ReadAllLines(FileName);//Automatically closes file after open it
            //lTasks.AddRange(arrTasks);

            return lUsers;
        }

        internal static void SaveDataToFile(TextBox UserName, TextBox Password, string FileName, bool Append)
        {
            if (UserName.Text == null || Password.Text == null)
                MessageBox.Show("UserName and Password Cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {

                if (Append)
                {
                    //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
                    //{
                    //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
                    //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
                    //}

                    //File.AppendAllText("Daily Tasks File.txt", txtTask.Text + "#//#" + txtDeadLine.Text);
                    //the previous line closes the file automatically and creates the file if it is not exists and append to the file if it is exists , so it is a shortcut for :
                    //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
                    //{
                    //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
                    //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
                    //}

                    //File.AppendAllText("Daily Tasks.txt", txtTask.Text + "#//#" + txtDeadLine.Text + Environment.NewLine()    );//Automatically closes the file and creates it if it is not exists
                    File.AppendAllText(FileName, UserName.Text + "#//#" + Password.Text + "\r\n");//Automatically closes the file and creates it if it is not exists
                }

            }
        }

        //public void SaveDataToFile()
        //{
        //    if (String.IsNullOrWhiteSpace(txtTask.Text) || String.IsNullOrWhiteSpace(txtDeadLine.Text))
        //    {
        //        MessageBox.Show("Please enter task and deadline to add the task to your daily tasks", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        if (String.IsNullOrWhiteSpace(txtTask.Text))
        //            txtTask.Focus();
        //        else
        //            txtDeadLine.Focus();
        //    }

        //    else
        //    {


        //        //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
        //        //{
        //        //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
        //        //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
        //        //}

        //        //File.AppendAllText("Daily Tasks File.txt", txtTask.Text + "#//#" + txtDeadLine.Text);
        //        //the previous line closes the file automatically and creates the file if it is not exists and append to the file if it is exists , so it is a shortcut for :
        //        //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
        //        //{
        //        //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
        //        //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
        //        //}

        //        //File.AppendAllText("Daily Tasks.txt", txtTask.Text + "#//#" + txtDeadLine.Text + Environment.NewLine()    );//Automatically closes the file and creates it if it is not exists
        //        File.AppendAllText("Daily Tasks.txt", txtTask.Text + "#//#" + txtDeadLine.Text + "#//#" + 0 + "\r\n");//Automatically closes the file and creates it if it is not exists

        //        MessageBox.Show("Task Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Close();
        //        Form frmDailyTasks = new frmDailyToDoTasks();
        //        frmDailyTasks.Show();
        //    }
        //}

        internal static bool _CheckUserExists(string UserName, string Password, string _FileName)
        {
            List<stUserInfo> lUsers = new List<stUserInfo>();
            lUsers = LoadFileDate(_FileName);

            foreach (stUserInfo User in lUsers)
            {
                if (User.UserName.ToUpper() == UserName.ToUpper() && User.Password == Password)
                    return true;
            }
            return false;

        }

        internal static void _AddUser(TextBox UserName, TextBox Password, string FileName)
        {
            SaveDataToFile(UserName, Password, FileName, true);
        }


    }
}
