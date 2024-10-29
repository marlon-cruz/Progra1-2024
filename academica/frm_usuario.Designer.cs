namespace academica
{
    partial class frm_usuario
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
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.grdDatosUsuario = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionUsuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.lblRegistrosUsuario = new System.Windows.Forms.Label();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            this.grbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtConfirmacionUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuario)).BeginInit();
            this.grbEdicionUsuario.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.grbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(573, 38);
            this.lblBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarUsuario.TabIndex = 21;
            this.lblBuscarUsuario.Text = "BUSCAR:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(694, 44);
            this.txtBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(461, 22);
            this.txtBuscarUsuario.TabIndex = 22;
            this.txtBuscarUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuario_KeyUp_1);
            // 
            // grdDatosUsuario
            // 
            this.grdDatosUsuario.AllowUserToAddRows = false;
            this.grdDatosUsuario.AllowUserToDeleteRows = false;
            this.grdDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.usuario,
            this.clave,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosUsuario.Location = new System.Drawing.Point(578, 76);
            this.grdDatosUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatosUsuario.Name = "grdDatosUsuario";
            this.grdDatosUsuario.ReadOnly = true;
            this.grdDatosUsuario.RowHeadersWidth = 51;
            this.grdDatosUsuario.Size = new System.Drawing.Size(579, 310);
            this.grdDatosUsuario.TabIndex = 20;
            this.grdDatosUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosUsuario_CellClick);
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.MinimumWidth = 6;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 125;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "clave";
            this.clave.MinimumWidth = 6;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            this.clave.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // grbEdicionUsuario
            // 
            this.grbEdicionUsuario.Controls.Add(this.btnEliminarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnModificarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnNuevoUsuario);
            this.grbEdicionUsuario.Location = new System.Drawing.Point(326, 394);
            this.grbEdicionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionUsuario.Name = "grbEdicionUsuario";
            this.grbEdicionUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionUsuario.Size = new System.Drawing.Size(392, 71);
            this.grbEdicionUsuario.TabIndex = 19;
            this.grbEdicionUsuario.TabStop = false;
            this.grbEdicionUsuario.Text = "Navegacion";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(252, 23);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(129, 47);
            this.btnEliminarUsuario.TabIndex = 6;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click_1);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(116, 23);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(139, 47);
            this.btnModificarUsuario.TabIndex = 5;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click_1);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(8, 23);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(111, 47);
            this.btnNuevoUsuario.TabIndex = 4;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click_1);
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.lblRegistrosUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(34, 394);
            this.grbNavegacionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(284, 71);
            this.grbNavegacionUsuario.TabIndex = 18;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "Navegacion";
            // 
            // lblRegistrosUsuario
            // 
            this.lblRegistrosUsuario.AutoSize = true;
            this.lblRegistrosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosUsuario.Location = new System.Drawing.Point(101, 30);
            this.lblRegistrosUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosUsuario.Name = "lblRegistrosUsuario";
            this.lblRegistrosUsuario.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosUsuario.TabIndex = 10;
            this.lblRegistrosUsuario.Text = "x de n";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.Location = new System.Drawing.Point(229, 17);
            this.btnUltimoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(47, 47);
            this.btnUltimoUsuario.TabIndex = 3;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            this.btnUltimoUsuario.Click += new System.EventHandler(this.btnUltimoUsuario_Click);
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(185, 17);
            this.btnSiguienteUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(47, 47);
            this.btnSiguienteUsuario.TabIndex = 2;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            this.btnSiguienteUsuario.Click += new System.EventHandler(this.btnSiguienteUsuario_Click);
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(53, 22);
            this.btnAnteriorUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(47, 47);
            this.btnAnteriorUsuario.TabIndex = 1;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            this.btnAnteriorUsuario.Click += new System.EventHandler(this.btnAnteriorUsuario_Click);
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(47, 47);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            this.btnPrimeroUsuario.Click += new System.EventHandler(this.btnPrimeroUsuario_Click_1);
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.Controls.Add(this.txtConfirmacionUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblClave);
            this.grbDatosUsuario.Controls.Add(this.txtClaveUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblTelefonoUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtUsuario);
            this.grbDatosUsuario.Enabled = false;
            this.grbDatosUsuario.Location = new System.Drawing.Point(33, 26);
            this.grbDatosUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosUsuario.Size = new System.Drawing.Size(520, 361);
            this.grbDatosUsuario.TabIndex = 17;
            this.grbDatosUsuario.TabStop = false;
            this.grbDatosUsuario.Text = "Datos Alumnos";
            // 
            // txtConfirmacionUsuario
            // 
            this.txtConfirmacionUsuario.Location = new System.Drawing.Point(335, 108);
            this.txtConfirmacionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmacionUsuario.Name = "txtConfirmacionUsuario";
            this.txtConfirmacionUsuario.PasswordChar = '*';
            this.txtConfirmacionUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtConfirmacionUsuario.TabIndex = 10;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(41, 103);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 29);
            this.lblClave.TabIndex = 9;
            this.lblClave.Text = "Clave:";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(175, 108);
            this.txtClaveUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.PasswordChar = '*';
            this.txtClaveUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtClaveUsuario.TabIndex = 8;
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(41, 255);
            this.lblTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(116, 29);
            this.lblTelefonoUsuario.TabIndex = 7;
            this.lblTelefonoUsuario.Text = "Telefono:";
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(175, 260);
            this.txtTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoUsuario.TabIndex = 6;
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionUsuario.Location = new System.Drawing.Point(41, 207);
            this.lblDireccionUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(121, 29);
            this.lblDireccionUsuario.TabIndex = 5;
            this.lblDireccionUsuario.Text = "Direccion:";
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(175, 212);
            this.txtDireccionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(333, 22);
            this.txtDireccionUsuario.TabIndex = 4;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(41, 158);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(107, 29);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(175, 162);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(333, 22);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(41, 46);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 29);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(175, 50);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 547);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.grdDatosUsuario);
            this.Controls.Add(this.grbEdicionUsuario);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbDatosUsuario);
            this.Name = "frm_usuario";
            this.Text = "frm_usuario";
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuario)).EndInit();
            this.grbEdicionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.DataGridView grdDatosUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.GroupBox grbEdicionUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Label lblRegistrosUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
        private System.Windows.Forms.GroupBox grbDatosUsuario;
        private System.Windows.Forms.TextBox txtConfirmacionUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label lblTelefonoUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.Label lblDireccionUsuario;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}