using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace MainUI
{
    public partial class Navigation : Form
    {
        User user;
        public Navigation(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadUserDetails();
        }

        // Kullanıcının detaylarını yukle
        private void LoadUserDetails()
        {
            usernameLabel.Text = user.Username;
            totalProjectCount.Text = user.TotalProjects.ToString();
            projectsCompleted.Text = user.TotalProjectsCompleted.ToString();
            projectsLeft.Text = (user.TotalProjects - user.TotalProjectsCompleted).ToString();
        }
    }
}
