using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsDB.Entities;

namespace WinFormsDB.DbContextAplication
{
    public class DbContextAcademy:DbContext
    {
        public DbContextAcademy()
        {
            Groups = new List<Group>();
        }
        public List<Group> Groups { get; set; }
        public DbSet<Student> students { get; set; } 
        public DbSet<Group> groups { get; set; }
        
        private string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repos\Source\WinFormsDB\WinFormsDB\DB\DbAcademy.mdf;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(sqlConnectionString);
                // .UseLazyLoadingProxies()
                
        }

    }
}


    
