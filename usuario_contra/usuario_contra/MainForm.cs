/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC30
 * Fecha: 28/10/2026
 * Hora: 07:57 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace usuario_contra
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
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			string usuarioCorrecto = "Nina";
			string passCorrecta = "12345";
			if(txtUser.Text== usuarioCorrecto && txtContra.Text==passCorrecta)
			{
				MessageBox.Show("Bienvenido " + txtUser.Text);
				menu m = new menu();
				m.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("usuario o contra incorrectos");
				txtContra.Clear();
				txtUser.Focus();
			}
		}
	}
}
