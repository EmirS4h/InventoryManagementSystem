using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace MainUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProjectManager manager = new ProjectManager(new EfProjectDal());
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
