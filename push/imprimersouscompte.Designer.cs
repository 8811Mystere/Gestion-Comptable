namespace push
{
    partial class imprimersouscompte
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet5 = new push.DataSet5();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTableAdapter = new push.DataSet5TableAdapters.DataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "push.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1143, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet5
            // 
            this.DataSet5.DataSetName = "DataSet5";
            this.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.DataSet5;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // imprimersouscompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "imprimersouscompte";
            this.Size = new System.Drawing.Size(1143, 598);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private DataSet5 DataSet5;
        private DataSet5TableAdapters.DataTableTableAdapter DataTableTableAdapter;
    }
}
