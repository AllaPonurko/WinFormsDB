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
        public FormStudent(FormAcademy academy)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e, FormAcademy academy,Group group)
        {
            Student student = new Student();
            student.FirstName= txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Email = txtEmail.Text;
            if (academy.listBoxGroup.SelectedItem.ToString() == group.Name)
                group.Students.Add(student);
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
