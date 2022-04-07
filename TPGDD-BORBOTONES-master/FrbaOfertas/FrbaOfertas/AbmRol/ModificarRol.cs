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
    public partial class ModificarRol : Form
    {
        public ModificarRol(int id, string nombreRol)
        {
            InitializeComponent();
            IdTB.Text = id.ToString();
            RolTB.Text = nombreRol.ToString();
            cargarFunc();
            cargarMisFunc(id);
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        int contador1 = 0;
        int contador2 = 0;
        int idAgregar = 0;
        int idEliminar = 0;

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarFunc() {

            String cadena = "select Func_Id 'ID', Func_Nombre 'Nombre funcionalidad' ";
            cadena += "from LOS_BORBOTONES.Funcionalidad";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            FuncDGV.DataSource = dataSet.Tables[0];
        }

        public void cargarMisFunc(int id) {
            string cadena = "select f.Func_Id 'ID', f.Func_Nombre 'Nombre funcionalidad' ";
            cadena += "from LOS_BORBOTONES.Func_Rol r join LOS_BORBOTONES.Funcionalidad f on (r.Func_Id = f.Func_Id) ";
            cadena += "where r.Rol_Id = @id and Habilitado = 1";
            SqlCommand comandoMisFunc = new SqlCommand(cadena, conexion);
            comandoMisFunc.Parameters.AddWithValue("@id", id);
            SqlDataAdapter data = new SqlDataAdapter(comandoMisFunc);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            MisFuncDGV.DataSource = dataSet.Tables[0];
        }


       

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            
            if (contador1 < 1)
            {
                if (MisFuncDGV.Rows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una funcionalidad a sacar...");
                }
                else
                {
                    string seleccion = MisFuncDGV.CurrentRow.Cells[0].Value.ToString();
                    MessageBox.Show(seleccion);
                    idEliminar = Convert.ToInt32(seleccion);

                    MisFuncDGV.Rows.RemoveAt(MisFuncDGV.CurrentRow.Index);
                    contador1 = 1;
                    
                    
                }
            }
            else
            {
                MessageBox.Show("Sólo se puede eliminar uno por vez...");
            }
            
        }

      

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            
            if (contador2 < 1)
            {
                 if (FuncDGV.Rows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una funcionalidad a dar de alta");
                }
                else
                {
                    bool estaLaFuncion = false;
                    String funcion1 = Convert.ToString(FuncDGV.Rows[FuncDGV.CurrentRow.Index].Cells[0].Value);
                    String funcion2 = Convert.ToString(FuncDGV.Rows[FuncDGV.CurrentRow.Index].Cells[1].Value);
                    //Verifico si la funcion que quiere agregar ya se encuentra en el listado de las funciones agregadas
                    foreach (DataGridViewRow row in MisFuncDGV.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == funcion1)
                        {
                            estaLaFuncion = true;
                            MessageBox.Show("Ya agregaste esta funcionalidad...");
                        }
                    }
                    if (!estaLaFuncion)
                    {
                        DataTable dt = MisFuncDGV.DataSource as DataTable;
                        dt.Rows.Add(new object[] { funcion1, funcion2 });
                        contador2 = 1;
                        idAgregar = Convert.ToInt32(funcion1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sólo puedes agregar una por vez...");
            }
            
        }

        public void agregarFunc(int idAgregar, int idRol){
            conexion.Open();
            string cadena = "insert into LOS_BORBOTONES.Func_Rol ";
            cadena += "(Rol_Id, Func_Id) ";
            cadena += "values (@rol, @func)";
            SqlCommand comandoAgregar = new SqlCommand(cadena, conexion);
            comandoAgregar.Parameters.AddWithValue("@func", idAgregar.ToString());
            comandoAgregar.Parameters.AddWithValue("@rol", idRol.ToString());
            comandoAgregar.ExecuteNonQuery();
            conexion.Close();
        }

        public void eliminarfunc(int idEliminar, int idRol)
        {
            conexion.Open();
            string cadena = "update LOS_BORBOTONES.Func_Rol ";
            cadena += "set Habilitado = 0 ";
            cadena += "where Rol_Id = @rol and Func_Id = @func";
            SqlCommand comandoEliminar = new SqlCommand(cadena, conexion);
            comandoEliminar.Parameters.AddWithValue("@func", idEliminar.ToString());
            comandoEliminar.Parameters.AddWithValue("@rol", idRol.ToString());
            comandoEliminar.ExecuteNonQuery();
            conexion.Close();
        }

        public void modificarNombreRol(int id) {
            conexion.Open();
            string nombre = RolTB.Text;
            String cadena = "update LOS_BORBOTONES.Role ";
            cadena += "set Rol_Nombre = @nombre ";
            cadena += "where Rol_Id = @id";
            SqlCommand comandoModf = new SqlCommand(cadena, conexion);
            comandoModf.Parameters.AddWithValue("@id", id);
            comandoModf.Parameters.AddWithValue("@nombre", nombre);
            comandoModf.ExecuteNonQuery();
            conexion.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            
            int idRol = Convert.ToInt32(IdTB.Text.ToString());
            modificarNombreRol(idRol);
            if (idEliminar != idAgregar) //verifica que el que se agrego y el que se elimino  o viceversa sean el mismo
            {                
                if (idAgregar>0)
                {
                    agregarFunc(idAgregar, idRol);
                }
                if (idEliminar > 0)
                {
                    eliminarfunc(idEliminar, idRol);
                }
            }
           
           MessageBox.Show("Se actualizaron los datos correctamente...");
           this.Close();
        }
    }
}
