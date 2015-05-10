/*
 * Created by SharpDevelop.
 * User: Josue01
 * Date: 03/05/2015
 * Time: 10:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace biblioteca
{
	/// <summary>
	/// Description of mostrar.
	/// </summary>
	public partial class mostrar : Form
	{
		//funciones conexionMySQL;
		public mostrar()
		{
			
			//conexionMySQL = new funciones();
			funciones nuevolibro = new funciones();
				//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			dataGridView1.DataSource = nuevolibro.mostrartodo();
			dataGridView1.DataMember = "libro";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

	}
}
		
	
