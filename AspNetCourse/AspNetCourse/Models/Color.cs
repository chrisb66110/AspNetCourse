using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetCourse.Models
{
    [Table("Color")]
    public class Color
    {
        [Key]
        [Column("Id")]
        public int idColor { get; set; }

        [Column("Name")]
        public string name { get; set; }
    }
}