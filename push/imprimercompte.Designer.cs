namespace push
{
    partial class imprimercompte
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTableTableAdapter = new push.DataSet3TableAdapters.DataTableTableAdapter();
            this.DataSet3 = new push.DataSet3();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.DataSet3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "push.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1143, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // imprimercompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "imprimercompte";
            this.Size = new System.Drawing.Size(1143, 598);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet3TableAdapters.DataTableTableAdapter DataTableTableAdapter;
        private DataSet3 DataSet3;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
