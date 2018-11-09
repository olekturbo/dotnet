namespace Crud
{
	partial class StanowiskoPracownika
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
			this.stanowiskopracownikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.stanowisko_pracownikaTableAdapter = new Crud.DataSet1TableAdapters.stanowisko_pracownikaTableAdapter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.stanowiskopracownikaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.stanowiskopracownikaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.stanowiskoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.stanowiskoTableAdapter = new Crud.DataSet1TableAdapters.stanowiskoTableAdapter();
			this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pracownikTableAdapter = new Crud.DataSet1TableAdapters.pracownikTableAdapter();
			this.idstanowiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.zapiszBtn = new System.Windows.Forms.Button();
			this.usunBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskopracownikaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskopracownikaBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskopracownikaBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// stanowiskopracownikaBindingSource
			// 
			this.stanowiskopracownikaBindingSource.DataMember = "stanowisko_pracownika";
			this.stanowiskopracownikaBindingSource.DataSource = this.dataSet1;
			// 
			// stanowisko_pracownikaTableAdapter
			// 
			this.stanowisko_pracownikaTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstanowiskoDataGridViewTextBoxColumn,
            this.idpracownikDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.stanowiskopracownikaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(536, 370);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// stanowiskopracownikaBindingSource1
			// 
			this.stanowiskopracownikaBindingSource1.DataMember = "stanowisko_pracownika";
			this.stanowiskopracownikaBindingSource1.DataSource = this.dataSet1;
			// 
			// stanowiskopracownikaBindingSource2
			// 
			this.stanowiskopracownikaBindingSource2.DataMember = "stanowisko_pracownika";
			this.stanowiskopracownikaBindingSource2.DataSource = this.dataSet1;
			// 
			// stanowiskoBindingSource
			// 
			this.stanowiskoBindingSource.DataMember = "stanowisko";
			this.stanowiskoBindingSource.DataSource = this.dataSet1;
			// 
			// stanowiskoTableAdapter
			// 
			this.stanowiskoTableAdapter.ClearBeforeFill = true;
			// 
			// pracownikBindingSource
			// 
			this.pracownikBindingSource.DataMember = "pracownik";
			this.pracownikBindingSource.DataSource = this.dataSet1;
			// 
			// pracownikTableAdapter
			// 
			this.pracownikTableAdapter.ClearBeforeFill = true;
			// 
			// idstanowiskoDataGridViewTextBoxColumn
			// 
			this.idstanowiskoDataGridViewTextBoxColumn.DataPropertyName = "id_stanowisko";
			this.idstanowiskoDataGridViewTextBoxColumn.DataSource = this.stanowiskoBindingSource;
			this.idstanowiskoDataGridViewTextBoxColumn.DisplayMember = "nazwa";
			this.idstanowiskoDataGridViewTextBoxColumn.HeaderText = "id_stanowisko";
			this.idstanowiskoDataGridViewTextBoxColumn.Name = "idstanowiskoDataGridViewTextBoxColumn";
			this.idstanowiskoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.idstanowiskoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.idstanowiskoDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// idpracownikDataGridViewTextBoxColumn
			// 
			this.idpracownikDataGridViewTextBoxColumn.DataPropertyName = "id_pracownik";
			this.idpracownikDataGridViewTextBoxColumn.DataSource = this.pracownikBindingSource;
			this.idpracownikDataGridViewTextBoxColumn.DisplayMember = "nazwisko";
			this.idpracownikDataGridViewTextBoxColumn.HeaderText = "id_pracownik";
			this.idpracownikDataGridViewTextBoxColumn.Name = "idpracownikDataGridViewTextBoxColumn";
			this.idpracownikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.idpracownikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.idpracownikDataGridViewTextBoxColumn.ValueMember = "id";
			// 
			// zapiszBtn
			// 
			this.zapiszBtn.Location = new System.Drawing.Point(570, 105);
			this.zapiszBtn.Name = "zapiszBtn";
			this.zapiszBtn.Size = new System.Drawing.Size(75, 23);
			this.zapiszBtn.TabIndex = 1;
			this.zapiszBtn.Text = "Zapisz";
			this.zapiszBtn.UseVisualStyleBackColor = true;
			this.zapiszBtn.Click += new System.EventHandler(this.zapiszBtn_Click);
			// 
			// usunBtn
			// 
			this.usunBtn.Location = new System.Drawing.Point(570, 170);
			this.usunBtn.Name = "usunBtn";
			this.usunBtn.Size = new System.Drawing.Size(75, 23);
			this.usunBtn.TabIndex = 2;
			this.usunBtn.Text = "Usuń";
			this.usunBtn.UseVisualStyleBackColor = true;
			this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(620, 216);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 3;
			// 
			// StanowiskoPracownika
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 454);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usunBtn);
			this.Controls.Add(this.zapiszBtn);
			this.Controls.Add(this.dataGridView1);
			this.Name = "StanowiskoPracownika";
			this.Text = "StanowiskoPracownika";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Osoba_FormClosing);
			this.Load += new System.EventHandler(this.StanowiskoPracownika_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskopracownikaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskopracownikaBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskopracownikaBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stanowiskoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource stanowiskopracownikaBindingSource;
		private DataSet1TableAdapters.stanowisko_pracownikaTableAdapter stanowisko_pracownikaTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource stanowiskopracownikaBindingSource1;
		private System.Windows.Forms.BindingSource stanowiskopracownikaBindingSource2;
		private System.Windows.Forms.BindingSource stanowiskoBindingSource;
		private DataSet1TableAdapters.stanowiskoTableAdapter stanowiskoTableAdapter;
		private System.Windows.Forms.BindingSource pracownikBindingSource;
		private DataSet1TableAdapters.pracownikTableAdapter pracownikTableAdapter;
		private System.Windows.Forms.DataGridViewComboBoxColumn idstanowiskoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn idpracownikDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button zapiszBtn;
		private System.Windows.Forms.Button usunBtn;
		private System.Windows.Forms.Label label1;
	}
}