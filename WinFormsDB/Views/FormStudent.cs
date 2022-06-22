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
            labelGroup.Text = academy.listBoxGroup.SelectedItem.ToString();
            Student student = new Student();
            student.FirstName= txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Email = txtEmail.Text;
            academy.academy.students.Add(student);
            foreach(var item in academy.academy.Groups)
            {
                if (item.Name == academy.listBoxGroup.SelectedItem.ToString())
                    item.Students.Add(student);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(txtFirstName.Text.Length!=0 && txtLastName.Text.Length!=0&&txtEmail.Text.Length!=0)
            listBoxStudents.Items.Add(txtFirstName.Text+" "+ txtLastName.Text);
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
