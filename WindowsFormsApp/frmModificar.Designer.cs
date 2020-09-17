namespace WindowsFormsApp
{
    partial class frmModificar
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
            this.lbcodigo = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbdescripcion = new System.Windows.Forms.Label();
            this.lbmarca = new System.Windows.Forms.Label();
            this.lbimagen = new System.Windows.Forms.Label();
            this.lbcategoria = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.btaceptar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.cbmarcar = new System.Windows.Forms.ComboBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(112, 58);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(63, 20);
            this.lbcodigo.TabIndex = 0;
            this.lbcodigo.Text = "Codigo:";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(106, 110);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(69, 20);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre:";
            // 
            // lbdescripcion
            // 
            this.lbdescripcion.AutoSize = true;
            this.lbdescripcion.Location = new System.Drawing.Point(79, 158);
            this.lbdescripcion.Name = "lbdescripcion";
            this.lbdescripcion.Size = new System.Drawing.Size(96, 20);
            this.lbdescripcion.TabIndex = 2;
            this.lbdescripcion.Text = "Descripcion:";
            // 
            // lbmarca
            // 
            this.lbmarca.AutoSize = true;
            this.lbmarca.Location = new System.Drawing.Point(118, 212);
            this.lbmarca.Name = "lbmarca";
            this.lbmarca.Size = new System.Drawing.Size(57, 20);
            this.lbmarca.TabIndex = 3;
            this.lbmarca.Text = "Marca:";
            // 
            // lbimagen
            // 
            this.lbimagen.AutoSize = true;
            this.lbimagen.Location = new System.Drawing.Point(71, 327);
            this.lbimagen.Name = "lbimagen";
            this.lbimagen.Size = new System.Drawing.Size(104, 20);
            this.lbimagen.TabIndex = 4;
            this.lbimagen.Text = "URL Imagen:";
            // 
            // lbcategoria
            // 
            this.lbcategoria.AutoSize = true;
            this.lbcategoria.Location = new System.Drawing.Point(93, 268);
            this.lbcategoria.Name = "lbcategoria";
            this.lbcategoria.Size = new System.Drawing.Size(82, 20);
            this.lbcategoria.TabIndex = 5;
            this.lbcategoria.Text = "Categoria:";
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Location = new System.Drawing.Point(118, 386);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(57, 20);
            this.lbprecio.TabIndex = 6;
            this.lbprecio.Text = "Precio:";
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(100, 445);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(97, 31);
            this.btaceptar.TabIndex = 7;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = true;
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(279, 445);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(87, 31);
            this.btcancelar.TabIndex = 8;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(241, 58);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(196, 26);
            this.txtcodigo.TabIndex = 9;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(241, 110);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(196, 26);
            this.txtnombre.TabIndex = 10;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(241, 158);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(196, 26);
            this.txtdescripcion.TabIndex = 11;
            // 
            // cbmarcar
            // 
            this.cbmarcar.FormattingEnabled = true;
            this.cbmarcar.Location = new System.Drawing.Point(241, 212);
            this.cbmarcar.Name = "cbmarcar";
            this.cbmarcar.Size = new System.Drawing.Size(196, 28);
            this.cbmarcar.TabIndex = 12;
            // 
            // cbcategoria
            // 
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(241, 265);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(196, 28);
            this.cbcategoria.TabIndex = 13;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(241, 327);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(196, 26);
            this.txtimagen.TabIndex = 14;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(241, 380);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(196, 26);
            this.txtprecio.TabIndex = 15;
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 499);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.cbmarcar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.lbprecio);
            this.Controls.Add(this.lbcategoria);
            this.Controls.Add(this.lbimagen);
            this.Controls.Add(this.lbmarca);
            this.Controls.Add(this.lbdescripcion);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbcodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmModificar";
            this.Text = "Modificar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbdescripcion;
        private System.Windows.Forms.Label lbmarca;
        private System.Windows.Forms.Label lbimagen;
        private System.Windows.Forms.Label lbcategoria;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Button btaceptar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox cbmarcar;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.TextBox txtprecio;
    }
}