using CRUDudemy.Datos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDudemy.Presentacion.Reportes
{
    public partial class Form_reporte_contactos : Form
    {
        public Form_reporte_contactos()
        {
            InitializeComponent();
        }

        #region "Mis metodos"
        private void Listado()
        {
            try
            {
                Datos_contactos Datos = new Datos_contactos();
                string ctexto = txt01.Text;
                DataTable miTabla = new DataTable();
                miTabla = Datos.listadoContactos(ctexto);
                ReportDataSource fuente = new ReportDataSource("DataSet1", miTabla);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(fuente);
                reportViewer1.LocalReport.ReportEmbeddedResource = "CRUDudemy.Presentacion.Reportes.Reporte_contactos.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
                
            }
            catch(Exception ex) 
            {
                throw ex;
            } 
        }
        #endregion

        private void Form_reporte_contactos_Load(object sender, EventArgs e)
        {
            this.Listado();
            //this.reportViewer1.RefreshReport();
        }
    }
}
