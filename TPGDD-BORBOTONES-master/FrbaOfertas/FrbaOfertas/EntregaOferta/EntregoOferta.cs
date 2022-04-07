using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FrbaOfertas.EntregaOferta
{
    public partial class EntregoOferta : Form
    {
        public EntregoOferta(int cliente, string codOferta)
        {
            InitializeComponent();
            mostrarFechaSistema();
            unCliente = cliente;
            oferta = codOferta;

        }

        int unCliente;
        string oferta;

        public void mostrarFechaSistema() {

            String fecha_sistema = Properties.Settings.Default.fechaSistema;
            DateTime unaFecha = Convert.ToDateTime(fecha_sistema);
            FechaNacDTP.Value = unaFecha;
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            ApellidoTB.Clear();
            DniTB.Clear();
            DireccionTB.Clear();
            TelefonoTB.Clear();
            EmailTB.Clear();
            CiudadTB.Clear();
            mostrarFechaSistema();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntregarBtn_Click(object sender, EventArgs e)
        {
            if (NombreTB.Text.Trim() != "" && ApellidoTB.Text.Trim() != "" && DniTB.Text.Trim() != "" && DireccionTB.Text.Trim() != "" && TelefonoTB.Text.Trim() != "" && EmailTB.Text.Trim() != "" && CiudadTB.Text.Trim() != "" && FechaNacDTP.Text.Trim() != "")
            {
                conexion.Open();
                int telf = Convert.ToInt32(TelefonoTB.Text.ToString());
                int dniRetira = Convert.ToInt32(DniTB.Text.ToString());
                String cadena = "update LOS_BORBOTONES.Cupon ";
                cadena += "set Cli_Dest_Nombre = @nombre, ";
                cadena += "Cli_Dest_Apellido = @apellido, ";
                cadena += "Cli_Dest_Ciudad = @ciudad, ";
                cadena += "Cli_Dest_Direccion = @direccion, ";
                cadena += "Cli_Dest_Dni = @dniRetiro, ";
                cadena += "Cli_Dest_Fecha_Nac = cast(@fechNac as datetime), ";
                cadena += "Cli_Dest_Mail = @email, ";
                cadena += "Cli_Dest_Telefono = @telf, ";
                cadena += "Oferta_Entregado_Fecha = cast(@fechEntrega as datetime)";
                cadena += "where Cli_Dni = @dni and Oferta_Codigo = @oferta";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@nombre",NombreTB.Text);
                comando.Parameters.AddWithValue("@apellido", ApellidoTB.Text);
                comando.Parameters.AddWithValue("@ciudad", CiudadTB.Text);
                comando.Parameters.AddWithValue("@direccion", DireccionTB.Text);
                comando.Parameters.AddWithValue("@dniRetiro", dniRetira);
                comando.Parameters.AddWithValue("@fechNac", FechaNacDTP.Value);
                comando.Parameters.AddWithValue("@email", EmailTB.Text);
                comando.Parameters.AddWithValue("@telf", telf);
                comando.Parameters.AddWithValue("@dni", unCliente);
                comando.Parameters.AddWithValue("@oferta", oferta);
                comando.Parameters.AddWithValue("@fechEntrega", FechaNacDTP.Value);

                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se registró correctamente el retiro de la oferta...");
                    this.Close();
                }

                conexion.Close();

            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos...");
            }
        }

        private void DniTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TelefonoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
