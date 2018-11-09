using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
	public partial class Pracownik : Form
	{
		public Pracownik()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Pracownik_Load(object sender, EventArgs e)
		{
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet11.adres' . Możesz go przenieść lub usunąć.
			this.adresTableAdapter.Fill(this.dataSet11.adres);
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet11.oddzial' . Możesz go przenieść lub usunąć.
			this.oddzialTableAdapter.Fill(this.dataSet11.oddzial);
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet11.pracownik' . Możesz go przenieść lub usunąć.
			this.pracownikTableAdapter.Fill(this.dataSet11.pracownik);

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//sprawdza czy jest zaznaczony wiersz
			if (dataGridView1.CurrentRow != null)
			{
				dataGridView1.CurrentRow.Selected = true;
				//usuwa zaznaczony wiersz
				dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
				label8.Text = "USUNIETO!";
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void btnZapisz_Click(object sender, EventArgs e)
		{
			//aktualizuje bazę o wpisy w
			if (txtImie.Text.Length < 3 || txtNazwisko.Text.Length < 3 || dateTimePicker1.Value.ToString() == "" || dateTimePicker1.Value >= DateTime.Now.Date)
				label8.Text = "BLEDNE DANE!";
			else
			{
				pracownikTableAdapter.Update(dataSet11.pracownik);
				label8.Text = "ZAPISANO!";
			}
		}

		private void Osoba_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?",
			"UWAGA!!!", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				pracownikTableAdapter.Update(dataSet11.pracownik);
			}
		}

	}
}
