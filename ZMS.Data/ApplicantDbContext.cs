using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZMS.Domain.Applicants;

namespace ZMS.Data
{
    public class ApplicantDbContext : DbContext
    {
        public ApplicantDbContext(DbContextOptions<ApplicantDbContext> options) : base (options)
        {

        }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
    }
}
