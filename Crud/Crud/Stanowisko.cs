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
	public partial class Stanowisko : Form
	{
		public Stanowisko()
		{
			InitializeComponent();
		}

		private void Stanowisko_Load(object sender, EventArgs e)
		{
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.stanowisko_pracownika' . Możesz go przenieść lub usunąć.
			this.stanowisko_pracownikaTableAdapter.Fill(this.dataSet1.stanowisko_pracownika);
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.stanowisko_pracownika' . Możesz go przenieść lub usunąć.
			this.stanowisko_pracownikaTableAdapter.Fill(this.dataSet1.stanowisko_pracownika);
			// TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.stanowisko' . Możesz go przenieść lub usunąć.
			this.stanowiskoTableAdapter.Fill(this.dataSet1.stanowisko);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Length < 3 || textBox2.Text.Length < 4)
				label5.Text = "BLEDNE DANE!";
			else
			{
				stanowiskoTableAdapter.Update(dataSet1.stanowisko);
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
				stanowiskoTableAdapter.Update(dataSet1.stanowisko);
			}
		}
	}
}
