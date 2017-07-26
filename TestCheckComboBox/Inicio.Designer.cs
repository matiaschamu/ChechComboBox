using BibliotecaMAF.Controles.CheckComboBox;

namespace TestCheckComboBox2
{
	partial class Inicio
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.textBoxAgregar = new System.Windows.Forms.TextBox();
			this.buttonQuitarUltimo = new System.Windows.Forms.Button();
			this.buttonQuitarTodos = new System.Windows.Forms.Button();
			this.textBoxCantidad = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.combo1 = new BibliotecaMAF.Controles.CheckComboBox.CheckComboBox();
			this.SuspendLayout();
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Location = new System.Drawing.Point(12, 12);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
			this.buttonAgregar.TabIndex = 2;
			this.buttonAgregar.Text = "Agrega";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
			// 
			// textBoxAgregar
			// 
			this.textBoxAgregar.Location = new System.Drawing.Point(93, 15);
			this.textBoxAgregar.Name = "textBoxAgregar";
			this.textBoxAgregar.Size = new System.Drawing.Size(100, 20);
			this.textBoxAgregar.TabIndex = 3;
			// 
			// buttonQuitarUltimo
			// 
			this.buttonQuitarUltimo.Location = new System.Drawing.Point(12, 41);
			this.buttonQuitarUltimo.Name = "buttonQuitarUltimo";
			this.buttonQuitarUltimo.Size = new System.Drawing.Size(75, 23);
			this.buttonQuitarUltimo.TabIndex = 4;
			this.buttonQuitarUltimo.Text = "Quita Ult";
			this.buttonQuitarUltimo.UseVisualStyleBackColor = true;
			this.buttonQuitarUltimo.Click += new System.EventHandler(this.buttonQuitarUltimo_Click);
			// 
			// buttonQuitarTodos
			// 
			this.buttonQuitarTodos.Location = new System.Drawing.Point(93, 41);
			this.buttonQuitarTodos.Name = "buttonQuitarTodos";
			this.buttonQuitarTodos.Size = new System.Drawing.Size(75, 23);
			this.buttonQuitarTodos.TabIndex = 5;
			this.buttonQuitarTodos.Text = "Quita Todos";
			this.buttonQuitarTodos.UseVisualStyleBackColor = true;
			this.buttonQuitarTodos.Click += new System.EventHandler(this.buttonQuitarTodos_Click);
			// 
			// textBoxCantidad
			// 
			this.textBoxCantidad.Location = new System.Drawing.Point(199, 15);
			this.textBoxCantidad.Name = "textBoxCantidad";
			this.textBoxCantidad.Size = new System.Drawing.Size(28, 20);
			this.textBoxCantidad.TabIndex = 6;
			this.textBoxCantidad.Text = "1";
			this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(247, 70);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(229, 251);
			this.textBox1.TabIndex = 9;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
			this.comboBox1.Location = new System.Drawing.Point(12, 327);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(229, 21);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
			this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
			this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
			this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
			this.comboBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDoubleClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 70);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(229, 251);
			this.textBox2.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(174, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Check 3ro";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// combo1
			// 
			this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.combo1.FormattingEnabled = true;
			this.combo1.ItemsString = new string[] {
        "111",
        "222",
        "333",
        "444",
        "555",
        "666",
        "777",
        "888",
        "999",
        "000",
        "",
        "YYY"};
			this.combo1.Location = new System.Drawing.Point(247, 327);
			this.combo1.Name = "combo1";
			this.combo1.Size = new System.Drawing.Size(229, 28);
			this.combo1.TabIndex = 8;
			this.combo1.ItemCheck += new BibliotecaMAF.Controles.CheckComboBox.CheckComboBox.SampleEventHandler(this.combo1_ItemCheck);
			this.combo1.DropDown += new System.EventHandler(this.combo1_DropDown);
			this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
			this.combo1.SelectionChangeCommitted += new System.EventHandler(this.combo1_SelectionChangeCommitted);
			this.combo1.TextUpdate += new System.EventHandler(this.combo1_TextUpdate);
			this.combo1.DropDownClosed += new System.EventHandler(this.combo1_DropDownClosed);
			this.combo1.TextChanged += new System.EventHandler(this.combo1_TextChanged);
			this.combo1.Click += new System.EventHandler(this.combo1_Click);
			this.combo1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combo1_MouseClick);
			this.combo1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.combo1_MouseDoubleClick);
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 360);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.combo1);
			this.Controls.Add(this.textBoxCantidad);
			this.Controls.Add(this.buttonQuitarTodos);
			this.Controls.Add(this.buttonQuitarUltimo);
			this.Controls.Add(this.textBoxAgregar);
			this.Controls.Add(this.buttonAgregar);
			this.Location = new System.Drawing.Point(10, 10);
			this.Name = "Inicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Inicio";
			this.Load += new System.EventHandler(this.Inicio_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.TextBox textBoxAgregar;
		private System.Windows.Forms.Button buttonQuitarUltimo;
		private System.Windows.Forms.Button buttonQuitarTodos;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private BibliotecaMAF.Controles.CheckComboBox.CheckComboBox combo1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
	}
}
