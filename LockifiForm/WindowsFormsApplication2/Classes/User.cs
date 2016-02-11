using LatchSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockifiApp
{
    public class User
    {
        public string name { get; set; }
        public string accountId {get; }
        public Boolean status { get; set; }

        public User(string nameI, string accountIdI)
        {
            name = nameI;
            accountId = accountIdI;
            status = false;
        }
        public Boolean getLatchStatus(Latch latch)
        {
            LatchResponse statusResponse = null;

            try
            {
                statusResponse = latch.Status(accountId);
            }
            catch (Exception es)
            {
                string message = "You do not have internet connection";
                string caption = "Problem with internet connection";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (statusResponse.Error != null && statusResponse.Error.Message != "")
            {
                string message = statusResponse.Error.Message;
                string caption = "Latch connection: " + statusResponse.Error.Code;
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                Dictionary<string, object> op = (Dictionary<string, object>)statusResponse.Data["operations"];
                Dictionary<string, object> st = (Dictionary<string, object>)op[global::LockifiApp.Properties.Settings.Default.latch_appid];
                
                return st["status"].ToString() == "on";
            }
        }
    }
}
