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

namespace FrbaOfertas.AbmRol
{
    public partial class RestaurarRol : Form
    {
        public RestaurarRol()
        {
            InitializeComponent();
            cargarDatos();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        public void cargarDatos()
        {
            String cadena;
            cadena = "SELECT Rol_Id 'Id', Rol_Nombre 'Nombre Rol' ";
            cadena += "FROM LOS_BORBOTONES.Role ";
            cadena += "WHERE Habilitado = 0 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            RolesDGV.DataSource = dataSet.Tables[0];
        }

        private void RolTB_TextChanged(object sender, EventArgs e)
        {
            if (RolTB.Text != "")
            {
                RolesDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in RolesDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in RolesDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(RolTB.Text.ToUpper()) == 0)
                        {
                            RolesDGV.ClearSelection();
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                cargarDatos();
            }
        }

        private void RestaurarBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(RolesDGV.CurrentRow.Cells[0].Value.ToString());
            SqlCommand comandoRestaurar = new SqlCommand("UPDATE LOS_BORBOTONES.Role SET Habilitado = 1 WHERE Rol_Id = @id", conexion);
            comandoRestaurar.Parameters.AddWithValue("@id", id);
            conexion.Open();
            int cant;
            cant = comandoRestaurar.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se restauró exitosamente el Rol...");

            }
            conexion.Close();
            RolesDGV.Refresh();
            RolesDGV.Parent.Refresh();
            RolTB.Clear();
            cargarDatos();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
