/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC30
 * Fecha: 28/10/2026
 * Hora: 08:04 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace usuario_contra
{
	/// <summary>
	/// Description of menu.
	/// </summary>
	public partial class menu : Form
	{
		public menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
