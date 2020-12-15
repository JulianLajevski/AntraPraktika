
namespace AntraPraktika.UI
{
    partial class TeachersEvaluationsForm
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
            this.teachersEvaluationsList = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teachersEvaluationsList
            // 
            this.teachersEvaluationsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.teachersEvaluationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cStudent,
            this.cValue,
            this.cComment,
            this.cDate});
            this.teachersEvaluationsList.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersEvaluationsList.ForeColor = System.Drawing.Color.White;
            this.teachersEvaluationsList.FullRowSelect = true;
            this.teachersEvaluationsList.GridLines = true;
            this.teachersEvaluationsList.HideSelection = false;
            this.teachersEvaluationsList.Location = new System.Drawing.Point(70, 50);
            this.teachersEvaluationsList.Margin = new System.Windows.Forms.Padding(2);
            this.teachersEvaluationsList.Name = "teachersEvaluationsList";
            this.teachersEvaluationsList.Size = new System.Drawing.Size(699, 227);
            this.teachersEvaluationsList.TabIndex = 1;
            this.teachersEvaluationsList.UseCompatibleStateImageBehavior = false;
            this.teachersEvaluationsList.View = System.Windows.Forms.View.Details;
            // 
            // cId
            // 
            this.cId.Text = "Id";
            // 
            // cStudent
            // 
            this.cStudent.Text = "Student";
            this.cStudent.Width = 203;
            // 
            // cValue
            // 
            this.cValue.Text = "Value";
            this.cValue.Width = 154;
            // 
            // cComment
            // 
            this.cComment.Text = "Comment";
            this.cComment.Width = 150;
            // 
            // cDate
            // 
            this.cDate.Text = "Date";
            this.cDate.Width = 127;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(70, 342);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(243, 72);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(526, 342);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(243, 72);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // TeachersEvaluationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 462);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.teachersEvaluationsList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeachersEvaluationsForm";
            this.Text = "TeachersEvaluations";
            this.Load += new System.EventHandler(this.allTeachersEvaluationsLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView teachersEvaluationsList;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cStudent;
        private System.Windows.Forms.ColumnHeader cValue;
        private System.Windows.Forms.ColumnHeader cComment;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}