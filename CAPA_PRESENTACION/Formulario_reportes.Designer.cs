namespace CAPA_PRESENTACION
{
    partial class Formulario_reportes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosConsultas = new CAPA_PRESENTACION.DatosConsultas();
            this.ConsultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConsultasTableAdapter = new CAPA_PRESENTACION.DatosConsultasTableAdapters.ConsultasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ConsultasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1004, 640);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosConsultas
            // 
            this.DatosConsultas.DataSetName = "DatosConsultas";
            this.DatosConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConsultasBindingSource
            // 
            this.ConsultasBindingSource.DataMember = "Consultas";
            this.ConsultasBindingSource.DataSource = this.DatosConsultas;
            // 
            // ConsultasTableAdapter
            // 
            this.ConsultasTableAdapter.ClearBeforeFill = true;
            // 
            // Formulario_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formulario_reportes";
            this.Text = "Formulario_reportes";
            this.Load += new System.EventHandler(this.Formulario_reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsultasBindingSource;
        private DatosConsultas DatosConsultas;
        private DatosConsultasTableAdapters.ConsultasTableAdapter ConsultasTableAdapter;
    }
}