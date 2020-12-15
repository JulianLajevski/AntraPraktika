
namespace AntraPraktika.UI
{
    partial class EvaluationStudentForm
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
            this.valuesListView = new System.Windows.Forms.ListView();
            this.cLesson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valuesListView
            // 
            this.valuesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.valuesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cLesson,
            this.cValue,
            this.cComment,
            this.cDate,
            this.cTeacher});
            this.valuesListView.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesListView.ForeColor = System.Drawing.Color.White;
            this.valuesListView.FullRowSelect = true;
            this.valuesListView.GridLines = true;
            this.valuesListView.HideSelection = false;
            this.valuesListView.Location = new System.Drawing.Point(59, 59);
            this.valuesListView.Margin = new System.Windows.Forms.Padding(2);
            this.valuesListView.Name = "valuesListView";
            this.valuesListView.Size = new System.Drawing.Size(644, 322);
            this.valuesListView.TabIndex = 0;
            this.valuesListView.UseCompatibleStateImageBehavior = false;
            this.valuesListView.View = System.Windows.Forms.View.Details;
            // 
            // cLesson
            // 
            this.cLesson.Text = "Lesson";
            this.cLesson.Width = 112;
            // 
            // cValue
            // 
            this.cValue.Text = "Value";
            this.cValue.Width = 114;
            // 
            // cComment
            // 
            this.cComment.Text = "Comment";
            this.cComment.Width = 118;
            // 
            // cDate
            // 
            this.cDate.Text = "Date";
            this.cDate.Width = 126;
            // 
            // cTeacher
            // 
            this.cTeacher.Text = "Teacher";
            this.cTeacher.Width = 162;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(563, 436);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(175, 43);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // EvaluationStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 493);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.valuesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvaluationStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.EvaluationStudentLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView valuesListView;
        private System.Windows.Forms.ColumnHeader cLesson;
        private System.Windows.Forms.ColumnHeader cValue;
        private System.Windows.Forms.ColumnHeader cComment;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.ColumnHeader cTeacher;
        private System.Windows.Forms.Button logoutButton;
    }
}