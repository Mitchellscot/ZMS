using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZMS.Domain.Equipment
{
    public class GearInspection
    {
        public int Id { get; set; }
        public GearType GearType { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(250)]
        public string Summary { get; set; }
        [Required]
        [StringLength(25)]
        public string Inspector { get; set; }
        public Gear Gear { get; set; }
        public int LabelNumber { get; set; }
    }
}
