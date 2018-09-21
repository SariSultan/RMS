using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class DisposalReason
    {
        public int Disposal_Reason_ID { get; set; }
        public string Disposal_Detailed_Name { get; set; }
        public string Disposal_Detailed_Comment { get; set; }

        public DisposalReason()
        {

        }
    }
}
