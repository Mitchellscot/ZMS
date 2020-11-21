using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZMS.Domain.Equipment
{
    public class Prussik
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfFirstUse { get; set; }
        public int InUse { get; set; }
        public int InStorage { get; set; }
        public int T2 { get; set; }
        public int T3 { get; set; }
        public int T4 { get; set; }
        public int T5 { get; set; }
        public int P2 { get; set; }
        public int T6 { get; set; }
    }
}
