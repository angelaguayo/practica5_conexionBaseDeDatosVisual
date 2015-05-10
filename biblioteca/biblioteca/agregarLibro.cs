/*
 * Created by SharpDevelop.
 * User: Josue01
 * Date: 03/05/2015
 * Time: 09:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
	/// <summary>
	/// Description of agregarLibro.
	/// </summary>
	public partial class agregarLibro : Form
	{
		public agregarLibro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{ 
			
			
			funciones nuevolibro = new funciones();
			int codigo=0;
		
			string autor=txtAutor.Text;
			string titulo=txtTitulo.Text;
			string descripcion=txtDescripcion.Text;
			//string codigoString =txtId.Text;
			string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
			//codigo = Convert.ToInt32(codigoString);
			nuevolibro.insertarRegistroNuevo( autor, titulo, descripcion,fecha);
			
			txtAutor.Text = "";
			txtDescripcion.Text ="";
			txtTitulo.Text="";
			//txtId.Text="";
			codigo =+ 1;
			
		}
		
			
	}
}
