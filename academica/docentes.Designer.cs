
namespace academica
{
    partial class docentes
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
            this.lblBuscarDocente = new System.Windows.Forms.Label();
            this.txtBuscarDocente = new System.Windows.Forms.TextBox();
            this.grdDatosDocentes = new System.Windows.Forms.DataGridView();
            this.grbEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnNuevoDocente = new System.Windows.Forms.Button();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblRegistrosDocente = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimeroDocente = new System.Windows.Forms.Button();
            this.grbDatosDocentes = new System.Windows.Forms.GroupBox();
            this.lblNivelAcademinco = new System.Windows.Forms.Label();
            this.txtNAcademico = new System.Windows.Forms.TextBox();
            this.lblMateria2 = new System.Windows.Forms.Label();
            this.txtMateria2 = new System.Windows.Forms.TextBox();
            this.lblMateria1 = new System.Windows.Forms.Label();
            this.txtMateria1 = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.IdDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).BeginInit();
            this.grbEdicionDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.grbDatosDocentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarDocente
            // 
            this.lblBuscarDocente.AutoSize = true;
            this.lblBuscarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDocente.Location = new System.Drawing.Point(559, 14);
            this.lblBuscarDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarDocente.Name = "lblBuscarDocente";
            this.lblBuscarDocente.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarDocente.TabIndex = 15;
            this.lblBuscarDocente.Text = "BUSCAR:";
            // 
            // txtBuscarDocente
            // 
            this.txtBuscarDocente.Location = new System.Drawing.Point(680, 20);
            this.txtBuscarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarDocente.Name = "txtBuscarDocente";
            this.txtBuscarDocente.Size = new System.Drawing.Size(461, 22);
            this.txtBuscarDocente.TabIndex = 16;
            this.txtBuscarDocente.TextChanged += new System.EventHandler(this.txtBuscarDocente_TextChanged);
            // 
            // grdDatosDocentes
            // 
            this.grdDatosDocentes.AllowUserToAddRows = false;
            this.grdDatosDocentes.AllowUserToDeleteRows = false;
            this.grdDatosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDocente,
            this.codigo,
            this.nombre,
            this.materia1,
            this.Materia2});
            this.grdDatosDocentes.Location = new System.Drawing.Point(564, 52);
            this.grdDatosDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatosDocentes.Name = "grdDatosDocentes";
            this.grdDatosDocentes.ReadOnly = true;
            this.grdDatosDocentes.RowHeadersWidth = 51;
            this.grdDatosDocentes.Size = new System.Drawing.Size(579, 310);
            this.grdDatosDocentes.TabIndex = 14;
            this.grdDatosDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosDocentes_CellClick);
            // 
            // grbEdicionDocente
            // 
            this.grbEdicionDocente.Controls.Add(this.btnEliminarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnModificarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnNuevoDocente);
            this.grbEdicionDocente.Location = new System.Drawing.Point(529, 393);
            this.grbEdicionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Name = "grbEdicionDocente";
            this.grbEdicionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Size = new System.Drawing.Size(392, 71);
            this.grbEdicionDocente.TabIndex = 19;
            this.grbEdicionDocente.TabStop = false;
            this.grbEdicionDocente.Text = "Editar";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.Location = new System.Drawing.Point(252, 23);
            this.btnEliminarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(129, 47);
            this.btnEliminarDocente.TabIndex = 6;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.Location = new System.Drawing.Point(116, 23);
            this.btnModificarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(139, 47);
            this.btnModificarDocente.TabIndex = 5;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocente.Location = new System.Drawing.Point(8, 23);
            this.btnNuevoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(111, 47);
            this.btnNuevoDocente.TabIndex = 4;
            this.btnNuevoDocente.Text = "Nuevo";
            this.btnNuevoDocente.UseVisualStyleBackColor = true;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnNuevoDocente_Click);
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.lblRegistrosDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnPrimeroDocente);
            this.grbNavegacionDocente.Location = new System.Drawing.Point(47, 392);
            this.grbNavegacionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Size = new System.Drawing.Size(284, 71);
            this.grbNavegacionDocente.TabIndex = 18;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegacion";
            // 
            // lblRegistrosDocente
            // 
            this.lblRegistrosDocente.AutoSize = true;
            this.lblRegistrosDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosDocente.Location = new System.Drawing.Point(101, 30);
            this.lblRegistrosDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosDocente.Name = "lblRegistrosDocente";
            this.lblRegistrosDocente.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosDocente.TabIndex = 10;
            this.lblRegistrosDocente.Text = "x de n";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocente.Location = new System.Drawing.Point(229, 17);
            this.btnUltimoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(47, 47);
            this.btnUltimoDocente.TabIndex = 3;
            this.btnUltimoDocente.Text = ">|";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocente.Location = new System.Drawing.Point(185, 17);
            this.btnSiguienteDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(47, 47);
            this.btnSiguienteDocente.TabIndex = 2;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocente.Location = new System.Drawing.Point(53, 22);
            this.btnAnteriorDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(47, 47);
            this.btnAnteriorDocente.TabIndex = 1;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPrimeroDocente
            // 
            this.btnPrimeroDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocente.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroDocente.Name = "btnPrimeroDocente";
            this.btnPrimeroDocente.Size = new System.Drawing.Size(47, 47);
            this.btnPrimeroDocente.TabIndex = 0;
            this.btnPrimeroDocente.Text = "|<";
            this.btnPrimeroDocente.UseVisualStyleBackColor = true;
            this.btnPrimeroDocente.Click += new System.EventHandler(this.btnPrimeroDocente_Click);
            // 
            // grbDatosDocentes
            // 
            this.grbDatosDocentes.Controls.Add(this.lblNivelAcademinco);
            this.grbDatosDocentes.Controls.Add(this.txtNAcademico);
            this.grbDatosDocentes.Controls.Add(this.lblMateria2);
            this.grbDatosDocentes.Controls.Add(this.txtMateria2);
            this.grbDatosDocentes.Controls.Add(this.lblMateria1);
            this.grbDatosDocentes.Controls.Add(this.txtMateria1);
            this.grbDatosDocentes.Controls.Add(this.lblNombreAlumno);
            this.grbDatosDocentes.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocentes.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosDocentes.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocentes.Enabled = false;
            this.grbDatosDocentes.Location = new System.Drawing.Point(1, 20);
            this.grbDatosDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosDocentes.Name = "grbDatosDocentes";
            this.grbDatosDocentes.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosDocentes.Size = new System.Drawing.Size(520, 318);
            this.grbDatosDocentes.TabIndex = 17;
            this.grbDatosDocentes.TabStop = false;
            this.grbDatosDocentes.Text = "Datos Alumnos";
            this.grbDatosDocentes.Enter += new System.EventHandler(this.grbDatosDocentes_Enter);
            // 
            // lblNivelAcademinco
            // 
            this.lblNivelAcademinco.AutoSize = true;
            this.lblNivelAcademinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcademinco.Location = new System.Drawing.Point(8, 246);
            this.lblNivelAcademinco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivelAcademinco.Name = "lblNivelAcademinco";
            this.lblNivelAcademinco.Size = new System.Drawing.Size(160, 29);
            this.lblNivelAcademinco.TabIndex = 9;
            this.lblNivelAcademinco.Text = "N acadeinco: ";
            // 
            // txtNAcademico
            // 
            this.txtNAcademico.Location = new System.Drawing.Point(175, 253);
            this.txtNAcademico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNAcademico.Name = "txtNAcademico";
            this.txtNAcademico.Size = new System.Drawing.Size(132, 22);
            this.txtNAcademico.TabIndex = 8;
            // 
            // lblMateria2
            // 
            this.lblMateria2.AutoSize = true;
            this.lblMateria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria2.Location = new System.Drawing.Point(41, 191);
            this.lblMateria2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria2.Name = "lblMateria2";
            this.lblMateria2.Size = new System.Drawing.Size(118, 29);
            this.lblMateria2.TabIndex = 7;
            this.lblMateria2.Text = "Materia2: ";
            // 
            // txtMateria2
            // 
            this.txtMateria2.Location = new System.Drawing.Point(175, 196);
            this.txtMateria2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateria2.Name = "txtMateria2";
            this.txtMateria2.Size = new System.Drawing.Size(132, 22);
            this.txtMateria2.TabIndex = 6;
            // 
            // lblMateria1
            // 
            this.lblMateria1.AutoSize = true;
            this.lblMateria1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria1.Location = new System.Drawing.Point(41, 143);
            this.lblMateria1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria1.Name = "lblMateria1";
            this.lblMateria1.Size = new System.Drawing.Size(124, 29);
            this.lblMateria1.TabIndex = 5;
            this.lblMateria1.Text = "Materia 1: ";
            // 
            // txtMateria1
            // 
            this.txtMateria1.Location = new System.Drawing.Point(175, 148);
            this.txtMateria1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateria1.Name = "txtMateria1";
            this.txtMateria1.Size = new System.Drawing.Size(333, 22);
            this.txtMateria1.TabIndex = 4;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(41, 94);
            this.lblNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(107, 29);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(175, 98);
            this.txtNombreDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(333, 22);
            this.txtNombreDocente.TabIndex = 2;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(41, 46);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(98, 29);
            this.lblCodigoAlumno.TabIndex = 1;
            this.lblCodigoAlumno.Text = "Codigo:";
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(175, 50);
            this.txtCodigoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoDocente.TabIndex = 0;
            // 
            // IdDocente
            // 
            this.IdDocente.DataPropertyName = "IdDocente";
            this.IdDocente.HeaderText = "ID";
            this.IdDocente.MinimumWidth = 6;
            this.IdDocente.Name = "IdDocente";
            this.IdDocente.ReadOnly = true;
            this.IdDocente.Visible = false;
            this.IdDocente.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
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
            // materia1
            // 
            this.materia1.DataPropertyName = "materia1";
            this.materia1.HeaderText = "MATERIA1";
            this.materia1.MinimumWidth = 6;
            this.materia1.Name = "materia1";
            this.materia1.ReadOnly = true;
            this.materia1.Width = 125;
            // 
            // Materia2
            // 
            this.Materia2.DataPropertyName = "materia2";
            this.Materia2.HeaderText = "MATERIA2";
            this.Materia2.MinimumWidth = 6;
            this.Materia2.Name = "Materia2";
            this.Materia2.ReadOnly = true;
            this.Materia2.Width = 125;
            // 
            // docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 489);
            this.Controls.Add(this.grbEdicionDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Controls.Add(this.grbDatosDocentes);
            this.Controls.Add(this.lblBuscarDocente);
            this.Controls.Add(this.txtBuscarDocente);
            this.Controls.Add(this.grdDatosDocentes);
            this.Name = "docentes";
            this.Text = "docentes";
            this.Load += new System.EventHandler(this.docentes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).EndInit();
            this.grbEdicionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.grbDatosDocentes.ResumeLayout(false);
            this.grbDatosDocentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarDocente;
        private System.Windows.Forms.TextBox txtBuscarDocente;
        private System.Windows.Forms.DataGridView grdDatosDocentes;
        private System.Windows.Forms.GroupBox grbEdicionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnNuevoDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.Label lblRegistrosDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimeroDocente;
        private System.Windows.Forms.GroupBox grbDatosDocentes;
        private System.Windows.Forms.Label lblNivelAcademinco;
        private System.Windows.Forms.TextBox txtNAcademico;
        private System.Windows.Forms.Label lblMateria2;
        private System.Windows.Forms.TextBox txtMateria2;
        private System.Windows.Forms.Label lblMateria1;
        private System.Windows.Forms.TextBox txtMateria1;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia2;
    }
}