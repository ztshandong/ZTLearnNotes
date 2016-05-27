namespace Library.UserControl
{
    partial class ucGridView
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
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFlagCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repS_FlagCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkFlagCheck = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repS_FlagCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSummary
            // 
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.Location = new System.Drawing.Point(0, 0);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repS_FlagCheck});
            this.gcSummary.Size = new System.Drawing.Size(565, 456);
            this.gcSummary.TabIndex = 0;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFlagCheck});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.DoubleClick += new System.EventHandler(this.gvSummary_DoubleClick);
            // 
            // colFlagCheck
            // 
            this.colFlagCheck.Caption = " ";
            this.colFlagCheck.ColumnEdit = this.repS_FlagCheck;
            this.colFlagCheck.FieldName = "FlagCheck";
            this.colFlagCheck.Name = "colFlagCheck";
            this.colFlagCheck.Visible = true;
            this.colFlagCheck.VisibleIndex = 0;
            this.colFlagCheck.Width = 33;
            // 
            // repS_FlagCheck
            // 
            this.repS_FlagCheck.AutoHeight = false;
            this.repS_FlagCheck.Name = "repS_FlagCheck";
            this.repS_FlagCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            this.repS_FlagCheck.ValueChecked = "Y";
            this.repS_FlagCheck.ValueUnchecked = "N";
            // 
            // chkFlagCheck
            // 
            this.chkFlagCheck.Location = new System.Drawing.Point(26, 37);
            this.chkFlagCheck.Name = "chkFlagCheck";
            this.chkFlagCheck.Properties.Caption = "";
            this.chkFlagCheck.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            this.chkFlagCheck.Properties.ValueChecked = "Y";
            this.chkFlagCheck.Properties.ValueUnchecked = "N";
            this.chkFlagCheck.Size = new System.Drawing.Size(16, 19);
            this.chkFlagCheck.TabIndex = 1;
            this.chkFlagCheck.CheckedChanged += new System.EventHandler(this.chkFlagCheck_CheckedChanged);
            // 
            // ucGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.chkFlagCheck);
            this.Controls.Add(this.gcSummary);
            this.Name = "ucGridView";
            this.Size = new System.Drawing.Size(565, 456);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repS_FlagCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colFlagCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repS_FlagCheck;
        private DevExpress.XtraEditors.CheckEdit chkFlagCheck;
    }
}
