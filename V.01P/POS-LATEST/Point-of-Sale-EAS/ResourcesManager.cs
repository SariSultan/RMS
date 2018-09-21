using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Calcium_RMS
{
    public class ResourcesManager 
    {
        public static string GetString(string aKey)
        {
            try
            {
                string temp = Properties.Resources.ResourceManager.GetString(aKey);
                if (temp == null)
                {
                    return "#" + aKey;
                }
                else
                {
                    return temp;
                }
            }
            catch (Exception)
            {
               // string temp = Properties.Resources.ResourceManager.GetObject(aKey).ToString();
               // if (temp == null)
               // {
               //     return "#" + aKey;
               // }
               // else
               // {
                //    return temp;
               // }
                return "ERROR";
             
            }
                
            

        }

    }

    public class FlowDirectionManager 
    {

        public static RightToLeft GetFlowDirection()
        {
          //  return RightToLeft.Inherit;
            string key = "RightToLeft";
            string temp = Properties.Resources.ResourceManager.GetString(key);
            if (temp == null)
            {
                return RightToLeft.No;
            }
            else
            {
                RightToLeft resut;
                if (Enum.TryParse<RightToLeft>(temp, true, out resut))
                {
                    return resut;
                }
                else
                {
                    return RightToLeft.Yes;
                }

                //return Enum.Parse(typeof(FlowDirection), temp);
            }

        }

    }

}
