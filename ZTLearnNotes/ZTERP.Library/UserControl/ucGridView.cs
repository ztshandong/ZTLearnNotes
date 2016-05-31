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
using DevExpress.XtraGrid.Columns;

namespace ZTERP.Library.UserControl
{
    public partial class ucGridView : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable _DataSource;
        public ucGridView()
        {
            InitializeComponent();
            DataBinder.BoundRepCheckEdit(repS_FlagCheck);
        }
        public void SetDataSource(DataTable dt)
        {            
            foreach (DataColumn col in dt.Columns)
            {
                GridColumn NewCol = new GridColumn();

                NewCol.Caption = col.ToString();
                NewCol.FieldName = col.ToString();
                NewCol.Name = "col" + col.ToString();
                NewCol.Visible = true;
                NewCol.VisibleIndex = 0;
                NewCol.OptionsColumn.AllowEdit = false;
                NewCol.OptionsColumn.ReadOnly = true;
                gvSummary.Columns.AddRange(new GridColumn[] {
            NewCol});
            }
             gcSummary.DataSource = _DataSource = dt;
        }

        private void chkFlagCheck_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in (gcSummary.DataSource as DataTable).Rows)
                dr["FlagCheck"] = chkFlagCheck.EditValue;
        }

        public DataTable GetSelectedTable()
        {
            if (_DataSource == null) return null;
            DataTable dt = _DataSource.Copy();
            string Filter = " FlagCheck = 'Y'";
            dt.DefaultView.RowFilter = Filter;
            dt = dt.DefaultView.ToTable();
            return dt;
        }

        private void gvSummary_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(gvSummary.FocusedValue.ToString());
            
        }
    }
}
