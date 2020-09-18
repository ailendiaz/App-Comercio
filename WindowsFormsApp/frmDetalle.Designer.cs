namespace WindowsFormsApp
{
    partial class frmDetalle
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(27, 44);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(67, 20);
            this.lbcodigo.TabIndex = 0;
            this.lbcodigo.Text = "Codigo: ";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(27, 119);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(69, 20);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(183, 38);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 26);
            this.txtcodigo.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(183, 119);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 3;
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(89, 316);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(104, 56);
            this.btaceptar.TabIndex = 4;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = true;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbcodigo);
            this.Name = "frmDetalle";
            this.Text = "frmDetalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btaceptar;
    }
}