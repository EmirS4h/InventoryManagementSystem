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
            TodoManager manager = new TodoManager(new EfTodoDal());
            dataGridView1.DataSource = manager.GetTodoDetails();
        }
    }
}
