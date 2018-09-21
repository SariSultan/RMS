using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class DisposalGeneral
    {
        public int Disposal_General_Number { get; set; }
        public string Disposal_General_Date { get; set; }
        public string Disposal_General_Time { get; set; }
        public int Disposal_General_Reason { get; set; }
        public double Disposal_General_TotalTax { get; set; }
        public double Disposal_General_TotalCost { get; set; }
        public int Disposal_General_IsRevised{ get; set; }
        public string Disposal_General_ReviseDate { get; set; }
        public string Disposal_General_ReviseTime { get; set; }
        public int Disposal_General_IsChecked { get; set; }
        public string Disposal_General_CheckDate { get; set; }
        public string Disposal_General_CheckTime { get; set; }       
        public string Disposal_General_Comments { get; set; }
        public int Disposal_General_TellerID { get; set; }

        public DisposalGeneral()
        {

        }
    }
}
