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
    public partial class FrmMenu : Form
    {

        private Timer horaTimer;
        public FrmMenu()
        {


            InitializeComponent();
            InitializeComponent();
            horaTimer = new Timer();
            horaTimer.Interval = 1000;
            horaTimer.Tick += Hora1_Tick;
            horaTimer.Start(); InitializeComponent();
            horaTimer = new Timer();
            horaTimer.Interval = 1000;
            horaTimer.Tick += Hora1_Tick;
            horaTimer.Start();
            
        }
        ClsConexion clase = new ClsConexion();
        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void Hora1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("T");
            LblFecha.Text = DateTime.Now.ToString("D");
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informacionPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ClsConexion instancia = new ClsConexion();

            // este es el contenido que se guarda  \n ese saltea la linea
            string contenido = "Analista de Sistemas\n" +
                               "Laboratorio de Programación 2\n" +
                               "DNI Alumno: 46 510 718\n" +
                               "Nombre Alumno: Mirko Lopez Bearzi" +
                               "Descripción del Proyecto\r\n" +
                               "La aplicación permite gestionar proveedores utilizando dos tablas principales en una base de datos Access:\r\n\r\nTABLA VENDEDOR: Incluye IdProveedor, Nombre, DNI, Domicilio y Rubro.\r\nTABLA RUBRO: Contiene IdRubro y el nombre del rubro.\r\nFuncionalidades Implementadas\r\nPantalla de Inicio / Menú Principal\r\nDesde el menú principal se accede a:\r\n\r\nDatos Personales: Muestra información sobre el sistema y el usuario, grabándola mediante el método Grabar en ClsConexion.\r\nProveedores: Permite cargar, listar y exportar proveedores.\r\nGestión de Proveedores\r\n\r\nCargar Proveedores: Ingreso de datos del proveedor (Nombre, DNI, Domicilio, Rubro) con selección de rubro desde un ComboBox.\r\nListar Proveedores: Muestra los proveedores organizados por rubro.\r\nGenerar Archivo CSV: Exporta un archivo CSV filtrado por rubro con los campos Nombre, DNI, Domicilio y Rubro.\r\nInterfaz Gráfica\r\nLa interfaz es clara y amigable, utilizando controles como etiquetas, cuadros de texto, botones, listas y ComboBox.\r\n\r\nValidaciones\r\n\r\nFormato adecuado para el DNI.\r\nValidación de campos completos antes de guardar.\r\nVerificación de que el rubro seleccionado esté en la lista de valores predefinidos." +
                               ""

                               ;

            // intanciamos el metodo y lo grabamo
            instancia.Grabar(contenido);
        }

        private void informacionSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargarProveedores frmCARGA = new  FrmCargarProveedores();
            frmCARGA.Show();
            this.Hide();
        }

        private void listarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generarArchivoCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarArchivo frmGenerarArch  = new FrmGenerarArchivo();    
            frmGenerarArch.Show();  
            this.Hide();

        }

        private void buscarPorDniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusqueda frmBusqueda = new FrmBusqueda(); 
            frmBusqueda.Show(); 
            this.Hide();

        }
    }
}
