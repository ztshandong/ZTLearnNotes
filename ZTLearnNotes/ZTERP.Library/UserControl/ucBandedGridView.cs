using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ZTERP.CommonClass;
using DevExpress.XtraGrid;

namespace ZTERP.Library.UserControl
{
    public partial class ucBandedGridView : DevExpress.XtraEditors.XtraUserControl
    {
     
        public ucBandedGridView()
        {
            InitializeComponent();
           // gcSummary.DataSource = Common.GetTable();
            DataBinder.BoundRepCheckEdit(rep_FlagCheck);
        }

        public GridControl Gridcontrol
        {
            get
            {
                return gcSummary;
            }
        }

        private void chkFlagCheck_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow r in (gcSummary.DataSource as DataTable).Rows)
            {
                r["FlagCheck"] = chkFlagCheck.EditValue;
            }
        }
    }
}
