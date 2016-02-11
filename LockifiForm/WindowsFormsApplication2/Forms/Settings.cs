using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LockifiApp;
using LockifiApp.Forms;
using System.IO;
using LatchSDK;

namespace WindowsFormsApplication2
{
    public partial class Settings : Form
    {
        public Lockifi parent;

        public Settings(Lockifi parentI)
        {

            parent = parentI;

            InitializeComponent();
            InitializeRadioButtons();

            Fill_dataGridViewUsers();
            Fill_dataGridViewRouters();
            InitializeTreeView();

        }
        private void InitializeTreeView()
        {
            

            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;

            TreeNode[] Sarray = new TreeNode[] {new TreeNode("Routers"), new TreeNode("Users"), new TreeNode("Latch"), new TreeNode("Lockifi") };
            treeViewSettings.Nodes.Add(new TreeNode("Settings", Sarray));
            treeViewSettings.ExpandAll();

            treeViewSettings.SelectedNode = treeViewSettings.Nodes[0].Nodes[0];
            treeViewSettings.Nodes[0].ForeColor = Color.Blue;
        }
        private void InitializeRadioButtons()
        {
            if (global::LockifiApp.Properties.Settings.Default.listen_mode == 1)
            {
                this.radioButtonChanges.Checked = true;
                this.radioButtonAllOpen.Checked = false;
                labelInfo.Text = "'Changes' mode detects changes in the latch of the users, if one user changes his latch status the wifi status will change to that.";
                labelInfo.Refresh();
            }
            else if (global::LockifiApp.Properties.Settings.Default.listen_mode == 2)
            {
                this.radioButtonAllOpen.Checked = true;
                this.radioButtonChanges.Checked = false;
                labelInfo.Text = "'All open' mode only turns on the wifi if all users have their latch unlocked.";
                labelInfo.Refresh();
            }
            else
            {
                global::LockifiApp.Properties.Settings.Default.listen_mode = 1;
                this.radioButtonChanges.Checked = true;
                this.radioButtonAllOpen.Checked = false;
                labelInfo.Text = "Changes mode detects changes in the latch of the users, if one user changes his latch status the wifi status will change to that.";
                labelInfo.Refresh();
            }
        }
        private void save_changes()
        {
            //Save listen mode
            if (radioButtonChanges.Checked == true)
            {
                global::LockifiApp.Properties.Settings.Default.listen_mode = 1;
            }
            else if (radioButtonAllOpen.Checked == true)
            {
                global::LockifiApp.Properties.Settings.Default.listen_mode = 2;
            }
            else
            {
                global::LockifiApp.Properties.Settings.Default.listen_mode = 1;
            }
            //Save appid
            global::LockifiApp.Properties.Settings.Default.latch_appid = textBoxAppId.Text;
            //Save seckey
            global::LockifiApp.Properties.Settings.Default.latch_seckey = textBoxSecKey.Text;

            global::LockifiApp.Properties.Settings.Default.Save();

            parent.latch = new Latch(global::LockifiApp.Properties.Settings.Default.latch_appid, global::LockifiApp.Properties.Settings.Default.latch_seckey);
        }
        private void Fill_dataGridViewUsers()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.ColumnCount = 3;
            dataGridViewUsers.Columns[0].Name = "accountId";
            dataGridViewUsers.Columns[1].Name = "User";
            dataGridViewUsers.Columns[2].Name = "Status";
            dataGridViewUsers.Columns[0].Visible = false;
            foreach (User user in parent.users)
            {
                String[] dataGrid_data = { user.accountId, user.name, user.status.ToString() };
                dataGridViewUsers.Rows.Add(dataGrid_data);
            }
            if(parent.users.Count == 0)
            {
                buttonEditUser.Enabled = false;
                buttonDeleteUser.Enabled = false;
            }
        }
        private void Fill_dataGridViewRouters()
        {
            dataGridViewRouters.Rows.Clear();
            dataGridViewRouters.ColumnCount = 2;
            dataGridViewRouters.Columns[0].Name = "Name";
            dataGridViewRouters.Columns[1].Name = "File";
            foreach (Router router in parent.routers)
            {
                String[] dataGrid_data = { router.name, Path.GetFileName(router.file) };
                dataGridViewRouters.Rows.Add(dataGrid_data);
            }
            if (parent.routers.Count == 0)
            {
                buttonEditRouter.Enabled = false;
                buttonDeleteRouter.Enabled = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            save_changes(); //Save information
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddRouter_Click(object sender, EventArgs e)
        {
            Form settings = new AddRouter(parent);
            settings.ShowDialog(this);
            Fill_dataGridViewRouters();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form add_username = new AddUsername(parent);
            add_username.ShowDialog(this);
            string username = (add_username as AddUsername).username;
            if (username != "")
            {
                Form pair_user = new PairUser(username,parent.latch);
                pair_user.ShowDialog(this);
                string accountId = (pair_user as PairUser).accountId;
                if (accountId != "")
                {
                    parent.users.Add(new User(username, accountId));
                    parent.toXML();
                    Fill_dataGridViewUsers();
                }
            }
        }

        private void buttonEditRouter_Click(object sender, EventArgs e)
        {
            Router router_selected = null;

            foreach (Router router in parent.routers)
            {
                if (dataGridViewRouters.CurrentRow.Cells[0].Value.ToString() == router.name)
                {
                    router_selected = router;
                    break;
                }
            }
            Form settings = new EditRouter(router_selected,parent);
            settings.ShowDialog(this);

            Fill_dataGridViewRouters();
            //save xml
            parent.toXML();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            //Si esta selec
            User user_selected = null;

            foreach (User user in parent.users)
            {
                if (dataGridViewUsers.CurrentRow.Cells[1].Value.ToString() == user.name)
                {
                    user_selected = user;
                    break;
                }
            }
            Form settings = new EditUser(user_selected,parent);
            settings.ShowDialog(this);
            Fill_dataGridViewUsers();
            //save xml
            parent.toXML();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            //if selected
            string captionE = "Delete user";
            string messageE = "Are you sure you want to delet this user?";

            if (MessageBox.Show(messageE, captionE,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LatchSDK.LatchResponse unpair = null;
                User user_selected = null;

                Form wait = new LockifiApp.Forms.Wait();
                wait.Show();

                foreach (User user in parent.users)
                {
                    if (dataGridViewUsers.CurrentRow.Cells[1].Value.ToString() == user.name)
                    {
                        user_selected = user;
                        break;
                    }
                }

                 try
                {
                        unpair = parent.latch.Unpair(user_selected.accountId);
                }
                catch
                {
                    wait.Close();
                    string message = "You do not have internet connection";
                    string caption = "Problem with internet connection";
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (unpair.Error != null && unpair.Error.Message != "")
                {
                    wait.Close();
                    string message = unpair.Error.Message;
                    string caption = "Latch connection: " + unpair.Error.Code;
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    wait.Close();
                    parent.users.Remove(user_selected);
                    Fill_dataGridViewUsers();
                    //save xml
                    parent.toXML();

                }
            }
        }

        private void buttonDeleteRouter_Click(object sender, EventArgs e)
        {
            //Si esta selec
            string captionE = "Delete router";
            string messageE = "Are you sure you want to delet this router?";

            if (MessageBox.Show(messageE, captionE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Router router_selected = null;

                foreach (Router router in parent.routers)
                {
                    if (dataGridViewRouters.CurrentRow.Cells[0].Value.ToString() == router.name)
                    {
                        router_selected = router;
                        break;
                    }
                }
                parent.routers.Remove(router_selected);
                parent.toXML();
                Fill_dataGridViewRouters();
            }
        }

        private void dataGridViewRouters_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridView.HitTestInfo hit = dataGridViewRouters.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.None)
                {
                    dataGridViewRouters.ClearSelection();
                    dataGridViewRouters.CurrentCell = null;
                }
            }
        }

        private void dataGridViewUsers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridView.HitTestInfo hit = dataGridViewUsers.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.None)
                {
                    dataGridViewUsers.ClearSelection();
                    dataGridViewUsers.CurrentCell = null;
                }
            }
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                buttonEditUser.Enabled = false;
                buttonDeleteUser.Enabled = false;
            }
            else
            {
                buttonEditUser.Enabled = true;
                buttonDeleteUser.Enabled = true;
            }
        }

        private void dataGridViewRouters_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRouters.SelectedRows.Count == 0)
            {
                buttonEditRouter.Enabled = false;
                buttonDeleteRouter.Enabled = false;
            }
            else
            {
                buttonEditRouter.Enabled = true;
                buttonDeleteRouter.Enabled = true;
            }
        }

        private void treeViewSettings_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }


        private void treeViewSettings_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text != null)
            {
                if (e.Node.Text != "Settings")
                {
                    foreach (TabPage ad in tabControl.TabPages)
                    {
                        if (ad.Name == "tab" + e.Node.Text)
                        {
                            tabControl.SelectedTab = ad;
                            break;
                        }
                    }
                }
            }
        }

        private void treeViewSettings_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Text != null)
            {
                if (e.Node.Text == "Settings")
                {
                    e.Cancel = true;
                    treeViewSettings.SelectedNode = treeViewSettings.Nodes[0].Nodes[0];
                }
            }
        }

        private void radioButtonChanges_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    labelInfo.Text = "'Changes' mode detects changes in the latch of the users, if one user changes his latch status the wifi status will change to that.";
                    labelInfo.Refresh();
                }
            }
        }

        private void radioButtonAllOpen_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    labelInfo.Text = "'All open' mode only turns on the wifi if all users have their latch unlocked.";
                    labelInfo.Refresh();
                }
            }
        }
    }
}
