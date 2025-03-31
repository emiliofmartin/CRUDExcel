namespace CRUDExcelEPPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnExaminar = new Button();
            lblFichero = new Label();
            dgvRegistros = new DataGridView();
            gbRegistro = new GroupBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCrear = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            gbRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(657, 255);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(12, 12);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(75, 23);
            btnExaminar.TabIndex = 1;
            btnExaminar.Text = "E&xaminar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // lblFichero
            // 
            lblFichero.AutoSize = true;
            lblFichero.Location = new Point(93, 16);
            lblFichero.Name = "lblFichero";
            lblFichero.Size = new Size(0, 15);
            lblFichero.TabIndex = 2;
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToOrderColumns = true;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(12, 41);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new Size(462, 208);
            dgvRegistros.TabIndex = 4;
            dgvRegistros.CellClick += dgvRegistros_CellClick;
            // 
            // gbRegistro
            // 
            gbRegistro.Controls.Add(btnModificar);
            gbRegistro.Controls.Add(btnEliminar);
            gbRegistro.Controls.Add(btnCrear);
            gbRegistro.Controls.Add(txtApellido);
            gbRegistro.Controls.Add(txtNombre);
            gbRegistro.Controls.Add(lblApellido);
            gbRegistro.Controls.Add(txtCodigo);
            gbRegistro.Controls.Add(lblNombre);
            gbRegistro.Controls.Add(lblCodigo);
            gbRegistro.Location = new Point(480, 41);
            gbRegistro.Name = "gbRegistro";
            gbRegistro.Size = new Size(252, 208);
            gbRegistro.TabIndex = 8;
            gbRegistro.TabStop = false;
            gbRegistro.Text = "Registro";
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(87, 127);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(168, 127);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Enabled = false;
            btnCrear.Location = new Point(6, 127);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "&Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(69, 86);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(174, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 23);
            txtNombre.TabIndex = 7;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 89);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(69, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(174, 23);
            txtCodigo.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(17, 30);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 294);
            Controls.Add(gbRegistro);
            Controls.Add(dgvRegistros);
            Controls.Add(lblFichero);
            Controls.Add(btnExaminar);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "CRUD Excel";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            gbRegistro.ResumeLayout(false);
            gbRegistro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnExaminar;
        private Label lblFichero;
        private DataGridView dgvRegistros;
        private GroupBox gbRegistro;
        private Label lblCodigo;
        private Label lblApellido;
        private TextBox txtCodigo;
        private Label lblNombre;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCrear;
        private Button btnEliminar;
        private Button btnModificar;
    }
}

