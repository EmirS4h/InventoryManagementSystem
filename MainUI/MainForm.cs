using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Windows.Forms;

namespace MainUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProjectManager manager = new ProjectManager(new EfProjectDal());
            dataGridView1.DataSource = manager.GetAllByMinTodoCount(2);
        }
    }
}
