namespace Bombones.Windows.Formularios
{
    partial class frmDireccionesEmpleadoAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDireccionesEmpleadoAE));
            btnCancelar = new Button();
            btnOk = new Button();
            label11 = new Label();
            label10 = new Label();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboCiudades = new ComboBox();
            txtAltura = new TextBox();
            txtEntre2 = new TextBox();
            txtEntre1 = new TextBox();
            txtCalle = new TextBox();
            cboProvinciasEstados = new ComboBox();
            txtDepto = new TextBox();
            txtPiso = new TextBox();
            txtCodPostal = new TextBox();
            cboPaises = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(508, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 74;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(96, 316);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 73;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(278, 262);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 68;
            label11.Text = "Depto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 262);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 67;
            label10.Text = "Piso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 199);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 66;
            label6.Text = "Cod, Postal:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 156);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 64;
            label1.Text = "Provincia/Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(545, 15);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 71;
            label7.Text = "Altura:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 73);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 70;
            label9.Text = "Y:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 44);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 69;
            label8.Text = "Entre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 15);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 72;
            label4.Text = "Calle:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 199);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 63;
            label5.Text = "Ciudad:";
            // 
            // cboCiudades
            // 
            cboCiudades.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCiudades.FormattingEnabled = true;
            cboCiudades.Location = new Point(119, 196);
            cboCiudades.Name = "cboCiudades";
            cboCiudades.Size = new Size(315, 23);
            cboCiudades.TabIndex = 62;
            cboCiudades.SelectedIndexChanged += cboCiudades_SelectedIndexChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(597, 12);
            txtAltura.MaxLength = 50;
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(144, 23);
            txtAltura.TabIndex = 56;
            // 
            // txtEntre2
            // 
            txtEntre2.Location = new Point(119, 70);
            txtEntre2.MaxLength = 50;
            txtEntre2.Name = "txtEntre2";
            txtEntre2.Size = new Size(412, 23);
            txtEntre2.TabIndex = 55;
            // 
            // txtEntre1
            // 
            txtEntre1.Location = new Point(119, 41);
            txtEntre1.MaxLength = 50;
            txtEntre1.Name = "txtEntre1";
            txtEntre1.Size = new Size(412, 23);
            txtEntre1.TabIndex = 54;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(119, 12);
            txtCalle.MaxLength = 50;
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(412, 23);
            txtCalle.TabIndex = 53;
            // 
            // cboProvinciasEstados
            // 
            cboProvinciasEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvinciasEstados.FormattingEnabled = true;
            cboProvinciasEstados.Location = new Point(119, 153);
            cboProvinciasEstados.Name = "cboProvinciasEstados";
            cboProvinciasEstados.Size = new Size(315, 23);
            cboProvinciasEstados.TabIndex = 61;
            cboProvinciasEstados.SelectedIndexChanged += cboProvinciasEstados_SelectedIndexChanged;
            // 
            // txtDepto
            // 
            txtDepto.Location = new Point(367, 259);
            txtDepto.MaxLength = 50;
            txtDepto.Name = "txtDepto";
            txtDepto.Size = new Size(129, 23);
            txtDepto.TabIndex = 59;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(119, 259);
            txtPiso.MaxLength = 50;
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(129, 23);
            txtPiso.TabIndex = 58;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(552, 196);
            txtCodPostal.MaxLength = 50;
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(207, 23);
            txtCodPostal.TabIndex = 57;
            // 
            // cboPaises
            // 
            cboPaises.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaises.FormattingEnabled = true;
            cboPaises.Location = new Point(119, 109);
            cboPaises.Name = "cboPaises";
            cboPaises.Size = new Size(315, 23);
            cboPaises.TabIndex = 60;
            cboPaises.SelectedIndexChanged += cboPaises_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 112);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 65;
            label2.Text = "País:";
            // 
            // frmDireccionesEmpleadoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 381);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cboCiudades);
            Controls.Add(txtAltura);
            Controls.Add(txtEntre2);
            Controls.Add(txtEntre1);
            Controls.Add(txtCalle);
            Controls.Add(cboProvinciasEstados);
            Controls.Add(txtDepto);
            Controls.Add(txtPiso);
            Controls.Add(txtCodPostal);
            Controls.Add(cboPaises);
            Controls.Add(label2);
            Name = "frmDireccionesEmpleadoAE";
            Text = "frmDireccionesEmpleadoAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOk;
        private Label label11;
        private Label label10;
        private Label label6;
        private Label label1;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label5;
        private ComboBox cboCiudades;
        private TextBox txtAltura;
        private TextBox txtEntre2;
        private TextBox txtEntre1;
        private TextBox txtCalle;
        private ComboBox cboProvinciasEstados;
        private TextBox txtDepto;
        private TextBox txtPiso;
        private TextBox txtCodPostal;
        private ComboBox cboPaises;
        private Label label2;
    }
}