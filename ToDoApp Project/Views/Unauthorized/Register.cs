﻿using System;
using System.Windows.Forms;
using ToDoApp_Project.Controller;
using ToDoApp_Project.Model;
using ToDoApp_Project.Utilities;

namespace ToDoApp_Project.View
{
    public partial class Register : Form
    {
        UserController userController = new UserController();

        public Register()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            Main view = new Main();
            view.Show();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (Validator.EmptyString(txtRegisterName.Text) ||
                Validator.EmptyString(txtRegisterPassword.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtRegisterName.Text = "";
                txtRegisterPassword.Text = "";
            }
            else if (Validator.NameLength(txtRegisterName.Text))
            {
                MessageBox.Show("Name must be between 3 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtRegisterName.Text = "";
                txtRegisterPassword.Text = "";
            }
            else if (Validator.NameLength(txtRegisterPassword.Text))
            {
                MessageBox.Show("Password must be between 6 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtRegisterName.Text = "";
                txtRegisterPassword.Text = "";
            }
            else if (userController.UsernameExist(txtRegisterName.Text))
            {
                MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtRegisterName.Text = "";
                txtRegisterPassword.Text = "";
            }
            else
            {
                User user = new User();
                user.Username = txtRegisterName.Text;
                user.Password = txtRegisterPassword.Text;
                user.Role = "User";

                userController.Register(user);

                Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void checkTogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtRegisterPassword.UseSystemPasswordChar = !txtRegisterPassword.UseSystemPasswordChar;
        }
    }
}
