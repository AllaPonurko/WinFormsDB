using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsDB.Entities;

namespace WinFormsDB.Views
{
    public partial class FormStudent : Form
    {
        
        public FormStudent()
        {
            InitializeComponent();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {

            //if (txtFirstName.Text.Length != 0 && txtLastName.Text.Length != 0 && txtEmail.Text.Length != 0)
            //{

            //    FormAcademy.dataStudent.TempLastName=txtLastName.Text; 
            //    FormAcademy.dataStudent.TempFirsName=txtFirstName.Text;
            //    FormAcademy.dataStudent.TempEmail=txtEmail.Text ;

            //}
            this.Close();
            //else
            //{
            //    MessageBox.Show("Enter all data");
            //}
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            FormAcademy.dataStudent.TempFirsName= txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            FormAcademy.dataStudent.TempLastName = txtLastName.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            FormAcademy.dataStudent.TempEmail = txtEmail.Text;
        }
    }
}
