using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class AdjustInventoryDetailed
    {
        public int ID { get; set; }
        public int Number { get; set; } /*FK to Adjustinventorygeneral*/
        public int ItemID { get; set; } /*FK to items table ID column*/
        public double OldQty { get; set; }
        public double NewQty { get; set; }
        public double DifferenceQty { get; set; }
        public double DifferenceValue { get; set; }

    }
}
