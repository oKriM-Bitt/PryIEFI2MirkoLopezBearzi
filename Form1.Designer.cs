namespace PryIEFI2MirkoLopezBearzi
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.Hora1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarArchivoCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorDniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.LblHora.Font = new System.Drawing.Font("Microsoft YaHei", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(185)))), ((int)(((byte)(192)))));
            this.LblHora.Location = new System.Drawing.Point(722, 557);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(0, 86);
            this.LblHora.TabIndex = 13;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.LblFecha.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(185)))), ((int)(((byte)(192)))));
            this.LblFecha.Location = new System.Drawing.Point(722, 652);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(0, 19);
            this.LblFecha.TabIndex = 14;
            // 
            // Hora1
            // 
            this.Hora1.Tick += new System.EventHandler(this.Hora1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.gestionProveedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionPersonalToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // informacionPersonalToolStripMenuItem
            // 
            this.informacionPersonalToolStripMenuItem.Name = "informacionPersonalToolStripMenuItem";
            this.informacionPersonalToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.informacionPersonalToolStripMenuItem.Text = "Informacion Personal y Informacion del Sistema";
            this.informacionPersonalToolStripMenuItem.Click += new System.EventHandler(this.informacionPersonalToolStripMenuItem_Click);
            // 
            // gestionProveedoresToolStripMenuItem
            // 
            this.gestionProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarProveedoresToolStripMenuItem,
            this.generarArchivoCSVToolStripMenuItem,
            this.buscarPorDniToolStripMenuItem});
            this.gestionProveedoresToolStripMenuItem.Name = "gestionProveedoresToolStripMenuItem";
            this.gestionProveedoresToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gestionProveedoresToolStripMenuItem.Text = "Gestion Proveedores";
            // 
            // cargarProveedoresToolStripMenuItem
            // 
            this.cargarProveedoresToolStripMenuItem.Name = "cargarProveedoresToolStripMenuItem";
            this.cargarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.cargarProveedoresToolStripMenuItem.Text = "Cargar Proveedores";
            this.cargarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.cargarProveedoresToolStripMenuItem_Click);
            // 
            // generarArchivoCSVToolStripMenuItem
            // 
            this.generarArchivoCSVToolStripMenuItem.Name = "generarArchivoCSVToolStripMenuItem";
            this.generarArchivoCSVToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.generarArchivoCSVToolStripMenuItem.Text = "Listar Y Generar Archivo CSV";
            this.generarArchivoCSVToolStripMenuItem.Click += new System.EventHandler(this.generarArchivoCSVToolStripMenuItem_Click);
            // 
            // buscarPorDniToolStripMenuItem
            // 
            this.buscarPorDniToolStripMenuItem.Name = "buscarPorDniToolStripMenuItem";
            this.buscarPorDniToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.buscarPorDniToolStripMenuItem.Text = "Busqueda";
            this.buscarPorDniToolStripMenuItem.Click += new System.EventHandler(this.buscarPorDniToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PryIEFI2MirkoLopezBearzi.Properties.Resources.Imagen_de_WhatsApp_2024_11_13_a_las_16_52_08_bef06286;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1055, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 682);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer Hora1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarArchivoCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorDniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionPersonalToolStripMenuItem;
    }
}

