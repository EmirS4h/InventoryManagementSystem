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
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userNameInput = textBox1.Text;
            string passwordInput = textBox2.Text;

            if (userNameInput != "" && passwordInput != "")
            {
                // Kullanıcı varmı kontrol et
                User userExist = CheckIfUserExist(userNameInput);

                // Eger kullanıcı varsa
                if (userExist != null)
                {
                    // Sifre dogrumu kontrol et
                    if (securePassword.CheckIfPasswordsMatch(passwordInput, userExist.Password))
                    {
                        // Sifre dogruysa
                        LoadFormToPanel(new UserUI(userExist), panel3);
                    }
                    else
                    {
                        // Sifre dogru degilse hata mesajı goster
                        label2.Visible = true;
                    }
                }
                else
                {
                    label2.Visible = true;
                }
            }
            else
            {
                label1.Visible = true;
            }

        }

        // Kullanıcı varmı kontrol et
        private User CheckIfUserExist(string username)
        {
            User user = userManager.GetByUsername(username);
            return user;
        }

        // Panel icerigini degistir
        private void LoadFormToPanel(Form form, Panel panel)
        {
            // Panelde halihazırda bir icerik varsa temizle
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            // yeni icerik ekle
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
