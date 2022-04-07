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

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class Estadistico : Form
    {
        public Estadistico()
        {
            InitializeComponent();
            DateTime unaFecha = fechaSistema();
            ListarCB.DropDownStyle = ComboBoxStyle.DropDownList;
            UnSemestreCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AnioCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ListarCB.SelectedIndex = 0;
            UnSemestreCB.SelectedIndex = 0;
            cargarCBAnio(AnioCB, unaFecha);
           
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        public void cargarCBAnio(ComboBox combo, DateTime fecha)
        {
            combo.DataSource = Enumerable.Range(2019, fecha.Year-2019+1).ToList();
            
        }

        public DateTime fechaSistema() {
            String fecha_sistema = Properties.Settings.Default.fechaSistema;
            DateTime unaFecha = Convert.ToDateTime(fecha_sistema);
            return unaFecha;
        }
        
        public void listadoMayorPorc(int mes1, int mes2, int fecha){
            string cadena = "select top 5 Provee_CUIT 'CUIT', Oferta_Codigo 'Código de oferta', Oferta_Precio_Ficticio 'Precio lista', Oferta_Precio 'Precio oferta', ";
                cadena += "cast(((Oferta_Precio_Ficticio-Oferta_Precio)*100)/Oferta_Precio_Ficticio as numeric(18,2)) 'Descuento en %' ";
                cadena += "from LOS_BORBOTONES.Oferta ";
                cadena += "where Oferta_Precio_Ficticio != Oferta_Precio and year(Oferta_Fecha) <= @aniofecha and MONTH(Oferta_Fecha) between @mes1 and @mes2 ";
                cadena += "order by 'Descuento en %' desc";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@aniofecha", fecha);
                comando.Parameters.AddWithValue("@mes1", mes1);
                comando.Parameters.AddWithValue("@mes2", mes2);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataSet dataSet = new DataSet();
                data.Fill(dataSet);
                ListadoDGV.DataSource = dataSet.Tables[0];
        }

        public void listadoMayorFac(int mesD, int mesH, int fecha) {
            String cadena = "select top 5 p.Provee_RS 'Razón social', f.Provee_CUIT 'CUIT', f.Factura_Nro 'Número de factura', f.Factura_Importe 'Importe' ";
            cadena += "from LOS_BORBOTONES.Factura f join LOS_BORBOTONES.Proveedor p on (f.Provee_CUIT = p.Provee_CUIT) ";
            cadena += "where year(Factura_Fecha) <= @aniofecha and MONTH(Factura_Fecha) between @mesD and @mesH ";
            cadena += "order by f.Factura_Importe DESC";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@aniofecha", fecha);
            comando.Parameters.AddWithValue("@mesD", mesD);
            comando.Parameters.AddWithValue("@mesH", mesH);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            ListadoDGV.DataSource = dataSet.Tables[0];
        }

        public void cargarListadoMayorPorc1s() {
            int fechaAnio = Convert.ToInt32(AnioCB.Text);
            conexion.Open();
            DateTime fechaSist = fechaSistema();
            if (fechaSist.Year.Equals(fechaAnio))
            {
                if (fechaSist.Month <=6)
                {
                    int mes2 = Convert.ToInt32(fechaSist.Month);
                    int mes1 = 1;
                    listadoMayorPorc(mes1, mes2, fechaAnio);
                }
                else
                {
                    int mes2 = 6;
                    int mes1 = 1;
                    listadoMayorPorc(mes1, mes2, fechaAnio);    
                }
            }
            else
            {
                int mes2 = 6;
                int mes1 = 1;
                listadoMayorPorc(mes1, mes2, fechaAnio);  
            }
            
            conexion.Close();
            
        }
        
        public void cargarListadoMayorPorc2s() {
            int fechaAnio = Convert.ToInt32(AnioCB.Text);
            conexion.Open();
            DateTime fechaSist = fechaSistema();
            if (fechaSist.Year.Equals(fechaAnio))
            {
                if (fechaSist.Month >= 7)
                {
                    int mes2 = Convert.ToInt32(fechaSist.Month);
                    int mes1 = 7;
                    listadoMayorPorc(mes1, mes2, fechaAnio);
                }
                else
                {
                    int mes2 = 12;
                    int mes1 = 7;
                    listadoMayorPorc(mes1, mes2, fechaAnio);
                }
            }
            else
            {
                int mes2 = 12;
                int mes1 = 7;
                listadoMayorPorc(mes1, mes2, fechaAnio);
            }
            conexion.Close();
            
        }

        public void cargarListadoMayorFac1s() {
            int fechaAnio = Convert.ToInt32(AnioCB.Text);
            conexion.Open();
            DateTime fechaSist = fechaSistema();
            if (fechaSist.Year.Equals(fechaAnio))
            {
                if (fechaSist.Month <= 6)
                {
                    int mes2 = Convert.ToInt32(fechaSist.Month);
                    int mes1 = 1;
                    listadoMayorFac(mes1, mes2, fechaAnio);
                }
                else
                {
                    int mes2 = 6;
                    int mes1 = 1;
                    listadoMayorFac(mes1, mes2, fechaAnio);
                }
            }
            else
            {
                int mes2 = 6;
                int mes1 = 1;
                listadoMayorFac(mes1, mes2, fechaAnio);
            }

            conexion.Close();
            
        }

        public void cargarListadoMayorFac2s() {
            int fechaAnio = Convert.ToInt32(AnioCB.Text);
            conexion.Open();
            DateTime fechaSist = fechaSistema();
            if (fechaSist.Year.Equals(fechaAnio))
            {
                if (fechaSist.Month >= 7)
                {
                    int mes2 = Convert.ToInt32(fechaSist.Month);
                    int mes1 = 7;
                    listadoMayorFac(mes1, mes2, fechaAnio);
                }
                else
                {
                    int mes2 = 12;
                    int mes1 = 7;
                    listadoMayorFac(mes1, mes2, fechaAnio);
                }
            }
            else
            {
                int mes2 = 12;
                int mes1 = 7;
                listadoMayorFac(mes1, mes2, fechaAnio);
            }
            conexion.Close();
            
        }
       

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (ListarCB.SelectedIndex > 0)
            {
                if (UnSemestreCB.SelectedIndex > 0)
                {
                    if (ListarCB.SelectedIndex == 1)
                    {
                        if (UnSemestreCB.SelectedIndex == 1)
                        {                            
                            cargarListadoMayorPorc1s();
                        }
                        else
                        {
                            cargarListadoMayorPorc2s();    
                        }
                        
                    }
                    else
                    {
                        if (UnSemestreCB.SelectedIndex == 1)
                        {                            
                            cargarListadoMayorFac1s();
                        }
                        else
                        {
                            cargarListadoMayorFac2s();
                        }
                          
                    }

                }
                else
                {
                    MessageBox.Show("Por favor elegir un semestre...");
                }
            }
            else
            {
                MessageBox.Show("Por favor elegir que una opción a listar...");
            }
        }
    }
}
