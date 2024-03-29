﻿using System.Windows.Forms;

namespace CST_150_Milestone
{
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears student display.
        /// </summary>
        public void ClearStudent()
        {
            StudentNameLbl.Text = string.Empty;
            StudentIdLbl.Text = string.Empty;
            AgeLbl.Text = string.Empty;
            BirthdayLbl.Text = string.Empty;
            EmailAddressLbl.Text = string.Empty;
            BirthPlaceLbl.Text = string.Empty;
            GpaLbl.Text = string.Empty;
            NotesRtb.Text = string.Empty;
            pictureBox1.Image = null;
        }

        /// <summary>
        /// Displays student information.
        /// </summary>
        /// <param name="student">Any student</param>
        public void DisplayStudent(Student student)
        {
            StudentNameLbl.Text = student.Name;
            StudentIdLbl.Text = student.StudentId.ToString();
            AgeLbl.Text = student.Age.ToString();
            BirthdayLbl.Text = student.BirthDate.ToString("dddd MMMM dd, yyyy");
            EmailAddressLbl.Text = student.EmailAddress;
            BirthPlaceLbl.Text = student.BirthPlace;
            GpaLbl.Text = student.GradePointAverage.ToString();
            NotesRtb.Text = student.Notes;
            pictureBox1.Image = student.ProfilePicture.FromBytes();
        }

        private void EmailAddressLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mailto = $"mailto:{EmailAddressLbl.Text}";
            new WebBrowser().Navigate(mailto);
        }
    }
}
