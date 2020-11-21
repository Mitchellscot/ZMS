using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ZMS.Domain.Applicants
{
    public class Applicant
    {
        public Applicant()
        {
            Conversations = new List<Conversation>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime AppDate { get; set; }
        public bool Hired { get; set; }
        [Required]
        public TrainingDates Training { get; set; }
        [Required]
        [StringLength(50)]
        public string JobSource { get; set; }
        [Required]
        [StringLength(250)]
        public string Availability { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public bool Returning { get; set; }
        public List<Conversation> Conversations { get; set; }
    }
}
