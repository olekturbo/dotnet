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
	public partial class Oddzial : Form
	{
		public Oddzial()
		{
			InitializeComponent();
		}

		private void Oddzial_Load(object sender, EventArgs e)
		{
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.oddzial' . Możesz go przenieść lub usunąć.
			this.oddzialTableAdapter.Fill(this.dataSet1.oddzial);

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Length < 3 || textBox2.Text.Length < 3)
				label5.Text = "BLEDNE DANE!";
			else
			{
				oddzialTableAdapter.Update(dataSet1.oddzial);
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
				oddzialTableAdapter.Update(dataSet1.oddzial);
			}
		}
	}
}
