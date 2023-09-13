namespace CapaPresentacion
{
    partial class FormProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LProducto = new System.Windows.Forms.Label();
            this.PFormUsuario = new System.Windows.Forms.Panel();
            this.TIdProducto = new System.Windows.Forms.TextBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.BEliminar = new System.Windows.Forms.Button();
            this.LCodProduct = new System.Windows.Forms.Label();
            this.BEditar = new System.Windows.Forms.Button();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.LNombree = new System.Windows.Forms.Label();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.TBNombree = new System.Windows.Forms.TextBox();
            this.Lestado = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBConfContra = new System.Windows.Forms.TextBox();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.LConfContrasena = new System.Windows.Forms.Label();
            this.TBcontrasena = new System.Windows.Forms.TextBox();
            this.LContrasena = new System.Windows.Forms.Label();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_Usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.PFormUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LProducto
            // 
            this.LProducto.BackColor = System.Drawing.Color.White;
            this.LProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.LProducto.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.Location = new System.Drawing.Point(0, 0);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(949, 47);
            this.LProducto.TabIndex = 26;
            this.LProducto.Text = "Lista de Productoss:";
            this.LProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PFormUsuario
            // 
            this.PFormUsuario.AutoScroll = true;
            this.PFormUsuario.BackColor = System.Drawing.Color.White;
            this.PFormUsuario.Controls.Add(this.TIdProducto);
            this.PFormUsuario.Controls.Add(this.LTitulo);
            this.PFormUsuario.Controls.Add(this.BEliminar);
            this.PFormUsuario.Controls.Add(this.LCodProduct);
            this.PFormUsuario.Controls.Add(this.BEditar);
            this.PFormUsuario.Controls.Add(this.TBdni);
            this.PFormUsuario.Controls.Add(this.BGuardar);
            this.PFormUsuario.Controls.Add(this.LNombree);
            this.PFormUsuario.Controls.Add(this.CBestado);
            this.PFormUsuario.Controls.Add(this.TBNombree);
            this.PFormUsuario.Controls.Add(this.Lestado);
            this.PFormUsuario.Controls.Add(this.LDescripcion);
            this.PFormUsuario.Controls.Add(this.CBRol);
            this.PFormUsuario.Controls.Add(this.LRol);
            this.PFormUsuario.Controls.Add(this.TBapellido);
            this.PFormUsuario.Controls.Add(this.LUsuario);
            this.PFormUsuario.Controls.Add(this.TBConfContra);
            this.PFormUsuario.Controls.Add(this.TBusuario);
            this.PFormUsuario.Controls.Add(this.LConfContrasena);
            this.PFormUsuario.Controls.Add(this.TBcontrasena);
            this.PFormUsuario.Controls.Add(this.LContrasena);
            this.PFormUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.PFormUsuario.Location = new System.Drawing.Point(691, 47);
            this.PFormUsuario.Name = "PFormUsuario";
            this.PFormUsuario.Size = new System.Drawing.Size(258, 523);
            this.PFormUsuario.TabIndex = 27;
            // 
            // TIdProducto
            // 
            this.TIdProducto.Location = new System.Drawing.Point(215, 39);
            this.TIdProducto.Name = "TIdProducto";
            this.TIdProducto.Size = new System.Drawing.Size(31, 20);
            this.TIdProducto.TabIndex = 23;
            this.TIdProducto.Text = "0";
            this.TIdProducto.Visible = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.White;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(36, 11);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(189, 25);
            this.LTitulo.TabIndex = 22;
            this.LTitulo.Text = "Detalle de Producto";
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Silver;
            this.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEliminar.FlatAppearance.BorderSize = 0;
            this.BEliminar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.Image = global::CapaPresentacion.Properties.Resources.papelera_xmark;
            this.BEliminar.Location = new System.Drawing.Point(23, 529);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(216, 39);
            this.BEliminar.TabIndex = 21;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEliminar.UseVisualStyleBackColor = false;
            // 
            // LCodProduct
            // 
            this.LCodProduct.AutoSize = true;
            this.LCodProduct.BackColor = System.Drawing.Color.White;
            this.LCodProduct.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodProduct.Location = new System.Drawing.Point(17, 47);
            this.LCodProduct.Name = "LCodProduct";
            this.LCodProduct.Size = new System.Drawing.Size(115, 17);
            this.LCodProduct.TabIndex = 1;
            this.LCodProduct.Text = "Cod. del producto";
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.Silver;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.FlatAppearance.BorderSize = 0;
            this.BEditar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.Image = global::CapaPresentacion.Properties.Resources.archivo_de_edicion;
            this.BEditar.Location = new System.Drawing.Point(23, 486);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(216, 37);
            this.BEditar.TabIndex = 20;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(31, 67);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(208, 20);
            this.TBdni.TabIndex = 7;
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.Silver;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.Black;
            this.BGuardar.Image = global::CapaPresentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.BGuardar.Location = new System.Drawing.Point(23, 444);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(216, 36);
            this.BGuardar.TabIndex = 19;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            // 
            // LNombree
            // 
            this.LNombree.AutoSize = true;
            this.LNombree.BackColor = System.Drawing.Color.White;
            this.LNombree.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombree.Location = new System.Drawing.Point(18, 98);
            this.LNombree.Name = "LNombree";
            this.LNombree.Size = new System.Drawing.Size(57, 17);
            this.LNombree.TabIndex = 2;
            this.LNombree.Text = "Nombre";
            // 
            // CBestado
            // 
            this.CBestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Location = new System.Drawing.Point(28, 417);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(208, 21);
            this.CBestado.TabIndex = 18;
            // 
            // TBNombree
            // 
            this.TBNombree.Location = new System.Drawing.Point(31, 118);
            this.TBNombree.Name = "TBNombree";
            this.TBNombree.Size = new System.Drawing.Size(208, 20);
            this.TBNombree.TabIndex = 8;
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.White;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.Location = new System.Drawing.Point(14, 397);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(48, 17);
            this.Lestado.TabIndex = 17;
            this.Lestado.Text = "Estado";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.BackColor = System.Drawing.Color.White;
            this.LDescripcion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.Location = new System.Drawing.Point(17, 148);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(76, 17);
            this.LDescripcion.TabIndex = 3;
            this.LDescripcion.Text = "Descripción";
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(28, 367);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(208, 21);
            this.CBRol.TabIndex = 15;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.White;
            this.LRol.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(17, 347);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(27, 17);
            this.LRol.TabIndex = 16;
            this.LRol.Text = "Rol";
            // 
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(31, 168);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(208, 20);
            this.TBapellido.TabIndex = 9;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.Color.White;
            this.LUsuario.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(20, 199);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(53, 17);
            this.LUsuario.TabIndex = 4;
            this.LUsuario.Text = "Usuario";
            // 
            // TBConfContra
            // 
            this.TBConfContra.Location = new System.Drawing.Point(31, 322);
            this.TBConfContra.Name = "TBConfContra";
            this.TBConfContra.Size = new System.Drawing.Size(208, 20);
            this.TBConfContra.TabIndex = 12;
            // 
            // TBusuario
            // 
            this.TBusuario.Location = new System.Drawing.Point(31, 219);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(208, 20);
            this.TBusuario.TabIndex = 10;
            // 
            // LConfContrasena
            // 
            this.LConfContrasena.AutoSize = true;
            this.LConfContrasena.BackColor = System.Drawing.Color.White;
            this.LConfContrasena.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfContrasena.Location = new System.Drawing.Point(17, 302);
            this.LConfContrasena.Name = "LConfContrasena";
            this.LConfContrasena.Size = new System.Drawing.Size(134, 17);
            this.LConfContrasena.TabIndex = 6;
            this.LConfContrasena.Text = "Confirmar contraseña";
            // 
            // TBcontrasena
            // 
            this.TBcontrasena.Location = new System.Drawing.Point(31, 270);
            this.TBcontrasena.Name = "TBcontrasena";
            this.TBcontrasena.Size = new System.Drawing.Size(208, 20);
            this.TBcontrasena.TabIndex = 11;
            // 
            // LContrasena
            // 
            this.LContrasena.AutoSize = true;
            this.LContrasena.BackColor = System.Drawing.Color.White;
            this.LContrasena.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContrasena.Location = new System.Drawing.Point(17, 250);
            this.LContrasena.Name = "LContrasena";
            this.LContrasena.Size = new System.Drawing.Size(74, 17);
            this.LContrasena.TabIndex = 5;
            this.LContrasena.Text = "Contraseña";
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_Usuarios,
            this.dni,
            this.nombre,
            this.apellido,
            this.email,
            this.Contrasena,
            this.Id_Rol,
            this.Rol,
            this.Estado});
            this.dataGridProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProducto.Location = new System.Drawing.Point(0, 47);
            this.dataGridProducto.MultiSelect = false;
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProducto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProducto.RowTemplate.Height = 28;
            this.dataGridProducto.Size = new System.Drawing.Size(691, 523);
            this.dataGridProducto.TabIndex = 28;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // id_Usuarios
            // 
            this.id_Usuarios.HeaderText = "id_Usuarios";
            this.id_Usuarios.Name = "id_Usuarios";
            this.id_Usuarios.ReadOnly = true;
            this.id_Usuarios.Visible = false;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 180;
            // 
            // Contrasena
            // 
            this.Contrasena.HeaderText = "Contraseña";
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.ReadOnly = true;
            this.Contrasena.Visible = false;
            // 
            // Id_Rol
            // 
            this.Id_Rol.HeaderText = "Id_Rol";
            this.Id_Rol.Name = "Id_Rol";
            this.Id_Rol.ReadOnly = true;
            this.Id_Rol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(193, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 13);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Buscar por :";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(260, 17);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 21);
            this.cboBusqueda.TabIndex = 30;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(388, 18);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 20);
            this.txtBusqueda.TabIndex = 31;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(542, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 570);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridProducto);
            this.Controls.Add(this.PFormUsuario);
            this.Controls.Add(this.LProducto);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.PFormUsuario.ResumeLayout(false);
            this.PFormUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Panel PFormUsuario;
        private System.Windows.Forms.TextBox TIdProducto;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Label LCodProduct;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.TextBox TBNombree;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TBConfContra;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.Label LConfContrasena;
        private System.Windows.Forms.TextBox TBcontrasena;
        private System.Windows.Forms.Label LContrasena;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
    }
}