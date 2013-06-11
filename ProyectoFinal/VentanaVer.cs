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
    public partial class VentanaVer : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=directorio; Uid=root; Password=208081433;");
        private String id;
 
        public VentanaVer(string id)
        {
            InitializeComponent();
            this.id = id;
            this.carga_Contacto();
            this.Text = "ID: " + id;
              
        }

        void carga_Contacto() 
        { 
            
            string sql = "SELECT * FROM contacto WHERE id = '" + this.id + "'";
            MySqlCommand comando = new MySqlCommand(sql, miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            if (!leer.IsDBNull(3))
            {
                this.lblNOMBRE.Text = leer.GetString(3);
            }
            else
            {
                this.lblNOMBRE.Text = "-";
            }
            if (!leer.IsDBNull(1))
            {
                this.lblAPATERNO.Text = leer.GetString(1);
            }
            else {
                this.lblAPATERNO.Text = "-";
            }
            if (!leer.IsDBNull(2))
            {
                this.lblAMATERNO.Text = leer.GetString(2);
            }
            else {
                this.lblAMATERNO.Text = "-";
            }
                if (!leer.IsDBNull(4))
                {
                    this.lblDOMICILIO.Text = leer.GetString(4);
                }
                else {
                    this.lblDOMICILIO.Text = "-";
                }
                if (!leer.IsDBNull(5))
                {
                    this.lblCOLONIA.Text = leer.GetString(5);
                }
                else {
                    this.lblCOLONIA.Text = "-";
                } if (!leer.IsDBNull(6))
                {
                    this.lblCP.Text = leer.GetString(6);
                }
                else {
                    this.lblCP.Text = "-";
                } if (!leer.IsDBNull(7))
                {
                    this.lblMUNICIPIO.Text = leer.GetString(7);
                }
                else {
                    this.lblMUNICIPIO.Text = "-";
                } if (!leer.IsDBNull(8))
                {
                    this.lblESTADO.Text = leer.GetString(8);
                } if (!leer.IsDBNull(9))
                {
                    this.lblPAIS.Text = leer.GetString(9);
                }
                else {
                    this.lblPAIS.Text = "-";
                } if (!leer.IsDBNull(10))
                {
                    this.lblMAPA.Text = leer.GetString(10);
                }
                else {
                    this.lblMAPA.Text = "-";
                } if (!leer.IsDBNull(11))
                {
                    this.lblTELEFONO.Text = leer.GetString(11);
                }
                else {
                    this.lblTELEFONO.Text = "-";
                } if (!leer.IsDBNull(12))
                {
                    this.lblCELULAR.Text = leer.GetString(12);
                }
                else {
                    this.lblCELULAR.Text = "-";
                } if (!leer.IsDBNull(13))
                {
                    this.lblRADIO.Text = leer.GetString(13);
                }
                else {
                    this.lblRADIO.Text = "-";
                } if (!leer.IsDBNull(14))
                {
                    this.lblEMAIL.Text = leer.GetString(14);
                }
                else {
                    this.lblEMAIL.Text = "-";
                } if (!leer.IsDBNull(15))
                {
                    this.lblOBSERVACIONES.Text = leer.GetString(15);
                }
                else {
                    this.lblOBSERVACIONES.Text = "-";
                }
            miconexion.Close();
        }

    }
}
