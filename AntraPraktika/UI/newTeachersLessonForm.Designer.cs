
namespace AntraPraktika.UI
{
    partial class newTeachersLessonForm
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
            this.groupListView = new System.Windows.Forms.ListView();
            this.cIdG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitleG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lessonsListView = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLesson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teachersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupListView
            // 
            this.groupListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.groupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cIdG,
            this.cTitleG});
            this.groupListView.ForeColor = System.Drawing.Color.White;
            this.groupListView.FullRowSelect = true;
            this.groupListView.GridLines = true;
            this.groupListView.HideSelection = false;
            this.groupListView.Location = new System.Drawing.Point(719, 48);
            this.groupListView.Name = "groupListView";
            this.groupListView.Size = new System.Drawing.Size(339, 126);
            this.groupListView.TabIndex = 3;
            this.groupListView.UseCompatibleStateImageBehavior = false;
            this.groupListView.View = System.Windows.Forms.View.Details;
            // 
            // cIdG
            // 
            this.cIdG.Text = "Id";
            // 
            // cTitleG
            // 
            this.cTitleG.Text = "Group";
            // 
            // lessonsListView
            // 
            this.lessonsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.lessonsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cLesson});
            this.lessonsListView.ForeColor = System.Drawing.Color.White;
            this.lessonsListView.FullRowSelect = true;
            this.lessonsListView.GridLines = true;
            this.lessonsListView.HideSelection = false;
            this.lessonsListView.Location = new System.Drawing.Point(719, 199);
            this.lessonsListView.Name = "lessonsListView";
            this.lessonsListView.Size = new System.Drawing.Size(339, 126);
            this.lessonsListView.TabIndex = 2;
            this.lessonsListView.UseCompatibleStateImageBehavior = false;
            this.lessonsListView.View = System.Windows.Forms.View.Details;
            // 
            // cId
            // 
            this.cId.Text = "Id";
            // 
            // cLesson
            // 
            this.cLesson.Text = "Lesson";
            // 
            // teachersListView
            // 
            this.teachersListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.teachersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.cTeacher});
            this.teachersListView.ForeColor = System.Drawing.Color.White;
            this.teachersListView.FullRowSelect = true;
            this.teachersListView.GridLines = true;
            this.teachersListView.HideSelection = false;
            this.teachersListView.Location = new System.Drawing.Point(29, 115);
            this.teachersListView.Name = "teachersListView";
            this.teachersListView.Size = new System.Drawing.Size(614, 277);
            this.teachersListView.TabIndex = 8;
            this.teachersListView.UseCompatibleStateImageBehavior = false;
            this.teachersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // cTeacher
            // 
            this.cTeacher.Text = "Teacher";
            this.cTeacher.Width = 130;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(758, 371);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(249, 66);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(258, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teacher lesson";
            // 
            // newTeachersLessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.teachersListView);
            this.Controls.Add(this.groupListView);
            this.Controls.Add(this.lessonsListView);
            this.Name = "newTeachersLessonForm";
            this.Text = "newTeachersLessonForm";
            this.Load += new System.EventHandler(this.newTeachersLessonLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.ColumnHeader cIdG;
        private System.Windows.Forms.ColumnHeader cTitleG;
        private System.Windows.Forms.ListView lessonsListView;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cLesson;
        private System.Windows.Forms.ListView teachersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader cTeacher;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
    }
}