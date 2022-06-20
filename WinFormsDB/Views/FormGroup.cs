using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsDB.DbContextAplication;
using WinFormsDB.Entities;

namespace WinFormsDB.Views
{
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
        }
        //public FormGroup(FormAcademy academy)
        //{
        //    InitializeComponent();
            
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e, FormAcademy academy)
        {
            Group group = new Group();
            group.Name = txtName.Text;
            DbContextAcademy contextAcademy = new DbContextAcademy();
            contextAcademy.Groups.Add(group);
            academy.listBoxGroup.Items.Add(group.Name);
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
