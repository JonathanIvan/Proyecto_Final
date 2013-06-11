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
    public partial class VentanaNuevo : Form
    {
        private Principal padre;

        public VentanaNuevo(Principal padre)
        {
            this.padre = padre;
            InitializeComponent();
               
        }
        

        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=directorio; Uid=root; Password=208081433;");
        
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             
            MySqlCommand comando = new MySqlCommand("Insert into `directorio`.`contacto`set nombre=@NAME,ap=@APP,am=@AMP,domicilio=@DOMICILIOO,colonia=@COLONIAA,cp=@CPP,municipio=@MUNICIPIOO,estado=@ESTADOO,pais=@PAISS,mapa=@MAPAA,telefono=@TEL,celular=@CEL,radio=@RADIOO,email=@EMAILL,observaciones=@OBSER", miconexion);
            comando.Parameters.AddWithValue("NAME", textNom.Text);
            comando.Parameters.AddWithValue("APP", textAp.Text);
            comando.Parameters.AddWithValue("AMP", textAm.Text);
            comando.Parameters.AddWithValue("DOMICILIOO", textDomicilio.Text);
            comando.Parameters.AddWithValue("COLONIAA", textColonia.Text);
            comando.Parameters.AddWithValue("CPP", textCp.Text);
            comando.Parameters.AddWithValue("MUNICIPIOO", textMunicipio.Text);
            comando.Parameters.AddWithValue("ESTADOO", textEstado.Text);
            comando.Parameters.AddWithValue("PAISS", textPais.Text);
            comando.Parameters.AddWithValue("MAPAA", textMapa.Text);
            comando.Parameters.AddWithValue("TEL", textTelefono.Text);
            comando.Parameters.AddWithValue("CEL", textCelular.Text);
            comando.Parameters.AddWithValue("RADIOO", textRadio.Text);
            comando.Parameters.AddWithValue("EMAILL", textEmail.Text);
            comando.Parameters.AddWithValue("OBSER", TextObserva.Text);
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Agregado Correctamente");
            this.padre.carga_Principal();
        }
    }
}
