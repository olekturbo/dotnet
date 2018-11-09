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
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void Start_Load(object sender, EventArgs e)
		{

		}

		private void oddziałToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Oddzial oddzial = new Oddzial();
			oddzial.MdiParent = this;
			oddzial.Show();

		}

		private void stanowiskoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Stanowisko stanowisko = new Stanowisko();
			stanowisko.MdiParent = this;
			stanowisko.Show();

		}

		private void pracownikToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Pracownik pracownik = new Pracownik();
			pracownik.MdiParent = this;
			pracownik.Show();

		}

		private void stanowiskoPracownikaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StanowiskoPracownika stanowiskoPracownika = new StanowiskoPracownika();
			stanowiskoPracownika.MdiParent = this;
			stanowiskoPracownika.Show();
		}

		private void Adres_Click(object sender, EventArgs e)
		{
			Adres adres = new Adres();
			adres.MdiParent = this;
			adres.Show();
		}

		private void stanowiskoPracownikaToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			StanowiskoPracownika stanowiskoPracownika = new StanowiskoPracownika();
			stanowiskoPracownika.MdiParent = this;
			stanowiskoPracownika.Show();
		}
	}
}
