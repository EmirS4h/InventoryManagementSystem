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
    public partial class UserUI : Form
    {
        string username;
        public UserUI(User user)
        {
            InitializeComponent();
            username = user.Username;
            label1.Text = username;
        }

        private void UserUI_Load(object sender, EventArgs e)
        {
        }
    }
}
