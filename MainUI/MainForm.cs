﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
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
        public MainForm()
        {
            InitializeComponent();
            TodoManager manager = new TodoManager(new InMemoryTodoDal());
            dataGridView1.DataSource = manager.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}