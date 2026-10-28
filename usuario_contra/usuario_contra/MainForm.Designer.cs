/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC30
 * Fecha: 28/10/2026
 * Hora: 07:57 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace usuario_contra
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblUser = new System.Windows.Forms.Label();
			this.lblContra = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUser
			// 
			this.lblUser.Location = new System.Drawing.Point(44, 45);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(100, 23);
			this.lblUser.TabIndex = 0;
			this.lblUser.Text = "Usuario:";
			// 
			// lblContra
			// 
			this.lblContra.Location = new System.Drawing.Point(44, 90);
			this.lblContra.Name = "lblContra";
			this.lblContra.Size = new System.Drawing.Size(100, 23);
			this.lblContra.TabIndex = 1;
			this.lblContra.Text = "contra:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(174, 47);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(128, 20);
			this.txtUser.TabIndex = 2;
			// 
			// txtContra
			// 
			this.txtContra.Location = new System.Drawing.Point(174, 90);
			this.txtContra.Name = "txtContra";
			this.txtContra.Size = new System.Drawing.Size(128, 20);
			this.txtContra.TabIndex = 3;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(132, 180);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(121, 43);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 285);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtContra);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.lblContra);
			this.Controls.Add(this.lblUser);
			this.Name = "MainForm";
			this.Text = "usuario_contra";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label lblContra;
		private System.Windows.Forms.Label lblUser;
	}
}
