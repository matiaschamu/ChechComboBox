using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TestCheckComboBox2
{
	public partial class Inicio : Form
	{
		public Inicio()
		{
			InitializeComponent();
		}

		private void buttonAgregar_Click(object sender, EventArgs e)
		{
			int mNumero;
			if (int.TryParse(textBoxCantidad.Text, out mNumero))
			{
				if (mNumero > 0)
				{

					if (mNumero == 1)
					{
						if (textBoxAgregar.Text.Trim() != "")
						{
							//checkBoxComboBox1.Items.Add(textBoxAgregar.Text);
							combo1.Items.Add(textBoxAgregar.Text);
						}
					}
					else
					{
						if (textBoxAgregar.Text.Trim() != "")
						{
							string[] mS = new string[mNumero];
							for (int i = 0; i < mS.Length; i++)
							{
								mS[i] = textBoxAgregar.Text;
							}
							//checkBoxComboBox1.Items.AddRange(mS);
							combo1.Items.AddRange(mS);
						}
					}
				}
			}
		}

		private void buttonQuitarUltimo_Click(object sender, EventArgs e)
		{
			if (combo1.Items.Count > 0)
			{
				//checkBoxComboBox1.Items.RemoveAt(checkBoxComboBox1.Items.Count-1);
				combo1.Items.RemoveAt(combo1.Items.Count - 1);
			}
		}

		private void buttonQuitarTodos_Click(object sender, EventArgs e)
		{
			//checkBoxComboBox1.Items.Clear();
			combo1.Items.Clear();
		}

		private void combo1_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "Clik" + "\r\n";
		}

		private void combo1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			textBox1.Text = textBox1.Text + "DobleClik" + "\r\n";
		}

		private void combo1_DropDown(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "DropDown" + "\r\n";
		}

		private void combo1_DropDownClosed(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "DropDownClosed" + "\r\n";
		}

		private void combo1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "SelectedIndexChanged" + "\r\n";
		}

		private void combo1_TextUpdate(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "TextUpdate" + "\r\n";
		}

		private void combo1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			textBox1.Text = textBox1.Text + "ItemCheck" + "\r\n";
		}

		private void comboBox1_Click(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "Clik" + "\r\n";
		}

		private void comboBox1_MouseClick(object sender, MouseEventArgs e)
		{
			textBox2.Text = textBox2.Text + "MouseClik" + "\r\n";
		}

		private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			textBox2.Text = textBox2.Text + "DoubleClik" + "\r\n";
		}

		private void comboBox1_DropDown(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "DropDown" + "\r\n";
		}

		private void comboBox1_DropDownClosed(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "DropDownClosed" + "\r\n";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "SelectedIndexChanged" + "\r\n";
		}

		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "SelectionChangeCommitted" + "\r\n";
		}

		private void comboBox1_TextUpdate(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "TextUpdate" + "\r\n";
		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text + "TextChanged" + "\r\n";
		}

		private void combo1_MouseClick(object sender, MouseEventArgs e)
		{
			textBox1.Text = textBox1.Text + "MouseClik" + "\r\n";
		}

		private void Inicio_Load(object sender, EventArgs e)
		{
			combo1.Text = "Hola";
			//combo1.SelectedValue = "Wildcards";
			comboBox1.Text = "Hola2";
		}

		private void combo1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "SelectionChangeCommitted" + "\r\n";
		}

		private void combo1_TextChanged(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "TextChanged" + "\r\n";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//checkedListBox1.SetItemCheckState(2, CheckState.Checked);
			combo1.SetItemCheckState(2, CheckState.Checked);
		}

	

	

	

	
	}
}
