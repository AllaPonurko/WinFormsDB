using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinFormsDB.Entities
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } 
        public List <Student> Students { get; set; }
        public Group()
        {
            Id = new Guid();
            Students = new List<Student>();
            this.Name = Name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
