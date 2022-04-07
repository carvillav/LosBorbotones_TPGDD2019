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
using System.Globalization;

namespace FrbaOfertas.Facturar
{
    public partial class EmitirFac : Form
    {
        public EmitirFac(String proveedor, DateTime desde, DateTime hasta)
        {
            InitializeComponent();
            ProvTB.Text = proveedor;
            cargarCupones(desde, hasta);
            DesdeDTP.Value = desde;
            HastaDTP.Value = hasta;
            fechaDesde = desde;
            fechaHasta = hasta;
        }

        String fecha_sistema = Properties.Settings.Default.fechaSistema;
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        DateTime fechaDesde;
        DateTime fechaHasta;

        public void cargarCupones(DateTime desde, DateTime hasta) {
            String prov = ProvTB.Text;
            String cadena = "SELECT c.Oferta_Codigo 'Código de producto', count(c.Oferta_Codigo) 'Cantidad vendida', count(c.Oferta_Codigo)*o.Oferta_Precio 'Monto' ";
            cadena += "FROM LOS_BORBOTONES.Cupon c JOIN LOS_BORBOTONES.Oferta o ON (c.Oferta_Codigo = o.Oferta_Codigo) ";
            cadena += "GROUP BY c.Oferta_Codigo, o.Oferta_Precio, o.Oferta_Fecha, o.Oferta_Fecha_Venc, o.Provee_CUIT, c.Factura_Nro ";
            cadena += "HAVING cast(o.Oferta_Fecha as date) between cast('"+desde+"' as date) and Cast('"+hasta+"' as date) ";
            cadena += "AND c.Factura_Nro is null ";
            cadena += "AND o.Provee_CUIT = '" + prov + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            CuponesDGV.DataSource = dataSet.Tables[0];
           Double suma = 0.0;          
            foreach (DataGridViewRow row in CuponesDGV.Rows)
            {
                if (row.Cells[2].Value != null) 
                    suma += Convert.ToDouble(row.Cells[2].Value);
            }
            TotalTB.Text = suma.ToString();
        }

        private void EmitirFac_Load(object sender, EventArgs e)
        {

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void actualizarCupon(String prov, DateTime desde, DateTime hasta, int nroFac) {
            string cadena = "update LOS_BORBOTONES.Cupon ";
            cadena += "set Factura_Nro = @fac ";
            cadena += "where Cupon_Id in (select Cupon_Id from LOS_BORBOTONES.Oferta o join LOS_BORBOTONES.Cupon c on (o.Oferta_Codigo = c.Oferta_Codigo) ";
            cadena += "where c.Factura_Nro is null and o.Provee_CUIT = @prov ";
            cadena += "and cast(c.Oferta_Fecha_Compra as date) between cast(@desde as date) and cast(@hasta as date))";
            SqlCommand comandoCupon = new SqlCommand(cadena, conexion);
            comandoCupon.Parameters.AddWithValue("@fac", nroFac);
            comandoCupon.Parameters.AddWithValue("@prov", prov);
            comandoCupon.Parameters.AddWithValue("@desde", desde);
            comandoCupon.Parameters.AddWithValue("@hasta", hasta);
            int cant;
            cant = comandoCupon.ExecuteNonQuery();
            
            MessageBox.Show("Factura generada con exito...");
            this.Close();
            
        }

        private void EmitirBtn_Click(object sender, EventArgs e)
        {
            conexion.Open();
            DateTime fechaSist = Convert.ToDateTime(fecha_sistema);
            string cadena = "insert into LOS_BORBOTONES.Factura ";
            cadena += "(Factura_Fecha, Factura_Importe, Fecha_Desde, Fecha_Hasta, Provee_CUIT) ";
            cadena += "values ";
            cadena += "(@fecha, @monto, cast(@desde  as datetime), cast(@hasta as datetime), @prov) ";
            cadena += "SELECT SCOPE_IDENTITY()";
            SqlCommand comandoFac = new SqlCommand(cadena, conexion);
            comandoFac.Parameters.AddWithValue("@fecha", fechaSist);
            comandoFac.Parameters.AddWithValue("@monto", TotalTB.Text);
            comandoFac.Parameters.AddWithValue("@desde", fechaDesde);
            comandoFac.Parameters.AddWithValue("@hasta", fechaHasta);
            comandoFac.Parameters.AddWithValue("@prov", ProvTB.Text);

            int result = Convert.ToInt32(comandoFac.ExecuteScalar());
            actualizarCupon(ProvTB.Text, fechaDesde, fechaHasta, result);

            conexion.Close();
        }

    }
}
