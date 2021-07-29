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
    public partial class NewStudent : Form
    {
        private static readonly Bitmap s_blank = new(256, 256);
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
            ProfilePicPB.Image = s_blank;
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
    }
}
