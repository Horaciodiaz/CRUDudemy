namespace CRUDudemy.Presentacion.Reportes
{
    partial class Form_reporte_contactos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listadoDeContactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_reportes = new CRUDudemy.Presentacion.Reportes.DS_reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt01 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeContactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoDeContactosBindingSource
            // 
            this.listadoDeContactosBindingSource.DataMember = "Listado de Contactos";
            this.listadoDeContactosBindingSource.DataSource = this.dS_reportes;
            // 
            // dS_reportes
            // 
            this.dS_reportes.DataSetName = "DS_reportes";
            this.dS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listadoDeContactosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUDudemy.Presentacion.Reportes.Reporte_contactos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(917, 515);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(137, 46);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(100, 20);
            this.txt01.TabIndex = 1;
            this.txt01.Visible = false;
            // 
            // Form_reporte_contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_reporte_contactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_reporte_contactos";
            this.Load += new System.EventHandler(this.Form_reporte_contactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeContactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listadoDeContactosBindingSource;
        private DS_reportes dS_reportes;
        internal System.Windows.Forms.TextBox txt01;
    }
}