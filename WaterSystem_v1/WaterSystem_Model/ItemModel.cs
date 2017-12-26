using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class ItemModel: IModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int MeasurementId { get; set; }
        public bool IsActive { get; set; }
        public string PFlag { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
