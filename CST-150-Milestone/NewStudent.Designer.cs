
namespace CST_150_Milestone
{
    partial class NewStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotesRtb = new System.Windows.Forms.RichTextBox();
            this.BirthPlaceTxt = new System.Windows.Forms.TextBox();
            this.StudentIdTxt = new System.Windows.Forms.TextBox();
            this.StudentNameTxt = new System.Windows.Forms.TextBox();
            this.ProfilePicPB = new System.Windows.Forms.PictureBox();
            this.BirthdayDtp = new System.Windows.Forms.DateTimePicker();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.EnrollBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EmailAddressTxt = new System.Windows.Forms.TextBox();
            this.GpaTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicPB)).BeginInit();
            this.SuspendLayout();
            // 
            // NotesRtb
            // 
            this.NotesRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesRtb.Location = new System.Drawing.Point(8, 269);
            this.NotesRtb.Name = "NotesRtb";
            this.NotesRtb.Size = new System.Drawing.Size(689, 180);
            this.NotesRtb.TabIndex = 6;
            this.NotesRtb.Text = "";
            // 
            // BirthPlaceTxt
            // 
            this.BirthPlaceTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BirthPlaceTxt.Location = new System.Drawing.Point(270, 137);
            this.BirthPlaceTxt.Name = "BirthPlaceTxt";
            this.BirthPlaceTxt.Size = new System.Drawing.Size(180, 29);
            this.BirthPlaceTxt.TabIndex = 3;
            this.BirthPlaceTxt.Text = "Birthplace";
            // 
            // StudentIdTxt
            // 
            this.StudentIdTxt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentIdTxt.Location = new System.Drawing.Point(330, 63);
            this.StudentIdTxt.Name = "StudentIdTxt";
            this.StudentIdTxt.Size = new System.Drawing.Size(225, 39);
            this.StudentIdTxt.TabIndex = 1;
            this.StudentIdTxt.Text = "StudentId";
            // 
            // StudentNameTxt
            // 
            this.StudentNameTxt.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentNameTxt.Location = new System.Drawing.Point(269, 7);
            this.StudentNameTxt.Name = "StudentNameTxt";
            this.StudentNameTxt.Size = new System.Drawing.Size(578, 50);
            this.StudentNameTxt.TabIndex = 0;
            this.StudentNameTxt.Text = "Name";
            // 
            // ProfilePicPB
            // 
            this.ProfilePicPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProfilePicPB.Location = new System.Drawing.Point(8, 7);
            this.ProfilePicPB.Name = "ProfilePicPB";
            this.ProfilePicPB.Size = new System.Drawing.Size(256, 256);
            this.ProfilePicPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicPB.TabIndex = 4;
            this.ProfilePicPB.TabStop = false;
            this.ProfilePicPB.Click += new System.EventHandler(this.ProfilePicPB_Click);
            // 
            // BirthdayDtp
            // 
            this.BirthdayDtp.Location = new System.Drawing.Point(330, 108);
            this.BirthdayDtp.Name = "BirthdayDtp";
            this.BirthdayDtp.Size = new System.Drawing.Size(261, 23);
            this.BirthdayDtp.TabIndex = 2;
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.Location = new System.Drawing.Point(270, 114);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(54, 15);
            this.birthdayLbl.TabIndex = 12;
            this.birthdayLbl.Text = "Birthday:";
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnrollBtn.Location = new System.Drawing.Point(817, 426);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(75, 23);
            this.EnrollBtn.TabIndex = 8;
            this.EnrollBtn.Text = "&Enroll";
            this.EnrollBtn.UseVisualStyleBackColor = true;
            this.EnrollBtn.Click += new System.EventHandler(this.EnrollBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(736, 426);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // EmailAddressTxt
            // 
            this.EmailAddressTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmailAddressTxt.Location = new System.Drawing.Point(270, 172);
            this.EmailAddressTxt.Name = "EmailAddressTxt";
            this.EmailAddressTxt.Size = new System.Drawing.Size(180, 29);
            this.EmailAddressTxt.TabIndex = 4;
            this.EmailAddressTxt.Text = "Email Address";
            // 
            // GpaTxt
            // 
            this.GpaTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GpaTxt.Location = new System.Drawing.Point(270, 207);
            this.GpaTxt.Name = "GpaTxt";
            this.GpaTxt.Size = new System.Drawing.Size(180, 29);
            this.GpaTxt.TabIndex = 5;
            this.GpaTxt.Text = "Grade Point Average";
            // 
            // NewStudent
            // 
            this.AcceptButton = this.EnrollBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EnrollBtn);
            this.Controls.Add(this.birthdayLbl);
            this.Controls.Add(this.BirthdayDtp);
            this.Controls.Add(this.NotesRtb);
            this.Controls.Add(this.GpaTxt);
            this.Controls.Add(this.EmailAddressTxt);
            this.Controls.Add(this.BirthPlaceTxt);
            this.Controls.Add(this.StudentIdTxt);
            this.Controls.Add(this.StudentNameTxt);
            this.Controls.Add(this.ProfilePicPB);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotesRtb;
        private System.Windows.Forms.TextBox BirthPlaceTxt;
        private System.Windows.Forms.TextBox StudentIdTxt;
        private System.Windows.Forms.TextBox StudentNameTxt;
        private System.Windows.Forms.PictureBox ProfilePicPB;
        private System.Windows.Forms.DateTimePicker BirthdayDtp;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.Button EnrollBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox EmailAddressTxt;
        private System.Windows.Forms.TextBox GpaTxt;
    }
}