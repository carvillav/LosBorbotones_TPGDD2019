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
    public partial class NuevoRol : Form
    {
        public NuevoRol()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void NuevoRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet1.Funcionalidad' Puede moverla o quitarla según sea necesario.
            this.funcionalidadTableAdapter.Fill(this.gD2C2019DataSet1.Funcionalidad);

        }


        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Saca una funcionalidad del segundo DGV
        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (NuevasFuncDGV.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una funcionalidad a sacar...");
            }
            else
            {
                NuevasFuncDGV.Rows.RemoveAt(NuevasFuncDGV.CurrentRow.Index);
            }
        }

        //agrega una funcionalidad de un DGV a otro DGV
        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (FuncDGV.Rows.Count == 0)
            {
                MessageBox.Show("error: debe seleccionar una funcionalidad a dar de alta");
            }
            else
            {
                bool estaLaFuncion = false;
                String funcion = Convert.ToString(FuncDGV.Rows[FuncDGV.CurrentRow.Index].Cells[0].Value);
                //Verifico si la funcion que quiere agregar ya se encuentra en el listado de las funciones agregadas
                foreach (DataGridViewRow row in NuevasFuncDGV.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == funcion)
                    {
                        estaLaFuncion = true;
                        MessageBox.Show("Ya agregaste esta funcionalidad...");
                    }
                }
                if (!estaLaFuncion)
                {
                    NuevasFuncDGV.Rows.Add(funcion);
                }
            }
        }

        //buscar id de funcionalidad
        public int buscarId(String funcionalidad) {
            string cadena = "select Func_Id ";
            cadena += "from LOS_BORBOTONES.Funcionalidad ";
            cadena += "where Func_Nombre = @funcNom";
            SqlCommand comandoFunc = new SqlCommand(cadena, conexion);
            comandoFunc.Parameters.AddWithValue("@funcNom", funcionalidad);
            SqlDataAdapter data = new SqlDataAdapter(comandoFunc);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            int id = Convert.ToInt32(tabla.Rows[0][0].ToString());
            return id;
        }

        //inserta los id de funcionalidades y de rol correspondientes
        public void cargarRolXFunc(int id) {
            foreach (DataGridViewRow row in NuevasFuncDGV.Rows) {
                  
                int idFunc = buscarId(row.Cells[0].Value.ToString());
                string cadena = "INSERT INTO LOS_BORBOTONES.Func_Rol ";
                cadena += "(Rol_Id, Func_Id) ";
                cadena += "Values ";
                cadena += "(@idRol, @idFunc)";
                SqlCommand comandoExiste = new SqlCommand(cadena, conexion);
                comandoExiste.Parameters.AddWithValue("@idFunc", idFunc);
                comandoExiste.Parameters.AddWithValue("@idRol", id);
                comandoExiste.ExecuteNonQuery();
            }
            MessageBox.Show("El rol se creó correctamente...");
            RolTB.Clear();
            NuevasFuncDGV.Rows.Clear();
                 
        }
       
        //evalua si el rol que se ingresa ya existe
        public Boolean existeRol() {
            String rol = RolTB.Text.Trim();
            string cadena = "SELECT * FROM LOS_BORBOTONES.Role ";
            cadena += "WHERE Rol_Nombre = @nombre";
            SqlCommand comandoExiste = new SqlCommand(cadena, conexion);
            comandoExiste.Parameters.AddWithValue("@nombre", rol);
            SqlDataAdapter data = new SqlDataAdapter(comandoExiste);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            if (tabla.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }       
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (RolTB.Text.Trim() != "")
            {
                if (NuevasFuncDGV.Rows.Count > 0)
                {
                    if (!existeRol())
                    {
                        String rol = RolTB.Text.Trim();                                          
                        string cadena = "insert into LOS_BORBOTONES.Role ";
                        cadena += "(Rol_Nombre) ";
                        cadena += "values ";
                        cadena += "(@rol) ";
                        cadena += "SELECT SCOPE_IDENTITY()";
                        SqlCommand comandoNuevo = new SqlCommand(cadena, conexion);
                        comandoNuevo.Parameters.AddWithValue("@rol", rol);
                        int result = Convert.ToInt32(comandoNuevo.ExecuteScalar());
                                               
                         cargarRolXFunc(result);   
                        
                    }
                    else
                    {
                        MessageBox.Show("El Rol ya existe, intente nuevamente con otro nombre...");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor agregue una o varias funcionalidades al nuevo Rol...");   
                }
            }
            else
            {
                MessageBox.Show("Por favor poner un nombre al nuevo Rol...");
            }
            conexion.Close();
        }
    }
}
