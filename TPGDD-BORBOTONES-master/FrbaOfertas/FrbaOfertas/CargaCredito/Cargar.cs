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

namespace FrbaOfertas.CargaCredito
{
    public partial class Cargar : Form
    {
        public Cargar()
        {
            InitializeComponent();
            TipoPagoCB.DropDownStyle = ComboBoxStyle.DropDownList;
            cargarTipoPago(TipoPagoCB);
            cargarDatosClientes();
        }

        String fecha_sistema = Properties.Settings.Default.fechaSistema;
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void cargarTipoPago(ComboBox combo)
        {
            conexion.Open();
            string cadena = "select Tipo_Pago_Desc from LOS_BORBOTONES.TipoDePago";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader dataCB = comando.ExecuteReader();
            while (dataCB.Read())
            {
                combo.Items.Add(dataCB[0].ToString());
            }
            conexion.Close();
            combo.Items.Insert(0, "Elegir una opción...");
            combo.SelectedIndex = 0;
        }

        public void cargarDatosClientes() {
            String cadena;
            cadena = "SELECT c.Cli_Nombre Cliente, c.Cli_Apellido Apellido, c.Cli_Dni Dni, c.Cli_Mail Email ";
            cadena += "FROM LOS_BORBOTONES.Cliente c JOIN LOS_BORBOTONES.Usuario u ON (c.User_name = u.User_name) ";
            cadena += "WHERE u.Habilitado = 1 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            ClientesDGV.DataSource = dataSet.Tables[0];
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int idTipoPago(string tipo) {
            string cadena = "select Tipo_Pago_Id from LOS_BORBOTONES.TipoDePago ";
            cadena += "where Tipo_Pago_Desc = @tipo";
            SqlCommand comandoCliente = new SqlCommand(cadena, conexion);
            comandoCliente.Parameters.AddWithValue("@tipo", tipo);
            SqlDataAdapter data = new SqlDataAdapter(comandoCliente);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            int id = Convert.ToInt32(tabla.Rows[0][0].ToString());
            return id;
        }

        private void DniTB_TextChanged(object sender, EventArgs e)
        {
            if (DniTB.Text != "")
            {
                ClientesDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in ClientesDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in ClientesDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(DniTB.Text.ToUpper()) == 0)
                        {
                            ClientesDGV.ClearSelection();
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                cargarDatosClientes();
            }
        }

        private void CargarBtn_Click(object sender, EventArgs e)
        {
            if (TipoPagoCB.SelectedIndex > 0) {

                conexion.Open();    
                String unaSeleccion = TipoPagoCB.Text;
                String dni = ClientesDGV.CurrentRow.Cells[2].Value.ToString();
                int monto = Convert.ToInt32(MontoNUD.Value);
                int idTP = idTipoPago(unaSeleccion);
                DateTime unaFecha = Convert.ToDateTime(fecha_sistema);               
                string datos = DatoTarjetaTB.Text;
                string cadena = "insert into LOS_BORBOTONES.Carga ";
                cadena += "(Cli_Dni,Carga_Credito, Carga_Fecha, Tipo_Pago_Id, Datos_Tarjeta) ";
                cadena += "values ";
                cadena += "(cast (@dni as numeric (18,0)), cast (@monto as numeric (18,2)), cast('" + unaFecha + "' as date), @tipo, @datos)";
                SqlCommand comandoCargar = new SqlCommand(cadena, conexion);
                comandoCargar.Parameters.AddWithValue("@dni", dni);
                comandoCargar.Parameters.AddWithValue("@monto", monto);
                comandoCargar.Parameters.AddWithValue("@tipo", idTP);
                comandoCargar.Parameters.AddWithValue("@datos", datos);
                int cant;
                cant = comandoCargar.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Carga de crédito exitosa...");
                    cargarDatosClientes();
                    TipoPagoCB.SelectedIndex = 0;
                    DniTB.Clear();
                    MontoNUD.Text = "0";

                }
                conexion.Close();

            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de pago...");
            }
        }

        private void TipoPagoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoPagoCB.SelectedIndex < 2) {
                DatoTarjetaTB.Enabled = false;
                DatoTarjetaTB.Text = "";
            }
            else
            {
                DatoTarjetaTB.Enabled = true;
            }
        }
    }
}
