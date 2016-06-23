using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTERP.DataAccessLayer
{
    public sealed class DALDLL { }
    public class DALBase
    {
     public GetDataBaseType OneIns
        {
            get { return oneIns; }
        }
        private GetDataBaseType oneIns = GetDataBaseType.Instance;

        private  DataBaseType dbType = GetDataBaseType.Instance.CreateDataBaseType("ConnectDataBaseMSSQL", null);
      //  private DataBaseType dbType = ConnectDataBaseMSSQL.Instance;

        public DataBaseType DbType
        {
            get
            {
                return dbType;
            }
           
        }
     
     
    }
}
