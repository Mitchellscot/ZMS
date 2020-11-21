using System;
using System.Collections.Generic;
using System.Text;

namespace ZMS.Domain.Equipment
{
    public class GloveCount
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int XSGloves { get; set; }
        public int SGloves { get; set; }
        public int MGloves { get; set; }
        public int LGloves { get; set; }
        public int XLGloves { get; set; }
        public int BrakesInUse { get; set; }
        public int BrakesInStorage { get; set; }
        public int SGuide { get; set; }
        public int MGuide { get; set; }
        public int LGuide { get; set; }
        public int XLGuide { get; set; }
    }
}
