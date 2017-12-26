﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class SupplierModel: IModel
    {
        public int Supplier_Id { get; set; }
        public int SupplierNo { get; set; }
        public string  Comp_Name { get; set; }
        public string Address { get; set; }
        public string Supplier_Mobileno { get; set; }
        public string VatNo { get; set; }
        public string TinNo { get; set; }
        public bool IsActive { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
