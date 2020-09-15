namespace BankStatementReader
{
    partial class UserControl1
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
            this.StatementsGrid = new DevExpress.XtraGrid.GridControl();
            this.StatementsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSGIMStatementId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumarReferinta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNrExtras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSumaInitiala = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSumaFinalRezervat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TransactionsGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTranzactieId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumaTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInformatiiPentruClient1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatementsGrid
            // 
            this.StatementsGrid.Location = new System.Drawing.Point(0, 106);
            this.StatementsGrid.MainView = this.StatementsGridView;
            this.StatementsGrid.Name = "StatementsGrid";
            this.StatementsGrid.Size = new System.Drawing.Size(1287, 272);
            this.StatementsGrid.TabIndex = 2;
            this.StatementsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StatementsGridView,
            this.gridView2});
            // 
            // StatementsGridView
            // 
            this.StatementsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSGIMStatementId,
            this.ColNumarReferinta,
            this.ColIban,
            this.ColNrExtras,
            this.ColSumaInitiala,
            this.ColSumaFinalRezervat});
            this.StatementsGridView.GridControl = this.StatementsGrid;
            this.StatementsGridView.Name = "StatementsGridView";
            this.StatementsGridView.OptionsCustomization.AllowGroup = false;
            this.StatementsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colSGIMStatementId
            // 
            this.colSGIMStatementId.FieldName = "Id";
            this.colSGIMStatementId.MinWidth = 35;
            this.colSGIMStatementId.Name = "colSGIMStatementId";
            this.colSGIMStatementId.Visible = true;
            this.colSGIMStatementId.VisibleIndex = 0;
            this.colSGIMStatementId.Width = 35;
            // 
            // ColNumarReferinta
            // 
            this.ColNumarReferinta.FieldName = "NumarReferintaCont";
            this.ColNumarReferinta.Name = "ColNumarReferinta";
            this.ColNumarReferinta.OptionsColumn.ReadOnly = true;
            this.ColNumarReferinta.OptionsEditForm.Caption = "Numar Referinta Cont";
            this.ColNumarReferinta.Visible = true;
            this.ColNumarReferinta.VisibleIndex = 1;
            this.ColNumarReferinta.Width = 145;
            // 
            // ColIban
            // 
            this.ColIban.FieldName = "ContIban";
            this.ColIban.Name = "ColIban";
            this.ColIban.OptionsColumn.ReadOnly = true;
            this.ColIban.Visible = true;
            this.ColIban.VisibleIndex = 2;
            this.ColIban.Width = 145;
            // 
            // ColNrExtras
            // 
            this.ColNrExtras.FieldName = "NumarExtras";
            this.ColNrExtras.Name = "ColNrExtras";
            this.ColNrExtras.OptionsColumn.ReadOnly = true;
            this.ColNrExtras.Visible = true;
            this.ColNrExtras.VisibleIndex = 3;
            this.ColNrExtras.Width = 145;
            // 
            // ColSumaInitiala
            // 
            this.ColSumaInitiala.FieldName = "SumaSoldInitial";
            this.ColSumaInitiala.Name = "ColSumaInitiala";
            this.ColSumaInitiala.OptionsColumn.ReadOnly = true;
            this.ColSumaInitiala.Visible = true;
            this.ColSumaInitiala.VisibleIndex = 4;
            this.ColSumaInitiala.Width = 145;
            // 
            // ColSumaFinalRezervat
            // 
            this.ColSumaFinalRezervat.FieldName = "SumaSoldFinalRezervat";
            this.ColSumaFinalRezervat.Name = "ColSumaFinalRezervat";
            this.ColSumaFinalRezervat.OptionsColumn.ReadOnly = true;
            this.ColSumaFinalRezervat.Visible = true;
            this.ColSumaFinalRezervat.VisibleIndex = 5;
            this.ColSumaFinalRezervat.Width = 151;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.StatementsGrid;
            this.gridView2.Name = "gridView2";
            // 
            // TransactionsGrid
            // 
            this.TransactionsGrid.Location = new System.Drawing.Point(22, 384);
            this.TransactionsGrid.MainView = this.gridView1;
            this.TransactionsGrid.Name = "TransactionsGrid";
            this.TransactionsGrid.Size = new System.Drawing.Size(1451, 270);
            this.TransactionsGrid.TabIndex = 3;
            this.TransactionsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTranzactieId,
            this.colDataTranzactie,
            this.colCodTranzactie1,
            this.colSumaTranzactie1,
            this.colTipTranzactie1,
            this.colInformatiiPentruClient1});
            this.gridView1.GridControl = this.TransactionsGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTranzactieId
            // 
            this.colTranzactieId.FieldName = "TranzactieId";
            this.colTranzactieId.Name = "colTranzactieId";
            this.colTranzactieId.OptionsColumn.ReadOnly = true;
            this.colTranzactieId.Visible = true;
            this.colTranzactieId.VisibleIndex = 0;
            this.colTranzactieId.Width = 35;
            // 
            // colDataTranzactie
            // 
            this.colDataTranzactie.FieldName = "DataTranzactie";
            this.colDataTranzactie.Name = "colDataTranzactie";
            this.colDataTranzactie.OptionsColumn.ReadOnly = true;
            this.colDataTranzactie.Visible = true;
            this.colDataTranzactie.VisibleIndex = 1;
            this.colDataTranzactie.Width = 147;
            // 
            // colCodTranzactie1
            // 
            this.colCodTranzactie1.FieldName = "CodTranzactie";
            this.colCodTranzactie1.Name = "colCodTranzactie1";
            this.colCodTranzactie1.OptionsColumn.ReadOnly = true;
            this.colCodTranzactie1.Visible = true;
            this.colCodTranzactie1.VisibleIndex = 2;
            this.colCodTranzactie1.Width = 147;
            // 
            // colSumaTranzactie1
            // 
            this.colSumaTranzactie1.FieldName = "SumaTranzactie";
            this.colSumaTranzactie1.Name = "colSumaTranzactie1";
            this.colSumaTranzactie1.OptionsColumn.ReadOnly = true;
            this.colSumaTranzactie1.Visible = true;
            this.colSumaTranzactie1.VisibleIndex = 3;
            this.colSumaTranzactie1.Width = 147;
            // 
            // colTipTranzactie1
            // 
            this.colTipTranzactie1.FieldName = "TipTranzactie";
            this.colTipTranzactie1.Name = "colTipTranzactie1";
            this.colTipTranzactie1.OptionsColumn.ReadOnly = true;
            this.colTipTranzactie1.Visible = true;
            this.colTipTranzactie1.VisibleIndex = 4;
            this.colTipTranzactie1.Width = 147;
            // 
            // colInformatiiPentruClient1
            // 
            this.colInformatiiPentruClient1.FieldName = "InformatiiPentruClient";
            this.colInformatiiPentruClient1.Name = "colInformatiiPentruClient1";
            this.colInformatiiPentruClient1.OptionsColumn.ReadOnly = true;
            this.colInformatiiPentruClient1.Visible = true;
            this.colInformatiiPentruClient1.VisibleIndex = 5;
            this.colInformatiiPentruClient1.Width = 152;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TransactionsGrid);
            this.Controls.Add(this.StatementsGrid);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1399, 724);
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl StatementsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView StatementsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSGIMStatementId;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumarReferinta;
        private DevExpress.XtraGrid.Columns.GridColumn ColIban;
        private DevExpress.XtraGrid.Columns.GridColumn ColNrExtras;
        private DevExpress.XtraGrid.Columns.GridColumn ColSumaInitiala;
        private DevExpress.XtraGrid.Columns.GridColumn ColSumaFinalRezervat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl TransactionsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTranzactieId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colSumaTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colInformatiiPentruClient1;
    }
}
