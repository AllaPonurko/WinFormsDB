
namespace WinFormsDB
{
    partial class FormAcademy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNameGroup = new System.Windows.Forms.TextBox();
            this.labelNameGroup = new System.Windows.Forms.Label();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            this.labelListGroups = new System.Windows.Forms.Label();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(47, 323);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(120, 23);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 15;
            this.listBoxGroup.Location = new System.Drawing.Point(47, 34);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(120, 184);
            this.listBoxGroup.TabIndex = 1;
            this.listBoxGroup.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(47, 260);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(120, 23);
            this.btnAddGroup.TabIndex = 2;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(692, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNameGroup
            // 
            this.txtNameGroup.Enabled = false;
            this.txtNameGroup.Location = new System.Drawing.Point(312, 72);
            this.txtNameGroup.Name = "txtNameGroup";
            this.txtNameGroup.Size = new System.Drawing.Size(152, 23);
            this.txtNameGroup.TabIndex = 4;
            this.txtNameGroup.TextChanged += new System.EventHandler(this.txtNameGroup_TextChanged);
            // 
            // labelNameGroup
            // 
            this.labelNameGroup.AutoSize = true;
            this.labelNameGroup.Location = new System.Drawing.Point(312, 34);
            this.labelNameGroup.Name = "labelNameGroup";
            this.labelNameGroup.Size = new System.Drawing.Size(75, 15);
            this.labelNameGroup.TabIndex = 5;
            this.labelNameGroup.Text = "Name Group";
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.Location = new System.Drawing.Point(312, 121);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(152, 23);
            this.btnSaveGroup.TabIndex = 6;
            this.btnSaveGroup.Text = "Save Group";
            this.btnSaveGroup.UseVisualStyleBackColor = true;
            this.btnSaveGroup.Click += new System.EventHandler(this.btnSaveGroup_Click);
            // 
            // labelListGroups
            // 
            this.labelListGroups.AutoSize = true;
            this.labelListGroups.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelListGroups.Location = new System.Drawing.Point(47, 16);
            this.labelListGroups.Name = "labelListGroups";
            this.labelListGroups.Size = new System.Drawing.Size(66, 15);
            this.labelListGroups.TabIndex = 7;
            this.labelListGroups.Text = "List Groups";
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(47, 290);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteGroup.TabIndex = 8;
            this.btnDeleteGroup.Text = "Delete Group";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // FormAcademy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAddStudent;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.labelListGroups);
            this.Controls.Add(this.btnSaveGroup);
            this.Controls.Add(this.labelNameGroup);
            this.Controls.Add(this.txtNameGroup);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "FormAcademy";
            this.Text = "Welcome to Academy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        public System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNameGroup;
        private System.Windows.Forms.Label labelNameGroup;
        private System.Windows.Forms.Button btnSaveGroup;
        private System.Windows.Forms.Label labelListGroups;
        private System.Windows.Forms.Button btnDeleteGroup;
    }
}

