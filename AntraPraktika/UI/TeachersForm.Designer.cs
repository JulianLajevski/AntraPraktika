
namespace AntraPraktika.UI
{
    partial class TeachersForm
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
            this.helloTextView = new System.Windows.Forms.Label();
            this.newEvaluationButton = new System.Windows.Forms.Button();
            this.myEvaluationButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloTextView
            // 
            this.helloTextView.AutoSize = true;
            this.helloTextView.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloTextView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.helloTextView.Location = new System.Drawing.Point(283, 49);
            this.helloTextView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloTextView.Name = "helloTextView";
            this.helloTextView.Size = new System.Drawing.Size(204, 35);
            this.helloTextView.TabIndex = 0;
            this.helloTextView.Text = "Hello, Jolanta!";
            // 
            // newEvaluationButton
            // 
            this.newEvaluationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.newEvaluationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newEvaluationButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEvaluationButton.ForeColor = System.Drawing.Color.White;
            this.newEvaluationButton.Location = new System.Drawing.Point(163, 181);
            this.newEvaluationButton.Margin = new System.Windows.Forms.Padding(2);
            this.newEvaluationButton.Name = "newEvaluationButton";
            this.newEvaluationButton.Size = new System.Drawing.Size(154, 51);
            this.newEvaluationButton.TabIndex = 1;
            this.newEvaluationButton.Text = "New evaluation";
            this.newEvaluationButton.UseVisualStyleBackColor = false;
            this.newEvaluationButton.Click += new System.EventHandler(this.newEvaluationButton_Click);
            // 
            // myEvaluationButton
            // 
            this.myEvaluationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.myEvaluationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myEvaluationButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myEvaluationButton.ForeColor = System.Drawing.Color.White;
            this.myEvaluationButton.Location = new System.Drawing.Point(420, 181);
            this.myEvaluationButton.Margin = new System.Windows.Forms.Padding(2);
            this.myEvaluationButton.Name = "myEvaluationButton";
            this.myEvaluationButton.Size = new System.Drawing.Size(154, 51);
            this.myEvaluationButton.TabIndex = 2;
            this.myEvaluationButton.Text = "My evaluations";
            this.myEvaluationButton.UseVisualStyleBackColor = false;
            this.myEvaluationButton.Click += new System.EventHandler(this.myEvaluationButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(648, 367);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(92, 51);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 429);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.myEvaluationButton);
            this.Controls.Add(this.newEvaluationButton);
            this.Controls.Add(this.helloTextView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeachersForm";
            this.Text = "TeachersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloTextView;
        private System.Windows.Forms.Button newEvaluationButton;
        private System.Windows.Forms.Button myEvaluationButton;
        private System.Windows.Forms.Button logoutButton;
    }
}