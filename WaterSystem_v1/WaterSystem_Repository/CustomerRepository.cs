using System.Collections.Generic;
using System.Data;

namespace WaterSystem_Repository
{
    public class CustomerRepository
    {
        DatabaseCommunication communication = null;
        public const string spName = "SP_CustomerMaster";
        public CustomerRepository()
        {
            communication = new DatabaseCommunication();
        }
        public DataSet Retrieve()
        {
            return communication.blFill(spName);
        }

        public DataSet Save(Dictionary<string, string> parameters)
        {
            return communication.blFill_Para_Name(parameters, spName);
        }
    }
}
