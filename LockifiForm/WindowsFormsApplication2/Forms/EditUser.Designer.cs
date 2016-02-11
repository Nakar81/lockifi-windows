namespace LockifiApp
{
    partial class EditUser
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(19, 28);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(222, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 228);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(122, 228);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteUser);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paired user";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(89, 30);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteUser.TabIndex = 0;
            this.buttonDeleteUser.Text = "Delete user";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeleteUser;
    }
}