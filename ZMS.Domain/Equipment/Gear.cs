using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Text;

namespace ZMS.Domain.Equipment
{
    public class Gear // named Gear because the plural of Equipment is still Equipment! So Equipment = Plural and Gear = Singular
    {
        public int Id { get; set; }
        public int LabelNumber { get; set; }
        [StringLength(25)]
        public string SerialNumber { get; set; }
        [Required]
        public GearType GearType { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfFirstUse { get; set; }
        [Required]
        [StringLength(25)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(25)]
        public string GearModel { get; set; }
        [StringLength(250)]
        public string Notes { get; set; }
        public bool RescueGear { get; set; }
        public GearStatus Status { get; set; }
        public GearLocation Location { get; set; }
        public bool GuideEquipment { get; set; }
        [StringLength(25)]
        public string GuideAssigned { get; set; }
        public List<GearInspection> Inspections { get; set; }
    }
}
