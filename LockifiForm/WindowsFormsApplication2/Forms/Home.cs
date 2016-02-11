using LockifiApp;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;
using LatchSDK;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public partial class Lockifi : Form
    {
        private Boolean listening;
        private Boolean onNotify;
        private Boolean router_current_status;
        private string current_script_router;

        public  List<User> users { get; set; }
        public List<Router> routers { get; set; }

        public Latch latch { get; set; }

        public Lockifi()
        {
            global::LockifiApp.Properties.Settings.Default.Reload();
            InitializeComponent();

            notifyIcon1.Text = "Lockifi";
            notifyIcon1.ContextMenuStrip = contextMenuStripNotifyIcon;

            users = new List<User>();
            routers = new List<Router>();

            listening = false;
            onNotify = false;
            router_current_status = false;
            current_script_router = "";

            FromXML();

            latch = new Latch(global::LockifiApp.Properties.Settings.Default.latch_appid, global::LockifiApp.Properties.Settings.Default.latch_seckey);

            Fill_ComboBoxRouters();
            Fill_comboBoxWifiStatus();

            this.Show();

            Fill_dataGridViewUsers();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form settings = new Settings(this);
            settings.ShowDialog(this);
            Fill_dataGridViewUsers();
            Fill_ComboBoxRouters();
        }
        
        public void toXML()
        {
            string path = Directory.GetCurrentDirectory();

            if (!Directory.Exists(path + "\\Data")) // if the file directory doesnt exist..
                Directory.CreateDirectory(path + "\\Data"); // create the file directory

            if (!File.Exists(path + "\\Data\\users.xml")) // if the XML file doesnt exist..
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\Data\\users.xml", Encoding.UTF8); // create the xml file
                xW.WriteStartElement("users");
                xW.WriteEndElement();
                xW.Close();
            }

            if (!File.Exists(path + "\\Data\\routers.xml")) // if the XML file doesnt exist..
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\Data\\routers.xml", Encoding.UTF8); // create the xml file
                xW.WriteStartElement("routers");
                xW.WriteEndElement();
                xW.Close();
            }

            // create XML document to write to
            XmlDocument xDocUsers = new XmlDocument();
            xDocUsers.Load(path + "\\Data\\users.xml");
            XmlNode rootU = xDocUsers.DocumentElement;
            rootU.RemoveAll();

            XmlDocument xDocRouters = new XmlDocument();
            xDocRouters.Load(path + "\\Data\\routers.xml");
            XmlNode rootR = xDocRouters.DocumentElement;
            rootR.RemoveAll();

            // create node for every property inside the taskProperties class
            foreach (User user in users)
            {
                XmlNode nodeTop = xDocUsers.CreateElement("User");
                XmlNode nodeName = xDocUsers.CreateElement("name");
                XmlNode nodeAccountId = xDocUsers.CreateElement("accountId");

                nodeName.InnerText = user.name;
                nodeAccountId.InnerText = user.accountId;

                // add these nodes to the 'nodeTop' node
                nodeTop.AppendChild(nodeName);
                nodeTop.AppendChild(nodeAccountId);

                // add the nodeTop to the document
                xDocUsers.DocumentElement.AppendChild(nodeTop);
            }
            // create node for every property inside the taskProperties class
            foreach (Router router in routers)
            {
                XmlNode nodeTop = xDocRouters.CreateElement("router");
                XmlNode nodeName = xDocRouters.CreateElement("name");
                XmlNode nodeFile = xDocRouters.CreateElement("file");

                nodeName.InnerText = router.name;
                nodeFile.InnerText = router.file;

                // add these nodes to the 'nodeTop' node
                nodeTop.AppendChild(nodeName);
                nodeTop.AppendChild(nodeFile);

                // add the nodeTop to the document
                xDocRouters.DocumentElement.AppendChild(nodeTop);
            }
            // save the document
            xDocUsers.Save(path + "\\Data\\users.xml");
            // save the document
            xDocRouters.Save(path + "\\Data\\routers.xml");
        }

        public void FromXML()
        {
            string path = Directory.GetCurrentDirectory();
            if (Directory.Exists(path + "\\Data"))
            {
                if (File.Exists(path + "\\Data\\users.xml"))
                {
                    
                    XmlDocument xDocUsers = new XmlDocument();
                    xDocUsers.Load(path + "\\Data\\users.xml");

                    XmlNode rootNode = xDocUsers.SelectSingleNode("/users");

                    string name = null;
                    string accountId = null;

                    foreach (XmlNode node in rootNode.ChildNodes) // for each <testcase> node
                    {
                        try
                        {
                            name = node.ChildNodes[0].InnerText;
                            accountId = node.ChildNodes[1].InnerText;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Error in reading XML Data", "xmlError", MessageBoxButtons.OK);
                            //borrar archivo
                        }

                        User user = new User(name, accountId);
                        users.Add(user);
                        user.status = false;
                    }
                }
                if (File.Exists(path + "\\Data\\routers.xml"))
                {
                    XmlDocument xDocRouters = new XmlDocument();
                    xDocRouters.Load(path + "\\Data\\routers.xml");

                    XmlNode rootNode = xDocRouters.SelectSingleNode("/routers");

                    string name = null;
                    string file = null;

                    foreach (XmlNode node in rootNode.ChildNodes) // for each <testcase> node
                    {
                        try
                        {
                            name = node.ChildNodes[0].InnerText;
                            file = node.ChildNodes[1].InnerText;

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Error in reading XML Data", "xmlError", MessageBoxButtons.OK);
                            //borrar archivo
                        }
                        Router router = new Router(name, file);
                        routers.Add(router);
                    }
                }
            }
        }

        private Boolean Fill_dataGridViewUsers()
        {
            dataGridViewUsers.Rows.Clear();
            if (global::LockifiApp.Properties.Settings.Default.latch_appid=="" || global::LockifiApp.Properties.Settings.Default.latch_seckey == "" || global::LockifiApp.Properties.Settings.Default.latch_appid == "*" || global::LockifiApp.Properties.Settings.Default.latch_seckey == "*")
            {
                string message = "You must configure Latch";
                string caption = "Latch is not configured";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (users.Count > 0)
                {
                    LatchResponse statusC = null;

                    try {
                        statusC = latch.Status(users[0].accountId);
                    }catch(Exception e)
                    {
                        string message = "You do not have internet connection";
                        string caption = "Problem with internet connection";
                        DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (statusC.Error != null && statusC.Error.Code == 102)
                    {
                        string message = "Latch configuration is wrong";
                        string caption = "Problem with Latch configuration";
                        DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        dataGridViewUsers.ColumnCount = 3;
                        dataGridViewUsers.Columns[0].Name = "accountId";
                        dataGridViewUsers.Columns[1].Name = "User";
                        dataGridViewUsers.Columns[2].Name = "Status";
                        dataGridViewUsers.Columns[0].Visible = false;
                        foreach (User user in users)
                        {
                            user.status = user.getLatchStatus(latch);
                            String[] dataGrid_data = { user.accountId, user.name, user.status.ToString() }; ;
                            dataGridViewUsers.Rows.Add(dataGrid_data);
                        }
                        dataGridViewUsers.ClearSelection();
                        return true;
                    }
                }
            }
            return false;
        }
        private void Fill_ComboBoxRouters()
        {
            comboBoxRouters.Items.Clear();
            if (routers.Count == 0)
            {
                comboBoxRouters.Items.Add("<empty>");
            }
            else {
                foreach (Router router in routers)
                {
                    comboBoxRouters.Items.Add(router);
                }
            }
            comboBoxRouters.SelectedIndex = 0;
            comboBoxRouters.Select();
        }
        private void Fill_comboBoxWifiStatus()
        {
            comboBoxWifiStatus.Items.AddRange(new object[] {
            "-unknow-",
            "On",
            "Off"});
            comboBoxWifiStatus.SelectedIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listening)
            {
                comboBoxRouters.Enabled = true;
                comboBoxWifiStatus.Enabled = true;
                buttonConfiguration.Enabled = true;
                buttonListen.Text = "Start listen";
                listening = false;
                labelCurrentWifiStatus.Text = "-unknow-";
                timerReloadUsers.Stop();
            }
            else
            {
                if (LockifiApp.Properties.Settings.Default.latch_appid == "" || LockifiApp.Properties.Settings.Default.latch_seckey == "" || global::LockifiApp.Properties.Settings.Default.latch_appid == "*" || global::LockifiApp.Properties.Settings.Default.latch_seckey == "*")
                {
                    string message = "You must configure Latch to listen";
                    string caption = "Latch configuration fails";
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (users.Count == 0)
                {
                    string message = "You must add one user to listen";
                    string caption = "Users empty";
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (routers.Count == 0 || comboBoxRouters.Text == "<empty>")
                {
                    string message = "You must add one router to listen";
                    string caption = "Routers empty";
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (comboBoxWifiStatus.SelectedIndex == 0)
                {
                    string message = "You must enter the wifi status";
                    string caption = "Unknow wifi status";
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Fill_dataGridViewUsers())
                    {
                        foreach(Router router in routers)
                        {
                            if (router.name == comboBoxRouters.Text)
                            {
                                current_script_router = router.file;
                                break;
                            }
                        }
                        if (current_script_router == "")
                        {
                            string message = "There has been a problem with the script of the router\nTry again with another router";
                            string caption = "Router script problem";
                            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {

                            comboBoxRouters.Enabled = false;
                            comboBoxWifiStatus.Enabled = false;
                            buttonConfiguration.Enabled = false;
                            buttonListen.Text = "Stop listen";
                            listening = true;

                            labelCurrentWifiStatus.Text = comboBoxWifiStatus.Text;
                            router_current_status = (comboBoxWifiStatus.Text == "On");

                            //Select listen mode
                            if (global::LockifiApp.Properties.Settings.Default.listen_mode == 2)
                            {
                                timerReloadUsers.Tick += new EventHandler(listen_all_open);
                            }
                            else
                            {
                                timerReloadUsers.Tick += new EventHandler(listen_changes);
                            }
                            timerReloadUsers.Start();   //Start timer
                        }
                    }
                }
            }
        }

        private void Lockifi_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                onNotify = true;
            }
        }

        private void reOpenLockifi()
        {
            if (onNotify)
            {
                onNotify = false;
                this.Show();
                this.Activate();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void Lockifi_FormClosed(object sender, FormClosingEventArgs e)
        {
            string captionE;
            string messageE;
            MessageBoxIcon iconE;

            if (listening)
            {
                captionE = "Alert";
                messageE = "Are you sure you want to quit ?\nIf you exit the listen will stop";
                iconE = MessageBoxIcon.Warning;
            }
            else
            {
                captionE = "Alert";
                messageE = "Are you sure you want to quit ?";
                iconE = MessageBoxIcon.Information;
            }

            if (MessageBox.Show(messageE, captionE,MessageBoxButtons.YesNo, iconE) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            reOpenLockifi();
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Reflection.MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(notifyIcon1, null);

            }
        }

        private void viewToolStripMenuItemNotifyIcon_Click(object sender, EventArgs e)
        {
            reOpenLockifi();
        }

        private void exitToolStripMenuItemNotifyIcon_Click(object sender, EventArgs e)
        {
            reOpenLockifi();
            this.Close();
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
        private void listen_changes(object sender, EventArgs e)
        {

            foreach (User user in users)
            {
                Boolean userOnLatchStatus = user.getLatchStatus(latch);

                if (userOnLatchStatus != user.status)
                {
                    user.status = userOnLatchStatus;

                    dataGridViewUsers.Rows[
                    dataGridViewUsers.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["accountId"].Value.ToString().Equals(user.accountId))
                    .First().Index
                    ].Cells["status"].Value = user.status.ToString();
                    dataGridViewUsers.Refresh();

                    if (userOnLatchStatus != router_current_status)
                    {

                        if (userOnLatchStatus)
                        {
                            
                            labelCurrentWifiStatus.Text = "Enabling...";
                            labelCurrentWifiStatus.Refresh();
                            timerReloadUsers.Stop();
                            //script
                            run_script(current_script_router, true);

                            run_script(current_script_router, true);
                            System.Threading.Thread.Sleep(20000);
                            timerReloadUsers.Start();
                            labelCurrentWifiStatus.Text = "On";
                            router_current_status = true;

                        }
                        else
                        {
                            labelCurrentWifiStatus.Text = "Disabling...";
                            labelCurrentWifiStatus.Refresh();
                            timerReloadUsers.Stop();
                            //script
                            run_script(current_script_router, false);

                            System.Threading.Thread.Sleep(20000);
                            timerReloadUsers.Start();
                            labelCurrentWifiStatus.Text = "Off";
                            router_current_status = false;
                        }
                    }
                }

            }
        }
        private async void  listen_all_open(object sender, EventArgs e)
        {
            Boolean globalState = true;

            foreach (User user in users)
            {
                Boolean userOnLatchStatus = user.getLatchStatus(latch);

                if (userOnLatchStatus != user.status)   //If user latch change
                {
                    user.status = userOnLatchStatus;

                    dataGridViewUsers.Rows[
                    dataGridViewUsers.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["accountId"].Value.ToString().Equals(user.accountId))
                    .First().Index
                    ].Cells["status"].Value = user.status.ToString();
                    dataGridViewUsers.Refresh();
                }


                if (!userOnLatchStatus) //Change global state
                {
                    globalState = false;
                }

            }
            if(globalState != router_current_status)
            {
                timerReloadUsers.Stop();
                if (globalState)
                {
                    //Enable
                    labelCurrentWifiStatus.Text = "Enabling...";
                    labelCurrentWifiStatus.Refresh();
                    //llamar a script
                    run_script(current_script_router,true);

                    await Task.Delay(20000);

                    labelCurrentWifiStatus.Text = "On";
                    router_current_status = true;
                }
                else
                {
                    //Unable
                    labelCurrentWifiStatus.Text = "Disabling...";
                    labelCurrentWifiStatus.Refresh();
                    //llamar a script
                    run_script(current_script_router,false);

                    labelCurrentWifiStatus.Text = "Off";
                    router_current_status = false;
                }
                timerReloadUsers.Start();
            }
        }
        private void run_script(String file, Boolean state)
        {
            string stateString = "0";
            if (state)
            {
                stateString = "1";
            }

            
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Scripts\", file);
            path = (path.Contains(" ")) ? "\"" + path + "\"" : path;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python.exe";

            start.Arguments = path + " " + stateString;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
    }
}
