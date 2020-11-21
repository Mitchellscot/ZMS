using System;
using System.Collections.Generic;
using System.Text;
using ZMS.Domain.Equipment;

namespace ZMS.Data.Equipment
{
    public class SqlGearData : IGearData
    {
        public Gear AddGear(Gear newGear)
        {
            throw new NotImplementedException();
        }

        public GearInspection AddInspection(GearInspection newInspection)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public Gear DeleteGear()
        {
            throw new NotImplementedException();
        }

        public Gear DeleteGear(int id)
        {
            throw new NotImplementedException();
        }

        public GearInspection DeleteInspection()
        {
            throw new NotImplementedException();
        }

        public GearInspection DeleteInspection(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gear> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gear> GetAllEquipment()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gear> GetByGearType()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gear> GetByGearType(GearType type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gear> GetByGearType(string type)
        {
            throw new NotImplementedException();
        }

        public Gear GetGearById(int Id)
        {
            throw new NotImplementedException();
        }

        public GearInspection GetInspectionById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GearInspection> GetInspections(int id)
        {
            throw new NotImplementedException();
        }

        public Gear UpdateGear(Gear updatedGear)
        {
            throw new NotImplementedException();
        }

        public GearInspection UpdateInspection(GearInspection updatedInspection)
        {
            throw new NotImplementedException();
        }
    }
}
