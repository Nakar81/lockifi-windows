namespace LockifiApp
{
    partial class AddRouter
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
            this.textBoxRoutername = new System.Windows.Forms.TextBox();
            this.buttonCancelRoutername = new System.Windows.Forms.Button();
            this.buttonAcceptRoutername = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRoutername
            // 
            this.textBoxRoutername.Location = new System.Drawing.Point(18, 34);
            this.textBoxRoutername.Name = "textBoxRoutername";
            this.textBoxRoutername.Size = new System.Drawing.Size(327, 20);
            this.textBoxRoutername.TabIndex = 1;
            // 
            // buttonCancelRoutername
            // 
            this.buttonCancelRoutername.Location = new System.Drawing.Point(302, 218);
            this.buttonCancelRoutername.Name = "buttonCancelRoutername";
            this.buttonCancelRoutername.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRoutername.TabIndex = 2;
            this.buttonCancelRoutername.Text = "Cancel";
            this.buttonCancelRoutername.UseVisualStyleBackColor = true;
            this.buttonCancelRoutername.Click += new System.EventHandler(this.buttonCancelRoutername_Click);
            // 
            // buttonAcceptRoutername
            // 
            this.buttonAcceptRoutername.Location = new System.Drawing.Point(191, 218);
            this.buttonAcceptRoutername.Name = "buttonAcceptRoutername";
            this.buttonAcceptRoutername.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptRoutername.TabIndex = 3;
            this.buttonAcceptRoutername.Text = "Accept";
            this.buttonAcceptRoutername.UseVisualStyleBackColor = true;
            this.buttonAcceptRoutername.Click += new System.EventHandler(this.buttonAcceptRoutername_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.py";
            this.openFileDialog1.Filter = "Python Files (py)|*.py";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRoutername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Router name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Script file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the script file of your router";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAcceptRoutername);
            this.Controls.Add(this.buttonCancelRoutername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRouter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add router";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAcceptRoutername;
        private System.Windows.Forms.Button buttonCancelRoutername;
        private System.Windows.Forms.TextBox textBoxRoutername;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}