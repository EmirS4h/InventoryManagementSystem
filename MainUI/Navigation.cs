using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI
{
    public partial class Navigation : Form
    {
        public Navigation(User user)
        {
            InitializeComponent();
            usernameLabel.Text = user.Username;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultLogin = false;
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Save();
        }
    }
}
