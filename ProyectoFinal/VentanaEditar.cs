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
    public partial class VentanaEditar : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=directorio; Uid=root; Password=208081433;");
        private String id;
        private Principal padre;
        
        public VentanaEditar(Principal padre, string id)
        {
            this.padre = padre;
            InitializeComponent();
            // TODO: Complete member initialization
            this.id = id;
            this.Text = "ID: " + id;
            carga_datos();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("update contacto set nombre=@NAME,ap=@APP,am=@AMP,domicilio=@DOMICILIOO,colonia=@COLONIAA,cp=@CPP,municipio=@MUNICIPIOO,estado=@ESTADOO,pais=@PAISS,mapa=@MAPAA,telefono=@TEL,celular=@CEL,radio=@RADIOO,email=@EMAILL,observaciones=@OBSER where id ='" + this.id + "'", miconexion);
            
            comando.Parameters.AddWithValue("NAME", txtNom.Text);
            comando.Parameters.AddWithValue("APP", txtAp.Text);
            comando.Parameters.AddWithValue("AMP", txtAm.Text);
            comando.Parameters.AddWithValue("DOMICILIOO", txtDomicilio.Text);
            comando.Parameters.AddWithValue("COLONIAA", txtColonia.Text);
            comando.Parameters.AddWithValue("CPP", txtCp.Text);
            comando.Parameters.AddWithValue("MUNICIPIOO", txtMunicipio.Text);
            comando.Parameters.AddWithValue("ESTADOO", txtEstado.Text);
            comando.Parameters.AddWithValue("PAISS", txtPais.Text);
            comando.Parameters.AddWithValue("MAPAA", txtMapa.Text);
            comando.Parameters.AddWithValue("TEL", txtTelefono.Text);
            comando.Parameters.AddWithValue("CEL", txtCelular.Text);
            comando.Parameters.AddWithValue("RADIOO", txtRadio.Text);
            comando.Parameters.AddWithValue("EMAILL", txtEmail.Text);
            comando.Parameters.AddWithValue("OBSER", txtObservaciones.Text);
            miconexion.Open();
           comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Editado");
            this.padre.carga_Principal();
        }

        private void VentanaEditar_Load(object sender, EventArgs e)
        {
            
        }
        void carga_datos() {
            string sql = "SELECT * FROM contacto WHERE id = '" + this.id + "'";
            MySqlCommand comando = new MySqlCommand(sql, miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            if (!leer.IsDBNull(3))
            {
                this.txtNom.Text = leer.GetString(3);
            }
            else {
                this.txtNom.Text = " ";
            } if (!leer.IsDBNull(1))
            {
                this.txtAp.Text = leer.GetString(1);
            }
            else {
                this.txtAp.Text = " ";
            } if (!leer.IsDBNull(2))
            {
                this.txtAm.Text = leer.GetString(2);
            }
            else {
                this.txtAm.Text = " ";
            } if (!leer.IsDBNull(12))
            {
                this.txtCelular.Text = leer.GetString(12);
            }
            else {
                this.txtCelular.Text = " ";
            } if (!leer.IsDBNull(6))
            {
                this.txtCp.Text = leer.GetString(6);
            }
            else {
                this.txtCp.Text = " ";
            } if (!leer.IsDBNull(5))
            {
                this.txtColonia.Text = leer.GetString(5);
            }
            else {
                this.txtColonia.Text = " ";
            } if (!leer.IsDBNull(4))
            {
                this.txtDomicilio.Text = leer.GetString(4);
            }
            else {
                this.txtDomicilio.Text = " ";
            } if (!leer.IsDBNull(8))
            {
                this.txtEstado.Text = leer.GetString(8);
            }
            else {
                this.txtEstado.Text = " ";
            } if (!leer.IsDBNull(7))
            {
                this.txtMunicipio.Text = leer.GetString(7);
            }
            else {
                this.txtMunicipio.Text = " ";
            } if (!leer.IsDBNull(9))
            {
                this.txtPais.Text = leer.GetString(9);
            }
            else {
                this.txtPais.Text = " ";
            } if (!leer.IsDBNull(10))
            {
                this.txtMapa.Text = leer.GetString(10);
            }
            else {
                this.txtMapa.Text = " ";
            } if (!leer.IsDBNull(15))
            {
                this.txtObservaciones.Text = leer.GetString(15);
            }
            else {
                this.txtObservaciones.Text = " ";
            } if (!leer.IsDBNull(13))
            {
                this.txtRadio.Text = leer.GetString(13);
            }
            else {
                this.txtRadio.Text = " ";
            } if (!leer.IsDBNull(14))
            {
                this.txtEmail.Text = leer.GetString(14);
            }
            else {
                this.txtEmail.Text = " ";
            } if (!leer.IsDBNull(11))
            {
                this.txtTelefono.Text = leer.GetString(11);
            }
            else {
                this.txtTelefono.Text = " ";
            }
            miconexion.Close();
        }
    }
}
