using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetCourse.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Column("Id")]
        public int id { get; set; }

        [Column("Name")]
        [StringLength(64,ErrorMessage = "Maximum 64 characters")]
        public string name { get; set; }

        [Column("Birthdate")]
        public DateTime birthdate { get; set; }

        [Column("Age")]
        public int age { get; set; }

    }
}