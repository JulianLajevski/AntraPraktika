
namespace AntraPraktika.UI
{
    partial class AdminForm
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
            this.teachersButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.teacherLessonsButton = new System.Windows.Forms.Button();
            this.lessonsButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teachersButton
            // 
            this.teachersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.teachersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teachersButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersButton.ForeColor = System.Drawing.Color.White;
            this.teachersButton.Location = new System.Drawing.Point(19, 223);
            this.teachersButton.Margin = new System.Windows.Forms.Padding(2);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(135, 55);
            this.teachersButton.TabIndex = 0;
            this.teachersButton.Text = "Teachers";
            this.teachersButton.UseVisualStyleBackColor = false;
            this.teachersButton.Click += new System.EventHandler(this.teachersButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.studentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsButton.ForeColor = System.Drawing.Color.White;
            this.studentsButton.Location = new System.Drawing.Point(19, 313);
            this.studentsButton.Margin = new System.Windows.Forms.Padding(2);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(135, 54);
            this.studentsButton.TabIndex = 1;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = false;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // teacherLessonsButton
            // 
            this.teacherLessonsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.teacherLessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherLessonsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLessonsButton.ForeColor = System.Drawing.Color.White;
            this.teacherLessonsButton.Location = new System.Drawing.Point(19, 406);
            this.teacherLessonsButton.Margin = new System.Windows.Forms.Padding(2);
            this.teacherLessonsButton.Name = "teacherLessonsButton";
            this.teacherLessonsButton.Size = new System.Drawing.Size(135, 54);
            this.teacherLessonsButton.TabIndex = 3;
            this.teacherLessonsButton.Text = "Lesson to teacher";
            this.teacherLessonsButton.UseVisualStyleBackColor = false;
            this.teacherLessonsButton.Click += new System.EventHandler(this.teacherLessonsButton_Click);
            // 
            // lessonsButton
            // 
            this.lessonsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.lessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lessonsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsButton.ForeColor = System.Drawing.Color.White;
            this.lessonsButton.Location = new System.Drawing.Point(19, 124);
            this.lessonsButton.Margin = new System.Windows.Forms.Padding(2);
            this.lessonsButton.Name = "lessonsButton";
            this.lessonsButton.Size = new System.Drawing.Size(135, 54);
            this.lessonsButton.TabIndex = 4;
            this.lessonsButton.Text = "Lessons";
            this.lessonsButton.UseVisualStyleBackColor = false;
            this.lessonsButton.Click += new System.EventHandler(this.lessonsButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.groupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsButton.ForeColor = System.Drawing.Color.White;
            this.groupsButton.Location = new System.Drawing.Point(19, 28);
            this.groupsButton.Margin = new System.Windows.Forms.Padding(2);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(135, 54);
            this.groupsButton.TabIndex = 5;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Location = new System.Drawing.Point(190, 28);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(657, 432);
            this.adminPanel.TabIndex = 6;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(713, 472);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(135, 54);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 537);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.lessonsButton);
            this.Controls.Add(this.teacherLessonsButton);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.teachersButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teachersButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button teacherLessonsButton;
        private System.Windows.Forms.Button lessonsButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.FlowLayoutPanel adminPanel;
        private System.Windows.Forms.Button logoutButton;
    }
}