
namespace AntraPraktika.UI
{
    partial class newTeacherForm
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
            this.lessonsListView = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLesson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupListView = new System.Windows.Forms.ListView();
            this.cIdG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitleG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.lessonsListView.Location = new System.Drawing.Point(38, 53);
            this.lessonsListView.Name = "lessonsListView";
            this.lessonsListView.Size = new System.Drawing.Size(339, 126);
            this.lessonsListView.TabIndex = 0;
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
            this.groupListView.Location = new System.Drawing.Point(419, 53);
            this.groupListView.Name = "groupListView";
            this.groupListView.Size = new System.Drawing.Size(339, 126);
            this.groupListView.TabIndex = 1;
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(104, 213);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(104, 275);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(165, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Location = new System.Drawing.Point(419, 213);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdatePicker.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(419, 275);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(164, 57);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Add";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(100, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(100, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(415, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthdate";
            // 
            // newTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.groupListView);
            this.Controls.Add(this.lessonsListView);
            this.Name = "newTeacherForm";
            this.Text = "newTeacherForm";
            this.Load += new System.EventHandler(this.newTeacherLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lessonsListView;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cLesson;
        private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.ColumnHeader cIdG;
        private System.Windows.Forms.ColumnHeader cTitleG;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}