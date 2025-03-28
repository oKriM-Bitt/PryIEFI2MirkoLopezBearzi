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
using System.ComponentModel;

namespace PryIEFI2MirkoLopezBearzi
{
    internal class ClsConexion
    {

        //conexion
         OleDbConnection Conexion = new OleDbConnection();
        //manda instrucciones
         OleDbCommand Comando = new OleDbCommand();
        //adapta las intrucciones y las acomoda
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();

       
       
        private string CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =GestionProveedores1.mdb";
        private string Tabla = "TABLA VENDEDOR";
        public string Alumno = "Alumnos.txt";
        public string info = "Infosistema.txt";

        public void Grabar(string contenido)
        {
            // Crear y escribir en el archivo
            File.WriteAllText(Alumno, contenido);

            // Abrir el archivo en el Bloc de notas
            Process.Start(new ProcessStartInfo
            {
                FileName = Alumno,
                UseShellExecute = true
            });

        }
        // Atributos para los datos de proveedor
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Rubro { get; set; }


        // Cargar un nuevo proveedor
        public void CargarProveedor(string nombre, int dni, string domicilio, int rubro)
        {
            try
            {
                // Establecer la cadena de conexión
                Conexion.ConnectionString = CadenaConexion;

                // Abrir la conexión
                Conexion.Open();

                // Configurar el comando
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;

                // Establecer el comando SQL para insertar un proveedor
                Comando.CommandText = "INSERT INTO [TABLA VENDEDOR] (Nombre, DNI, Domicilio, IdRubro) VALUES (?, ?, ?, ?)";

                // Agregar los parámetros para evitar SQL Injection
                Comando.Parameters.AddWithValue("?", nombre);   // Primer parámetro: Nombre
                Comando.Parameters.AddWithValue("?", dni);      // Segundo parámetro: DNI
                Comando.Parameters.AddWithValue("?", domicilio); // Tercer parámetro: Domicilio
                Comando.Parameters.AddWithValue("?", rubro);    // Cuarto parámetro: IdRubro

                // Ejecutar el comando de inserción
                int filasAfectadas = Comando.ExecuteNonQuery();

                // Verificar si se insertaron filas correctamente
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Proveedor agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el proveedor.");
                }

                // Cerrar la conexión
                Conexion.Close();
            }
            catch (Exception e)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show("Error: " + e.Message);
            }
        }

        // Listar todos los proveedores
        public void ListarProveedores(DataGridView Grilla)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                Adaptador = new OleDbDataAdapter(Comando);
                DataSet DS = new DataSet();
                Adaptador.Fill(DS);
                Grilla.DataSource = DS.Tables[0];
                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Listar proveedores filtrados por rubro
        public void ListarProveedoresPorRubro(DataGridView Grilla, int rubroId)
        {
            try
            {
                // Configurar la conexión
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;

                // Consulta SQL para listar proveedores de la tabla VENDEDOR por rubro
                Comando.CommandText = "SELECT * FROM [TABLA VENDEDOR] WHERE IdRubro = @IdRubro";
                Comando.Parameters.Clear(); // Limpiar parámetros previos
                Comando.Parameters.AddWithValue("@IdRubro", rubroId);

                // Llenar el DataGridView con los resultados
                Adaptador = new OleDbDataAdapter(Comando);
                DataSet DS = new DataSet();
                Adaptador.Fill(DS);
                Grilla.DataSource = DS.Tables[0];

                // Cerrar la conexión
                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void Busqueda(DataGridView grilla, int? dni, string nombre)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;

                // Construir la consulta SQL dinámica según los parámetros
                string consulta = "SELECT * FROM [TABLA VENDEDOR] WHERE 1=1";
                if (dni.HasValue)
                {
                    consulta += " AND DNI = @DNI";
                    Comando.Parameters.AddWithValue("@DNI", dni.Value);
                }
                if (!string.IsNullOrEmpty(nombre))
                {
                    consulta += " AND Nombre LIKE @Nombre";
                    Comando.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                }

                Comando.CommandText = consulta;

                // Ejecutar la consulta y llenar el DataGridView con los resultados
                Adaptador = new OleDbDataAdapter(Comando);
                DataSet DS = new DataSet();
                Adaptador.Fill(DS);
                grilla.DataSource = DS.Tables[0];

                // Cerrar la conexión
                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        // Generar un archivo CSV de proveedores filtrados por rubro
        public void GenerarArchivoCSV(DataGridView grilla, string rutaArchivo)
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                    // Escribir los encabezados de las columnas
                    string encabezados = string.Join(";", grilla.Columns.Cast<DataGridViewColumn>().Select(col => col.HeaderText));
                    archivo.WriteLine(encabezados);

                    // Escribir los datos de cada fila
                    foreach (DataGridViewRow fila in grilla.Rows)
                    {
                        if (!fila.IsNewRow) // Ignorar la fila nueva vacía en el DataGridView
                        {
                            string[] celdas = fila.Cells.Cast<DataGridViewCell>()
                                .Select(celda => celda.Value?.ToString() ?? string.Empty)
                                .ToArray();
                            archivo.WriteLine(string.Join(";", celdas));
                        }
                    }
                }

                MessageBox.Show("Archivo CSV generado exitosamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}