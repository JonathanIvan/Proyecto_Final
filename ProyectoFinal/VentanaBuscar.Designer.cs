namespace ProyectoFinal
{
    partial class VentanaBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.btnbus = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblObserva = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblAm = new System.Windows.Forms.Label();
            this.lblAp = new System.Windows.Forms.Label();
            this.dtgBuscar = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(21, 28);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgBuscar);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.btnbus);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtRadio);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblObserva);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtPais);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.txtMunicipio);
            this.panel1.Controls.Add(this.txtCp);
            this.panel1.Controls.Add(this.txtColonia);
            this.panel1.Controls.Add(this.txtDomicilio);
            this.panel1.Controls.Add(this.txtAM);
            this.panel1.Controls.Add(this.txtAP);
            this.panel1.Controls.Add(this.lblPais);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblMunicipio);
            this.panel1.Controls.Add(this.lblCp);
            this.panel1.Controls.Add(this.lblColonia);
            this.panel1.Controls.Add(this.lblDomicilio);
            this.panel1.Controls.Add(this.lblAm);
            this.panel1.Controls.Add(this.lblAp);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 454);
            this.panel1.TabIndex = 2;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(277, 175);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(206, 65);
            this.txtObservaciones.TabIndex = 29;
            this.txtObservaciones.Text = "";
            // 
            // btnbus
            // 
            this.btnbus.Location = new System.Drawing.Point(524, 217);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(75, 23);
            this.btnbus.TabIndex = 28;
            this.btnbus.Text = "Buscar";
            this.btnbus.UseVisualStyleBackColor = true;
            this.btnbus.Click += new System.EventHandler(this.btnbus_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(462, 136);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(131, 20);
            this.txtRadio.TabIndex = 25;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(277, 136);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(131, 20);
            this.txtCelular.TabIndex = 24;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(70, 135);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 20);
            this.txtTelefono.TabIndex = 23;
            // 
            // lblObserva
            // 
            this.lblObserva.AutoSize = true;
            this.lblObserva.Location = new System.Drawing.Point(199, 178);
            this.lblObserva.Name = "lblObserva";
            this.lblObserva.Size = new System.Drawing.Size(78, 13);
            this.lblObserva.TabIndex = 22;
            this.lblObserva.Text = "Observaciones";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Radio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Celular";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(21, 139);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(438, 102);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(131, 20);
            this.txtPais.TabIndex = 17;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(268, 102);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(131, 20);
            this.txtEstado.TabIndex = 16;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(79, 102);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(131, 20);
            this.txtMunicipio.TabIndex = 15;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(438, 65);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(131, 20);
            this.txtCp.TabIndex = 14;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(257, 65);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(131, 20);
            this.txtColonia.TabIndex = 13;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(71, 65);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(131, 20);
            this.txtDomicilio.TabIndex = 12;
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(489, 25);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(104, 20);
            this.txtAM.TabIndex = 11;
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(283, 25);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(105, 20);
            this.txtAP.TabIndex = 10;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(405, 105);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "Pais";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(222, 105);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(21, 105);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(52, 13);
            this.lblMunicipio.TabIndex = 7;
            this.lblMunicipio.Text = "Municipio";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(405, 68);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(27, 13);
            this.lblCp.TabIndex = 6;
            this.lblCp.Text = "C.P.";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(209, 68);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(42, 13);
            this.lblColonia.TabIndex = 5;
            this.lblColonia.Text = "Colonia";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(21, 68);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblAm
            // 
            this.lblAm.AutoSize = true;
            this.lblAm.Location = new System.Drawing.Point(397, 28);
            this.lblAm.Name = "lblAm";
            this.lblAm.Size = new System.Drawing.Size(86, 13);
            this.lblAm.TabIndex = 3;
            this.lblAm.Text = "Apellido Materno";
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.Location = new System.Drawing.Point(193, 28);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(84, 13);
            this.lblAp.TabIndex = 2;
            this.lblAp.Text = "Apellido Paterno";
            // 
            // dtgBuscar
            // 
            this.dtgBuscar.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.AP,
            this.AM,
            this.Telefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBuscar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBuscar.Location = new System.Drawing.Point(11, 261);
            this.dtgBuscar.Name = "dtgBuscar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBuscar.Size = new System.Drawing.Size(588, 145);
            this.dtgBuscar.TabIndex = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // AP
            // 
            this.AP.HeaderText = "Apellido Paterno";
            this.AP.Name = "AP";
            // 
            // AM
            // 
            this.AM.HeaderText = "Apellido Materno";
            this.AM.Name = "AM";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // VentanaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 454);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaBuscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblObserva;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblAm;
        private System.Windows.Forms.Label lblAp;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.DataGridView dtgBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}