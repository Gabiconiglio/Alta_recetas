namespace RecetasSLN
{
    partial class AltaRecetas
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
            this.lblNroReceta = new System.Windows.Forms.Label();
            this.lblTipoReceta = new System.Windows.Forms.Label();
            this.lblCheff = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.TxtCheff = new System.Windows.Forms.TextBox();
            this.CmbIngredientes = new System.Windows.Forms.ComboBox();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.CmbTipoReceta = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DgwIngredientes = new System.Windows.Forms.DataGridView();
            this.Id_Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotalIng = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroReceta
            // 
            this.lblNroReceta.AutoSize = true;
            this.lblNroReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroReceta.Location = new System.Drawing.Point(127, 6);
            this.lblNroReceta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroReceta.Name = "lblNroReceta";
            this.lblNroReceta.Size = new System.Drawing.Size(70, 13);
            this.lblNroReceta.TabIndex = 0;
            this.lblNroReceta.Text = "Receta N°:";
            this.lblNroReceta.Click += new System.EventHandler(this.lblNroReceta_Click);
            // 
            // lblTipoReceta
            // 
            this.lblTipoReceta.AutoSize = true;
            this.lblTipoReceta.Location = new System.Drawing.Point(48, 73);
            this.lblTipoReceta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoReceta.Name = "lblTipoReceta";
            this.lblTipoReceta.Size = new System.Drawing.Size(81, 13);
            this.lblTipoReceta.TabIndex = 5;
            this.lblTipoReceta.Text = "Tipo de Receta";
            // 
            // lblCheff
            // 
            this.lblCheff.AutoSize = true;
            this.lblCheff.Location = new System.Drawing.Point(70, 51);
            this.lblCheff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheff.Name = "lblCheff";
            this.lblCheff.Size = new System.Drawing.Size(35, 13);
            this.lblCheff.TabIndex = 3;
            this.lblCheff.Text = "Cheff:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(61, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // TxtCheff
            // 
            this.TxtCheff.Location = new System.Drawing.Point(130, 47);
            this.TxtCheff.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCheff.Name = "TxtCheff";
            this.TxtCheff.Size = new System.Drawing.Size(284, 20);
            this.TxtCheff.TabIndex = 4;
            // 
            // CmbIngredientes
            // 
            this.CmbIngredientes.FormattingEnabled = true;
            this.CmbIngredientes.Location = new System.Drawing.Point(130, 97);
            this.CmbIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.CmbIngredientes.Name = "CmbIngredientes";
            this.CmbIngredientes.Size = new System.Drawing.Size(189, 21);
            this.CmbIngredientes.TabIndex = 7;
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(333, 94);
            this.NudCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(80, 20);
            this.NudCantidad.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(305, 265);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 20);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(188, 265);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(73, 20);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(432, 91);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CmbTipoReceta
            // 
            this.CmbTipoReceta.FormattingEnabled = true;
            this.CmbTipoReceta.Location = new System.Drawing.Point(130, 72);
            this.CmbTipoReceta.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTipoReceta.Name = "CmbTipoReceta";
            this.CmbTipoReceta.Size = new System.Drawing.Size(189, 21);
            this.CmbTipoReceta.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(130, 27);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(284, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // DgwIngredientes
            // 
            this.DgwIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Ingrediente,
            this.Ingredientes,
            this.Unidad,
            this.Cantidad,
            this.Acciones});
            this.DgwIngredientes.Location = new System.Drawing.Point(39, 122);
            this.DgwIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.DgwIngredientes.Name = "DgwIngredientes";
            this.DgwIngredientes.RowHeadersWidth = 62;
            this.DgwIngredientes.RowTemplate.Height = 28;
            this.DgwIngredientes.Size = new System.Drawing.Size(569, 104);
            this.DgwIngredientes.TabIndex = 10;
            this.DgwIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwIngredientes_CellContentClick);
            // 
            // Id_Ingrediente
            // 
            this.Id_Ingrediente.HeaderText = "Id_Ingrediente";
            this.Id_Ingrediente.Name = "Id_Ingrediente";
            this.Id_Ingrediente.Visible = false;
            // 
            // Ingredientes
            // 
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.MinimumWidth = 8;
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Width = 150;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.MinimumWidth = 8;
            this.Acciones.Name = "Acciones";
            this.Acciones.Text = "Quitar";
            this.Acciones.UseColumnTextForButtonValue = true;
            this.Acciones.Width = 150;
            // 
            // lblTotalIng
            // 
            this.lblTotalIng.AutoSize = true;
            this.lblTotalIng.Location = new System.Drawing.Point(415, 241);
            this.lblTotalIng.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalIng.Name = "lblTotalIng";
            this.lblTotalIng.Size = new System.Drawing.Size(113, 13);
            this.lblTotalIng.TabIndex = 11;
            this.lblTotalIng.Text = "Total de Ingredientes: ";
            // 
            // AltaRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 365);
            this.Controls.Add(this.lblTotalIng);
            this.Controls.Add(this.DgwIngredientes);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CmbTipoReceta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.CmbIngredientes);
            this.Controls.Add(this.TxtCheff);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCheff);
            this.Controls.Add(this.lblTipoReceta);
            this.Controls.Add(this.lblNroReceta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaRecetas";
            this.Text = "AltaRecetas";
            this.Load += new System.EventHandler(this.AltaRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroReceta;
        private System.Windows.Forms.Label lblTipoReceta;
        private System.Windows.Forms.Label lblCheff;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox TxtCheff;
        private System.Windows.Forms.ComboBox CmbIngredientes;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox CmbTipoReceta;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DgwIngredientes;
        private System.Windows.Forms.Label lblTotalIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}