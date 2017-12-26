using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class SubExpencesModel: IModel
    {
        public int SubExpences_ID { get; set; }
        public int Expences_ID { get; set; }
        public string SubExpences_Name { get; set; }
        public bool IsActive { get; set; }
        public bool SysFlag { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
