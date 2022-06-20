using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDB.Views;

namespace WinFormsDB
{
    public partial class FormAcademy : Form
    {
        public FormAcademy()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FormStudent student = new FormStudent();
            student.Show();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            FormGroup formGroup = new FormGroup();
            formGroup.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
