using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProyectoFinal
{
    class VenEliminar
    {

        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=directorio; Uid=root; Password=208081433;");
        private String id;
        private Principal padre;

        public VenEliminar(Principal padre, string id)
        {
            this.padre = padre;
            // TODO: Complete member initialization
            this.id = id;

            DialogResult resultado = MessageBox.Show("¿Realmende desea Eliminar Contacto", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            this.carga_Contacto();
        }
        public void carga_Contacto()
        {
            
            MySqlCommand comando = new MySqlCommand("Delete FROM contacto where id ='" + this.id + "'", miconexion);
            
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
           MessageBox.Show("Contacto Borrado Correctamente");
           this.padre.carga_Principal();
    }
  }
}