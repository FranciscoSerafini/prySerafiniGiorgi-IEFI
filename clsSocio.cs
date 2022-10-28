using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;

namespace prySerafiniGiorgi_IEFI
{
    internal class clsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();//enviamos ordenes a las bases de dapto
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//adpatamos los datos que estan en la base a datos comprensibles por .NET

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEFI.mdb";
        private string tabla = "Socio";

        private decimal deuda;
        private Int32 cantidad;

        private Int32 dni;
        private string nombre;
        private decimal deu;
        private Int32 saldo;

        //propiedas de solo lecturas 
        public Int32 Dni_Socio 
        {
            get { return dni; }//retorna el valor del dni
            set { dni = value; }
        }
        public string Nombre_Apellido
        {
            get { return nombre; }//retorna el valor del nombre
            set { nombre = value; }
        }
        public Int32 Saldo
        {
            get { return saldo; }
            
        }
        public Int32 cantidadSocios
        {
            get { return cantidad; }
        }
        public decimal promedioSueldos
        {
            get { return saldo/cantidad;}
        }



        //metodos con los que trabajaremos
        public void Listar(DataGridView dgvGrilla) //intentando 
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
                adaptador.Fill(DS);

                dgvGrilla.DataSource = DS.Tables[0];


                conexion.Close();
                
            }
            catch (Exception )
            {
                
                //throw;
            }

        }
        public void Buscar(Int32 Dni_Socio)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion; //configuracion de la conexion
                conexion.Open();
                
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //comando para traer la tabla
                comando.CommandText = tabla;


                
                OleDbDataReader DR = comando.ExecuteReader(); //recibe lo que tiene la tabla y el comando ejecuta
                if (DR.HasRows) //preguntamos si hay filas
                {
                    while (DR.Read()) //mientras haya datos
                    {
                        if (DR.GetInt32(0) == Dni_Socio) //comparamos con lo ingresado 
                        {
                            dni = DR.GetInt32(0);
                            nombre = DR.GetString(1);
                            saldo = DR.GetInt32(5);
                        }
                    }
                }
                conexion.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ListarSocios(DataGridView dgvGrilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla en memoria ram que tiene datos de mi tabla
                adaptador.Fill(DS);//metodo para rellenar la grilla
                dgvGrilla.DataSource = DS.Tables[0];

                
                dgvGrilla.Rows.Clear();
                cantidad = 0;
                saldo = 0;
                OleDbDataReader DR = comando.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {

                        if (DR.GetInt32(5) > 0)
                         {
                             cantidad = Dni_Socio + 1;
                             saldo = saldo + DR.GetInt32(5);
                     
                        
                        }
                    
                    }
                }



                conexion.Close();
            }
            catch (Exception)
            {

              //  throw;
            }
        }
    }


}

    
