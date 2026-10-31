namespace CpParcial2Armr
{
    partial class FrmHorarioPrograma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblCanal = new System.Windows.Forms.Label();
            this.cboCanal = new System.Windows.Forms.ComboBox();
            this.lblTituloPrograma = new System.Windows.Forms.Label();
            this.txtTituloPrograma = new System.Windows.Forms.TextBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.lblConductorPrincipal = new System.Windows.Forms.Label();
            this.txtConductorPrincipal = new System.Windows.Forms.TextBox();
            this.dgbLista = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.dgbLista.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(71, 30);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(778, 201);
            this.dgvLista.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(438, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = " PROGRAMAS";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(117, 84);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(186, 18);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "BUSCAR  PROGRAMA:";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(309, 84);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(334, 22);
            this.txtParametro.TabIndex = 3;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanal.Location = new System.Drawing.Point(24, 45);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(66, 18);
            this.lblCanal.TabIndex = 5;
            this.lblCanal.Text = "CANAL:";
            // 
            // cboCanal
            // 
            this.cboCanal.FormattingEnabled = true;
            this.cboCanal.Location = new System.Drawing.Point(139, 39);
            this.cboCanal.Name = "cboCanal";
            this.cboCanal.Size = new System.Drawing.Size(137, 24);
            this.cboCanal.TabIndex = 6;
            // 
            // lblTituloPrograma
            // 
            this.lblTituloPrograma.AutoSize = true;
            this.lblTituloPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrograma.Location = new System.Drawing.Point(24, 94);
            this.lblTituloPrograma.Name = "lblTituloPrograma";
            this.lblTituloPrograma.Size = new System.Drawing.Size(71, 18);
            this.lblTituloPrograma.TabIndex = 7;
            this.lblTituloPrograma.Text = "TITULO:";
            // 
            // txtTituloPrograma
            // 
            this.txtTituloPrograma.Location = new System.Drawing.Point(139, 93);
            this.txtTituloPrograma.Name = "txtTituloPrograma";
            this.txtTituloPrograma.Size = new System.Drawing.Size(263, 22);
            this.txtTituloPrograma.TabIndex = 8;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(24, 145);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(114, 18);
            this.lblHoraInicio.TabIndex = 9;
            this.lblHoraInicio.Text = "HORA INICIO:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(139, 145);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(100, 22);
            this.dtpHoraInicio.TabIndex = 10;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(24, 181);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(96, 18);
            this.lblHoraFin.TabIndex = 11;
            this.lblHoraFin.Text = "HORA  FIN:";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(139, 181);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(100, 22);
            this.dtpHoraFin.TabIndex = 12;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(420, 45);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(140, 18);
            this.lblDiaSemana.TabIndex = 13;
            this.lblDiaSemana.Text = "DIA DE SEMANA:";
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Location = new System.Drawing.Point(637, 44);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(137, 24);
            this.cboDiaSemana.TabIndex = 14;
            // 
            // lblConductorPrincipal
            // 
            this.lblConductorPrincipal.AutoSize = true;
            this.lblConductorPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductorPrincipal.Location = new System.Drawing.Point(420, 94);
            this.lblConductorPrincipal.Name = "lblConductorPrincipal";
            this.lblConductorPrincipal.Size = new System.Drawing.Size(211, 18);
            this.lblConductorPrincipal.TabIndex = 15;
            this.lblConductorPrincipal.Text = "CONDUCTOR PRINCIPAL:";
            // 
            // txtConductorPrincipal
            // 
            this.txtConductorPrincipal.Location = new System.Drawing.Point(637, 93);
            this.txtConductorPrincipal.Name = "txtConductorPrincipal";
            this.txtConductorPrincipal.Size = new System.Drawing.Size(263, 22);
            this.txtConductorPrincipal.TabIndex = 16;
            // 
            // dgbLista
            // 
            this.dgbLista.Controls.Add(this.dgvLista);
            this.dgbLista.Location = new System.Drawing.Point(64, 133);
            this.dgbLista.Name = "dgbLista";
            this.dgbLista.Size = new System.Drawing.Size(919, 250);
            this.dgbLista.TabIndex = 23;
            this.dgbLista.TabStop = false;
            this.dgbLista.Text = "LISTA PROGRAMAS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::CpParcial2Armr.Properties.Resources.close;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(688, 25);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 45);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CpParcial2Armr.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(509, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 45);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CpParcial2Armr.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(637, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 45);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::CpParcial2Armr.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(327, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 45);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CpParcial2Armr.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(479, 172);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 45);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::CpParcial2Armr.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(152, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 45);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CpParcial2Armr.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(662, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 45);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Location = new System.Drawing.Point(64, 389);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(919, 97);
            this.pnlAcciones.TabIndex = 24;
            // 
            // gboDatos
            // 
            this.gboDatos.Controls.Add(this.btnCancelar);
            this.gboDatos.Controls.Add(this.cboCanal);
            this.gboDatos.Controls.Add(this.lblCanal);
            this.gboDatos.Controls.Add(this.lblTituloPrograma);
            this.gboDatos.Controls.Add(this.btnGuardar);
            this.gboDatos.Controls.Add(this.txtConductorPrincipal);
            this.gboDatos.Controls.Add(this.txtTituloPrograma);
            this.gboDatos.Controls.Add(this.lblConductorPrincipal);
            this.gboDatos.Controls.Add(this.lblHoraInicio);
            this.gboDatos.Controls.Add(this.cboDiaSemana);
            this.gboDatos.Controls.Add(this.dtpHoraInicio);
            this.gboDatos.Controls.Add(this.lblDiaSemana);
            this.gboDatos.Controls.Add(this.lblHoraFin);
            this.gboDatos.Controls.Add(this.dtpHoraFin);
            this.gboDatos.Location = new System.Drawing.Point(64, 516);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Size = new System.Drawing.Size(919, 248);
            this.gboDatos.TabIndex = 25;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "DATOS";
            // 
            // FrmHorarioPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 789);
            this.Controls.Add(this.gboDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.dgbLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHorarioPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: HORARIO-PROGRAMA :::";
            this.Load += new System.EventHandler(this.FrmHorarioPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.dgbLista.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.ComboBox cboCanal;
        private System.Windows.Forms.Label lblTituloPrograma;
        private System.Windows.Forms.TextBox txtTituloPrograma;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.Label lblConductorPrincipal;
        private System.Windows.Forms.TextBox txtConductorPrincipal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox dgbLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.GroupBox gboDatos;
    }
}

