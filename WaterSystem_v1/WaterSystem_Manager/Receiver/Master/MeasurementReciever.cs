using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Reciever
{
    public class MeasurementReciever
    {
        DatabaseCommunication dbCommunication = null;
        public MeasurementReciever()
        {
            dbCommunication = new DatabaseCommunication();
        }
        public void Add()
        {

        }

        public void Update()
        {

        }

        public DataSet GetList()
        {
           return dbCommunication.blFill("SP_MeasurementMaster");
        }
    }
}
