using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace LockifiApp
{
    public partial class AddUsername : Form
    {
        public string username { get; set; }
        public Lockifi grandparent;

        public AddUsername(Lockifi grandparentI)
        {
            grandparent = grandparentI;

            InitializeComponent();
            username = "";
            buttonAcceptUsername.Focus();
        }

        private void buttonAcceptUsername_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                //Si esta selec
                string captionE = "Username empty";
                string messageE = "You must enter a username";

                MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //save data
                username = textBoxUsername.Text;
                Boolean repeat = false;
                
                foreach(User user in grandparent.users)
                {
                    if (user.name == username)
                    {
                        repeat = true;
                        break;
                    }
                }
                if (repeat)
                {
                    //if exist username
                    string captionE = "Username already exist";
                    string messageE = "You must enter other username";

                    MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Text = "";
                    username = "";
                }
                else {
                    this.Close();
                }
            }
        }

        private void buttonCancelUsername_Click(object sender, EventArgs e)
        {
            username = "";
            this.Close();
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAcceptUsername.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
