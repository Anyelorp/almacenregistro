using System;
using System.Windows;
using System.Data.SqlClient;

namespace almacen
{
    public partial class MainWindow : Window
    {
        private string connectionString = @"Data Source=(localdb)\anyelo;Initial Catalog=anyelo;Integrated Security=True";

        public MainWindow()
        {
            InitializeComponent();
            REGISTRAR.Click += REGISTRAR_Click;
        }

        private void REGISTRAR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Utiliza directamente los valores de los campos sin validar su tipo
                string nombre = NOMBRE.Text;
                string categoria = CATEGORIA.Text;
                string cantidad = CANTIDAD.Text;
                string estado = ESTADO.Text;
                string precio = PRECIO.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO almacen (Nombre, Categoria, Cantidad, Estado, Precio) VALUES (@Nombre, @Categoria, @Cantidad, @Estado, @Precio)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Almacen registrado correctamente.");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el almacen: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            NOMBRE.Text = "";
            CATEGORIA.Text = "";
            CANTIDAD.Text = "";
            ESTADO.Text = "";
            PRECIO.Text = "";
        }

        private void ABRIR_PROVEEDORES_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Crear una instancia de la ventana proveedores
                proveedores proveedoresWindow = new proveedores();

                // Mostrar la ventana proveedores
                proveedoresWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de proveedores: " + ex.Message);
            }
        }
    }
}
