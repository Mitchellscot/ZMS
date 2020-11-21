using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZMS.Domain.Applicants
{
    public class Conversation
    {
        public int Id { get; set; }
        public bool Interview { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }
        [StringLength(250)]
        [Required]
        public string Summary { get; set; }
        public Applicant Applicant { get; set; }
        public int ApplicantId { get; set; }
    }
}
