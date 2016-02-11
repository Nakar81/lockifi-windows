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
    public partial class EditRouter : Form
    {
        public Lockifi grandparent;
        public Router current_router;
        Boolean fileSelected;

        public EditRouter(Router router,Lockifi grandparentI)
        {
            grandparent = grandparentI;
            InitializeComponent();
            current_router = router;
            fileSelected = false;
            textBoxRoutername.Text = current_router.name;
            labelFile.Text = Path.GetFileName(router.file);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileSelected = true;
                labelFile.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxRoutername.Text == "")
            {
                //Si esta selec
                string captionE = "Routername empty";
                string messageE = "You must enter a router name";

                MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Boolean repeat = false;
                foreach(Router router in grandparent.routers)
                {
                    if (router.name == textBoxRoutername.Text && router != current_router)
                    {
                        repeat = true;
                        break;
                    }
                }
                if (repeat)
                {

                    string captionE = "Router name already exist";
                    string messageE = "You must enter other router name";

                    MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxRoutername.Text = current_router.name;
                }
                else {
                    current_router.name = textBoxRoutername.Text;

                    if (fileSelected)
                    {
                        var fileName = openFileDialog1.FileName;
                        string router_file = Path.GetFileNameWithoutExtension(fileName) + "_" + current_router.name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".py";

                        string new_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Scripts\", router_file);

                        File.Copy(fileName, new_path, true);
                        current_router.file = router_file;
                    }
                    this.Close();
                }
            }
        }
    }
}
