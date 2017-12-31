using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    class RowMaterialRepository: BaseRepository
    {
        public const string spName = "SP_RowMaterialMaster";
        public RowMaterialRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
