using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZTERP.CommonClass;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxPivotGrid1.DataSource = CommonClass.GetTable();
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            ASPxPivotGridExporter1.ExportXlsxToResponse("test", new XlsxExportOptionsEx
            {
                AllowGrouping = DevExpress.Utils.DefaultBoolean.False,
                AllowFixedColumnHeaderPanel=DevExpress.Utils.DefaultBoolean.False

            });
            
        }
    }
}