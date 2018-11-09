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
	public partial class Adres : Form
	{
		public Adres()
		{
			InitializeComponent();
		}

		private void Adres_Load(object sender, EventArgs e)
		{
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.adres' . Możesz go przenieść lub usunąć.
			this.adresTableAdapter.Fill(this.dataSet1.adres);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Length < 3 || textBox2.Text.Length < 3 || textBox3.Text.Length < 6 || textBox3.Text.Length < 1)
				label5.Text = "BLEDNE DANE!";
			else
			{
				adresTableAdapter.Update(dataSet1.adres);
				label5.Text = "ZAPISANO!";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				dataGridView1.CurrentRow.Selected = true;
				//usuwa zaznaczony wiersz
				dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
				label5.Text = "USUNIETO!";

			}
		}

		private void Osoba_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?",
			"UWAGA!!!", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				adresTableAdapter.Update(dataSet1.adres);
			}
		}
	}
}
