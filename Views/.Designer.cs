namespace BankStatementReader
{
    partial class StatementForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statementGridItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionGridItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colInformatiiPentruClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetaliiTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferintaClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumaTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TransactionsGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTranzactieId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumaTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInformatiiPentruClient1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatementsGrid = new DevExpress.XtraGrid.GridControl();
            this.StatementsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSGIMStatementId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumarReferinta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNrExtras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSumaInitiala = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSumaFinalRezervat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();

            this.statementsLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.transactionLaber = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.statementGridItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLaber)).BeginInit();
            this.SuspendLayout();
            // 
            // statementGridItemModelBindingSource
            // 
            this.statementGridItemModelBindingSource.DataSource = typeof(BankStatementReader.StatementGridItemModel);
            // 
            // transactionGridItemModelBindingSource
            // 
            this.transactionGridItemModelBindingSource.DataSource = typeof(BankStatementReader.TransactionGridItemModel);
            // 
            // colInformatiiPentruClient
            // 
            this.colInformatiiPentruClient.FieldName = "InformatiiPentruClient";
            this.colInformatiiPentruClient.Name = "colInformatiiPentruClient";
            // 
            // colDetaliiTranzactie
            // 
            this.colDetaliiTranzactie.FieldName = "DetaliiTranzactie";
            this.colDetaliiTranzactie.Name = "colDetaliiTranzactie";
            // 
            // colReferintaClient
            // 
            this.colReferintaClient.FieldName = "ReferintaClient";
            this.colReferintaClient.Name = "colReferintaClient";
            // 
            // colTipTranzactie
            // 
            this.colTipTranzactie.FieldName = "TipTranzactie";
            this.colTipTranzactie.Name = "colTipTranzactie";
            // 
            // colSumaTranzactie
            // 
            this.colSumaTranzactie.FieldName = "SumaTranzactie";
            this.colSumaTranzactie.Name = "colSumaTranzactie";
            // 
            // colCodTranzactie
            // 
            this.colCodTranzactie.FieldName = "CodTranzactie";
            this.colCodTranzactie.Name = "colCodTranzactie";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TransactionsGrid);
            this.layoutControl1.Controls.Add(this.StatementsGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1040, 333, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1475, 594);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TransactionsGrid
            // 
            this.TransactionsGrid.Location = new System.Drawing.Point(12, 231);
            this.TransactionsGrid.MainView = this.gridView1;
            this.TransactionsGrid.Name = "TransactionsGrid";
            this.TransactionsGrid.Size = new System.Drawing.Size(1451, 350);
            this.TransactionsGrid.TabIndex = 5;
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
            // StatementsGrid
            // 
            this.StatementsGrid.Location = new System.Drawing.Point(12, 29);
            this.StatementsGrid.MainView = this.StatementsGridView;
            this.StatementsGrid.Name = "StatementsGrid";
            this.StatementsGrid.Size = new System.Drawing.Size(1451, 181);
            this.StatementsGrid.TabIndex = 4;
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.statementsLabel,
            this.transactionLaber});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1475, 594);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.StatementsGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1455, 185);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TransactionsGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 219);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1455, 354);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // statementsLabel
            // 
            this.statementsLabel.AllowHotTrack = false;
            this.statementsLabel.Location = new System.Drawing.Point(0, 0);
            this.statementsLabel.Name = "statementsLabel";
            this.statementsLabel.Size = new System.Drawing.Size(1455, 17);
            this.statementsLabel.Text = "Statements: ";
            this.statementsLabel.TextSize = new System.Drawing.Size(68, 13);
            // 
            // transactionLaber
            // 
            this.transactionLaber.AllowHotTrack = false;
            this.transactionLaber.Location = new System.Drawing.Point(0, 202);
            this.transactionLaber.Name = "transactionLaber";
            this.transactionLaber.Size = new System.Drawing.Size(1455, 17);
            this.transactionLaber.Text = "Transactions: ";
            this.transactionLaber.TextSize = new System.Drawing.Size(68, 13);
            // 
            // StatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 594);
            this.Controls.Add(this.layoutControl1);
            this.Name = "StatementForm";
            this.Text = "StatementForm";
            ((System.ComponentModel.ISupportInitialize)(this.statementGridItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLaber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource statementGridItemModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colInformatiiPentruClient;
        private DevExpress.XtraGrid.Columns.GridColumn colDetaliiTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colReferintaClient;
        private DevExpress.XtraGrid.Columns.GridColumn colTipTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colSumaTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTranzactie;
        private System.Windows.Forms.BindingSource transactionGridItemModelBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl StatementsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView StatementsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSGIMStatementId;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumarReferinta;
        private DevExpress.XtraGrid.Columns.GridColumn ColIban;
        private DevExpress.XtraGrid.Columns.GridColumn ColNrExtras;
        private DevExpress.XtraGrid.Columns.GridColumn ColSumaInitiala;
        private DevExpress.XtraGrid.Columns.GridColumn ColSumaFinalRezervat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl TransactionsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTranzactieId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colSumaTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colInformatiiPentruClient1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleLabelItem statementsLabel;
        private DevExpress.XtraLayout.SimpleLabelItem transactionLaber;
    }
}