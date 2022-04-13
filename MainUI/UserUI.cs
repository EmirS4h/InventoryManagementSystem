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
        public UserUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["DefaultUsername"] = "";
            Properties.Settings.Default["DefaultUserPassword"] = "";
            Properties.Settings.Default["DefaultLogin"] = false;
            Properties.Settings.Default.Save();
        }
    }
}
