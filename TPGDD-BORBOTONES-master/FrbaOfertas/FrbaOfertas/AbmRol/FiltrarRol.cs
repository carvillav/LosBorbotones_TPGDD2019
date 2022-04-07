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
    public partial class FiltrarRol : Form
    {
        public FiltrarRol()
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
            cadena += "WHERE Habilitado = 1 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            RolDGV.DataSource = dataSet.Tables[0];
        }

        private void RolTB_TextChanged(object sender, EventArgs e)
        {
            if (RolTB.Text != "")
            {
                RolDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in RolDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in RolDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(RolTB.Text.ToUpper()) == 0)
                        {
                            RolDGV.ClearSelection();
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

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            int rol = Convert.ToInt32(RolDGV.CurrentRow.Cells[0].Value.ToString());
            SqlCommand comandoEliminar = new SqlCommand("UPDATE LOS_BORBOTONES.Role SET Habilitado = 0 WHERE Rol_Id = @id", conexion);
            comandoEliminar.Parameters.AddWithValue("@id", rol);
            conexion.Open();
            int cant;
            cant = comandoEliminar.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se eliminó exitosamente el Rol...");

            }
            conexion.Close();
            RolDGV.Refresh();
            RolDGV.Parent.Refresh();
            cargarDatos();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(RolDGV.CurrentRow.Cells[0].Value.ToString());
            string nombreRol = RolDGV.CurrentRow.Cells[1].Value.ToString();
            AbmRol.ModificarRol nuevo = new ModificarRol(id, nombreRol);
            nuevo.ShowDialog();
            RolTB.Clear();
            cargarDatos();
        }
    }
}
