namespace LockifiApp
{
    partial class AddUsername
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonCancelUsername = new System.Windows.Forms.Button();
            this.buttonAcceptUsername = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(25, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(107, 42);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(270, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // buttonCancelUsername
            // 
            this.buttonCancelUsername.Location = new System.Drawing.Point(302, 93);
            this.buttonCancelUsername.Name = "buttonCancelUsername";
            this.buttonCancelUsername.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelUsername.TabIndex = 2;
            this.buttonCancelUsername.Text = "Cancel";
            this.buttonCancelUsername.UseVisualStyleBackColor = true;
            this.buttonCancelUsername.Click += new System.EventHandler(this.buttonCancelUsername_Click);
            // 
            // buttonAcceptUsername
            // 
            this.buttonAcceptUsername.Location = new System.Drawing.Point(210, 93);
            this.buttonAcceptUsername.Name = "buttonAcceptUsername";
            this.buttonAcceptUsername.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptUsername.TabIndex = 3;
            this.buttonAcceptUsername.Text = "Accept";
            this.buttonAcceptUsername.UseVisualStyleBackColor = true;
            this.buttonAcceptUsername.Click += new System.EventHandler(this.buttonAcceptUsername_Click);
            // 
            // AddUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 128);
            this.Controls.Add(this.buttonAcceptUsername);
            this.Controls.Add(this.buttonCancelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUsername";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonCancelUsername;
        private System.Windows.Forms.Button buttonAcceptUsername;
    }
}