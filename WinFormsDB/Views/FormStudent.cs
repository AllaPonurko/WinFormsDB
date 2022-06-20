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
        //public FormStudent()
        //{
        //    InitializeComponent();
        //}
        public FormStudent(FormAcademy academy)
        {
            InitializeComponent();
            labelGroup.Text = academy.listBoxGroup.SelectedItem.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName= txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Email = txtEmail.Text;
            if(txtFirstName.Text!=null&& txtLastName.Text!=null)
            listBoxStudents.Items.Add(student.ToString());
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
