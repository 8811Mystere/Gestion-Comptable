namespace push
{
    partial class imprimercomptefrm
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
            this.DataSet2 = new push.DataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imprimercomptefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 559);
            this.Name = "imprimercomptefrm";
            this.Text = "imprimercomptefrm";
            this.Load += new System.EventHandler(this.imprimercomptefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet2 DataSet2;
    }
}