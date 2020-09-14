namespace WindowsFormsApp
{
    partial class FMAgregar
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
            this.lbCodigoArt = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbdescripcion = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbimagen = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.tbimagen = new System.Windows.Forms.TextBox();
            this.tbprecio = new System.Windows.Forms.TextBox();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.btaceptar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodigoArt
            // 
            this.lbCodigoArt.AutoSize = true;
            this.lbCodigoArt.Location = new System.Drawing.Point(99, 56);
            this.lbCodigoArt.Name = "lbCodigoArt";
            this.lbCodigoArt.Size = new System.Drawing.Size(63, 20);
            this.lbCodigoArt.TabIndex = 0;
            this.lbCodigoArt.Text = "Codigo:";
            this.lbCodigoArt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(93, 93);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(69, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbdescripcion
            // 
            this.lbdescripcion.AutoSize = true;
            this.lbdescripcion.Location = new System.Drawing.Point(66, 135);
            this.lbdescripcion.Name = "lbdescripcion";
            this.lbdescripcion.Size = new System.Drawing.Size(96, 20);
            this.lbdescripcion.TabIndex = 2;
            this.lbdescripcion.Text = "Descripcion:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(105, 182);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(57, 20);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca:";
            this.lbMarca.Click += new System.EventHandler(this.lbMarca_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(80, 229);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(82, 20);
            this.lbCategoria.TabIndex = 4;
            this.lbCategoria.Text = "Categoria:";
            // 
            // lbimagen
            // 
            this.lbimagen.AutoSize = true;
            this.lbimagen.Location = new System.Drawing.Point(95, 280);
            this.lbimagen.Name = "lbimagen";
            this.lbimagen.Size = new System.Drawing.Size(67, 20);
            this.lbimagen.TabIndex = 5;
            this.lbimagen.Text = "Imagen:";
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Location = new System.Drawing.Point(105, 341);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(57, 20);
            this.lbprecio.TabIndex = 6;
            this.lbprecio.Text = "Precio:";
            this.lbprecio.Click += new System.EventHandler(this.lbprecio_Click);
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(246, 50);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(179, 26);
            this.tbcodigo.TabIndex = 7;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(246, 93);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(179, 26);
            this.tbnombre.TabIndex = 8;
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(246, 135);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(179, 26);
            this.tbdescripcion.TabIndex = 9;
            // 
            // tbimagen
            // 
            this.tbimagen.Location = new System.Drawing.Point(246, 280);
            this.tbimagen.Name = "tbimagen";
            this.tbimagen.Size = new System.Drawing.Size(179, 26);
            this.tbimagen.TabIndex = 10;
            this.tbimagen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(246, 341);
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(179, 26);
            this.tbprecio.TabIndex = 11;
            // 
            // cbmarca
            // 
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(246, 182);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(179, 28);
            this.cbmarca.TabIndex = 12;
            // 
            // cbcategoria
            // 
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(246, 229);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(179, 28);
            this.cbcategoria.TabIndex = 13;
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(139, 414);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(86, 38);
            this.btaceptar.TabIndex = 14;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = true;
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(296, 414);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(86, 38);
            this.btcancelar.TabIndex = 15;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // FMAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 489);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.tbprecio);
            this.Controls.Add(this.tbimagen);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.lbprecio);
            this.Controls.Add(this.lbimagen);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbdescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigoArt);
            this.Name = "FMAgregar";
            this.Text = "FMAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoArt;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbdescripcion;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbimagen;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.TextBox tbimagen;
        private System.Windows.Forms.TextBox tbprecio;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Button btaceptar;
        private System.Windows.Forms.Button btcancelar;
    }
}