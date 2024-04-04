using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace almacen
{
    /// <summary>
    /// Lógica de interacción para proveedores.xaml
    /// </summary>
    public partial class proveedores : Window
    {
        private string connectionString = @"Data Source=(localdb)\anyelo;Initial Catalog=anyelo;Integrated Security=True";
        public proveedores()
        {
            InitializeComponent();
        }

        private void OBTENER_PROVEEDOR_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Proveedores";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Aquí puedes mostrar los datos en un control de datos como un DataGrid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener proveedores: " + ex.Message);
            }
        }

        private void AGREGAR_PROVEEDOR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Proveedores (NombreEmpresa, NombreContacto, Direccion, Telefono, CorreoElectronico, TerminosPago) VALUES (@NombreEmpresa, @NombreContacto, @Direccion, @Telefono, @CorreoElectronico, @TerminosPago)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreEmpresa", NOMBRE_EMPRESA.Text);
                    cmd.Parameters.AddWithValue("@NombreContacto", NOMBRE_CONTACTO.Text);
                    cmd.Parameters.AddWithValue("@Direccion", DIRECCION.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TELEFONO.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CORREO_ELECTRONICO.Text);
                    cmd.Parameters.AddWithValue("@TerminosPago", TERMINO_PAGO.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Proveedor agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar proveedor: " + ex.Message);
            }
        }

        private void ACTUALIZAR_PROVEEDOR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Verificar si se ha proporcionado un ID válido
                if (!string.IsNullOrEmpty(ID.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Proveedores SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, Direccion = @Direccion, Telefono = @Telefono, CorreoElectronico = @CorreoElectronico, TerminosPago = @TerminosPago WHERE IdProveedor = @IdProveedor";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@NombreEmpresa", NOMBRE_EMPRESA.Text);
                        cmd.Parameters.AddWithValue("@NombreContacto", NOMBRE_CONTACTO.Text);
                        cmd.Parameters.AddWithValue("@Direccion", DIRECCION.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TELEFONO.Text);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", CORREO_ELECTRONICO.Text);
                        cmd.Parameters.AddWithValue("@TerminosPago", TERMINO_PAGO.Text);
                        cmd.Parameters.AddWithValue("@IdProveedor", int.Parse(ID.Text));
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Proveedor actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el proveedor con el ID especificado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe proporcionar un ID de proveedor válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar proveedor: " + ex.Message);
            }
        }

        private void ELIMINAR_PROVEEDOR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Proveedores WHERE IdProveedor = @IdProveedor";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdProveedor", int.Parse(ID.Text));
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proveedor eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el proveedor con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
            }
        }

        private void ABRIR_INVENTARIO_Click(object sender, RoutedEventArgs e)
        {
            {
                inventario ventanaInventario = new inventario();
                ventanaInventario.Show();
            }
        }
    }
}
    
