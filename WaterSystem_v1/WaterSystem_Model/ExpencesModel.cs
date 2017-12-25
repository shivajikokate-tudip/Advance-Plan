using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class ExpencesModel
    {
        public int Expences_ID { get; set; }
        public string Option_Type { get; set; }
        public string Expences_Name { get; set; }
        public bool IsActive { get; set; }
        public string SysFlag { get; set; }
    }
}
