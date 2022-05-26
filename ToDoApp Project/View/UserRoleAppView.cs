﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp_Project.View
{
    public partial class UserRoleAppView : Form
    {
        public UserRoleAppView()
        {
            InitializeComponent();
        }

        private void ToDoListsButton_Click(object sender, EventArgs e)
        {
            Hide();
            txtBoxCreateToDoTitle view = new txtBoxCreateToDoTitle();
            view.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserRoleAppView_Load(object sender, EventArgs e)
        {
            userMainLabel.Text = $"Welcome {LoginView.currentUserName}";
        }
    }
}
