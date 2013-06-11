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
    public partial class VentanaBuscar : Form
    {
        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=directorio; Uid=root; Password=208081433;");
        public VentanaBuscar()
        {
            InitializeComponent();
            
        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }

        private void btnbus_Click(object sender, EventArgs e)
        {
            busqueda_Contacto();
        }
        void busqueda_Contacto()
        {
            DataTable tablaresul = new DataTable();
            string sql = "select id, ap, am, nombre, telefono from directorio " +
                "where ap like '%" + txtAP.Text.Trim() + "%'and am like '%" + txtAM.Text.Trim() + "%' " +
                "and nombre like '%" + txtNombre.Text.Trim() + "%' and domicilio like '%" + txtDomicilio.Text.Trim() + "%' " +
                "and colonia like '%" + txtColonia.Text.Trim() + "%'and cp like '%" + txtCp.Text.Trim() + "%'" +
                "and municipio like '%" + txtMunicipio.Text.Trim() + "%' and estado like '%" + txtEstado.Text.Trim() + "%' " +
                "and pais like '%" + txtPais.Text.Trim() + "%' and telefono like '%" + txtTelefono.Text.Trim() + "%' " +
                "and celular like '%" + txtCelular.Text.Trim() + "%' and radio like '%" + txtRadio.Text.Trim() + "%' " +
                "and email like '%" + txtEmail.Text.Trim() + "%'";
            MySqlCommand busqueda = new MySqlCommand(sql, miconexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(busqueda);
            
            adaptador.Fill(tablaresul);
            busqueda.ExecuteReader();

            
            dtgBuscar.DataSource = tablaresul;
            dtgBuscar.Visible = true;
            this.Size = new System.Drawing.Size(643, 715);
            miconexion.Close();
        }
    }
}
