﻿
namespace academica
{
    partial class materias
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
            this.lblBuscarMaterias = new System.Windows.Forms.Label();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.grdDatosMaterias = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionMaterias = new System.Windows.Forms.GroupBox();
            this.btnEliminarMaterias = new System.Windows.Forms.Button();
            this.btnModificarMaterias = new System.Windows.Forms.Button();
            this.btnNuevoMaterias = new System.Windows.Forms.Button();
            this.grbNavegacionMaterias = new System.Windows.Forms.GroupBox();
            this.lblRegistrosMaterias = new System.Windows.Forms.Label();
            this.btnUltimoMaterias = new System.Windows.Forms.Button();
            this.btnSiguienteMaterias = new System.Windows.Forms.Button();
            this.btnAnteriorMaterias = new System.Windows.Forms.Button();
            this.btnPrimeroMaterias = new System.Windows.Forms.Button();
            this.grbDatosMaterias = new System.Windows.Forms.GroupBox();
            this.lblUvMaterias = new System.Windows.Forms.Label();
            this.txtUvMaterias = new System.Windows.Forms.TextBox();
            this.lblNombreMaterias = new System.Windows.Forms.Label();
            this.txtNombreMaterias = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterias = new System.Windows.Forms.Label();
            this.txtCodigoMaterias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).BeginInit();
            this.grbEdicionMaterias.SuspendLayout();
            this.grbNavegacionMaterias.SuspendLayout();
            this.grbDatosMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarMaterias
            // 
            this.lblBuscarMaterias.AutoSize = true;
            this.lblBuscarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMaterias.Location = new System.Drawing.Point(555, 23);
            this.lblBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarMaterias.Name = "lblBuscarMaterias";
            this.lblBuscarMaterias.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarMaterias.TabIndex = 15;
            this.lblBuscarMaterias.Text = "BUSCAR:";
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(676, 30);
            this.txtBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(461, 22);
            this.txtBuscarMaterias.TabIndex = 16;
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // grdDatosMaterias
            // 
            this.grdDatosMaterias.AllowUserToAddRows = false;
            this.grdDatosMaterias.AllowUserToDeleteRows = false;
            this.grdDatosMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosMaterias.Location = new System.Drawing.Point(560, 62);
            this.grdDatosMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDatosMaterias.Name = "grdDatosMaterias";
            this.grdDatosMaterias.ReadOnly = true;
            this.grdDatosMaterias.RowHeadersWidth = 51;
            this.grdDatosMaterias.Size = new System.Drawing.Size(579, 310);
            this.grdDatosMaterias.TabIndex = 14;
            this.grdDatosMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosMaterias_CellClick);
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "ID";
            this.idMateria.MinimumWidth = 6;
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
            this.idMateria.Width = 125;
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
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.MinimumWidth = 6;
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            this.uv.Width = 125;
            // 
            // grbEdicionMaterias
            // 
            this.grbEdicionMaterias.Controls.Add(this.btnEliminarMaterias);
            this.grbEdicionMaterias.Controls.Add(this.btnModificarMaterias);
            this.grbEdicionMaterias.Controls.Add(this.btnNuevoMaterias);
            this.grbEdicionMaterias.Location = new System.Drawing.Point(308, 379);
            this.grbEdicionMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicionMaterias.Name = "grbEdicionMaterias";
            this.grbEdicionMaterias.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicionMaterias.Size = new System.Drawing.Size(392, 71);
            this.grbEdicionMaterias.TabIndex = 13;
            this.grbEdicionMaterias.TabStop = false;
            this.grbEdicionMaterias.Text = "Navegacion";
            // 
            // btnEliminarMaterias
            // 
            this.btnEliminarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMaterias.Location = new System.Drawing.Point(252, 23);
            this.btnEliminarMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarMaterias.Name = "btnEliminarMaterias";
            this.btnEliminarMaterias.Size = new System.Drawing.Size(129, 47);
            this.btnEliminarMaterias.TabIndex = 6;
            this.btnEliminarMaterias.Text = "Eliminar";
            this.btnEliminarMaterias.UseVisualStyleBackColor = true;
            this.btnEliminarMaterias.Click += new System.EventHandler(this.btnEliminarMaterias_Click);
            // 
            // btnModificarMaterias
            // 
            this.btnModificarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMaterias.Location = new System.Drawing.Point(116, 23);
            this.btnModificarMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarMaterias.Name = "btnModificarMaterias";
            this.btnModificarMaterias.Size = new System.Drawing.Size(139, 47);
            this.btnModificarMaterias.TabIndex = 5;
            this.btnModificarMaterias.Text = "Modificar";
            this.btnModificarMaterias.UseVisualStyleBackColor = true;
            this.btnModificarMaterias.Click += new System.EventHandler(this.btnModificarMaterias_Click);
            // 
            // btnNuevoMaterias
            // 
            this.btnNuevoMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMaterias.Location = new System.Drawing.Point(8, 23);
            this.btnNuevoMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoMaterias.Name = "btnNuevoMaterias";
            this.btnNuevoMaterias.Size = new System.Drawing.Size(111, 47);
            this.btnNuevoMaterias.TabIndex = 4;
            this.btnNuevoMaterias.Text = "Nuevo";
            this.btnNuevoMaterias.UseVisualStyleBackColor = true;
            this.btnNuevoMaterias.Click += new System.EventHandler(this.btnNuevoMaterias_Click);
            // 
            // grbNavegacionMaterias
            // 
            this.grbNavegacionMaterias.Controls.Add(this.lblRegistrosMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnUltimoMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnSiguienteMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnAnteriorMaterias);
            this.grbNavegacionMaterias.Controls.Add(this.btnPrimeroMaterias);
            this.grbNavegacionMaterias.Location = new System.Drawing.Point(16, 379);
            this.grbNavegacionMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacionMaterias.Name = "grbNavegacionMaterias";
            this.grbNavegacionMaterias.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacionMaterias.Size = new System.Drawing.Size(284, 71);
            this.grbNavegacionMaterias.TabIndex = 12;
            this.grbNavegacionMaterias.TabStop = false;
            this.grbNavegacionMaterias.Text = "Navegacion";
            // 
            // lblRegistrosMaterias
            // 
            this.lblRegistrosMaterias.AutoSize = true;
            this.lblRegistrosMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosMaterias.Location = new System.Drawing.Point(101, 30);
            this.lblRegistrosMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosMaterias.Name = "lblRegistrosMaterias";
            this.lblRegistrosMaterias.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosMaterias.TabIndex = 10;
            this.lblRegistrosMaterias.Text = "x de n";
            // 
            // btnUltimoMaterias
            // 
            this.btnUltimoMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMaterias.Location = new System.Drawing.Point(229, 17);
            this.btnUltimoMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimoMaterias.Name = "btnUltimoMaterias";
            this.btnUltimoMaterias.Size = new System.Drawing.Size(47, 47);
            this.btnUltimoMaterias.TabIndex = 3;
            this.btnUltimoMaterias.Text = ">|";
            this.btnUltimoMaterias.UseVisualStyleBackColor = true;
            this.btnUltimoMaterias.Click += new System.EventHandler(this.btnUltimoMaterias_Click);
            // 
            // btnSiguienteMaterias
            // 
            this.btnSiguienteMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMaterias.Location = new System.Drawing.Point(185, 17);
            this.btnSiguienteMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguienteMaterias.Name = "btnSiguienteMaterias";
            this.btnSiguienteMaterias.Size = new System.Drawing.Size(47, 47);
            this.btnSiguienteMaterias.TabIndex = 2;
            this.btnSiguienteMaterias.Text = ">";
            this.btnSiguienteMaterias.UseVisualStyleBackColor = true;
            this.btnSiguienteMaterias.Click += new System.EventHandler(this.btnSiguienteMaterias_Click);
            // 
            // btnAnteriorMaterias
            // 
            this.btnAnteriorMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMaterias.Location = new System.Drawing.Point(53, 22);
            this.btnAnteriorMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnteriorMaterias.Name = "btnAnteriorMaterias";
            this.btnAnteriorMaterias.Size = new System.Drawing.Size(47, 47);
            this.btnAnteriorMaterias.TabIndex = 1;
            this.btnAnteriorMaterias.Text = "<";
            this.btnAnteriorMaterias.UseVisualStyleBackColor = true;
            this.btnAnteriorMaterias.Click += new System.EventHandler(this.btnAnteriorMaterias_Click);
            // 
            // btnPrimeroMaterias
            // 
            this.btnPrimeroMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMaterias.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeroMaterias.Name = "btnPrimeroMaterias";
            this.btnPrimeroMaterias.Size = new System.Drawing.Size(47, 47);
            this.btnPrimeroMaterias.TabIndex = 0;
            this.btnPrimeroMaterias.Text = "|<";
            this.btnPrimeroMaterias.UseVisualStyleBackColor = true;
            this.btnPrimeroMaterias.Click += new System.EventHandler(this.btnPrimeroMaterias_Click);
            // 
            // grbDatosMaterias
            // 
            this.grbDatosMaterias.Controls.Add(this.lblUvMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtUvMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblNombreMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtNombreMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblCodigoMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtCodigoMaterias);
            this.grbDatosMaterias.Enabled = false;
            this.grbDatosMaterias.Location = new System.Drawing.Point(15, 11);
            this.grbDatosMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosMaterias.Name = "grbDatosMaterias";
            this.grbDatosMaterias.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosMaterias.Size = new System.Drawing.Size(520, 361);
            this.grbDatosMaterias.TabIndex = 11;
            this.grbDatosMaterias.TabStop = false;
            this.grbDatosMaterias.Text = "Datos Materias";
            // 
            // lblUvMaterias
            // 
            this.lblUvMaterias.AutoSize = true;
            this.lblUvMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUvMaterias.Location = new System.Drawing.Point(41, 143);
            this.lblUvMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUvMaterias.Name = "lblUvMaterias";
            this.lblUvMaterias.Size = new System.Drawing.Size(51, 29);
            this.lblUvMaterias.TabIndex = 5;
            this.lblUvMaterias.Text = "UV:";
            // 
            // txtUvMaterias
            // 
            this.txtUvMaterias.Location = new System.Drawing.Point(175, 148);
            this.txtUvMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUvMaterias.Name = "txtUvMaterias";
            this.txtUvMaterias.Size = new System.Drawing.Size(83, 22);
            this.txtUvMaterias.TabIndex = 4;
            // 
            // lblNombreMaterias
            // 
            this.lblNombreMaterias.AutoSize = true;
            this.lblNombreMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaterias.Location = new System.Drawing.Point(41, 94);
            this.lblNombreMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMaterias.Name = "lblNombreMaterias";
            this.lblNombreMaterias.Size = new System.Drawing.Size(107, 29);
            this.lblNombreMaterias.TabIndex = 3;
            this.lblNombreMaterias.Text = "Nombre:";
            // 
            // txtNombreMaterias
            // 
            this.txtNombreMaterias.Location = new System.Drawing.Point(175, 98);
            this.txtNombreMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreMaterias.Name = "txtNombreMaterias";
            this.txtNombreMaterias.Size = new System.Drawing.Size(333, 22);
            this.txtNombreMaterias.TabIndex = 2;
            // 
            // lblCodigoMaterias
            // 
            this.lblCodigoMaterias.AutoSize = true;
            this.lblCodigoMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaterias.Location = new System.Drawing.Point(41, 46);
            this.lblCodigoMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMaterias.Name = "lblCodigoMaterias";
            this.lblCodigoMaterias.Size = new System.Drawing.Size(98, 29);
            this.lblCodigoMaterias.TabIndex = 1;
            this.lblCodigoMaterias.Text = "Codigo:";
            // 
            // txtCodigoMaterias
            // 
            this.txtCodigoMaterias.Location = new System.Drawing.Point(175, 50);
            this.txtCodigoMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoMaterias.Name = "txtCodigoMaterias";
            this.txtCodigoMaterias.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoMaterias.TabIndex = 0;
            // 
            // materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 468);
            this.Controls.Add(this.lblBuscarMaterias);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.grdDatosMaterias);
            this.Controls.Add(this.grbEdicionMaterias);
            this.Controls.Add(this.grbNavegacionMaterias);
            this.Controls.Add(this.grbDatosMaterias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "materias";
            this.Text = "materias";
            this.Load += new System.EventHandler(this.materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).EndInit();
            this.grbEdicionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.ResumeLayout(false);
            this.grbNavegacionMaterias.PerformLayout();
            this.grbDatosMaterias.ResumeLayout(false);
            this.grbDatosMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.DataGridView grdDatosMaterias;
        private System.Windows.Forms.GroupBox grbEdicionMaterias;
        private System.Windows.Forms.Button btnEliminarMaterias;
        private System.Windows.Forms.Button btnModificarMaterias;
        private System.Windows.Forms.Button btnNuevoMaterias;
        private System.Windows.Forms.GroupBox grbNavegacionMaterias;
        private System.Windows.Forms.Label lblRegistrosMaterias;
        private System.Windows.Forms.Button btnUltimoMaterias;
        private System.Windows.Forms.Button btnSiguienteMaterias;
        private System.Windows.Forms.Button btnAnteriorMaterias;
        private System.Windows.Forms.Button btnPrimeroMaterias;
        private System.Windows.Forms.GroupBox grbDatosMaterias;
        private System.Windows.Forms.Label lblUvMaterias;
        private System.Windows.Forms.TextBox txtUvMaterias;
        private System.Windows.Forms.Label lblNombreMaterias;
        private System.Windows.Forms.TextBox txtNombreMaterias;
        private System.Windows.Forms.Label lblCodigoMaterias;
        private System.Windows.Forms.TextBox txtCodigoMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}