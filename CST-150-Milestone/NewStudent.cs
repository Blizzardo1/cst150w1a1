using System.Drawing;
using System.Windows.Forms;

namespace CST_150_Milestone
{
    public partial class NewStudent : Form
    {
        /// <summary>
        /// New Student created via Enroll Button
        /// </summary>
        public Student Student { get; private set; }

        /// <summary>
        /// New Student Form
        /// </summary>
        public NewStudent()
        {
            InitializeComponent();
        }

        private void ProfilePicPB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Images (*.png, *.bmp, *.dib, *.jpg, *.jpeg)|*.png;*.bmp;*.dib;*.jpg;*.jpeg|Portable Network Graphics Image (*.png)|*.png|Bitmap Image (*.bmp,*.dib)|*.bmp;*.dib|JPEG Image (*.jpg, *.jpeg)|*.jpg;*.jpeg|All Files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ProfilePicPB.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            if(ProfilePicPB.Image == null)
            {
                MessageBox.Show(this, "Cannot leave Profile picture blank!\nPlease select an image", "Profile picture blank", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            _ = int.TryParse(StudentIdTxt.Text, out int id);
            _ = double.TryParse(GpaTxt.Text, out double gpa);
            Student = new(StudentNameTxt.Text, BirthdayDtp.Value, id) {
                EmailAddress = EmailAddressTxt.Text,
                BirthPlace = BirthPlaceTxt.Text,
                GradePointAverage = gpa,
                Notes = NotesRtb.Text,
                ProfilePicture = ProfilePicPB.Image.ToBytes()
            };
        }

        internal void Repopulate(Student stu)
        {
            StudentNameTxt.Text = stu.Name;
            EmailAddressTxt.Text = stu.EmailAddress;
            BirthPlaceTxt.Text = stu.BirthPlace;
            BirthdayDtp.Value = stu.BirthDate;
            StudentIdTxt.Text = stu.StudentId.ToString();
            GpaTxt.Text = stu.GradePointAverage.ToString();
            NotesRtb.Text = stu.Notes;
            ProfilePicPB.Image = stu.ProfilePicture.FromBytes();
            EnrollBtn.Text = "Commit";
        }
    }
}
