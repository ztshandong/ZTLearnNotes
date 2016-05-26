﻿using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DataBinder
    {
        public static void BoundCheckEdit(RepositoryItemCheckEdit lueCheck)
        {
            lueCheck.AutoHeight = false;
            lueCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            lueCheck.ValueChecked = "Y";
            lueCheck.ValueUnchecked = "N";
        }
    }
}
