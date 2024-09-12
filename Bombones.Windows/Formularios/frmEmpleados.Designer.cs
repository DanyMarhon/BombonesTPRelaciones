namespace Bombones.Windows.Formularios
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbImprimir = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            tsbCerrar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            label1 = new Label();
            label2 = new Label();
            cboPaginas = new ComboBox();
            txtCantidadPaginas = new TextBox();
            botonPrimero = new Button();
            botonAnterior = new Button();
            botonSiguiente = new Button();
            botonUltimo = new Button();
            panelNavegacion = new Panel();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colFechaContratacion = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panelNavegacion.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 59);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(44, 59);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(44, 59);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(44, 59);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 59);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // tsbImprimir
            // 
            tsbImprimir.Image = (Image)resources.GetObject("tsbImprimir.Image");
            tsbImprimir.ImageScaling = ToolStripItemImageScaling.None;
            tsbImprimir.ImageTransparentColor = Color.Magenta;
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(57, 59);
            tsbImprimir.Text = "Imprimir";
            tsbImprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 62);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.Image = Properties.Resources.list_40px;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 59);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbCerrar
            // 
            tsbCerrar.Image = (Image)resources.GetObject("tsbCerrar.Image");
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(44, 59);
            tsbCerrar.Text = "Cerrar";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCerrar.Click += tsbCerrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbImprimir, toolStripSeparator3, tsbOrdenar, tsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 62);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnPrimero
            // 
            btnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrimero.Image = Properties.Resources.first_24px;
            btnPrimero.Location = new Point(1713, 30);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(75, 41);
            btnPrimero.TabIndex = 23;
            btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.Image = Properties.Resources.previous_24px;
            btnAnterior.Location = new Point(1794, 30);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 41);
            btnAnterior.TabIndex = 22;
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguiente.Image = Properties.Resources.next_24px;
            btnSiguiente.Location = new Point(1875, 30);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 41);
            btnSiguiente.TabIndex = 21;
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUltimo.Image = Properties.Resources.last_24px;
            btnUltimo.Location = new Point(1956, 30);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(75, 41);
            btnUltimo.TabIndex = 20;
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 38);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 25;
            label1.Text = "Pág.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 38);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 24;
            label2.Text = "de:";
            // 
            // cboPaginas
            // 
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(138, 35);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(68, 23);
            cboPaginas.TabIndex = 26;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Location = new Point(241, 35);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Size = new Size(85, 23);
            txtCantidadPaginas.TabIndex = 27;
            // 
            // botonPrimero
            // 
            botonPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonPrimero.Image = Properties.Resources.first_24px;
            botonPrimero.Location = new Point(436, 25);
            botonPrimero.Name = "botonPrimero";
            botonPrimero.Size = new Size(75, 41);
            botonPrimero.TabIndex = 35;
            botonPrimero.UseVisualStyleBackColor = true;
            botonPrimero.Click += btnPrimero_Click;
            // 
            // botonAnterior
            // 
            botonAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonAnterior.Image = Properties.Resources.previous_24px;
            botonAnterior.Location = new Point(517, 25);
            botonAnterior.Name = "botonAnterior";
            botonAnterior.Size = new Size(75, 41);
            botonAnterior.TabIndex = 34;
            botonAnterior.UseVisualStyleBackColor = true;
            botonAnterior.Click += btnAnterior_Click;
            // 
            // botonSiguiente
            // 
            botonSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonSiguiente.Image = Properties.Resources.next_24px;
            botonSiguiente.Location = new Point(598, 25);
            botonSiguiente.Name = "botonSiguiente";
            botonSiguiente.Size = new Size(75, 41);
            botonSiguiente.TabIndex = 33;
            botonSiguiente.UseVisualStyleBackColor = true;
            botonSiguiente.Click += btnSiguiente_Click;
            // 
            // botonUltimo
            // 
            botonUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonUltimo.Image = Properties.Resources.last_24px;
            botonUltimo.Location = new Point(679, 25);
            botonUltimo.Name = "botonUltimo";
            botonUltimo.Size = new Size(75, 41);
            botonUltimo.TabIndex = 32;
            botonUltimo.UseVisualStyleBackColor = true;
            botonUltimo.Click += btnUltimo_Click;
            // 
            // panelNavegacion
            // 
            panelNavegacion.Controls.Add(botonUltimo);
            panelNavegacion.Controls.Add(botonSiguiente);
            panelNavegacion.Controls.Add(botonAnterior);
            panelNavegacion.Controls.Add(botonPrimero);
            panelNavegacion.Controls.Add(txtCantidadPaginas);
            panelNavegacion.Controls.Add(cboPaginas);
            panelNavegacion.Controls.Add(label2);
            panelNavegacion.Controls.Add(label1);
            panelNavegacion.Controls.Add(btnUltimo);
            panelNavegacion.Controls.Add(btnSiguiente);
            panelNavegacion.Controls.Add(btnAnterior);
            panelNavegacion.Controls.Add(btnPrimero);
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Location = new Point(0, 350);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(800, 100);
            panelNavegacion.TabIndex = 16;
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 62);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 388);
            panelGrilla.TabIndex = 15;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colApellido, colFechaContratacion, colDireccion });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 388);
            dgvDatos.TabIndex = 2;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 42;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 76;
            // 
            // colApellido
            // 
            colApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            colApellido.Width = 76;
            // 
            // colFechaContratacion
            // 
            colFechaContratacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colFechaContratacion.HeaderText = "Fecha Contratación";
            colFechaContratacion.MinimumWidth = 150;
            colFechaContratacion.Name = "colFechaContratacion";
            colFechaContratacion.ReadOnly = true;
            colFechaContratacion.Width = 150;
            // 
            // colDireccion
            // 
            colDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelNavegacion);
            Controls.Add(panelGrilla);
            Controls.Add(toolStrip1);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbImprimir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripButton tsbCerrar;
        private ToolStrip toolStrip1;
        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnUltimo;
        private Label label1;
        private Label label2;
        private ComboBox cboPaginas;
        private TextBox txtCantidadPaginas;
        private Button botonPrimero;
        private Button botonAnterior;
        private Button botonSiguiente;
        private Button botonUltimo;
        private Panel panelNavegacion;
        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colFechaContratacion;
        private DataGridViewTextBoxColumn colDireccion;
    }
}