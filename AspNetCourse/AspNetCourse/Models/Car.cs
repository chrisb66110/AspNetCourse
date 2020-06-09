using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetCourse.Models
{
    [Table("Car")]
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("RegistrationNumber")]
        public int registrationNumber { get; set; }

        [Column("Year")]
        public int year { get; set; }

        [Column("IdOwner")]
        public int idOwner { get; set; }
        [ForeignKey("idOwner")]
        public Person owner { get; set; }

        public ICollection<CarColor> Colors { get; set; }

    }
}