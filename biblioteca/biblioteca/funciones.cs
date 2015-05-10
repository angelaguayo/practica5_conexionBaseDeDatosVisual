
//__________________________________________________
using System;
using System.Data;
using MySql.Data.MySqlClient;



namespace biblioteca
{
	public class funciones : MySQL
	{
		public funciones ()
		{
		}

		public void insertarRegistroNuevo(string autor, string titulo, string descripcion, string fecha){
			
			this.abrirConexion();
			
			string sql = "INSERT INTO libro VALUES ("+"default"+",'" + autor + "', '" + titulo + "','"+ descripcion +"','"+ fecha +"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
			
			}

		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		
		public DataSet mostrartodo(){
			this.abrirConexion();
			string query = "select * from libro";
			
			MySqlDataAdapter datalibro = new MySqlDataAdapter(query, myConnection);
			DataSet dsLibro = new DataSet();
			datalibro.Fill(dsLibro, "libro");
			this.cerrarConexion();
			return dsLibro;
			
		}
		
		private string querySelect(){
			return "SELECT * " +
	           	"FROM libro";
		}
	}
}
