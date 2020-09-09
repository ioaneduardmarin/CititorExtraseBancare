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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StatementsGrid = new DevExpress.XtraGrid.GridControl();
            this.statementGridItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatementsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSGIMStatementId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumarReferinta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNrExtras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSumaInitiala = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSumaFinalRezervat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatementGridLabel = new System.Windows.Forms.Label();
            this.TransactionsGrid = new DevExpress.XtraGrid.GridControl();
            this.transactionGridItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTranzactieId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumaTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipTranzactie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInformatiiPentruClient1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TransactionGridLabel = new System.Windows.Forms.Label();
            this.colInformatiiPentruClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetaliiTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferintaClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumaTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTranzactie = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementGridItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StatementsGrid);
            this.splitContainer1.Panel1.Controls.Add(this.StatementGridLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TransactionsGrid);
            this.splitContainer1.Panel2.Controls.Add(this.TransactionGridLabel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 2;
            // 
            // StatementsGrid
            // 
            this.StatementsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatementsGrid.DataSource = this.statementGridItemModelBindingSource;
            this.StatementsGrid.Location = new System.Drawing.Point(24, 12);
            this.StatementsGrid.MainView = this.StatementsGridView;
            this.StatementsGrid.Name = "StatementsGrid";
            this.StatementsGrid.Size = new System.Drawing.Size(776, 194);
            this.StatementsGrid.TabIndex = 1;
            this.StatementsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StatementsGridView});
            // 
            // statementGridItemModelBindingSource
            // 
            this.statementGridItemModelBindingSource.DataSource = typeof(BankStatementReader.StatementGridItemModel);
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
            // StatementGridLabel
            // 
            this.StatementGridLabel.AutoSize = true;
            this.StatementGridLabel.Location = new System.Drawing.Point(3, 0);
            this.StatementGridLabel.Name = "StatementGridLabel";
            this.StatementGridLabel.Size = new System.Drawing.Size(66, 13);
            this.StatementGridLabel.TabIndex = 0;
            this.StatementGridLabel.Text = "Statements: ";
            // 
            // TransactionsGrid
            // 
            this.TransactionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionsGrid.DataSource = this.transactionGridItemModelBindingSource;
            this.TransactionsGrid.Location = new System.Drawing.Point(0, 20);
            this.TransactionsGrid.MainView = this.gridView1;
            this.TransactionsGrid.Name = "TransactionsGrid";
            this.TransactionsGrid.Size = new System.Drawing.Size(800, 201);
            this.TransactionsGrid.TabIndex = 1;
            this.TransactionsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // transactionGridItemModelBindingSource
            // 
            this.transactionGridItemModelBindingSource.DataSource = typeof(BankStatementReader.TransactionGridItemModel);
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
            // TransactionGridLabel
            // 
            this.TransactionGridLabel.AutoSize = true;
            this.TransactionGridLabel.Location = new System.Drawing.Point(4, 4);
            this.TransactionGridLabel.Name = "TransactionGridLabel";
            this.TransactionGridLabel.Size = new System.Drawing.Size(74, 13);
            this.TransactionGridLabel.TabIndex = 0;
            this.TransactionGridLabel.Text = "Transactions: ";
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
            // StatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StatementForm";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementGridItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatementsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl StatementsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView StatementsGridView;
        private System.Windows.Forms.Label StatementGridLabel;
        private System.Windows.Forms.Label TransactionGridLabel;
        private System.Windows.Forms.BindingSource statementGridItemModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumarReferinta;
        private DevExpress.XtraGrid.Columns.GridColumn ColIban;
        private DevExpress.XtraGrid.Columns.GridColumn ColNrExtras;
        private DevExpress.XtraGrid.Columns.GridColumn ColSumaInitiala;
        private DevExpress.XtraGrid.Columns.GridColumn ColSumaFinalRezervat;
        private DevExpress.XtraGrid.Columns.GridColumn colSGIMStatementId;
        private DevExpress.XtraGrid.Columns.GridColumn colInformatiiPentruClient;
        private DevExpress.XtraGrid.Columns.GridColumn colDetaliiTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colReferintaClient;
        private DevExpress.XtraGrid.Columns.GridColumn colTipTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colSumaTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTranzactie;
        private DevExpress.XtraGrid.GridControl TransactionsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource transactionGridItemModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTranzactieId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTranzactie;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colSumaTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipTranzactie1;
        private DevExpress.XtraGrid.Columns.GridColumn colInformatiiPentruClient1;
    }
}