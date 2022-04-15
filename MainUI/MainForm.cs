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
        readonly UserManager userManager;
        readonly SecurePassword securePassword;

        enum DockStyles
        {
            LEFT,
            RIGHT,
            TOP,
            BOTTOM,
            FILL,
        }

        public MainForm()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
            securePassword = new SecurePassword();

            // Default User varsa giris yap
            if (Properties.Settings.Default.DefaultLogin)
            {
                LoginDefaultUser();
            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userNameInput = textBox1.Text;
            string passwordInput = textBox2.Text;
            bool remember = rememberMe.Checked;

            if (remember)
            {
                SetDefaultUser(userNameInput);
            }
            else
            {
                ClearDefaultUser();
            }

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
                        LoadFormToPanel(new UserUI(userExist), panel3, DockStyles.FILL);
                        LoadFormToPanel(new Navigation(userExist), panel1, DockStyles.FILL);
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
        private static void LoadFormToPanel(Form form, Panel panel, DockStyles style)
        {
            // Panelde halihazırda bir icerik varsa temizle
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            // yeni icerik ekle
            form.TopLevel = false;

            form.Dock = style switch
            {
                DockStyles.FILL => DockStyle.Fill,
                DockStyles.TOP => DockStyle.Top,
                DockStyles.BOTTOM => DockStyle.Bottom,
                DockStyles.LEFT => DockStyle.Left,
                DockStyles.RIGHT => DockStyle.Right,
                _ => DockStyle.Fill,
            };

            panel.Controls.Add(form);
            form.Show();
        }

        private void LoginDefaultUser()
        {
            string username = Properties.Settings.Default.Username;
            User user = userManager.GetByUsername(username);
            LoadFormToPanel(new UserUI(user), panel3, DockStyles.FILL);
            LoadFormToPanel(new Navigation(user), panel1, DockStyles.FILL);
        }

        private static void SetDefaultUser(string username)
        {
            Properties.Settings.Default.DefaultLogin = true;
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Save();

        }
        private static void ClearDefaultUser()
        {
            Properties.Settings.Default.DefaultLogin = false;
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Save();
        }
    }
}
