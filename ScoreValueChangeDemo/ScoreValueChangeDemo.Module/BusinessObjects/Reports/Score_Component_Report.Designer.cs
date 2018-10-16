namespace ScoreValueChangeDemo.Module.BusinessObjects.Reports
{
    partial class Score_Component_Report
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score_Component_Report));
            this.ReportSqlDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldAssetClass = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldAssetType = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldAssetSubType = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldAssetId = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldComponent = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCurrentScore = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldValuationScore = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPreviousYear = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.fieldComponentType = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldComponentSubType = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportSqlDataSource
            // 
            this.ReportSqlDataSource.ConnectionName = "localhost_fvp-database_Copy_Connection";
            this.ReportSqlDataSource.Name = "ReportSqlDataSource";
            storedProcQuery1.Name = "Report_Score_Changes_Component";
            queryParameter1.Name = "@client";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.Client]", typeof(string));
            queryParameter2.Name = "@job";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.Job]", typeof(string));
            queryParameter3.Name = "@assetclass";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.AssetClass]", typeof(string));
            queryParameter4.Name = "@assetType";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.AssetType]", typeof(string));
            queryParameter5.Name = "@assetSubType";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.AssetSubtype]", typeof(string));
            queryParameter6.Name = "@pageno";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.Page]", typeof(int));
            queryParameter7.Name = "@records";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.Size]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.StoredProcName = "Report_Score_Changes_Component";
            this.ReportSqlDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.ReportSqlDataSource.ResultSchemaSerializable = resources.GetString("ReportSqlDataSource.ResultSchemaSerializable");
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrPivotGrid1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Job", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 210.4167F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_Score_Changes_Component.Job")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1109F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.Cell.WordWrap = true;
            this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.CustomTotalCell.WordWrap = true;
            this.xrPivotGrid1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldHeader.WordWrap = true;
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValue.WordWrap = true;
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.WordWrap = true;
            this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueTotal.WordWrap = true;
            this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.GrandTotalCell.WordWrap = true;
            this.xrPivotGrid1.Appearance.Lines.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.Lines.WordWrap = true;
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.TotalCell.WordWrap = true;
            this.xrPivotGrid1.DataMember = "Report_Score_Changes_Component";
            this.xrPivotGrid1.DataSource = this.ReportSqlDataSource;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldAssetClass,
            this.fieldAssetType,
            this.fieldAssetSubType,
            this.fieldAssetId,
            this.fieldComponent,
            this.fieldComponentType,
            this.fieldComponentSubType,
            this.fieldCurrentScore,
            this.fieldValuationScore,
            this.fieldPreviousYear});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 48.95833F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OLAPConnectionString = "";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowColumnTotals = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowRowTotals = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1109F, 137.5F);
            // 
            // fieldAssetClass
            // 
            this.fieldAssetClass.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldAssetClass.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAssetClass.AreaIndex = 2;
            this.fieldAssetClass.FieldName = "AssetClass";
            this.fieldAssetClass.Name = "fieldAssetClass";
            // 
            // fieldAssetType
            // 
            this.fieldAssetType.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldAssetType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAssetType.AreaIndex = 1;
            this.fieldAssetType.FieldName = "AssetType";
            this.fieldAssetType.Name = "fieldAssetType";
            // 
            // fieldAssetSubType
            // 
            this.fieldAssetSubType.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldAssetSubType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAssetSubType.AreaIndex = 0;
            this.fieldAssetSubType.FieldName = "AssetSubType";
            this.fieldAssetSubType.Name = "fieldAssetSubType";
            // 
            // fieldAssetId
            // 
            this.fieldAssetId.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldAssetId.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAssetId.AreaIndex = 3;
            this.fieldAssetId.FieldName = "AssetId";
            this.fieldAssetId.Name = "fieldAssetId";
            // 
            // fieldComponent
            // 
            this.fieldComponent.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldComponent.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldComponent.AreaIndex = 4;
            this.fieldComponent.FieldName = "Component";
            this.fieldComponent.Name = "fieldComponent";
            // 
            // fieldCurrentScore
            // 
            this.fieldCurrentScore.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldCurrentScore.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCurrentScore.AreaIndex = 4;
            this.fieldCurrentScore.CellFormat.FormatString = "{0:n2}";
            this.fieldCurrentScore.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldCurrentScore.FieldName = "CurrentScore";
            this.fieldCurrentScore.Name = "fieldCurrentScore";
            this.fieldCurrentScore.Visible = false;
            // 
            // fieldValuationScore
            // 
            this.fieldValuationScore.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldValuationScore.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValuationScore.AreaIndex = 0;
            this.fieldValuationScore.CellFormat.FormatString = "{0:n2}";
            this.fieldValuationScore.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldValuationScore.FieldName = "ValuationScore";
            this.fieldValuationScore.Name = "fieldValuationScore";
            // 
            // fieldPreviousYear
            // 
            this.fieldPreviousYear.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.fieldPreviousYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldPreviousYear.AreaIndex = 0;
            this.fieldPreviousYear.CellFormat.FormatString = "{0:n2}";
            this.fieldPreviousYear.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldPreviousYear.FieldName = "Previous Year";
            this.fieldPreviousYear.Name = "fieldPreviousYear";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.Expanded = false;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Expanded = false;
            this.Detail1.HeightF = 0F;
            this.Detail1.Name = "Detail1";
            // 
            // fieldComponentType
            // 
            this.fieldComponentType.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldComponentType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldComponentType.AreaIndex = 5;
            this.fieldComponentType.FieldName = "ComponentType";
            this.fieldComponentType.Name = "fieldComponentType";
            // 
            // fieldComponentSubType
            // 
            this.fieldComponentSubType.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldComponentSubType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldComponentSubType.AreaIndex = 6;
            this.fieldComponentSubType.FieldName = "ComponentSubType";
            this.fieldComponentSubType.MinWidth = 30;
            this.fieldComponentSubType.Name = "fieldComponentSubType";
            this.fieldComponentSubType.Width = 120;
            // 
            // Score_Component_Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader1,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ParameterSqlDataSource,
            this.ReportSqlDataSource});
            this.DataMember = "Report_Score_Changes_Component";
            this.DataSource = this.ReportSqlDataSource;
            this.Landscape = true;
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Client,
            this.AssetClass});
            this.Version = "17.1";
            this.Controls.SetChildIndex(this.DetailReport, 0);
            this.Controls.SetChildIndex(this.GroupHeader1, 0);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }


        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource ReportSqlDataSource;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAssetClass;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAssetType;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAssetSubType;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAssetId;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldComponent;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldValuationScore;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPreviousYear;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCurrentScore;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldComponentType;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldComponentSubType;
    }
}
