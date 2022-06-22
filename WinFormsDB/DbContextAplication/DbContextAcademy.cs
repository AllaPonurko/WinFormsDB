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
            //Database.EnsureCreated();
        }
        public List<Group> Groups { get; set; }
        public DbSet<Student> students { get; set; } 
        public DbSet<Group> groups { get; set; }

        private string sqlConnectionString = @"Server=(localdb)\mssqllocaldb;Database=DbAcademy;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(sqlConnectionString);
                // .UseLazyLoadingProxies()
                
        }

    }
}


    
