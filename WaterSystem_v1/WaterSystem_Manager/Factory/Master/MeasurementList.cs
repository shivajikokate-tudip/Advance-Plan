using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Manager.Reciever;

namespace WaterSystem_Manager.Factory
{
    public class MeasurementList : ICommand
    {
        private MeasurementReciever _measurementReceiver;

        public MeasurementList(MeasurementReciever measurementReceiver)
        {
            _measurementReceiver = measurementReceiver;
        }
        public DataSet Execute()
        {
           return _measurementReceiver.GetList();
        }
    }
}
