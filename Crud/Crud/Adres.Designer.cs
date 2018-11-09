namespace Crud
{
	partial class Adres
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kodpocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numerulicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new Crud.DataSet1();
			this.adresTableAdapter = new Crud.DataSet1TableAdapters.adresTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.kodpocztowyDataGridViewTextBoxColumn,
            this.numerulicyDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.adresBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(579, 438);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// ulicaDataGridViewTextBoxColumn
			// 
			this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "ulica";
			this.ulicaDataGridViewTextBoxColumn.HeaderText = "ulica";
			this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
			// 
			// miastoDataGridViewTextBoxColumn
			// 
			this.miastoDataGridViewTextBoxColumn.DataPropertyName = "miasto";
			this.miastoDataGridViewTextBoxColumn.HeaderText = "miasto";
			this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
			// 
			// kodpocztowyDataGridViewTextBoxColumn
			// 
			this.kodpocztowyDataGridViewTextBoxColumn.DataPropertyName = "kod_pocztowy";
			this.kodpocztowyDataGridViewTextBoxColumn.HeaderText = "kod_pocztowy";
			this.kodpocztowyDataGridViewTextBoxColumn.Name = "kodpocztowyDataGridViewTextBoxColumn";
			// 
			// numerulicyDataGridViewTextBoxColumn
			// 
			this.numerulicyDataGridViewTextBoxColumn.DataPropertyName = "numer_ulicy";
			this.numerulicyDataGridViewTextBoxColumn.HeaderText = "numer_ulicy";
			this.numerulicyDataGridViewTextBoxColumn.Name = "numerulicyDataGridViewTextBoxColumn";
			// 
			// adresBindingSource
			// 
			this.adresBindingSource.DataMember = "adres";
			this.adresBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// adresTableAdapter
			// 
			this.adresTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(613, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ulica";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(613, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Miasto";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(613, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Kod Pocztowy";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(613, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Numer ulicy";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(587, 341);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Zapisz";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(681, 341);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Usuń";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "ulica", true));
			this.textBox1.Location = new System.Drawing.Point(609, 62);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "miasto", true));
			this.textBox2.Location = new System.Drawing.Point(609, 122);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "kod_pocztowy", true));
			this.textBox3.Location = new System.Drawing.Point(609, 193);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "numer_ulicy", true));
			this.textBox4.Location = new System.Drawing.Point(609, 251);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(630, 291);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 17);
			this.label5.TabIndex = 11;
			// 
			// Adres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Adres";
			this.Text = "Adres";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Osoba_FormClosing);
			this.Load += new System.EventHandler(this.Adres_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource adresBindingSource;
		private DataSet1TableAdapters.adresTableAdapter adresTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kodpocztowyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numerulicyDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
	}
}