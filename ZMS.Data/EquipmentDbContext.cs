using System;
using System.Collections.Generic;
using System.Text;
using ZMS.Domain.Equipment;
using Microsoft.EntityFrameworkCore;

namespace ZMS.Data
{
    public class EquipmentDbContext : DbContext
    {
        public EquipmentDbContext(DbContextOptions<EquipmentDbContext> options) : base(options)
        {

        }
        public DbSet<Gear> Equipment { get; set; }
        public DbSet<GearInspection> GearInspections { get; set; }
    }
}
