namespace Crud
{
	partial class Pracownik
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
			this.dataSet1 = new Crud.DataSet1();
			this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.oddzialBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet11 = new Crud.DataSet1();
			this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pracownikTableAdapter = new Crud.DataSet1TableAdapters.pracownikTableAdapter();
			this.oddzialTableAdapter = new Crud.DataSet1TableAdapters.oddzialTableAdapter();
			this.adresTableAdapter = new Crud.DataSet1TableAdapters.adresTableAdapter();
			this.btnUsun = new System.Windows.Forms.Button();
			this.btnZapisz = new System.Windows.Forms.Button();
			this.txtImie = new System.Windows.Forms.TextBox();
			this.txtNazwisko = new System.Windows.Forms.TextBox();
			this.cmbOddzial = new System.Windows.Forms.ComboBox();
			this.cmbAdres = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oddzialidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.adresidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.notatkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oddzialBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataSet1BindingSource
			// 
			this.dataSet1BindingSource.DataSource = this.dataSet1;
			this.dataSet1BindingSource.Position = 0;
			// 
			// oddzialBindingSource
			// 
			this.oddzialBindingSource.DataMember = "oddzial";
			this.oddzialBindingSource.DataSource = this.dataSet11BindingSource;
			// 
			// dataSet11BindingSource
			// 
			this.dataSet11BindingSource.DataSource = this.dataSet11;
			this.dataSet11BindingSource.Position = 0;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// adresBindingSource
			// 
			this.adresBindingSource.DataMember = "adres";
			this.adresBindingSource.DataSource = this.dataSet11BindingSource;
			// 
			// pracownikBindingSource
			// 
			this.pracownikBindingSource.DataMember = "pracownik";
			this.pracownikBindingSource.DataSource = this.dataSet11;
			// 
			// pracownikTableAdapter
			// 
			this.pracownikTableAdapter.ClearBeforeFill = true;
			// 
			// oddzialTableAdapter
			// 
			this.oddzialTableAdapter.ClearBeforeFill = true;
			// 
			// adresTableAdapter
			// 
			this.adresTableAdapter.ClearBeforeFill = true;
			// 
			// btnUsun
			// 
			this.btnUsun.Location = new System.Drawing.Point(1136, 352);
			this.btnUsun.Name = "btnUsun";
			this.btnUsun.Size = new System.Drawing.Size(87, 39);
			this.btnUsun.TabIndex = 1;
			this.btnUsun.Text = "Usuń";
			this.btnUsun.UseVisualStyleBackColor = true;
			this.btnUsun.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnZapisz
			// 
			this.btnZapisz.Location = new System.Drawing.Point(964, 352);
			this.btnZapisz.Name = "btnZapisz";
			this.btnZapisz.Size = new System.Drawing.Size(87, 39);
			this.btnZapisz.TabIndex = 2;
			this.btnZapisz.Text = "Zapisz";
			this.btnZapisz.UseVisualStyleBackColor = true;
			this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
			// 
			// txtImie
			// 
			this.txtImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "imie", true));
			this.txtImie.Location = new System.Drawing.Point(1145, 41);
			this.txtImie.Name = "txtImie";
			this.txtImie.Size = new System.Drawing.Size(121, 22);
			this.txtImie.TabIndex = 3;
			// 
			// txtNazwisko
			// 
			this.txtNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "nazwisko", true));
			this.txtNazwisko.Location = new System.Drawing.Point(1145, 81);
			this.txtNazwisko.Name = "txtNazwisko";
			this.txtNazwisko.Size = new System.Drawing.Size(121, 22);
			this.txtNazwisko.TabIndex = 4;
			// 
			// cmbOddzial
			// 
			this.cmbOddzial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pracownikBindingSource, "oddzial_id", true));
			this.cmbOddzial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "oddzial_id", true));
			this.cmbOddzial.DataSource = this.oddzialBindingSource;
			this.cmbOddzial.DisplayMember = "nazwa";
			this.cmbOddzial.FormattingEnabled = true;
			this.cmbOddzial.Location = new System.Drawing.Point(1145, 121);
			this.cmbOddzial.Name = "cmbOddzial";
			this.cmbOddzial.Size = new System.Drawing.Size(121, 24);
			this.cmbOddzial.TabIndex = 5;
			this.cmbOddzial.ValueMember = "nazwa";
			this.cmbOddzial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// cmbAdres
			// 
			this.cmbAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "adres_id", true));
			this.cmbAdres.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pracownikBindingSource, "adres_id", true));
			this.cmbAdres.DataSource = this.adresBindingSource;
			this.cmbAdres.DisplayMember = "miasto";
			this.cmbAdres.FormattingEnabled = true;
			this.cmbAdres.Location = new System.Drawing.Point(1145, 166);
			this.cmbAdres.Name = "cmbAdres";
			this.cmbAdres.Size = new System.Drawing.Size(121, 24);
			this.cmbAdres.TabIndex = 6;
			this.cmbAdres.ValueMember = "miasto";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "data_ur", true));
			this.dateTimePicker1.Location = new System.Drawing.Point(1089, 252);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1008, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Imię";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1008, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nazwisko";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1008, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Oddział";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1008, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Adres";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(946, 252);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Data urodzenia";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.oddzialidDataGridViewTextBoxColumn,
            this.adresidDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataurDataGridViewTextBoxColumn,
            this.notatkaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.pracownikBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(837, 395);
			this.dataGridView1.TabIndex = 13;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// oddzialidDataGridViewTextBoxColumn
			// 
			this.oddzialidDataGridViewTextBoxColumn.DataPropertyName = "oddzial_id";
			this.oddzialidDataGridViewTextBoxColumn.DataSource = this.oddzialBindingSource;
			this.oddzialidDataGridViewTextBoxColumn.DisplayMember = "nazwa";
			this.oddzialidDataGridViewTextBoxColumn.HeaderText = "oddzial_id";
			this.oddzialidDataGridViewTextBoxColumn.Name = "oddzialidDataGridViewTextBoxColumn";
			this.oddzialidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.oddzialidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.oddzialidDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// adresidDataGridViewTextBoxColumn
			// 
			this.adresidDataGridViewTextBoxColumn.DataPropertyName = "adres_id";
			this.adresidDataGridViewTextBoxColumn.DataSource = this.adresBindingSource;
			this.adresidDataGridViewTextBoxColumn.DisplayMember = "miasto";
			this.adresidDataGridViewTextBoxColumn.HeaderText = "adres_id";
			this.adresidDataGridViewTextBoxColumn.Name = "adresidDataGridViewTextBoxColumn";
			this.adresidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.adresidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.adresidDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// imieDataGridViewTextBoxColumn
			// 
			this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
			this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
			this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
			// 
			// nazwiskoDataGridViewTextBoxColumn
			// 
			this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
			this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
			this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
			// 
			// dataurDataGridViewTextBoxColumn
			// 
			this.dataurDataGridViewTextBoxColumn.DataPropertyName = "data_ur";
			this.dataurDataGridViewTextBoxColumn.HeaderText = "data_ur";
			this.dataurDataGridViewTextBoxColumn.Name = "dataurDataGridViewTextBoxColumn";
			// 
			// notatkaDataGridViewTextBoxColumn
			// 
			this.notatkaDataGridViewTextBoxColumn.DataPropertyName = "notatka";
			this.notatkaDataGridViewTextBoxColumn.HeaderText = "notatka";
			this.notatkaDataGridViewTextBoxColumn.Name = "notatkaDataGridViewTextBoxColumn";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(782, 311);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 17);
			this.label6.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1008, 209);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "Notatka";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "notatka", true));
			this.textBox1.Location = new System.Drawing.Point(1145, 206);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 22);
			this.textBox1.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(932, 297);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 17);
			this.label8.TabIndex = 17;
			// 
			// Pracownik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1301, 430);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cmbAdres);
			this.Controls.Add(this.cmbOddzial);
			this.Controls.Add(this.txtNazwisko);
			this.Controls.Add(this.txtImie);
			this.Controls.Add(this.btnZapisz);
			this.Controls.Add(this.btnUsun);
			this.Name = "Pracownik";
			this.Text = "Pracownik";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Osoba_FormClosing);
			this.Load += new System.EventHandler(this.Pracownik_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.oddzialBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource dataSet1BindingSource;
		private System.Windows.Forms.BindingSource dataSet11BindingSource;
		private DataSet1 dataSet11;
		private System.Windows.Forms.BindingSource pracownikBindingSource;
		private DataSet1TableAdapters.pracownikTableAdapter pracownikTableAdapter;
		private System.Windows.Forms.BindingSource oddzialBindingSource;
		private DataSet1TableAdapters.oddzialTableAdapter oddzialTableAdapter;
		private System.Windows.Forms.BindingSource adresBindingSource;
		private DataSet1TableAdapters.adresTableAdapter adresTableAdapter;
		private System.Windows.Forms.Button btnUsun;
		private System.Windows.Forms.Button btnZapisz;
		private System.Windows.Forms.TextBox txtImie;
		private System.Windows.Forms.TextBox txtNazwisko;
		private System.Windows.Forms.ComboBox cmbOddzial;
		private System.Windows.Forms.ComboBox cmbAdres;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn oddzialidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn adresidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataurDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn notatkaDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
	}
}