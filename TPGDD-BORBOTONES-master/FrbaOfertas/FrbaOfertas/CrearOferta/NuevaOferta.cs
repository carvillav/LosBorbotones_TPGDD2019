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

namespace FrbaOfertas.CrearOferta
{
    public partial class NuevaOferta : Form
    {
        public NuevaOferta(String prov)
        {
            InitializeComponent();
            String fecha_sistema = Properties.Settings.Default.fechaSistema;
            DateTime unaFecha = Convert.ToDateTime(fecha_sistema);
            FechaP.Value = unaFecha;
            FechaV.Value = unaFecha;
            CuitTB.Text = prov;


        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");


        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            DescrpTB.Clear();
            CodTB.Clear();
            PrecioOF.Text = "0";
            PrecioList.Text = "0";
            CantT.Text = "0";
            CantCli.Text = "0";
        }

        private void CrearBtn_Click(object sender, EventArgs e)
        {
            if (DescrpTB.Text.Trim() != "" && CodTB.Text.Trim() != "" && PrecioOF.Text.Trim() != "" && PrecioList.Text.Trim() != "" && CantT.Text.Trim() != "" && CantCli.Text.Trim() != "")
            {               
            
                DateTime fechaPub = FechaP.Value;
                DateTime fechaVenc = FechaV.Value;

                String desc = DescrpTB.Text;
                String cuit = CuitTB.Text;
                String codigo = CodTB.Text;

                int precioOferta = Convert.ToInt32(PrecioOF.Value);
                int precioLista = Convert.ToInt32(PrecioList.Value);
                int cantTotal = Convert.ToInt32(CantT.Value);
                int cantCli = Convert.ToInt32(CantCli.Value);

                conexion.Open();
                String cadena = "insert into LOS_BORBOTONES.Oferta ";
                cadena += "(Oferta_Codigo, Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Cantidad_Compra, Oferta_Descripcion, Provee_CUIT) ";
                cadena += "values ";
                cadena += "(@codigo, @precio, @precioFic, @fechaPub, @fechaVenc, @disp, @cantComp, @desc, @prov)";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@precio", precioOferta);
                comando.Parameters.AddWithValue("@precioFic", precioLista);
                comando.Parameters.AddWithValue("@fechaPub", fechaPub);
                comando.Parameters.AddWithValue("@fechaVenc", fechaVenc);
                comando.Parameters.AddWithValue("@disp", cantTotal);
                comando.Parameters.AddWithValue("@cantComp", cantCli);
                comando.Parameters.AddWithValue("desc", desc);
                comando.Parameters.AddWithValue("@prov", cuit);

                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se creó correctamente la oferta...");
                    DescrpTB.Clear();
                    CodTB.Clear();
                    PrecioOF.Text = "0";
                    PrecioList.Text = "0";
                    CantT.Text = "0";
                    CantCli.Text = "0";
                

                }
            }
            else
            {
                MessageBox.Show("Por favor completar todos los campo...");
            }

            conexion.Close();
        }
    }
}
