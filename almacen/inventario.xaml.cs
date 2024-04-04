using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;

namespace almacen
{
    /// <summary>
    /// Lógica de interacción para inventario.xaml
    /// </summary>
    public partial class inventario : Window
    {
        private string connectionString = @"Data Source=(localdb)\anyelo;Initial Catalog=anyelo;Integrated Security=True";

        public inventario()
        {
            InitializeComponent();
            REGISTRAR_ENTRADA.Click += REGISTRAR_ENTRADA_Click;
        }

        private void REGISTRAR_ENTRADA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FECHA_HORA.SelectedDate.HasValue)
                {
                    DateTime fechaHora = FECHA_HORA.SelectedDate.Value;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Inventario (IdProducto, CantidadRecibida, FechaHora, IdProveedor, NumeroFactura) VALUES (@IdProducto, @CantidadRecibida, @FechaHora, @IdProveedor, @NumeroFactura)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@IdProducto", ID_DE_PRODUCTO.Text);
                        cmd.Parameters.AddWithValue("@CantidadRecibida", CANTIDAD_RECIBIDA.Text);
                        cmd.Parameters.AddWithValue("@FechaHora", fechaHora);
                        cmd.Parameters.AddWithValue("@IdProveedor", ID_DE_PROVEEDOR.Text);
                        cmd.Parameters.AddWithValue("@NumeroFactura", NUMERO_DE_FACTURA.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Entrada registrada correctamente.");

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione una fecha válida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la entrada: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            ID_DE_PRODUCTO.Text = "";
            CANTIDAD_RECIBIDA.Text = "";
            FECHA_HORA.Text = "";
            ID_DE_PROVEEDOR.Text = "";
            NUMERO_DE_FACTURA.Text = "";
        }

        private void ABRIR_SALIDA_INVENTARIO_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SALIDA_INVENTARIO salidaInventario = new SALIDA_INVENTARIO();
                salidaInventario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de salida de inventario: " + ex.Message);
            }
        }
    }
}