using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinFormsDB.Entities
{
    public class Student
    {   [Key]
        public Guid Id { get; set; }
        public Student()
        {
            Id = new Guid();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
        }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid GroupId { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return FirstName+" "+LastName;
        }


    }
}
