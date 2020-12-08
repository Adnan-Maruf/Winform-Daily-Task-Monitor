using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Daily_Task
{
    public partial class Form1 : Form
    {
        int limit = 0;
        public Control zx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            if (limit == 0)
            {
                control_panel.Controls.Add(msg1);
            }
        }
        private void Init()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Text = "Select task type", Value = "InitialText" });
            items.Add(new Item() { Text = "Entertainment", Value = "Entertainment" });
            items.Add(new Item() { Text = "Work", Value = "Work" });
            items.Add(new Item() { Text = "Study", Value = "Study" });
            items.Add(new Item() { Text = "Gaming", Value = "Gaming" });
            items.Add(new Item() { Text = "Rest", Value = "Rest" });

            addTaskType.DataSource = items;
            addTaskType.DisplayMember = "Text";
            addTaskType.ValueMember = "Value";

        }

        public class Item
        {
            public Item() { }

            public string Value { set; get; }
            public string Text { set; get; }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!addTaskName.Text.Equals("") && !addTaskType.Text.Equals("Select task type"))
            {
                if (limit == 0)
                {
                    control_panel.Controls.Remove(msg1);
                }
                limit++;
                SingleTask st = new SingleTask();
                st.task_no.Text = limit.ToString();
                st.task_name.Text = addTaskName.Text;
                st.task_type.Text = addTaskType.Text;
                st.Location = new Point(-3, control_panel.Controls.Count * 35);
                control_panel.Controls.Add(st);
                addTaskName.Text = String.Empty;
                Init();
            }
            else
            {
                MessageBox.Show("Task name & type required","Error!");
            }
            
        }

        private void menuBarExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Options_Save_Click(object sender, EventArgs e)
        {
            try
            {
                const string Folder = @"C:\Users\adnan\Desktop\Daily Task\Saved";
                if (!Directory.Exists(Folder))
                {
                    Directory.CreateDirectory(Folder);
                    FileCreate();
                }
                else
                {
                    FileCreate();
                }
                MessageBox.Show("Save successfull!", "Saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show("File cannot save!", "Error!");
            }
        }

        private void FileCreate()
        {
            string fileName = DisplayName.Text.ToString() + ".txt";
            string path2 = Path.GetFullPath("C:\\Users\\adnan\\Desktop\\Daily Task\\Saved");
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string var = Path.Combine(docPath, path2);
            string var1 = Path.Combine(var, fileName);
            using (StreamWriter writer = new StreamWriter(var1))
            {
                string var2 = DisplayName.Text;
                writer.WriteLine(var2);

            }
        }
    }
}
