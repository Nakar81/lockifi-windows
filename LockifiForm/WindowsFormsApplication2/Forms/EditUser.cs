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
    public partial class EditUser : Form
    {
        public User current_user;
        public Lockifi grandparent;

        public EditUser(User user,Lockifi grandparentI)
        {
            current_user = user;
            grandparent = grandparentI;
            InitializeComponent();
            textBoxUsername.Text = current_user.name;
        }


        private void buttonAccept_Click(object sender, EventArgs e)
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
                Boolean repeat = false;
                foreach(User user in grandparent.users)
                {
                    if(user.name == textBoxUsername.Text && user != current_user)
                    {
                        repeat = true;
                        break;
                    }
                }
                if (repeat)
                {
                    string captionE = "Username already exist";
                    string messageE = "You must enter other username";

                    MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Text = current_user.name;
                }
                else {
                    current_user.name = textBoxUsername.Text;
                    this.Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            string captionE = "Delete user";
            string messageE = "Are you sure you want to delet this user ?";

            if (MessageBox.Show(messageE, captionE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LatchSDK.LatchResponse unpair = null;

                Form wait = new Forms.Wait();
                wait.Show();

                try
                {
                    unpair = grandparent.latch.Unpair(current_user.accountId);
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
                    grandparent.users.Remove(current_user);
                    wait.Close();
                    this.Close();
                }
            }
        }
    }
}
