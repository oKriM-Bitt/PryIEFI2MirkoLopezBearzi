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
    public partial class FrmCargarProveedores : Form
    {
        public FrmCargarProveedores()
        {
            InitializeComponent();
        }
        ClsConexion cls = new ClsConexion();
        ClsRubro clsRubro = new ClsRubro(); 
        private void BtnAgregar_Click(object sender, EventArgs e)
        {


            String Nombre = TxtNombre.Text;
            String Domicilio = TxtDomicilio.Text;
            Int32 Rubro = CmbRubro.SelectedIndex + 1;

            // Validar si el DNI tiene 8 dígitos
            if (TxtDni.Text.Length == 8 && Int32.TryParse(TxtDni.Text, out int Dni))
            {
                // Llamar a CargarProveedor solo si el DNI es válido
                cls.CargarProveedor(Nombre, Dni, Domicilio, Rubro);
            }
            else
            {
                // Mostrar mensaje de error si el DNI no tiene 8 dígitos
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu(); 
            frmMenu.ShowDialog();
            this.Close();
        }

        private void FrmCargarProveedores_Load(object sender, EventArgs e)
        {
            clsRubro.CargarRubros(CmbRubro);
        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
