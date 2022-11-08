using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace prySerafiniGiorgi_IEFI
{
    internal class clsSucursales
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();//enviamos ordenes a las bases de dapto
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//adpatamos los datos que estan en la base a datos comprensibles por .NET

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEFI.mdb";
        private string tabla = "Sucursales";

        public void ListarComboBox(ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//cadena de conexion
                conexion.Open();
                comando.Connection = conexion; //el comando necesita tener una conexion
                comando.CommandType = CommandType.TableDirect; //nos trae una tabla
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla en memoria ram que tiene datos de mi tabla
                adaptador.Fill(DS, tabla);
                combo.DataSource = DS.Tables[tabla];
                combo.DisplayMember = "Detalle_Sucursal";//es lo que va aparecer en la lista desplegable
                combo.ValueMember = "Codigo_Sucursal";//esta invisible, pero esta


                conexion.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }
        public void FiltrarClientesDeUnaSucursal(DataGridView Grilla, Int32 Sucursal)
        {
            try
            {

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";
                OleDbDataReader Lector = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (Lector.HasRows)// si hay filas se lee
                {
                    while (Lector.Read())//leemos
                    {
                        if (Lector.GetInt32(3) == Sucursal )
                        {
                            Grilla.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetDecimal(5));
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
