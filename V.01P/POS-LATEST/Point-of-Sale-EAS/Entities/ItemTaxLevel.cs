using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class ItemTaxLevel
    {
        public int Item_Tax_ID { get; set; }
        public string Item_Tax_Percentage { get; set; }
        public string Item_Tax_Description { get; set; }

        public ItemTaxLevel()
        {

        }

    }
}
