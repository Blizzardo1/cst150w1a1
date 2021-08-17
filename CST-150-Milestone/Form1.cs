using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Student> _students;
        private ImageList _imageList;

        public Form1()
        {
            InitializeComponent();
            _students = new();
            _imageList = new();
            StudentId.FormatCardAsGCU = false;
            studentControl.ClearStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStudent ns = new();
            if (ns.ShowDialog() != DialogResult.OK) return;
            Student stu = ns.Student;
            string key = $"{stu.Name}:{stu.StudentId}";
            _imageList.Images.Add(key, stu.ProfilePicture.FromBytes());
            listView1.LargeImageList = _imageList;
            listView1.SmallImageList = _imageList;
            ListViewItem lvi = new(stu.Name, key);
            _students.Add(key, stu);
            listView1.Items.Add(lvi);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null || listView1.SelectedItems.Count == 0) return;
            ListViewItem item = listView1.SelectedItems[0];
            Student stu = _students[item.ImageKey];
            studentControl.DisplayStudent(stu);
        }
    }
}
