
namespace CST_150_Milestone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.studentControl = new CST_150_Milestone.StudentControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enroll Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentControl
            // 
            this.studentControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentControl.Location = new System.Drawing.Point(407, 21);
            this.studentControl.Name = "studentControl";
            this.studentControl.Size = new System.Drawing.Size(855, 500);
            this.studentControl.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(389, 477);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 530);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.studentControl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Student Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private StudentControl studentControl;
        private System.Windows.Forms.ListView listView1;
    }
}

