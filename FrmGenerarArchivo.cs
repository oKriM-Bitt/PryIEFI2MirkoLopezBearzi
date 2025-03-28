using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIEFI2MirkoLopezBearzi
{
    public partial class FrmGenerarArchivo : Form
    {
        public FrmGenerarArchivo()
        {
            InitializeComponent();
        }
        ClsConexion cls = new ClsConexion();
        ClsRubro clsRubro = new ClsRubro();

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Int32 Rubro = CmbRubros.SelectedIndex + 1;
            cls.ListarProveedoresPorRubro(GrlM, Rubro);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Guardar archivo CSV",
                FileName = "ProveedoresPorRubro.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
               cls.GenerarArchivoCSV(GrlM, rutaArchivo);
            }
        }

        private void CmbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmGenerarArchivo_Load(object sender, EventArgs e)
        {
            clsRubro.CargarRubros(CmbRubros);
        }

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            cls.ListarProveedores(GrlM);
        }
    }
}
