using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsDB.Entities;

namespace WinFormsDB.DbContextAplication
{
    public class DbContextAcademy:DbContext
    {
        public List<Group> Groups { get; set; }
        public DbSet<Student> students { get; set; }=null!;
        //public DbContextAcademy() => Database.EnsureCreated();
        public DbContextAcademy()
        {
            Groups = new List<Group>();
        }
    }
}
