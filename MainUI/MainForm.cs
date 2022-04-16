using Business.Concrete;
using Core.PasswordControls;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
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
        readonly ProjectManager projectManager;
        readonly TodoManager todoManager;
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
            projectManager = new ProjectManager(new EfProjectDal());
            todoManager = new TodoManager(new EfTodoDal());

            securePassword = new SecurePassword();

            // Default User varsa giris yap
            if (Properties.Settings.Default.DefaultLogin)
            {
                LoginDefaultUser();
                MakePanelsVisible();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı
            string userNameInput = textBox1.Text;
            // Sifre
            string passwordInput = textBox2.Text;
            // Beni hatırla
            bool remember = rememberMe.Checked;

            // Eger beni hatırla secili ise
            // Default user ekle
            if (remember)
            {
                SetDefaultUser(userNameInput);
            }
            // Degilse ise Default user temizle
            else
            {
                ClearDefaultUser();
            }

            // Alanlar bos degilse
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
                        LoadFormToPanel(new Navigation(userExist), panel1, DockStyles.FILL);
                        MakePanelsVisible();
                        LoadProjects(userExist);
                    }
                    else
                    {
                        // Sifre dogru degilse hata mesajı goster
                        label2.Visible = true;
                    }
                }
                // Kullanıcı bulunamadıysa hata mesajı goster
                else
                {
                    label2.Visible = true;
                }
            }
            // Alanlar boş ise hata mesajı goster
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
                ClearPanel(panel);
            }
            // yeni icerik ekle
            form.TopLevel = false;

            // Panelin Dock style belirler
            form.Dock = style switch
            {
                DockStyles.FILL => DockStyle.Fill,
                DockStyles.TOP => DockStyle.Top,
                DockStyles.BOTTOM => DockStyle.Bottom,
                DockStyles.LEFT => DockStyle.Left,
                DockStyles.RIGHT => DockStyle.Right,
                _ => DockStyle.Fill, // Default Dock Style
            };

            panel.Controls.Add(form);
            form.Show();
        }

        private static void ClearPanel(Panel panel)
        {
            panel.Controls.Clear();
        }

        // Default Kullanıcı girisi yap
        private void LoginDefaultUser()
        {
            string username = Properties.Settings.Default.Username;
            User user = userManager.GetByUsername(username);
            LoadFormToPanel(new Navigation(user), panel1, DockStyles.FILL);
            usernameLabel.Text = user.Username;
            LoadProjects(user);

        }

        // Default kullanıcı ekle
        private static void SetDefaultUser(string username)
        {
            Properties.Settings.Default.DefaultLogin = true;
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Save();

        }
        // Default kullanıcı kaldır
        private static void ClearDefaultUser()
        {
            Properties.Settings.Default.DefaultLogin = false;
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        // Cıkıs yap
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MakePanelsInvisible();
            ClearDefaultUser();
            panel1.Controls.Clear();
        }
        // Panelleri gorunmez yap
        private void MakePanelsInvisible()
        {
            topPanel.Visible = false;
            middlePanel.Visible = false;
        }
        // Panelleri gorunur yap
        private void MakePanelsVisible()
        {
            topPanel.Visible = true;
            middlePanel.Visible = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Kullanıcının Projelerini yukle
        private void LoadProjects(User user)
        {
            foreach (Project project in projectManager.GetAllByUserId(user.Id))
            {
                Button btn = new()
                {
                    Text = project.ProjectName,
                    Name = project.ProjectName + project.Id,
                    Dock = DockStyle.Top,
                    Size = new Size(135, 50),
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    projectName.Text = project.ProjectName;
                    ClearPanel(contentPanel);
                    GetAllProjectTodos(project.Id);
                };
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void GetAllProjectTodos(int id)
        {
            foreach (Todo todo in todoManager.GetAllTodosByProjectId(id))
            {
                Label label = new()
                {
                    Text = todo.TodoText,
                    Dock = DockStyle.Top,
                };
                contentPanel.Controls.Add(label);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
