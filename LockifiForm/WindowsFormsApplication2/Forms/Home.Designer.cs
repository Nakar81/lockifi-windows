namespace WindowsFormsApplication2
{
    partial class Lockifi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lockifi));
            this.labelCBRouters = new System.Windows.Forms.Label();
            this.comboBoxRouters = new System.Windows.Forms.ComboBox();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonListen = new System.Windows.Forms.Button();
            this.comboBoxWifiStatus = new System.Windows.Forms.ComboBox();
            this.labelCBWifiStatus = new System.Windows.Forms.Label();
            this.labelWifiStatus = new System.Windows.Forms.Label();
            this.labelCurrentWifiStatus = new System.Windows.Forms.Label();
            this.timerReloadUsers = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItemNotifyIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItemNotifyIcon = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCBRouters
            // 
            this.labelCBRouters.AutoSize = true;
            this.labelCBRouters.Location = new System.Drawing.Point(20, 26);
            this.labelCBRouters.Name = "labelCBRouters";
            this.labelCBRouters.Size = new System.Drawing.Size(42, 13);
            this.labelCBRouters.TabIndex = 0;
            this.labelCBRouters.Text = "Router:";
            // 
            // comboBoxRouters
            // 
            this.comboBoxRouters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRouters.FormattingEnabled = true;
            this.comboBoxRouters.Location = new System.Drawing.Point(68, 23);
            this.comboBoxRouters.Name = "comboBoxRouters";
            this.comboBoxRouters.Size = new System.Drawing.Size(122, 21);
            this.comboBoxRouters.TabIndex = 0;
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.Location = new System.Drawing.Point(637, 16);
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.Size = new System.Drawing.Size(168, 38);
            this.buttonConfiguration.TabIndex = 2;
            this.buttonConfiguration.Text = "Settings";
            this.buttonConfiguration.UseVisualStyleBackColor = true;
            this.buttonConfiguration.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridViewUsers.Location = new System.Drawing.Point(23, 71);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(782, 263);
            this.dataGridViewUsers.TabIndex = 3;
            this.dataGridViewUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUsers_MouseDown);
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(380, 23);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(85, 24);
            this.buttonListen.TabIndex = 5;
            this.buttonListen.Text = "Start listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxWifiStatus
            // 
            this.comboBoxWifiStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWifiStatus.FormattingEnabled = true;
            this.comboBoxWifiStatus.Location = new System.Drawing.Point(239, 23);
            this.comboBoxWifiStatus.Name = "comboBoxWifiStatus";
            this.comboBoxWifiStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWifiStatus.TabIndex = 10;
            // 
            // labelCBWifiStatus
            // 
            this.labelCBWifiStatus.AutoSize = true;
            this.labelCBWifiStatus.Location = new System.Drawing.Point(205, 29);
            this.labelCBWifiStatus.Name = "labelCBWifiStatus";
            this.labelCBWifiStatus.Size = new System.Drawing.Size(28, 13);
            this.labelCBWifiStatus.TabIndex = 7;
            this.labelCBWifiStatus.Text = "Wifi:";
            // 
            // labelWifiStatus
            // 
            this.labelWifiStatus.AutoSize = true;
            this.labelWifiStatus.Location = new System.Drawing.Point(496, 29);
            this.labelWifiStatus.Name = "labelWifiStatus";
            this.labelWifiStatus.Size = new System.Drawing.Size(28, 13);
            this.labelWifiStatus.TabIndex = 8;
            this.labelWifiStatus.Text = "Wifi:";
            // 
            // labelCurrentWifiStatus
            // 
            this.labelCurrentWifiStatus.AutoSize = true;
            this.labelCurrentWifiStatus.Location = new System.Drawing.Point(530, 29);
            this.labelCurrentWifiStatus.Name = "labelCurrentWifiStatus";
            this.labelCurrentWifiStatus.Size = new System.Drawing.Size(51, 13);
            this.labelCurrentWifiStatus.TabIndex = 9;
            this.labelCurrentWifiStatus.Text = "-unknow-";
            // 
            // timerReloadUsers
            // 
            this.timerReloadUsers.Interval = 1000;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Lockifi";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItemNotifyIcon,
            this.exitToolStripMenuItemNotifyIcon});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(100, 48);
            // 
            // viewToolStripMenuItemNotifyIcon
            // 
            this.viewToolStripMenuItemNotifyIcon.Name = "viewToolStripMenuItemNotifyIcon";
            this.viewToolStripMenuItemNotifyIcon.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItemNotifyIcon.Text = "View";
            this.viewToolStripMenuItemNotifyIcon.Click += new System.EventHandler(this.viewToolStripMenuItemNotifyIcon_Click);
            // 
            // exitToolStripMenuItemNotifyIcon
            // 
            this.exitToolStripMenuItemNotifyIcon.Name = "exitToolStripMenuItemNotifyIcon";
            this.exitToolStripMenuItemNotifyIcon.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItemNotifyIcon.Text = "Exit";
            this.exitToolStripMenuItemNotifyIcon.Click += new System.EventHandler(this.exitToolStripMenuItemNotifyIcon_Click);
            // 
            // Lockifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 357);
            this.Controls.Add(this.labelCurrentWifiStatus);
            this.Controls.Add(this.labelWifiStatus);
            this.Controls.Add(this.labelCBWifiStatus);
            this.Controls.Add(this.comboBoxWifiStatus);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.buttonConfiguration);
            this.Controls.Add(this.comboBoxRouters);
            this.Controls.Add(this.labelCBRouters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lockifi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lockifi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lockifi_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Lockifi_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCBRouters;
        private System.Windows.Forms.ComboBox comboBoxRouters;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.ComboBox comboBoxWifiStatus;
        private System.Windows.Forms.Label labelCBWifiStatus;
        private System.Windows.Forms.Label labelWifiStatus;
        private System.Windows.Forms.Label labelCurrentWifiStatus;
        private System.Windows.Forms.Timer timerReloadUsers;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItemNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItemNotifyIcon;
    }
}

