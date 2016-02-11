using LatchSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockifiApp.Forms
{
    public partial class PairUser : Form
    {
        public string accountId { get; set; }
        public string username { get; }
        Latch latch;

        public PairUser(String usernameI,Latch latchI)
        {
            username = usernameI;
            latch = latchI;

            InitializeComponent();

            accountId = "";
            textBoxUsername.Text = username;
            textBoxUsername.Enabled = false;
            textBoxPairCode.Select();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxPairCode.Text == "")
            {
                string captionE = "Pair code empty";
                string messageE = "You must enter a pair code";

                MessageBox.Show(messageE, captionE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form wait = new Forms.Wait();
                wait.Show();

                LatchResponse pair = null;
                try
                {
                    pair = latch.Pair(textBoxPairCode.Text);
                }
                catch
                {
                    wait.Close();
                    string message = "You do not have internet connection";
                    string caption = "Problem with internet connection";
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (pair.Error != null && pair.Error.Message != "")
                {
                    wait.Close();
                    string message = pair.Error.Message;
                    string caption = "Latch connection: " + pair.Error.Code;
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    wait.Close();
                    accountId = pair.Data["accountId"].ToString();
                    this.Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPairCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAccept.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
