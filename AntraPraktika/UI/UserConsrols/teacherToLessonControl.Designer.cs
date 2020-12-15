
namespace AntraPraktika.UI.UserConsrols
{
    partial class teacherToLessonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teachersListView = new System.Windows.Forms.ListView();
            this.cTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLesson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewButton = new System.Windows.Forms.Button();
            this.teacherLessonTextView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teachersListView
            // 
            this.teachersListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.teachersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTeacher,
            this.cGroup,
            this.cLesson});
            this.teachersListView.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersListView.ForeColor = System.Drawing.Color.White;
            this.teachersListView.FullRowSelect = true;
            this.teachersListView.GridLines = true;
            this.teachersListView.HideSelection = false;
            this.teachersListView.Location = new System.Drawing.Point(17, 47);
            this.teachersListView.Name = "teachersListView";
            this.teachersListView.Size = new System.Drawing.Size(614, 277);
            this.teachersListView.TabIndex = 8;
            this.teachersListView.UseCompatibleStateImageBehavior = false;
            this.teachersListView.View = System.Windows.Forms.View.Details;
            // 
            // cTeacher
            // 
            this.cTeacher.Text = "Teacher";
            this.cTeacher.Width = 130;
            // 
            // cGroup
            // 
            this.cGroup.Text = "Group";
            this.cGroup.Width = 100;
            // 
            // cLesson
            // 
            this.cLesson.Text = "Lesson";
            this.cLesson.Width = 100;
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.ForeColor = System.Drawing.Color.White;
            this.addNewButton.Location = new System.Drawing.Point(239, 353);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(151, 51);
            this.addNewButton.TabIndex = 9;
            this.addNewButton.Text = "Add new";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // teacherLessonTextView
            // 
            this.teacherLessonTextView.AutoSize = true;
            this.teacherLessonTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLessonTextView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.teacherLessonTextView.Location = new System.Drawing.Point(265, 12);
            this.teacherLessonTextView.Name = "teacherLessonTextView";
            this.teacherLessonTextView.Size = new System.Drawing.Size(136, 22);
            this.teacherLessonTextView.TabIndex = 10;
            this.teacherLessonTextView.Text = "Teachers Lesson";
            // 
            // teacherToLessonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teacherLessonTextView);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.teachersListView);
            this.Name = "teacherToLessonControl";
            this.Size = new System.Drawing.Size(657, 432);
            this.Load += new System.EventHandler(this.teacherToLessonLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView teachersListView;
        private System.Windows.Forms.ColumnHeader cTeacher;
        private System.Windows.Forms.ColumnHeader cGroup;
        private System.Windows.Forms.ColumnHeader cLesson;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Label teacherLessonTextView;
    }
}
