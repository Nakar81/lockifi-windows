namespace LockifiApp
{
    partial class EditRouter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRoutername = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRoutername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routername";
            // 
            // textBoxRoutername
            // 
            this.textBoxRoutername.Location = new System.Drawing.Point(19, 28);
            this.textBoxRoutername.Name = "textBoxRoutername";
            this.textBoxRoutername.Size = new System.Drawing.Size(222, 20);
            this.textBoxRoutername.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChange);
            this.groupBox2.Controls.Add(this.labelFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 84);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Script file";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(166, 36);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoEllipsis = true;
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(38, 41);
            this.labelFile.MaximumSize = new System.Drawing.Size(120, 13);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(53, 13);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "default.py";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(122, 229);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 229);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRouter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRoutername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}