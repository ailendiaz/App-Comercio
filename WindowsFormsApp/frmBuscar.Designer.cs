namespace WindowsFormsApp
{
    partial class frmBuscar
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btmodificar = new System.Windows.Forms.Button();
            this.txtdetalle = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(51, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(32, 80);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(116, 24);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(190, 64);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 62;
            this.dgvBuscar.Size = new System.Drawing.Size(455, 168);
            this.dgvBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(17, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(155, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Ingrese el Codigo del Producto:";
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(51, 203);
            this.btmodificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 21);
            this.btmodificar.TabIndex = 4;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // txtdetalle
            // 
            this.txtdetalle.Location = new System.Drawing.Point(51, 159);
            this.txtdetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(75, 23);
            this.txtdetalle.TabIndex = 5;
            this.txtdetalle.Text = "Ver Detalle";
            this.txtdetalle.UseVisualStyleBackColor = true;
            this.txtdetalle.Click += new System.EventHandler(this.txtdetalle_click);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(51, 244);
            this.bteliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 6;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 290);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmBuscar";
            this.Text = "Buscar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button txtdetalle;
        private System.Windows.Forms.Button bteliminar;
    }
}