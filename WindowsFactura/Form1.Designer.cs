namespace WindowsFactura
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
            this.btnInicializarProductos = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicializarProductos
            // 
            this.btnInicializarProductos.Location = new System.Drawing.Point(65, 87);
            this.btnInicializarProductos.Name = "btnInicializarProductos";
            this.btnInicializarProductos.Size = new System.Drawing.Size(146, 27);
            this.btnInicializarProductos.TabIndex = 0;
            this.btnInicializarProductos.Text = "Inicializar Productos";
            this.btnInicializarProductos.UseVisualStyleBackColor = true;
            this.btnInicializarProductos.Click += new System.EventHandler(this.btnInicializarProductos_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(65, 215);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(240, 150);
            this.gridProductos.TabIndex = 1;
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(65, 177);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(156, 32);
            this.btnMostrarProductos.TabIndex = 2;
            this.btnMostrarProductos.Text = "Mostrar Productos";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarProductos);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnInicializarProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicializarProductos;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button btnMostrarProductos;
    }
}

