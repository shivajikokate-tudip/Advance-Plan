using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class CustomerModel
    {
        public int Customer_Id { get; set; }
        public int Customer_No { get; set; }
        public string Comp_Name { get; set; }
        public string Address { get; set; }
        public string VatNo { get; set; }
        public string TinNo { get; set; }
        public bool IsActive { get; set; }
    }
}
