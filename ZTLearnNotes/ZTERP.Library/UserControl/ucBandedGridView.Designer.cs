namespace ZTERP.Library.UserControl
{
    partial class ucBandedGridView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.gvSummary = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gbFlagCheck = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFlagCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rep_FlagCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gbBaseINfo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCreatedBy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrgCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbDocInfo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDocNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.chkFlagCheck = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_FlagCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSummary
            // 
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.UseWaitCursor = true;
            this.gcSummary.Location = new System.Drawing.Point(0, 0);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_FlagCheck});
            this.gcSummary.Size = new System.Drawing.Size(616, 488);
            this.gcSummary.TabIndex = 0;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.UseWaitCursor = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // gvSummary
            // 
            this.gvSummary.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gbFlagCheck,
            this.gbBaseINfo,
            this.gbDocInfo});
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colFlagCheck,
            this.colCreatedBy,
            this.colOrgCode,
            this.colDocNo});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            // 
            // gbFlagCheck
            // 
            this.gbFlagCheck.Caption = "选";
            this.gbFlagCheck.Columns.Add(this.colFlagCheck);
            this.gbFlagCheck.Name = "gbFlagCheck";
            this.gbFlagCheck.VisibleIndex = 0;
            this.gbFlagCheck.Width = 43;
            // 
            // colFlagCheck
            // 
            this.colFlagCheck.Caption = "选";
            this.colFlagCheck.ColumnEdit = this.rep_FlagCheck;
            this.colFlagCheck.FieldName = "FlagCheck";
            this.colFlagCheck.Name = "colFlagCheck";
            this.colFlagCheck.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFlagCheck.OptionsColumn.AllowMove = false;
            this.colFlagCheck.OptionsColumn.AllowSize = false;
            this.colFlagCheck.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colFlagCheck.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colFlagCheck.OptionsColumn.ShowCaption = false;
            this.colFlagCheck.Visible = true;
            this.colFlagCheck.Width = 43;
            // 
            // rep_FlagCheck
            // 
            this.rep_FlagCheck.AutoHeight = false;
            this.rep_FlagCheck.Name = "rep_FlagCheck";
            this.rep_FlagCheck.ValueChecked = "Y";
            this.rep_FlagCheck.ValueUnchecked = "N";
            // 
            // gbBaseINfo
            // 
            this.gbBaseINfo.Caption = "基本信息";
            this.gbBaseINfo.Columns.Add(this.colCreatedBy);
            this.gbBaseINfo.Columns.Add(this.colOrgCode);
            this.gbBaseINfo.Name = "gbBaseINfo";
            this.gbBaseINfo.VisibleIndex = 1;
            this.gbBaseINfo.Width = 353;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.Caption = "创建人";
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.Width = 176;
            // 
            // colOrgCode
            // 
            this.colOrgCode.Caption = "网点";
            this.colOrgCode.FieldName = "OrgCode";
            this.colOrgCode.Name = "colOrgCode";
            this.colOrgCode.Visible = true;
            this.colOrgCode.Width = 177;
            // 
            // gbDocInfo
            // 
            this.gbDocInfo.Caption = "单据信息";
            this.gbDocInfo.Columns.Add(this.colDocNo);
            this.gbDocInfo.Name = "gbDocInfo";
            this.gbDocInfo.VisibleIndex = 2;
            this.gbDocInfo.Width = 180;
            // 
            // colDocNo
            // 
            this.colDocNo.Caption = "单据号码";
            this.colDocNo.FieldName = "DocNo";
            this.colDocNo.Name = "colDocNo";
            this.colDocNo.Visible = true;
            this.colDocNo.Width = 180;
            // 
            // chkFlagCheck
            // 
            this.chkFlagCheck.Location = new System.Drawing.Point(31, 55);
            this.chkFlagCheck.Name = "chkFlagCheck";
            this.chkFlagCheck.Properties.Caption = "";
            this.chkFlagCheck.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            this.chkFlagCheck.Properties.ValueChecked = "Y";
            this.chkFlagCheck.Properties.ValueUnchecked = "N";
            this.chkFlagCheck.Size = new System.Drawing.Size(18, 19);
            this.chkFlagCheck.TabIndex = 1;
            this.chkFlagCheck.UseWaitCursor = true;
            this.chkFlagCheck.CheckedChanged += new System.EventHandler(this.chkFlagCheck_CheckedChanged);
            // 
            // ucGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.chkFlagCheck);
            this.Controls.Add(this.gcSummary);
            this.Name = "ucGridControl";
            this.Size = new System.Drawing.Size(616, 488);
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_FlagCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvSummary;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFlagCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rep_FlagCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreatedBy;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrgCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDocNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbFlagCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbBaseINfo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbDocInfo;
        private DevExpress.XtraEditors.CheckEdit chkFlagCheck;
        public DevExpress.XtraGrid.GridControl gcSummary;
    }
}
