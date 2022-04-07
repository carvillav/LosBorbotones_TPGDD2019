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

namespace FrbaOfertas.PantallaUsuarios
{
    public partial class CambiarPass : Form
    {
        public CambiarPass(String usuario)
        {
            InitializeComponent();
            UsuarioTB.Text = usuario;
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void actualizarPass() {
            conexion.Open();
            String cadena = "UPDATE LOS_BORBOTONES.Usuario ";
            cadena += "SET Password = HASHBYTES('SHA2_256', CAST( (cast(@pass as nvarchar(20))) AS varbinary(70))) ";
            cadena += "WHERE User_name = @usuario";
            SqlCommand comandoCambiar = new SqlCommand(cadena, conexion);
            comandoCambiar.Parameters.AddWithValue("@usuario", UsuarioTB.Text);
            comandoCambiar.Parameters.AddWithValue("@pass", PassTB.Text);
            int cant;
            cant = comandoCambiar.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se cambió la contraseña exitosamente...");
                this.Close();

            }
            else
            {
                MessageBox.Show("La contraseña no se actualizó, intente nuevamente...");
            }
            conexion.Close();
        }

        private void CambiarBtn_Click(object sender, EventArgs e)
        {
            actualizarPass();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
