﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.studentControl = new CST_150_Milestone.StudentControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.modStuBtn = new System.Windows.Forms.Button();
            this.dismissBtn = new System.Windows.Forms.Button();
            this.queryTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
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
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(389, 435);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // modStuBtn
            // 
            this.modStuBtn.Location = new System.Drawing.Point(144, 495);
            this.modStuBtn.Name = "modStuBtn";
            this.modStuBtn.Size = new System.Drawing.Size(117, 23);
            this.modStuBtn.TabIndex = 3;
            this.modStuBtn.Text = "Modify";
            this.modStuBtn.UseVisualStyleBackColor = true;
            this.modStuBtn.Click += new System.EventHandler(this.modStuBtn_Click);
            // 
            // dismissBtn
            // 
            this.dismissBtn.Location = new System.Drawing.Point(27, 495);
            this.dismissBtn.Name = "dismissBtn";
            this.dismissBtn.Size = new System.Drawing.Size(111, 23);
            this.dismissBtn.TabIndex = 4;
            this.dismissBtn.Text = "Dismiss Student";
            this.dismissBtn.UseVisualStyleBackColor = true;
            this.dismissBtn.Click += new System.EventHandler(this.dismissBtn_Click);
            // 
            // queryTxt
            // 
            this.queryTxt.Location = new System.Drawing.Point(12, 21);
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(308, 23);
            this.queryTxt.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(326, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 530);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.queryTxt);
            this.Controls.Add(this.dismissBtn);
            this.Controls.Add(this.modStuBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.studentControl);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Student Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private StudentControl studentControl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button modStuBtn;
        private System.Windows.Forms.Button dismissBtn;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button searchBtn;
    }
}

