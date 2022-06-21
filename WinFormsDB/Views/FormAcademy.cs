using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDB.Entities;
using WinFormsDB.Views;

namespace WinFormsDB
{
    public partial class FormAcademy : Form
    {
        public FormAcademy()
        {
            InitializeComponent();
            academy = new DbContextAplication.DbContextAcademy();
        }
        public DbContextAplication.DbContextAcademy academy;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {try
            {
                if (listBoxGroup.SelectedItem != null)
                {
                    FormStudent student = new FormStudent(this);
                    student.Show();
                }

                else MessageBox.Show("No group selected");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            txtNameGroup.Text = null;
            txtNameGroup.BackColor = Color.White;
            txtNameGroup.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNameGroup_TextChanged(object sender, EventArgs e)
        {
            txtNameGroup.BackColor = Color.Aqua;
        }

        private void btnSaveGroup_Click(object sender, EventArgs e)
        {
           
            if (txtNameGroup.Text.Length != 0)
            {
                listBoxGroup.Items.Add(txtNameGroup.Text);
                Group group = new Group();
                group.Name = txtNameGroup.Text;
                academy.Groups.Add(group);
                academy.groups.Add(group);
                academy.SaveChanges();
            }
            else MessageBox.Show("Enter name");
           
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            foreach (var item in academy.Groups)
            {
                try
                {
                    if (item.Name == listBoxGroup.SelectedItem.ToString()
                        && item.Students.Count == 0)
                    {
                    listBoxGroup.Items.Remove(listBoxGroup.SelectedItem);
                    academy.Groups.Remove(item);
                    academy.groups.Remove(item);
                    academy.SaveChanges();
                    }
                    else MessageBox.Show("Group has students. It's can't delete");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
