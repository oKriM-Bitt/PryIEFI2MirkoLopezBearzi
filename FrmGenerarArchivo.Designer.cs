namespace PryIEFI2MirkoLopezBearzi
{
    partial class FrmGenerarArchivo
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
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.GrlM = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.CmbRubros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMostrarTodo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrlM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ForeColor = System.Drawing.Color.White;
            this.BtnReporte.Location = new System.Drawing.Point(126, 351);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(74, 59);
            this.BtnReporte.TabIndex = 35;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListar.ForeColor = System.Drawing.Color.White;
            this.BtnListar.Location = new System.Drawing.Point(28, 351);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(92, 59);
            this.BtnListar.TabIndex = 28;
            this.BtnListar.Text = "Listar segun Rubros";
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // GrlM
            // 
            this.GrlM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrlM.Location = new System.Drawing.Point(15, 15);
            this.GrlM.Margin = new System.Windows.Forms.Padding(6);
            this.GrlM.Name = "GrlM";
            this.GrlM.Size = new System.Drawing.Size(601, 264);
            this.GrlM.TabIndex = 27;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(67)))), ((int)(((byte)(99)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(668, 351);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(120, 64);
            this.BtnVolver.TabIndex = 36;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // CmbRubros
            // 
            this.CmbRubros.FormattingEnabled = true;
            this.CmbRubros.Location = new System.Drawing.Point(79, 315);
            this.CmbRubros.Name = "CmbRubros";
            this.CmbRubros.Size = new System.Drawing.Size(121, 21);
            this.CmbRubros.TabIndex = 38;
            this.CmbRubros.SelectedIndexChanged += new System.EventHandler(this.CmbRubro_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Rubros";
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.BtnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarTodo.ForeColor = System.Drawing.Color.White;
            this.BtnMostrarTodo.Location = new System.Drawing.Point(219, 351);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(90, 59);
            this.BtnMostrarTodo.TabIndex = 39;
            this.BtnMostrarTodo.Text = "Mostrar Todo";
            this.BtnMostrarTodo.UseVisualStyleBackColor = false;
            this.BtnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PryIEFI2MirkoLopezBearzi.Properties.Resources.Imagen_de_WhatsApp_2024_11_13_a_las_16_52_08_bef06286;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGenerarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMostrarTodo);
            this.Controls.Add(this.CmbRubros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.GrlM);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmGenerarArchivo";
            this.Text = "Generar Archivo";
            this.Load += new System.EventHandler(this.FrmGenerarArchivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrlM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DataGridView GrlM;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.ComboBox CmbRubros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMostrarTodo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}