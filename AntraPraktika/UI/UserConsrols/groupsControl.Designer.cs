
namespace AntraPraktika.UI.UserConsrols
{
    partial class groupsControl
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
            this.groupsListView = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupsListView
            // 
            this.groupsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.groupsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cTitle});
            this.groupsListView.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsListView.ForeColor = System.Drawing.Color.White;
            this.groupsListView.FullRowSelect = true;
            this.groupsListView.GridLines = true;
            this.groupsListView.HideSelection = false;
            this.groupsListView.Location = new System.Drawing.Point(22, 41);
            this.groupsListView.Name = "groupsListView";
            this.groupsListView.Size = new System.Drawing.Size(614, 277);
            this.groupsListView.TabIndex = 0;
            this.groupsListView.UseCompatibleStateImageBehavior = false;
            this.groupsListView.View = System.Windows.Forms.View.Details;
            // 
            // cId
            // 
            this.cId.Text = "Id";
            // 
            // cTitle
            // 
            this.cTitle.Text = "Title";
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.ForeColor = System.Drawing.Color.White;
            this.addNewButton.Location = new System.Drawing.Point(91, 347);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(151, 51);
            this.addNewButton.TabIndex = 1;
            this.addNewButton.Text = "Add new";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(393, 347);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(151, 51);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(290, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Groups";
            // 
            // groupsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.groupsListView);
            this.Name = "groupsControl";
            this.Size = new System.Drawing.Size(657, 432);
            this.Load += new System.EventHandler(this.groupsLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView groupsListView;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cTitle;
        private System.Windows.Forms.Label label1;
    }
}
