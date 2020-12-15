
namespace AntraPraktika.UI
{
    partial class newEvaluationForm
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
            this.studentsListView = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.NumericUpDown();
            this.saveEvaluationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsListView
            // 
            this.studentsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.studentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cStudent,
            this.cGroup});
            this.studentsListView.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListView.ForeColor = System.Drawing.Color.White;
            this.studentsListView.FullRowSelect = true;
            this.studentsListView.GridLines = true;
            this.studentsListView.HideSelection = false;
            this.studentsListView.Location = new System.Drawing.Point(94, 26);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(396, 123);
            this.studentsListView.TabIndex = 0;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
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
            // cGroup
            // 
            this.cGroup.Text = "Group";
            this.cGroup.Width = 154;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(344, 203);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(146, 20);
            this.commentTextBox.TabIndex = 1;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(94, 204);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.valueTextBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.valueTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(109, 20);
            this.valueTextBox.TabIndex = 2;
            this.valueTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveEvaluationButton
            // 
            this.saveEvaluationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.saveEvaluationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveEvaluationButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEvaluationButton.ForeColor = System.Drawing.Color.White;
            this.saveEvaluationButton.Location = new System.Drawing.Point(194, 288);
            this.saveEvaluationButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveEvaluationButton.Name = "saveEvaluationButton";
            this.saveEvaluationButton.Size = new System.Drawing.Size(198, 48);
            this.saveEvaluationButton.TabIndex = 3;
            this.saveEvaluationButton.Text = "Add";
            this.saveEvaluationButton.UseVisualStyleBackColor = false;
            this.saveEvaluationButton.Click += new System.EventHandler(this.saveEvaluationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comment";
            // 
            // newEvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveEvaluationButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.studentsListView);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "newEvaluationForm";
            this.Text = "newEvaluationForm";
            this.Load += new System.EventHandler(this.newEvaluationLoad);
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader cStudent;
        private System.Windows.Forms.ColumnHeader cGroup;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.NumericUpDown valueTextBox;
        private System.Windows.Forms.Button saveEvaluationButton;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}