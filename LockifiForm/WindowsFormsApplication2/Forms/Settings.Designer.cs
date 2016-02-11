namespace WindowsFormsApplication2
{
    partial class Settings
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
            this.treeViewSettings = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRouters = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteRouter = new System.Windows.Forms.Button();
            this.buttonEditRouter = new System.Windows.Forms.Button();
            this.buttonAddRouter = new System.Windows.Forms.Button();
            this.dataGridViewRouters = new System.Windows.Forms.DataGridView();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabLatch = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSecKey = new System.Windows.Forms.TextBox();
            this.textBoxAppId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLockifi = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonAllOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonChanges = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabRouters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRouters)).BeginInit();
            this.tabUsers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabLatch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabLockifi.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewSettings
            // 
            this.treeViewSettings.HideSelection = false;
            this.treeViewSettings.ItemHeight = 36;
            this.treeViewSettings.Location = new System.Drawing.Point(12, 34);
            this.treeViewSettings.Name = "treeViewSettings";
            this.treeViewSettings.ShowPlusMinus = false;
            this.treeViewSettings.Size = new System.Drawing.Size(191, 454);
            this.treeViewSettings.TabIndex = 0;
            this.treeViewSettings.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewSettings_BeforeCollapse);
            this.treeViewSettings.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewSettings_BeforeSelect);
            this.treeViewSettings.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSettings_AfterSelect);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRouters);
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Controls.Add(this.tabLatch);
            this.tabControl.Controls.Add(this.tabLockifi);
            this.tabControl.Location = new System.Drawing.Point(222, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(474, 480);
            this.tabControl.TabIndex = 1;
            // 
            // tabRouters
            // 
            this.tabRouters.Controls.Add(this.groupBox1);
            this.tabRouters.Location = new System.Drawing.Point(4, 22);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.Padding = new System.Windows.Forms.Padding(3);
            this.tabRouters.Size = new System.Drawing.Size(466, 454);
            this.tabRouters.TabIndex = 0;
            this.tabRouters.Text = "Routers";
            this.tabRouters.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteRouter);
            this.groupBox1.Controls.Add(this.buttonEditRouter);
            this.groupBox1.Controls.Add(this.buttonAddRouter);
            this.groupBox1.Controls.Add(this.dataGridViewRouters);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routers";
            // 
            // buttonDeleteRouter
            // 
            this.buttonDeleteRouter.Location = new System.Drawing.Point(347, 80);
            this.buttonDeleteRouter.Name = "buttonDeleteRouter";
            this.buttonDeleteRouter.Size = new System.Drawing.Size(90, 23);
            this.buttonDeleteRouter.TabIndex = 3;
            this.buttonDeleteRouter.Text = "Delete Router";
            this.buttonDeleteRouter.UseVisualStyleBackColor = true;
            this.buttonDeleteRouter.Click += new System.EventHandler(this.buttonDeleteRouter_Click);
            // 
            // buttonEditRouter
            // 
            this.buttonEditRouter.Location = new System.Drawing.Point(241, 80);
            this.buttonEditRouter.Name = "buttonEditRouter";
            this.buttonEditRouter.Size = new System.Drawing.Size(90, 23);
            this.buttonEditRouter.TabIndex = 2;
            this.buttonEditRouter.Text = "Edit Router";
            this.buttonEditRouter.UseVisualStyleBackColor = true;
            this.buttonEditRouter.Click += new System.EventHandler(this.buttonEditRouter_Click);
            // 
            // buttonAddRouter
            // 
            this.buttonAddRouter.Location = new System.Drawing.Point(16, 80);
            this.buttonAddRouter.Name = "buttonAddRouter";
            this.buttonAddRouter.Size = new System.Drawing.Size(90, 23);
            this.buttonAddRouter.TabIndex = 1;
            this.buttonAddRouter.Text = "Add Router";
            this.buttonAddRouter.UseVisualStyleBackColor = true;
            this.buttonAddRouter.Click += new System.EventHandler(this.buttonAddRouter_Click);
            // 
            // dataGridViewRouters
            // 
            this.dataGridViewRouters.AllowUserToAddRows = false;
            this.dataGridViewRouters.AllowUserToDeleteRows = false;
            this.dataGridViewRouters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRouters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRouters.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewRouters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRouters.EnableHeadersVisualStyles = false;
            this.dataGridViewRouters.Location = new System.Drawing.Point(16, 109);
            this.dataGridViewRouters.Name = "dataGridViewRouters";
            this.dataGridViewRouters.ReadOnly = true;
            this.dataGridViewRouters.RowHeadersVisible = false;
            this.dataGridViewRouters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRouters.Size = new System.Drawing.Size(421, 316);
            this.dataGridViewRouters.TabIndex = 4;
            this.dataGridViewRouters.SelectionChanged += new System.EventHandler(this.dataGridViewRouters_SelectionChanged);
            this.dataGridViewRouters.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRouters_MouseDown);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.groupBox2);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(466, 454);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonDeleteUser);
            this.groupBox2.Controls.Add(this.buttonEditUser);
            this.groupBox2.Controls.Add(this.buttonAddUser);
            this.groupBox2.Controls.Add(this.dataGridViewUsers);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 442);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(347, 80);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(90, 23);
            this.buttonDeleteUser.TabIndex = 3;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(241, 80);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(90, 23);
            this.buttonEditUser.TabIndex = 2;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(16, 80);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(90, 23);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.Location = new System.Drawing.Point(16, 109);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(421, 316);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);
            this.dataGridViewUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUsers_MouseDown);
            // 
            // tabLatch
            // 
            this.tabLatch.Controls.Add(this.groupBox3);
            this.tabLatch.Location = new System.Drawing.Point(4, 22);
            this.tabLatch.Name = "tabLatch";
            this.tabLatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabLatch.Size = new System.Drawing.Size(466, 454);
            this.tabLatch.TabIndex = 2;
            this.tabLatch.Text = "Latch";
            this.tabLatch.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSecKey);
            this.groupBox3.Controls.Add(this.textBoxAppId);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 226);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Latch settings";
            // 
            // textBoxSecKey
            // 
            this.textBoxSecKey.Location = new System.Drawing.Point(135, 102);
            this.textBoxSecKey.Name = "textBoxSecKey";
            this.textBoxSecKey.PasswordChar = '*';
            this.textBoxSecKey.Size = new System.Drawing.Size(289, 20);
            this.textBoxSecKey.TabIndex = 3;
            this.textBoxSecKey.Text = global::LockifiApp.Properties.Settings.Default.latch_seckey;
            // 
            // textBoxAppId
            // 
            this.textBoxAppId.Location = new System.Drawing.Point(135, 76);
            this.textBoxAppId.Name = "textBoxAppId";
            this.textBoxAppId.Size = new System.Drawing.Size(289, 20);
            this.textBoxAppId.TabIndex = 2;
            this.textBoxAppId.Text = global::LockifiApp.Properties.Settings.Default.latch_appid;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secret Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "App ID";
            // 
            // tabLockifi
            // 
            this.tabLockifi.Controls.Add(this.groupBox4);
            this.tabLockifi.Location = new System.Drawing.Point(4, 22);
            this.tabLockifi.Name = "tabLockifi";
            this.tabLockifi.Padding = new System.Windows.Forms.Padding(3);
            this.tabLockifi.Size = new System.Drawing.Size(466, 454);
            this.tabLockifi.TabIndex = 3;
            this.tabLockifi.Text = "Lockifi";
            this.tabLockifi.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelInfo);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 313);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lockifi settings";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(31, 188);
            this.labelInfo.MaximumSize = new System.Drawing.Size(400, 300);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(25, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonAllOpen);
            this.groupBox5.Controls.Add(this.radioButtonChanges);
            this.groupBox5.Location = new System.Drawing.Point(6, 58);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 107);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Listen mode";
            // 
            // radioButtonAllOpen
            // 
            this.radioButtonAllOpen.AutoSize = true;
            this.radioButtonAllOpen.Location = new System.Drawing.Point(252, 50);
            this.radioButtonAllOpen.Name = "radioButtonAllOpen";
            this.radioButtonAllOpen.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAllOpen.TabIndex = 0;
            this.radioButtonAllOpen.TabStop = true;
            this.radioButtonAllOpen.Text = "All open";
            this.radioButtonAllOpen.UseVisualStyleBackColor = true;
            this.radioButtonAllOpen.CheckedChanged += new System.EventHandler(this.radioButtonAllOpen_CheckedChanged);
            // 
            // radioButtonChanges
            // 
            this.radioButtonChanges.AutoSize = true;
            this.radioButtonChanges.Location = new System.Drawing.Point(78, 50);
            this.radioButtonChanges.Name = "radioButtonChanges";
            this.radioButtonChanges.Size = new System.Drawing.Size(67, 17);
            this.radioButtonChanges.TabIndex = 0;
            this.radioButtonChanges.TabStop = true;
            this.radioButtonChanges.Text = "Changes";
            this.radioButtonChanges.UseVisualStyleBackColor = true;
            this.radioButtonChanges.CheckedChanged += new System.EventHandler(this.radioButtonChanges_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(536, 498);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(617, 498);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 531);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeViewSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tabControl.ResumeLayout(false);
            this.tabRouters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRouters)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabLatch.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabLockifi.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSettings;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRouters;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabLatch;
        private System.Windows.Forms.TabPage tabLockifi;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewRouters;
        private System.Windows.Forms.Button buttonAddRouter;
        private System.Windows.Forms.Button buttonEditRouter;
        private System.Windows.Forms.Button buttonDeleteRouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSecKey;
        private System.Windows.Forms.TextBox textBoxAppId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonAllOpen;
        private System.Windows.Forms.RadioButton radioButtonChanges;
        private System.Windows.Forms.Label labelInfo;
    }
}