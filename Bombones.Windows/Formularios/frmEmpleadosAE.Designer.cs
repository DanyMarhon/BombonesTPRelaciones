namespace Bombones.Windows.Formularios
{
    partial class frmEmpleadosAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosAE));
            tabCliente = new TabControl();
            tabPage1 = new TabPage();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            tabPage2 = new TabPage();
            dgvDirecciones = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            btnEditarDireccion = new Button();
            btnBorrarDireccion = new Button();
            btnAgregarDireccion = new Button();
            btnCancelar = new Button();
            btnOk = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabCliente.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirecciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tabPage1);
            tabCliente.Controls.Add(tabPage2);
            tabCliente.Location = new Point(12, 12);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(741, 415);
            tabCliente.TabIndex = 44;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(733, 387);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(188, 155);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 155);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 40;
            label1.Text = "Fecha Contratación:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 90);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 40;
            label6.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 47);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 40;
            label4.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(135, 44);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(412, 23);
            txtApellido.TabIndex = 31;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 87);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(412, 23);
            txtNombre.TabIndex = 31;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvDirecciones);
            tabPage2.Controls.Add(btnEditarDireccion);
            tabPage2.Controls.Add(btnBorrarDireccion);
            tabPage2.Controls.Add(btnAgregarDireccion);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(733, 387);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Direcciones";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDirecciones
            // 
            dgvDirecciones.AllowUserToAddRows = false;
            dgvDirecciones.AllowUserToDeleteRows = false;
            dgvDirecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirecciones.Columns.AddRange(new DataGridViewColumn[] { colId, colDireccion });
            dgvDirecciones.Location = new Point(3, 3);
            dgvDirecciones.MultiSelect = false;
            dgvDirecciones.Name = "dgvDirecciones";
            dgvDirecciones.ReadOnly = true;
            dgvDirecciones.RowHeadersVisible = false;
            dgvDirecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirecciones.Size = new Size(724, 278);
            dgvDirecciones.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colDireccion
            // 
            colDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // btnEditarDireccion
            // 
            btnEditarDireccion.Image = Properties.Resources.edit_28px1;
            btnEditarDireccion.Location = new Point(269, 301);
            btnEditarDireccion.Name = "btnEditarDireccion";
            btnEditarDireccion.Size = new Size(119, 54);
            btnEditarDireccion.TabIndex = 35;
            btnEditarDireccion.Text = "Editar";
            btnEditarDireccion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditarDireccion.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDireccion
            // 
            btnBorrarDireccion.Image = Properties.Resources.delete_sign_28px;
            btnBorrarDireccion.Location = new Point(144, 301);
            btnBorrarDireccion.Name = "btnBorrarDireccion";
            btnBorrarDireccion.Size = new Size(119, 54);
            btnBorrarDireccion.TabIndex = 35;
            btnBorrarDireccion.Text = "Borrar";
            btnBorrarDireccion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrarDireccion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDireccion
            // 
            btnAgregarDireccion.Image = Properties.Resources.add_28px;
            btnAgregarDireccion.Location = new Point(19, 301);
            btnAgregarDireccion.Name = "btnAgregarDireccion";
            btnAgregarDireccion.Size = new Size(119, 54);
            btnAgregarDireccion.TabIndex = 35;
            btnAgregarDireccion.Text = "Agregar";
            btnAgregarDireccion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarDireccion.UseVisualStyleBackColor = true;
            btnAgregarDireccion.Click += btnAgregarDireccion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(500, 458);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(88, 458);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 45;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 538);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(tabCliente);
            Name = "frmEmpleadosAE";
            Text = "frmEmpleadosAE";
            tabCliente.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDirecciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCliente;
        private TabPage tabPage1;
        private Label label6;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TabPage tabPage2;
        private DataGridView dgvDirecciones;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDireccion;
        private Button btnEditarDireccion;
        private Button btnBorrarDireccion;
        private Button btnAgregarDireccion;
        private Button btnCancelar;
        private Button btnOk;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}