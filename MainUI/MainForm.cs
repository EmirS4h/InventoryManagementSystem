using Business.Concrete;
using Core.PasswordControls;
using DataAccess.Concrete.EntityFramework;
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
    public partial class MainForm : Form
    {
        UserManager userManager;
        SecurePassword securePassword;
        public MainForm()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
            securePassword = new SecurePassword();

            bool defaultLogin = Properties.Settings.Default.DefaultLogin;
            if (defaultLogin)
            {
                User user = userManager.GetByUsername(Properties.Settings.Default.DefaultUsername);
                LoadForm(new UserUI(), panel1);
                LoadForm(new Navigation(user), panel2);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                errorLabel.Visible =  false;
                // Girilen verileri al
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                // Kullanici kayitlimi kontrol et
                User userExist = userManager.GetByUsername(username);

                // Eger kullanici kayitli ise Veri tabanindaki sifre ile Girilen sifre aynimi kontrol et
                if (userExist != null && securePassword.CheckIfPasswordsMatch(password, userExist.Password))
                {
                    if (rememberMe.Checked)
                    {
                        Properties.Settings.Default["DefaultUsername"] = userExist.Username;
                        Properties.Settings.Default["DefaultUserPassword"] = userExist.Password;
                        Properties.Settings.Default["DefaultLogin"] = true;
                        Properties.Settings.Default.Save();
                    }
                    LoadForm(new UserUI(),panel1);
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    rememberMe.Checked = false;
                }
                // Kullanici kayitli degilse 
                // Kayıt olmak istermi diye sor
                else
                {
                    DialogResult result = MessageBox.Show("Böyle bir kullanıcı yok. Yeni kayıt yapmak istermisiniz?", "Kullanıcı Yok", MessageBoxButtons.YesNo);
                    // Eger kullanici kayit olmak ister ise
                    if (result == DialogResult.Yes)
                    {
                        // yeni kullanici kaydi yap
                        userManager.Add(new User { Password = securePassword.HashPassword(password), Username = username });
                    }
                }
            }
            else
            {
                errorLabel.Visible =  true;
            }
        }


        private void LoadForm(Form form,Panel panel)
        {
            if(panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }

            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
