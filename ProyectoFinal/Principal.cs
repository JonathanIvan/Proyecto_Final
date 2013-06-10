using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
          
            
        }
       
           
      MySqlConnection miconexion=new MySqlConnection("Server=127.0.0.1; Database=directorio; Uid=root; Password=208081433;");
     
      public void carga_Principal() {
          MySqlCommand comando = new MySqlCommand("select *from contacto", miconexion);
          miconexion.Open();
          MySqlDataReader leer=comando.ExecuteReader();
          dtgdirectorio.Rows.Clear();
          
          int renglon = 0;
          
          while (leer.Read()) {
              
              renglon = dtgdirectorio.Rows.Add();
              dtgdirectorio.Rows[renglon].Cells["Nombre"].Value = leer.GetString(3);
              dtgdirectorio.Rows[renglon].Cells["AP"].Value = leer.GetString(1);
              dtgdirectorio.Rows[renglon].Cells["AM"].Value = leer.GetString(2);
              dtgdirectorio.Rows[renglon].Cells["Telefono"].Value = leer.GetString(11);
              
              DataGridViewButtonColumn VER = new DataGridViewButtonColumn();
              VER.Name = "ver_" + leer.GetString(0);
              dtgdirectorio.Rows[renglon].Cells["VER"].Value = VER;

              DataGridViewButtonColumn ELIMINAR = new DataGridViewButtonColumn();
              ELIMINAR.Name = "eliminar_" + leer.GetString(0);
              dtgdirectorio.Rows[renglon].Cells["ELIMINAR"].Value = ELIMINAR;

              DataGridViewButtonColumn EDITAR = new DataGridViewButtonColumn();
              EDITAR.Name = "editar_" + leer.GetString(0);
              dtgdirectorio.Rows[renglon].Cells["EDITAR"].Value = EDITAR;

              

              DataGridViewButtonColumn ENVIAR = new DataGridViewButtonColumn();
              ENVIAR.Name = "enviar_" + leer.GetString(0);
              dtgdirectorio.Rows[renglon].Cells["ENVIAR"].Value = ENVIAR;

              
          }
          miconexion.Close();
      }


    

        private void Principal_Load(object sender, EventArgs e)
        {
            carga_Principal();
            
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            
            VentanaNuevo ventana_nuevo = new VentanaNuevo(this);
            
            ventana_nuevo.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VentanaBuscar ventanabuscar = new VentanaBuscar();
            ventanabuscar.Show();
            //this.SetVisibleCore(false);
            
        }


   
        private void dtgdirectorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgdirectorio.Columns["VER"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn) dtgdirectorio.Rows[e.RowIndex].Cells["VER"].Value;
                String id = boton.Name.Replace("ver_","");
                VentanaVer ver = new VentanaVer(id);
                ver.Show();
            }else if (e.ColumnIndex == dtgdirectorio.Columns["EDITAR"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dtgdirectorio.Rows[e.RowIndex].Cells["EDITAR"].Value;
                String id = boton.Name.Replace("editar_", "");
                VentanaEditar editar = new VentanaEditar (this,id);
                editar.Show();
            }else if (e.ColumnIndex == dtgdirectorio.Columns["ELIMINAR"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dtgdirectorio.Rows[e.RowIndex].Cells["ELIMINAR"].Value;
                String id = boton.Name.Replace("eliminar_", "");
                VenEliminar eliminar = new VenEliminar(this,id);
                
                //eliminar.Show();
            }
            else if (e.ColumnIndex == dtgdirectorio.Columns["ENVIAR"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dtgdirectorio.Rows[e.RowIndex].Cells["ENVIAR"].Value;
                String id = boton.Name.Replace("enviar_", "");
                VentanaEnviar enviar = new VentanaEnviar(id);

                enviar.Show();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            
            Microsoft.Office.Interop.Excel.Application Excel_Application;
            Excel._Workbook HojaTrabajo;
            Excel._Worksheet PestañaTrabajo;
            //Excel.Range ColumnaRango;

            Excel_Application = new Microsoft.Office.Interop.Excel.Application();

            object misValue = System.Reflection.Missing.Value;
            HojaTrabajo = Excel_Application.Workbooks.Add(misValue);
            PestañaTrabajo = (Excel.Worksheet)HojaTrabajo.ActiveSheet;

            //PestañaTrabajo.get_Range("A1", "D1").Font.Bold = true;
            //PestañaTrabajo.get_Range("A1", "D1").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
          
            int i = 0;
            int j = 0;

            for (i = 1; i < dtgdirectorio.Columns.Count + 1; i++) {

                PestañaTrabajo.Cells[1, i] = dtgdirectorio.Columns[i - 1].HeaderText;

            }
            for (i = 1; i < dtgdirectorio.RowCount - 1; i++) {

                for (j = 1; j < dtgdirectorio.Columns.Count - 1; j++) {

                    DataGridViewCell cell = dtgdirectorio[j, i];
                    PestañaTrabajo.Cells[i + 2, j + 1]=cell.Value;

                }
            }

            string Carpeta = @"C:\ArchivosExcel\";
            if(!Directory.Exists(Carpeta)){
                Directory.CreateDirectory(Carpeta);
            }
            string archivo = Carpeta + "Contacto.xls";
            try
            {
                HojaTrabajo.SaveAs(archivo,Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue,misValue,misValue,Excel.XlSaveAsAccessMode.xlExclusive,misValue,misValue,misValue,misValue,misValue);
                System.Diagnostics.Process.Start(Carpeta);
            }
            catch { }
            Excel_Application.Quit();


        }

       
    }
}
