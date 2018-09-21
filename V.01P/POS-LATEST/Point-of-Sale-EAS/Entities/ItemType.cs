using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class ItemType
    {
        public int Item_Type_ID { get; set; }   //Auto, PK 
        public string Item_Type_Name { get; set; }
        public string Item_Type_Description { get; set; }


        public ItemType()
        {

        }
    }
}
