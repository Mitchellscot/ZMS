using System;
using System.Collections.Generic;
using System.Text;
using ZMS.Domain.Equipment;

namespace ZMS.Data.Equipment
{
    public interface IGearData
    {
        IEnumerable<Gear> GetAllEquipment();
        Gear GetGearById(int id);
        Gear AddGear(Gear newGear);
        Gear UpdateGear(Gear updatedGear);
        Gear DeleteGear(int id);
        int Commit();
        IEnumerable<GearInspection> GetInspections(int id);
        GearInspection GetInspectionById(int id);
        GearInspection AddInspection(GearInspection newInspection);
        GearInspection UpdateInspection(GearInspection updatedInspection);
        GearInspection DeleteInspection(int id);



    }
}
