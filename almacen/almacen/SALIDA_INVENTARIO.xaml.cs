using System;
using System.Data.SqlClient;
using System.Windows;

namespace almacen
{
    public partial class SALIDA_INVENTARIO : Window
    {
        private string connectionString = @"Data Source=(localdb)\anyelo;Initial Catalog=anyelo;Integrated Security=True";

        public SALIDA_INVENTARIO()
        {
            InitializeComponent();
            REGISTRAR_SALIDA.Click += REGISTRAR_SALIDA_Click;
        }

        private void REGISTRAR_SALIDA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Inventario (IdProducto, CantidadRecibida, FechaHora, IdProveedor, NumeroFactura) VALUES (@IdProducto, @CantidadRecibida, @FechaHora, @IdProveedor, @NumeroFactura)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdProducto", ID_DE_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("@CantidadRecibida", CANTIDAD_RETIRADA.Text);
                    cmd.Parameters.AddWithValue("@FechaHora", FECHA_.SelectedDate);
                    cmd.Parameters.AddWithValue("@IdProveedor", ID_DE_CLIENTE.Text);
                    cmd.Parameters.AddWithValue("@NumeroFactura", NUMERO_DE_FACTURA.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Salida registrada correctamente.");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la salida: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            ID_DE_SALIDA.Text = "";
            ID_DE_PROVEEDOR.Text = "";
            CANTIDAD_RETIRADA.Text = "";
            FECHA_.SelectedDate = null;
            MOTIVO_DE_SALIDA.Text = "";
            ID_DE_CLIENTE.Text = "";
            NUMERO_DE_FACTURA.Text = "";
        }
    }
}
