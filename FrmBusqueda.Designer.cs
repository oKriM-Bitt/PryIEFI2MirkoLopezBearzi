namespace PryIEFI2MirkoLopezBearzi
{
    partial class FrmBusqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnBuscarYMostrar = new System.Windows.Forms.Button();
            this.GrlM = new System.Windows.Forms.DataGridView();
            this.LblDni = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrlM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(67)))), ((int)(((byte)(99)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(243, 38);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 19;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(63, 38);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(115, 20);
            this.TxtDni.TabIndex = 18;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(67)))), ((int)(((byte)(99)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Location = new System.Drawing.Point(12, 566);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(130, 63);
            this.BtnVolver.TabIndex = 17;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnBuscarYMostrar
            // 
            this.BtnBuscarYMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.BtnBuscarYMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarYMostrar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarYMostrar.Location = new System.Drawing.Point(384, 24);
            this.BtnBuscarYMostrar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnBuscarYMostrar.Name = "BtnBuscarYMostrar";
            this.BtnBuscarYMostrar.Size = new System.Drawing.Size(180, 57);
            this.BtnBuscarYMostrar.TabIndex = 16;
            this.BtnBuscarYMostrar.Text = "Buscar y Mostrar";
            this.BtnBuscarYMostrar.UseVisualStyleBackColor = false;
            this.BtnBuscarYMostrar.Click += new System.EventHandler(this.BtnBuscarYMostrar_Click);
            // 
            // GrlM
            // 
            this.GrlM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrlM.Location = new System.Drawing.Point(57, 112);
            this.GrlM.Margin = new System.Windows.Forms.Padding(6);
            this.GrlM.Name = "GrlM";
            this.GrlM.Size = new System.Drawing.Size(349, 264);
            this.GrlM.TabIndex = 15;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(67)))), ((int)(((byte)(99)))));
            this.LblDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblDni.Location = new System.Drawing.Point(24, 41);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(26, 13);
            this.LblDni.TabIndex = 21;
            this.LblDni.Text = "DNI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PryIEFI2MirkoLopezBearzi.Properties.Resources.Imagen_de_WhatsApp_2024_11_13_a_las_16_52_08_bef06286;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 651);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 651);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnBuscarYMostrar);
            this.Controls.Add(this.GrlM);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmBusqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.FrmBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrlM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnBuscarYMostrar;
        private System.Windows.Forms.DataGridView GrlM;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}