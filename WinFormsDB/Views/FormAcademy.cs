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
    public struct DataStudent
    {
       public string TempFirsName;
        public string TempLastName;
        public string TempEmail;
        
    }
    public partial class FormAcademy : Form
    {
        public FormAcademy()
        {
            InitializeComponent();
            academy = new DbContextAplication.DbContextAcademy();
        }
        /// <summary>
        /// объявляем статическую переменную для переноса данных из формы для студента
        /// </summary>
        static public DataStudent dataStudent;
        public DbContextAplication.DbContextAcademy academy;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (academy.groups != null&& listBoxGroup.Items.Count==0)
                foreach (var item in academy.groups)
                    listBoxGroup.Items.Add(item.ToString());
            //else MessageBox.Show("Group's list is empty");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {try
            {
                if (listBoxGroup.SelectedItem != null)
                {
                    FormStudent student = new FormStudent();
                    student.ShowDialog();
                  txtDataStudent.Text = dataStudent.TempFirsName
                        + " " + dataStudent.TempLastName;
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
            //foreach(var item in academy.Groups)
            //{
            //    if (txtNameGroup.Text == item.Name)
            //        MessageBox.Show("A group with the same name already exists");
            //    else
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
            //List<Group> GroupToDelete = new List<Group>();
            foreach (var item in academy.Groups)
            {
                
                    if (item.Name == listBoxGroup.SelectedItem.ToString()
                        && item.Students.Count == 0)
                    {
                        //GroupToDelete.Add(item);
                        listBoxGroup.Items.Remove(listBoxGroup.SelectedItem);

                    //foreach (var item1 in GroupToDelete)
                    //{
                        academy.Groups.Remove(item);
                        academy.groups.Remove(item);
                        academy.SaveChanges();
                    //}
                }
                    
                    else MessageBox.Show("Group has students. It's can't delete");
                
            }
        }

        private void txtDataStudent_TextChanged(object sender, EventArgs e)
        {
            txtDataStudent.BackColor = Color.LightGray;
        }

        private void btnSaveStudentInGroup_Click(object sender, EventArgs e)
        {
            Student student = new Student() { FirstName = dataStudent.TempFirsName,
                LastName=dataStudent.TempLastName,Email=dataStudent.TempEmail };
            foreach(var item in academy.Groups)
            {
                if (item.Name == listBoxGroup.SelectedItem.ToString())
                {
                    item.Students.Add(student);
                    listBoxStudents.Items.Add(student.ToString());
                    academy.students.Add(student);
                    academy.SaveChanges();
                }

            }
        }
    }
}
