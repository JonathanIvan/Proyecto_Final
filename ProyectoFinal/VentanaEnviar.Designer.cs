namespace ProyectoFinal
{
    partial class VentanaEnviar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.btnAdjunto = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtDe);
            this.panel1.Controls.Add(this.lblDe);
            this.panel1.Controls.Add(this.btnAdjunto);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.lblContenido);
            this.panel1.Controls.Add(this.txtContenido);
            this.panel1.Controls.Add(this.txtAsunto);
            this.panel1.Controls.Add(this.lblAsunto);
            this.panel1.Controls.Add(this.lblPara);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 390);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(84, 46);
            this.txtDe.Multiline = true;
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(174, 20);
            this.txtDe.TabIndex = 11;
            this.txtDe.UseSystemPasswordChar = true;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(21, 49);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 13);
            this.lblDe.TabIndex = 10;
            this.lblDe.Text = "De:";
            // 
            // btnAdjunto
            // 
            this.btnAdjunto.Location = new System.Drawing.Point(312, 137);
            this.btnAdjunto.Name = "btnAdjunto";
            this.btnAdjunto.Size = new System.Drawing.Size(75, 23);
            this.btnAdjunto.TabIndex = 9;
            this.btnAdjunto.Text = "Adjunto";
            this.btnAdjunto.UseVisualStyleBackColor = true;
            this.btnAdjunto.Click += new System.EventHandler(this.btnAdjunto_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(67, 18);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "label1";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(24, 147);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(58, 13);
            this.lblContenido.TabIndex = 5;
            this.lblContenido.Text = "Contenido:";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(27, 176);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(360, 182);
            this.txtContenido.TabIndex = 4;
            this.txtContenido.Text = "";
            this.txtContenido.TextChanged += new System.EventHandler(this.txtContenido_TextChanged);
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(94, 115);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(174, 20);
            this.txtAsunto.TabIndex = 3;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(39, 118);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(43, 13);
            this.lblAsunto.TabIndex = 2;
            this.lblAsunto.Text = "Asunto:";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(21, 18);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "Para:";
            this.lblPara.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(416, 272);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VentanaEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 386);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaEnviar";
            this.Text = "Enviar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnAdjunto;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}