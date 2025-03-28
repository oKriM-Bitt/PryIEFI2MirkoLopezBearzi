using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Collections;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using System.Data;

namespace PryIEFI2MirkoLopezBearzi
{
    internal class ClsRubro
    {

        //conexion
        OleDbConnection Conexion = new OleDbConnection();

        //manda instrucciones
        OleDbCommand Comando = new OleDbCommand();

        //adapta las intrucciones y las acomoda
       OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Provider=Microsoft.JET.OLEDB.4.0;Data Source=GestionProveedores.mdb
        // Provider=Microsoft.JET.OLEDB.4.0;Data Source =GestionProveedores.mdb"
        string CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =GestionProveedores1.mdb";
        private string Tabla = "RUBRO";

        public void CargarRubros(System.Windows.Forms.ComboBox cmbRubro)
        {
            try
            {

                Conexion.ConnectionString = CadenaConexion;

                string sql = "SELECT IdRubro, Nombre FROM Rubro";
                Adaptador = new OleDbDataAdapter(sql, Conexion);


                DataTable dt = new DataTable();
                Conexion.Open();
                Adaptador.Fill(dt);
                Conexion.Close();


                cmbRubro.DataSource = dt;
                cmbRubro.DisplayMember = "Nombre";
                cmbRubro.ValueMember = "IdRubro";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el archivo: {ex.Message}");
            }

        }
    }
}
