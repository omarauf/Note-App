using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Login
{
    public partial class Form1 : Form
    {
        private Form2 f2;
        private User user;
        private WebClient client = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            NameValueCollection userInfo = new NameValueCollection();
            userInfo.Add("name", txtRegName.Text);
            userInfo.Add("email", txtRegEmail.Text);
            userInfo.Add("password", txtRegPassword.Text);
            byte[] responseArray = client.UploadValues("http://syiner.com/C/register.php", "POST", userInfo);
            String responseString = Encoding.Default.GetString(responseArray);
            user = JsonConvert.DeserializeObject<User>(responseString);
            Console.WriteLine("\nResponse :\n{0}", responseString);

            if (user.Error) //we have an error show this error
            {
                //MessageBox.Show(user.Error_msg);
                Console.WriteLine("\n Error message :\n{0}", user.Error_msg);
                this.Enabled = true;
            }
            else //no error open form 2 and close form 1
            {
                Console.WriteLine("\n user :\n{0}", user);
                f2 = new Form2(user);
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            NameValueCollection userInfo = new NameValueCollection();
            userInfo.Add("email", txtLogEmail.Text);
            userInfo.Add("password", txtLogPassword.Text);
            byte[] responseArray = client.UploadValues("http://syiner.com/C/login.php", "POST", userInfo);
            String responseString = Encoding.Default.GetString(responseArray);
            user = JsonConvert.DeserializeObject<User>(responseString);
            Console.WriteLine("\nResponse :\n{0}", responseString);

            if (user.Error) //we have an error show this error
            {
                //MessageBox.Show(user.Error_msg);
                Console.WriteLine("\nError message :\n{0}", user.Error_msg);
                this.Enabled = true;
            }
            else //no error open form 2 and close form 1
            {
                Console.WriteLine("\nuser :\n{0}", user);
                f2 = new Form2(user);
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
        }

        #region placeHolder Control
        private void removePlaceholder(object sender, EventArgs e)
        {
            TextBox text = (TextBox) sender;
            text.Text = "";
        }

        private void writePlaceholder(object sender, EventArgs e)
        {
            if (sender.Equals(txtRegName) && txtRegName.Text == "")
                txtRegName.Text = "Name";
            else if (sender.Equals(txtRegEmail) && txtRegEmail.Text == "")
                txtRegEmail.Text = "Email";
            else if (sender.Equals(txtRegPassword) && txtRegPassword.Text == "")
                txtRegPassword.Text = "Password";
            else if (sender.Equals(txtLogEmail) && txtLogEmail.Text == "")
                txtRegPassword.Text = "Email";
            else if (sender.Equals(txtLogPassword) && txtLogPassword.Text == "")
                txtRegPassword.Text = "Password";
        }
        #endregion

    }
}
