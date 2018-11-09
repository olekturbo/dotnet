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
	public partial class StanowiskoPracownika : Form
	{
		public StanowiskoPracownika()
		{
			InitializeComponent();
		}

		private void StanowiskoPracownika_Load(object sender, EventArgs e)
		{
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.pracownik' . Możesz go przenieść lub usunąć.
			this.pracownikTableAdapter.Fill(this.dataSet1.pracownik);
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.pracownik' . Możesz go przenieść lub usunąć.
			this.pracownikTableAdapter.Fill(this.dataSet1.pracownik);
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.stanowisko' . Możesz go przenieść lub usunąć.
			this.stanowiskoTableAdapter.Fill(this.dataSet1.stanowisko);
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.stanowisko_pracownika' . Możesz go przenieść lub usunąć.
			this.stanowisko_pracownikaTableAdapter.Fill(this.dataSet1.stanowisko_pracownika);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void zapiszBtn_Click(object sender, EventArgs e)
		{
			stanowisko_pracownikaTableAdapter.Update(dataSet1.stanowisko_pracownika);
			label1.Text = "ZAPISANO!";
			
		}

		private void usunBtn_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				dataGridView1.CurrentRow.Selected = true;
				//usuwa zaznaczony wiersz
				dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
				label1.Text = "USUNIETO!";
			}
		}
		private void Osoba_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?",
			"UWAGA!!!", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				stanowisko_pracownikaTableAdapter.Update(dataSet1.stanowisko_pracownika);
			}
		}
	}
}
