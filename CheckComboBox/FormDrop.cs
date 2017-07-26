using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaMaf.Controles.CheckComboBox
{
	public partial class FormDrop : Form
	{
		public delegate void SampleEventHandler(object sender, EventArgs e);
		public event SampleEventHandler Ocultar;

		protected void OnOcultar()
		{
			if (Ocultar != null)
			{
				Ocultar(this,new EventArgs());
			}
		}

		public FormDrop()
		{
			InitializeComponent();
		}

		private void FormDrop_Deactivate(object sender, EventArgs e)
		{	
			this.Hide();
			OnOcultar();
		}

		public void Mostrar( ComboBox.ObjectCollection items)
		{
			//this.SuspendLayout();
			//checkedListBox.Items.Clear();
			//foreach (var mItem in items)
			//{
			//	string A = mItem.ToString();
			//	checkedListBox.Items.Add(A);
			//}
			//this.PerformLayout();
			this.Show();
			this.Height = checkedListBox.Height;
			checkedListBox.Width = this.Width;
			checkedListBox.Focus();
		}

		private void checkedListBox1_Resize(object sender, EventArgs e)
		{
			this.Height = checkedListBox.Height;
		}
	}
}
