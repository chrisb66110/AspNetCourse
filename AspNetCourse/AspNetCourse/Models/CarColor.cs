using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetCourse.Models
{
    [Table("CarColor")]
    public class CarColor
    {
        [Key]
        [Column("IdCar", Order = 0)]
        public int idCar { get; set; }
        [ForeignKey("idCar")]
        public Car car { get; set; }

        [Key]
        [Column("IdColor", Order = 1)]
        public int idColor { get; set; }
        [ForeignKey("idColor")]
        public Color color { get; set; }

    }
}