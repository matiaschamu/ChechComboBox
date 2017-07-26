using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaMaf.Controles.CheckComboBox
{
	public partial class CheckComboBox : ComboBox
	{
		public delegate void SampleEventHandler(object sender, ItemCheckEventArgs e);
		public event SampleEventHandler ItemCheck;
		private FormDrop F = new FormDrop();

		private void OnItemCheck(ItemCheckEventArgs e)
		{
			try
			{
				if (ItemCheck != null)
				{
					ItemCheck(this, e);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public CheckComboBox()
		{
			F.Ocultar += F_Ocultar;
			F.checkedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
			F.checkedListBox.ItemCheck += checkedListBox_ItemCheck;
		}

		public ListBox.SelectedObjectCollection SelectedItems
		{
			get
			{
				return F.checkedListBox.SelectedItems;
			}
		}

		public ListBox.SelectedIndexCollection SelectedIndices
		{
			get
			{
				return F.checkedListBox.SelectedIndices;
			}
		}

		public CheckedListBox.CheckedIndexCollection CheckedIndices
		{
			get
			{
				return F.checkedListBox.CheckedIndices;
			}
		}

		public CheckedListBox.CheckedItemCollection CheckedItems
		{
			get
			{
				return F.checkedListBox.CheckedItems;
			}
		}

		private delegate void DelegadoMetodo(ItemCheckEventArgs e);

		private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string T = "";
			bool mEContado = false;
			for (int i = 0; i < F.checkedListBox.CheckedIndices.Count; i++)
			{
				if (F.checkedListBox.CheckedIndices[i] == e.Index)
				{
					mEContado = true;
					if (e.NewValue == CheckState.Checked)
					{
						T = T + F.checkedListBox.Items[F.checkedListBox.CheckedIndices[i]].ToString() + "; ";
					}
				}
				else
				{
					if ((F.checkedListBox.CheckedIndices[i] > e.Index) && (mEContado == false))
					{
						mEContado = true;
						if (e.NewValue == CheckState.Checked)
						{
							T = T + F.checkedListBox.Items[e.Index].ToString() + "; ";
						}
						T = T + F.checkedListBox.Items[F.checkedListBox.CheckedIndices[i]].ToString() + "; ";
					}
					else
					{
						T = T + F.checkedListBox.Items[F.checkedListBox.CheckedIndices[i]].ToString() + "; ";
					}
				}
			}

			if (mEContado == false)
			{
				if (e.NewValue == CheckState.Checked)
				{
					T = T + F.checkedListBox.Items[e.Index].ToString() + "; ";
				}
			}
			if (T.Length > 2)
			{
				this.Text = T.Substring(0, T.Length - 2);
			}
			else
			{
				this.Text = "";
			}

			DelegadoMetodo D = new DelegadoMetodo(OnItemCheck);
			this.BeginInvoke(D, e);
			//OnItemCheck(e);
		}

		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				if (base.Text != value)
				{
					base.Items.Clear();
					if (value != "")
					{
						base.Items.Add(value);
						base.Text = value;
					}
				}
			}
		}

		private int mUltimoIndexSelect = -1;

		private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (F.checkedListBox.SelectedIndex != mUltimoIndexSelect)
			{
				mUltimoIndexSelect = F.checkedListBox.SelectedIndex;
				OnSelectedIndexChanged(e);
			}
		}

		private void F_Ocultar(object sender, EventArgs e)
		{
			OnDropDownClosed(new EventArgs());
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ResumeLayout(false);
		}

		public void SetItemCheckState(int index, CheckState checkState)
		{
			F.checkedListBox.SetItemCheckState(index, checkState);
		}

		public void SetItemCheckState(int index, bool checkState)
		{
			if (checkState == true)
			{
				F.checkedListBox.SetItemCheckState(index, CheckState.Checked  );
			}
			else
			{
				F.checkedListBox.SetItemCheckState(index, CheckState.Unchecked);
			}
		}

		private void Abrir()
		{
			F.Width = this.DropDownWidth;
			F.Height = this.DropDownHeight;
			Point P1 = this.PointToScreen(this.Location);
			Point P2 = new Point(P1.X - this.Left, P1.Y - this.Top + this.Height);
			F.Location = P2;
			F.Mostrar(base.Items);
			OnDropDown(new EventArgs());
			OnClick(new EventArgs());
			Point M = this.PointToClient(new Point(MousePosition.X, MousePosition.Y));
			OnMouseClick(new MouseEventArgs(MouseButtons, 1, M.X, M.Y, 0));
		}

		public new CheckedListBox.ObjectCollection Items
		{
			get
			{
				return F.checkedListBox.Items;
			}
		}

		public  string[] ItemsString
		{
			get
			{
				string[] R =new string[F.checkedListBox.Items.Count];
				for (int i = 0; i < F.checkedListBox.Items.Count; i++)
				{
					R[i] = (string) F.checkedListBox.Items[i];
				}
				return R;
			}
			set
			{
				F.checkedListBox.Items.Clear();
				F.checkedListBox.Items.AddRange(value);
			}
		}

		public override bool PreProcessMessage(ref Message msg)
		{
			if (msg.Msg == 256)
			{
				//Aca manejo el mensaje del la flecha para abajo sobre el combo
				if (msg.WParam.ToInt32() == 40)
				{
					return true;
				}
				//Aca manejo el mensaje del la flecha para arriba sobre el combo
				if (msg.WParam.ToInt32() == 38)
				{
					return true;
				}
			}
			return base.PreProcessMessage(ref msg);
		}

		public CheckState GetItemCheckState(int index)
		{
			return F.checkedListBox.GetItemCheckState(index);
		}

		public bool GetItemChecked(int index)
		{
			return F.checkedListBox.GetItemChecked(index);
		}

		protected override void WndProc(ref Message m)
		{
			//Aca manejo el mensaje del dobleclic sobre el combo
			if (m.Msg == 515)
			{
				Abrir();
				return;
			}
			//Aca manejo el mensaje del clic sobre el combo
			if (m.Msg == 513)
			{
				Abrir();
				return;
			}
			base.WndProc(ref m);
		}
	}
}
