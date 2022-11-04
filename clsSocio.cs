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

        private decimal saldo;
        private Int32 cantidad;
        private decimal promedio;

        private Int32 dni;
        private string nombre;
        private string direccion;
        private Int32 codSucursal;
        private Int32 codActividad;



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
        public decimal Saldo
        {   
           get { return saldo; }
            set { saldo = value; }

        } 
        public decimal TotalSaldo
        {
            get { return saldo; }
           

        }
        public Int32 cantidadSocios
        {
            get { return cantidad; }
        }
        public decimal promedioSaldo
        {
            get { return saldo/cantidad; }
        }
        public string Direccion
        {
            get { return direccion; }//retorna el valor del nombre
            set { direccion= value; }
        }
        public Int32 CodigoSucursal
        {
            get { return codSucursal; }
            set { codSucursal = value; }
        }
        public Int32 CodigoActividad
        {
            get { return codActividad; }
            set { codActividad = value; }
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
                comando.CommandText = "Socio";


                
                OleDbDataReader DR = comando.ExecuteReader(); //recibe lo que tiene la tabla y el comando ejecuta
                if (DR.HasRows) //preguntamos si hay filas
                {
                    while (DR.Read()) //mientras haya datos
                    {
                        if (DR.GetInt32(0) == Dni_Socio) //comparamos con lo ingresado 
                        {
                            dni = DR.GetInt32(0);
                            nombre = DR.GetString(1);
                            direccion = DR.GetString(2);
                            codSucursal = DR.GetInt32(3);
                            codActividad = DR.GetInt32(4);
                            saldo = DR.GetDecimal(5);

                        }
                    }
                }
                conexion.Close();

            }
            catch (Exception)
            {

                
            }
        }
        public void ListarSocios(DataGridView dgvGrilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion; //configuracion de la conexion
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //comando para traer la tabla
                comando.CommandText = tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                dgvGrilla.Rows.Clear();
                cantidad = 0;
                saldo = 0;
                while (DR.Read())
                {
                    if (DR.GetDecimal(5) > 0)
                    {
                    
                        dgvGrilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));
                        cantidad++;
                        saldo = saldo + DR.GetDecimal(5);

                    }
                    
                }
                conexion.Close();
            }
            catch (Exception)
            {

              
            }
        }

        public void RegistroClientes()
        {
            try
            {
                String Sql = "";
                Sql = "INSERT INTO Socio (Dni_Socio,Nombre_Apellido,Direccion,Codigo_Sucursal,Codigo_Actividad,Saldo)";
                Sql = Sql +  " VALUES (" + Dni_Socio + ",'" + Nombre_Apellido + "','" + Direccion+ "'," + CodigoSucursal+ "," + CodigoActividad + "," + Saldo + ")";
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser registrado con EXITO!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser registrado");
            }
        }

        public void BajaDeSocios()
        {
            try
            {
                String Sql = "";
                Sql = "DELETE FROM Socio " +
                    "WHERE(" + dni + "=[Dni_Socio])";

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser eliminado con EXITO!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser eliminado");
            }
        }
        public void ModificarSocios(Int32 Dni_Socio)
        {
            try
            {
                String Sql = "UPDATE Socio SET Dni_Socio = " + Dni_Socio + ", Nombre_Apellido= '" + Nombre_Apellido + "', Direccion= " + Direccion + ", Codigo_Sucursal= '" + CodigoSucursal + "' , Codigo_Actividad= '" + CodigoActividad + "' , Saldo= '" + Saldo + "'     WHERE [Dni_Socio] = '" + Dni_Socio + "'";


                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Tu socio pudo ser modificado con EXITO!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu socio no pudo ser modficado");
            }
        }

        public void FiltrarClientesDeUnaActividad(DataGridView Grilla, string Actividad)
        {
            try
            {

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Socio";
                OleDbDataReader Lector = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(4) == Dni_Socio)
                        {

                            Grilla.Rows.Add(Lector.GetInt32(0), Lector.GetString(1));
                            

                        }

                    }
                }
                conexion.Close();


            }
            catch (Exception)
            {
                ;


            }
        }

    }


}

    
