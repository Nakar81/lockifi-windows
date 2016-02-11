using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace LockifiApp
{
    public partial class AddRouter : Form
    {
        public Lockifi grandparent;
        public Boolean fileSelected;

        public AddRouter(Lockifi grandparentI)
        {
            grandparent = grandparentI;
            InitializeComponent();
            fileSelected = false;
        }

        private void buttonAcceptRoutername_Click(object sender, EventArgs e)
        {
            if (textBoxRoutername.Text == "")
            {
                //Si esta selec
                string captionE = "Router name empty";
                string messageE = "You must enter a router name";

                MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String routername = textBoxRoutername.Text;
                Boolean repeat = false;

                foreach (Router router in grandparent.routers)
                {
                    if (router.name == routername)
                    {
                        repeat = true;
                        break;
                    }
                }
                if (repeat)
                {
                    
                    string captionE = "Router name already exists";
                    string messageE = "You must enter other router name";

                    MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxRoutername.Text = "";
                    routername = "";
                }
                else
                {
                    if(!fileSelected)
                    {
                        string captionE = "Problem with script";
                        string messageE = "You must add a script file";

                        MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else{
                        if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Scripts"))
                            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Scripts");

                        var fileName = openFileDialog1.FileName;
                        string router_file = Path.GetFileNameWithoutExtension(fileName) + "_" + routername + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".py";

                        string new_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Scripts\", router_file);

                        File.Copy(fileName, new_path, true);
                        //save routername and  file
                        grandparent.routers.Add(new Router(routername, router_file));
                        //save xml
                        grandparent.toXML();
                        this.Close();
                    }
                }
            }
        }

        private void buttonCancelRoutername_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileSelected = true;
            }
        }
    }
}
