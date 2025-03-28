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
    public partial class FrmBusqueda : Form
    {
        public FrmBusqueda()
        {
            InitializeComponent();
        }
        ClsConexion clsConexion = new ClsConexion();
        public void BtnBuscarYMostrar_Click(object sender, EventArgs e)
        {
            string nombre = TxtApellido.Text;
            int? dni = null;

            if (TxtDni.Text.Length == 8 && Int32.TryParse(TxtDni.Text, out int dniValue))
            {
                dni = dniValue; // Asigna el valor de DNI si es válido
            }
            else if (!string.IsNullOrEmpty(TxtDni.Text))
            {
                // Mostrar mensaje de error si el DNI no tiene 8 dígitos
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamar al método de búsqueda con los valores de dni y nombre
            clsConexion.Busqueda(GrlM, dni, nombre);
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
          
        }
    }
}
