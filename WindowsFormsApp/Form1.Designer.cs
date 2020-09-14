namespace WindowsFormsApp
{
    partial class Form1
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
            this.DGVLista = new System.Windows.Forms.DataGridView();
            this.pbarticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbarticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVLista
            // 
            this.DGVLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLista.Location = new System.Drawing.Point(11, 21);
            this.DGVLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVLista.Name = "DGVLista";
            this.DGVLista.RowHeadersWidth = 62;
            this.DGVLista.RowTemplate.Height = 28;
            this.DGVLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVLista.Size = new System.Drawing.Size(471, 240);
            this.DGVLista.TabIndex = 0;
            this.DGVLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLista_CellContentClick);
            this.DGVLista.SelectionChanged += new System.EventHandler(this.DGVLista_SelectionChanged);
            // 
            // pbarticulo
            // 
            this.pbarticulo.Location = new System.Drawing.Point(518, 21);
            this.pbarticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbarticulo.Name = "pbarticulo";
            this.pbarticulo.Size = new System.Drawing.Size(303, 240);
            this.pbarticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbarticulo.TabIndex = 1;
            this.pbarticulo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 344);
            this.Controls.Add(this.pbarticulo);
            this.Controls.Add(this.DGVLista);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbarticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLista;
        private System.Windows.Forms.PictureBox pbarticulo;
    }
}

