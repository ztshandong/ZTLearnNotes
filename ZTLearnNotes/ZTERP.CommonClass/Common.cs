using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ZTERP.CommonClass
{
    public class Common
    {
        public static DataTable GetTable()
        {
            DataTable dt = new DataTable("Test");
            dt.Columns.Add("FlagCheck");
            dt.Columns.Add("CreatedBy");
            dt.Columns.Add("OrgCode");
            dt.Columns.Add("DocNo");
            dt.Rows.Add();
            dt.Rows[0]["FlagCheck"] = "Y";
            dt.Rows[0]["CreatedBy"] = "ZT";
            dt.Rows[0]["OrgCode"] = "SH";
            dt.Rows[0]["DocNo"] = "SHYD01050234";
            dt.Rows.Add();
            dt.Rows[1]["FlagCheck"] = "N";
            dt.Rows[1]["CreatedBy"] = "ZT";
            dt.Rows[1]["OrgCode"] = "WZ";
            dt.Rows[1]["DocNo"] = "SHZZ01050234";
            dt.Rows.Add();
            dt.Rows[2]["FlagCheck"] = "N";
            dt.Rows[2]["CreatedBy"] = "ZT";
            dt.Rows[2]["OrgCode"] = "GZ";
            dt.Rows[2]["DocNo"] = "SHHY01050234";
            return dt;
        }

    }
}
