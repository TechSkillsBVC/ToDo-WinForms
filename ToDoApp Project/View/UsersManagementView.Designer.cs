﻿namespace ToDoApp_Project.View
{
    partial class UsersManagementView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvUserManagementView = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDbModelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxRole = new System.Windows.Forms.TextBox();
            this.lblDeleteManagement = new System.Windows.Forms.Label();
            this.lblCreateManagement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblUsersManagementBig = new System.Windows.Forms.Label();
            this.lblIdManageCreate = new System.Windows.Forms.Label();
            this.lblUsernameManageCreate = new System.Windows.Forms.Label();
            this.lblPasswordManageCreate = new System.Windows.Forms.Label();
            this.lblRoleManageCreate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditRole = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditPass = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDbModelDataSet = new ToDoApp_Project.ApplicationDbModelDataSet();
            this.userTableAdapter = new ToDoApp_Project.ApplicationDbModelDataSetTableAdapters.UserTableAdapter();
            this.lblDeleteById = new System.Windows.Forms.Label();
            this.txtBoxDeleteById = new System.Windows.Forms.TextBox();
            this.lblDelByID = new System.Windows.Forms.Label();
            this.btnDeleteById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManagementView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDbModelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDbModelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserManagementView
            // 
            this.dgvUserManagementView.AutoGenerateColumns = false;
            this.dgvUserManagementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserManagementView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvUserManagementView.DataSource = this.userBindingSource1;
            this.dgvUserManagementView.Location = new System.Drawing.Point(12, 48);
            this.dgvUserManagementView.Name = "dgvUserManagementView";
            this.dgvUserManagementView.Size = new System.Drawing.Size(508, 529);
            this.dgvUserManagementView.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(702, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(701, 116);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 37);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(701, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(531, 57);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(70, 20);
            this.txtBoxId.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(753, 57);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(140, 20);
            this.txtBoxPassword.TabIndex = 5;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(607, 57);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(140, 20);
            this.txtBoxUsername.TabIndex = 6;
            // 
            // txtBoxRole
            // 
            this.txtBoxRole.Location = new System.Drawing.Point(899, 57);
            this.txtBoxRole.Name = "txtBoxRole";
            this.txtBoxRole.Size = new System.Drawing.Size(80, 20);
            this.txtBoxRole.TabIndex = 7;
            // 
            // lblDeleteManagement
            // 
            this.lblDeleteManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteManagement.ForeColor = System.Drawing.Color.White;
            this.lblDeleteManagement.Location = new System.Drawing.Point(527, 188);
            this.lblDeleteManagement.Name = "lblDeleteManagement";
            this.lblDeleteManagement.Size = new System.Drawing.Size(453, 30);
            this.lblDeleteManagement.TabIndex = 8;
            this.lblDeleteManagement.Text = "Select user from the grid and click delete to delete the account";
            this.lblDeleteManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateManagement
            // 
            this.lblCreateManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateManagement.ForeColor = System.Drawing.Color.White;
            this.lblCreateManagement.Location = new System.Drawing.Point(523, 12);
            this.lblCreateManagement.Name = "lblCreateManagement";
            this.lblCreateManagement.Size = new System.Drawing.Size(449, 31);
            this.lblCreateManagement.TabIndex = 9;
            this.lblCreateManagement.Text = "To create account fill all the white boxes below";
            this.lblCreateManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(527, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "To edit account select it from the grid";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(873, 540);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(99, 37);
            this.btnGoBack.TabIndex = 11;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblUsersManagementBig
            // 
            this.lblUsersManagementBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersManagementBig.ForeColor = System.Drawing.Color.White;
            this.lblUsersManagementBig.Location = new System.Drawing.Point(158, 12);
            this.lblUsersManagementBig.Name = "lblUsersManagementBig";
            this.lblUsersManagementBig.Size = new System.Drawing.Size(177, 33);
            this.lblUsersManagementBig.TabIndex = 12;
            this.lblUsersManagementBig.Text = "ALL USERS";
            // 
            // lblIdManageCreate
            // 
            this.lblIdManageCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdManageCreate.ForeColor = System.Drawing.Color.White;
            this.lblIdManageCreate.Location = new System.Drawing.Point(528, 90);
            this.lblIdManageCreate.Name = "lblIdManageCreate";
            this.lblIdManageCreate.Size = new System.Drawing.Size(73, 23);
            this.lblIdManageCreate.TabIndex = 13;
            this.lblIdManageCreate.Text = "id";
            // 
            // lblUsernameManageCreate
            // 
            this.lblUsernameManageCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameManageCreate.ForeColor = System.Drawing.Color.White;
            this.lblUsernameManageCreate.Location = new System.Drawing.Point(607, 90);
            this.lblUsernameManageCreate.Name = "lblUsernameManageCreate";
            this.lblUsernameManageCreate.Size = new System.Drawing.Size(137, 23);
            this.lblUsernameManageCreate.TabIndex = 14;
            this.lblUsernameManageCreate.Text = "username";
            // 
            // lblPasswordManageCreate
            // 
            this.lblPasswordManageCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordManageCreate.ForeColor = System.Drawing.Color.White;
            this.lblPasswordManageCreate.Location = new System.Drawing.Point(750, 90);
            this.lblPasswordManageCreate.Name = "lblPasswordManageCreate";
            this.lblPasswordManageCreate.Size = new System.Drawing.Size(143, 23);
            this.lblPasswordManageCreate.TabIndex = 15;
            this.lblPasswordManageCreate.Text = "password";
            // 
            // lblRoleManageCreate
            // 
            this.lblRoleManageCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleManageCreate.ForeColor = System.Drawing.Color.White;
            this.lblRoleManageCreate.Location = new System.Drawing.Point(899, 90);
            this.lblRoleManageCreate.Name = "lblRoleManageCreate";
            this.lblRoleManageCreate.Size = new System.Drawing.Size(80, 23);
            this.lblRoleManageCreate.TabIndex = 16;
            this.lblRoleManageCreate.Text = "role";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(861, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "role";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(712, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(569, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "username";
            // 
            // txtEditRole
            // 
            this.txtEditRole.Location = new System.Drawing.Point(861, 469);
            this.txtEditRole.Name = "txtEditRole";
            this.txtEditRole.Size = new System.Drawing.Size(80, 20);
            this.txtEditRole.TabIndex = 20;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(569, 469);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(140, 20);
            this.txtEditName.TabIndex = 19;
            // 
            // txtEditPass
            // 
            this.txtEditPass.Location = new System.Drawing.Point(715, 469);
            this.txtEditPass.Name = "txtEditPass";
            this.txtEditPass.Size = new System.Drawing.Size(140, 20);
            this.txtEditPass.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn4.HeaderText = "Role";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.applicationDbModelDataSet;
            // 
            // applicationDbModelDataSet
            // 
            this.applicationDbModelDataSet.DataSetName = "ApplicationDbModelDataSet";
            this.applicationDbModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // lblDeleteById
            // 
            this.lblDeleteById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteById.ForeColor = System.Drawing.Color.White;
            this.lblDeleteById.Location = new System.Drawing.Point(907, 352);
            this.lblDeleteById.Name = "lblDeleteById";
            this.lblDeleteById.Size = new System.Drawing.Size(46, 23);
            this.lblDeleteById.TabIndex = 26;
            this.lblDeleteById.Text = "id";
            // 
            // txtBoxDeleteById
            // 
            this.txtBoxDeleteById.Location = new System.Drawing.Point(823, 351);
            this.txtBoxDeleteById.Name = "txtBoxDeleteById";
            this.txtBoxDeleteById.Size = new System.Drawing.Size(70, 20);
            this.txtBoxDeleteById.TabIndex = 25;
            // 
            // lblDelByID
            // 
            this.lblDelByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelByID.ForeColor = System.Drawing.Color.White;
            this.lblDelByID.Location = new System.Drawing.Point(527, 292);
            this.lblDelByID.Name = "lblDelByID";
            this.lblDelByID.Size = new System.Drawing.Size(453, 30);
            this.lblDelByID.TabIndex = 28;
            this.lblDelByID.Text = "Delete By Id";
            this.lblDelByID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteById
            // 
            this.btnDeleteById.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteById.Location = new System.Drawing.Point(701, 332);
            this.btnDeleteById.Name = "btnDeleteById";
            this.btnDeleteById.Size = new System.Drawing.Size(99, 54);
            this.btnDeleteById.TabIndex = 27;
            this.btnDeleteById.Text = "DELETE BY ID";
            this.btnDeleteById.UseVisualStyleBackColor = true;
            this.btnDeleteById.Click += new System.EventHandler(this.btnDeleteById_Click);
            // 
            // UsersManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(984, 592);
            this.Controls.Add(this.lblDelByID);
            this.Controls.Add(this.btnDeleteById);
            this.Controls.Add(this.lblDeleteById);
            this.Controls.Add(this.txtBoxDeleteById);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEditRole);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.txtEditPass);
            this.Controls.Add(this.lblRoleManageCreate);
            this.Controls.Add(this.lblPasswordManageCreate);
            this.Controls.Add(this.lblUsernameManageCreate);
            this.Controls.Add(this.lblIdManageCreate);
            this.Controls.Add(this.lblUsersManagementBig);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreateManagement);
            this.Controls.Add(this.lblDeleteManagement);
            this.Controls.Add(this.txtBoxRole);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvUserManagementView);
            this.Name = "UsersManagementView";
            this.Text = "ToDo App";
            this.Load += new System.EventHandler(this.UsersManagementView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManagementView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDbModelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDbModelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserManagementView;
        private System.Windows.Forms.BindingSource applicationDbModelDataSetBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private ApplicationDbModelDataSet applicationDbModelDataSet;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private ApplicationDbModelDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxRole;
        private System.Windows.Forms.Label lblDeleteManagement;
        private System.Windows.Forms.Label lblCreateManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblUsersManagementBig;
        private System.Windows.Forms.Label lblIdManageCreate;
        private System.Windows.Forms.Label lblUsernameManageCreate;
        private System.Windows.Forms.Label lblPasswordManageCreate;
        private System.Windows.Forms.Label lblRoleManageCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditRole;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditPass;
        private System.Windows.Forms.Label lblDeleteById;
        private System.Windows.Forms.TextBox txtBoxDeleteById;
        private System.Windows.Forms.Label lblDelByID;
        private System.Windows.Forms.Button btnDeleteById;
    }
}