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
            userProjectsCount.Text = user.TotalProjects.ToString();
            userProjectsCompletedCount.Text = user.TotalProjectsCompleted.ToString();
            userProjectsLeft.Text = (user.TotalProjects - user.TotalProjectsCompleted).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
