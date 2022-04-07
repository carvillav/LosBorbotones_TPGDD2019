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
    public partial class BuscarOferta : Form
    {
        public BuscarOferta()
        {
            InitializeComponent();
            cargarOfertas();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void cargarOfertas() {
            conexion.Open();
            String fecha_sistema = Properties.Settings.Default.fechaSistema;
            DateTime unaFecha = Convert.ToDateTime(fecha_sistema);
            String cadena = "select cl.Cli_Dni 'DNI', cl.Cli_Nombre 'Nombre', cl.Cli_Apellido 'Apellido', o.Oferta_Codigo 'Código oferta', ";
            cadena += "o.Oferta_Descripcion 'Descripción', cu.Oferta_Fecha_Venc 'Fecha de Vencimiento' ";
            cadena += "from LOS_BORBOTONES.Cupon cu join LOS_BORBOTONES.Cliente cl on (cu.Cli_Dni = cl.Cli_Dni) ";
            cadena += "join LOS_BORBOTONES.Oferta o on(cu.Oferta_Codigo = o.Oferta_Codigo) ";
            cadena += "where cast(@fechaSist as datetime) between o.Oferta_Fecha and o.Oferta_Fecha_Venc and cu.Cli_Dest_Dni is null";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@fechaSist", unaFecha);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            OfertasDGV.DataSource = dataSet.Tables[0];

            conexion.Close();
        }

        private void BuscarTB_TextChanged(object sender, EventArgs e)
        {
            if (BuscarTB.Text != "")
            {
                OfertasDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in OfertasDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in OfertasDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(BuscarTB.Text.ToUpper()) == 0)
                        {
                            OfertasDGV.ClearSelection();
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                cargarOfertas();
            }
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntregarBtn_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(OfertasDGV.CurrentRow.Cells[0].Value.ToString());
            String oferta = OfertasDGV.CurrentRow.Cells[3].Value.ToString();
            EntregaOferta.EntregoOferta entrega = new EntregoOferta(dni, oferta);
            entrega.ShowDialog();
            BuscarTB.Clear();
        }
    }
}
