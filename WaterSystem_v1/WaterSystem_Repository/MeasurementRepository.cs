using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class MeasurementRepository
    {
        DatabaseCommunication dbCommunication = null;

        public MeasurementRepository()
        {
            dbCommunication = new DatabaseCommunication();
        }

        public DataSet Retrieve()
        {
            return dbCommunication.blFill("SP_MeasurementMaster");
        }

        public DataSet Save(Dictionary<string,string> parameters)
        {
            return dbCommunication.blFill_Para_Name(parameters, "SP_MeasurementMaster");
        }
    }
}
