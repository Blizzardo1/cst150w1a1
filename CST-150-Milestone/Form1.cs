using System.Text;
using System.Windows.Forms;

namespace CST_150_Milestone
{
    // TODO: Add search functionality
    // TODO: Refine and complete Video demonstration
    public partial class Form1 : Form
    {
        private Dictionary<string, Student> _students;
        private ImageList _imageList;
        Sql.Sql sql;

        public Form1()
        {
            InitializeComponent();
            _students = new();
            _imageList = new();
            StudentId.FormatCardAsGCU = false;
            studentControl.ClearStudent();
            listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            sql = new Sql.Sql("Students");
        }

        private void AddStudent(Student stu)
        {
            string key = $"{stu.Name}:{stu.StudentId}";
            _imageList.Images.Add(key, stu.ProfilePicture.FromBytes());
            listView1.LargeImageList = _imageList;
            listView1.SmallImageList = _imageList;
            ListViewItem lvi = new(stu.Name, key);
            _students.Add(key, stu);
            listView1.Items.Add(lvi);
            listView1.Sort();
        }

        // Future Method
        // Will not use due to Time Constraint Week 6
        private void ModifyStudent(Student stu)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStudent ns = new();
            if (ns.ShowDialog() != DialogResult.OK) return;
            AddStudent(ns.Student);
            sql.InsertInto(ns.Student.ToDictionary()).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null || listView1.SelectedItems.Count == 0)
            {
                studentControl.ClearStudent();
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            Student stu = _students[item.ImageKey];
            studentControl.DisplayStudent(stu);
        }

        private async void modStuBtn_Click(object sender, EventArgs e)
        {
            if (sender == null || listView1.SelectedItems.Count == 0) return;
            ListViewItem item = listView1.SelectedItems[0];
            Student stu = _students[item.ImageKey];
            NewStudent ns = new();
            ns.Repopulate(stu);
            if (ns.ShowDialog() != DialogResult.OK) return;
            _imageList.Images.RemoveByKey(item.ImageKey);
            _students.Remove(item.ImageKey);
            listView1.Items.Remove(item);

            AddStudent(ns.Student);
            await sql.Update(ns.Student.ToDictionary(), "studentid", stu.StudentId);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await sql.Connect();
            List<object> lst = await sql.GetEntry("*");
            var sb = new StringBuilder();
            lst.ForEach(s => {
                object[] o = s as object[];
                AddStudent(new(o[1].ToString(), DateTime.FromBinary((long)o[2]), (int)o[4])
                {
                    EmailAddress = o[3].ToString(),
                    BirthPlace = o[5].ToString(),
                    GradePointAverage = (double)(decimal)o[6],
                    ProfilePicture = Convert.FromBase64String(o[7].ToString().Trim('\'','\"')),
                    Notes = o[8].ToString()
                });
            });
        }

        private async void dismissBtn_Click(object sender, EventArgs e)
        {
            if (sender == null || listView1.SelectedItems.Count == 0) return;
            ListViewItem item = listView1.SelectedItems[0];
            Student stu = _students[item.ImageKey];
            _imageList.Images.RemoveByKey(item.ImageKey);
            _students.Remove(item.ImageKey);
            listView1.Items.Remove(item);
            await sql.Delete("studentid", stu.StudentId);
        }
    }
}
