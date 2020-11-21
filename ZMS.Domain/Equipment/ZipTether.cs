using System;
using System.Collections.Generic;
using System.Text;

namespace ZMS.Domain.Equipment
{
    public class ZipTether
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int InUseCount { get; set; }
        public int StorageCount { get; set; }
    }
}
