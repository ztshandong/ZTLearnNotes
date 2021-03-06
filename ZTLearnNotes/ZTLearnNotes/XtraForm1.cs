﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

using DevExpress.XtraGrid.Columns;

using ZTERP.Library.Forms;
using ZTERP.CommonClass;
using ZTERP.DataAccessLayer;

namespace ZTERP.Main
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = CommonClass.CommonClass.GetTable();
        public XtraForm1()
        {
            InitializeComponent();
            
            foreach(DataColumn col in dt.Columns)
            {
                GridColumn NewCol = new GridColumn();
                
                NewCol.Caption = col.ToString();
                NewCol.FieldName = col.ToString();
                NewCol.Name = "col"+ col.ToString();
                NewCol.Visible = true;
                NewCol.VisibleIndex = 0;

                gvDetail.Columns.AddRange(new GridColumn[] {
            NewCol});
            }
            gcDetail.DataSource = dt;
        }

        private void btnShowWait_Click(object sender, EventArgs e)
        {
            try
            {
                btnShowWait.Enabled = false;
                frmWaiting.ShowMe(this);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                btnShowWait.Enabled = true;
            }
        }

        private void btnCloseWait_Click(object sender, EventArgs e)
        {
            frmWaiting.HideMe(this);
        }

        private void btnBindSummary_Click(object sender, EventArgs e)
        {
            ucGridView1.SetDataSource(dt);
        }

        private void btnGetSelectedTable_Click(object sender, EventArgs e)
        {
            DataTable dt = ucGridView1.GetSelectedTable();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DALBase dal1 = new DALBase();
            DALBase dal2 = new DALBase();
            if (object.ReferenceEquals(dal1.DbType, dal2.DbType))
                MessageBox.Show("DbType1个");
            if (object.ReferenceEquals(dal1.OneIns, dal2.OneIns))
                MessageBox.Show("OneIns1个");
            
        }
    }
}