using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;

namespace ProyectoFinal
{
    public partial class VentanaEnviar : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=directorio; Uid=root; Password=208081433;");
        private String id;
        private string to;
        private string sub;
        private string body;
        private string From;

        private MailMessage mail;
        private Attachment data;
        public VentanaEnviar(string id)
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
            this.lblCorreo.Text = leer.GetString(14);
            miconexion.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
     {

        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
           openFileDialog1.ShowDialog();
           txtAsunto.Text = openFileDialog1.FileName;
        }

        public System.Net.Mime.ContentType mediaTypeName { get; set; }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!(lblCorreo.Text.Trim() == ""))
            {
                to = lblCorreo.Text;
                sub = txtAsunto.Text;
                body = txtContenido.Text;
                From = txtDe.Text;

                mail = new MailMessage();
                mail.To.Add(new MailAddress(this.to));
                mail.From = new MailAddress(this.From);
                mail.Subject = sub;
                mail.Body = body;
               // mail.passwor = new MailAddress(this.passwor);
                mail.IsBodyHtml = false;

                if (!(txtAsunto.Text.Trim() == ""))
                {
                    data = new Attachment(txtAsunto.Text, MediaTypeNames.Application.Octet);
                    mail.Attachments.Add(data);
                }
                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                using (client)
                {
                   // client.Credentials = new System.Net.NetworkCredential(this.txtDe,txtPassword);
                    client.EnableSsl = true;
                    client.Send(mail);

                }
                MessageBox.Show("enviado");
            }
        }
        private void txtContenido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
