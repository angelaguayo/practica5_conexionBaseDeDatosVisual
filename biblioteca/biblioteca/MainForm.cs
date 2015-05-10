/*
 * Created by SharpDevelop.
 * User: Josue01
 * Date: 01/05/2015
 * Time: 11:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace biblioteca 
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form 
	{
		public MainForm()
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
			agregarLibro agregarLibro = new agregarLibro();
			agregarLibro.Show();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			mostrar mostrar = new mostrar();
			mostrar.Show();
		}
	
	}
}
