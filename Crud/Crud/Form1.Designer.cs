namespace Crud
{
	partial class Start
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tabeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oddziałToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stanowiskoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pracownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Adres = new System.Windows.Forms.ToolStripMenuItem();
			this.stanowiskoPracownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabeleToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tabeleToolStripMenuItem
			// 
			this.tabeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oddziałToolStripMenuItem,
            this.stanowiskoToolStripMenuItem,
            this.pracownikToolStripMenuItem,
            this.Adres,
            this.stanowiskoPracownikaToolStripMenuItem});
			this.tabeleToolStripMenuItem.Name = "tabeleToolStripMenuItem";
			this.tabeleToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.tabeleToolStripMenuItem.Text = "Tabele";
			// 
			// oddziałToolStripMenuItem
			// 
			this.oddziałToolStripMenuItem.Name = "oddziałToolStripMenuItem";
			this.oddziałToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.oddziałToolStripMenuItem.Text = "Oddział";
			this.oddziałToolStripMenuItem.Click += new System.EventHandler(this.oddziałToolStripMenuItem_Click);
			// 
			// stanowiskoToolStripMenuItem
			// 
			this.stanowiskoToolStripMenuItem.Name = "stanowiskoToolStripMenuItem";
			this.stanowiskoToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.stanowiskoToolStripMenuItem.Text = "Stanowisko";
			this.stanowiskoToolStripMenuItem.Click += new System.EventHandler(this.stanowiskoToolStripMenuItem_Click);
			// 
			// pracownikToolStripMenuItem
			// 
			this.pracownikToolStripMenuItem.Name = "pracownikToolStripMenuItem";
			this.pracownikToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.pracownikToolStripMenuItem.Text = "Pracownik";
			this.pracownikToolStripMenuItem.Click += new System.EventHandler(this.pracownikToolStripMenuItem_Click);
			// 
			// Adres
			// 
			this.Adres.Name = "Adres";
			this.Adres.Size = new System.Drawing.Size(238, 26);
			this.Adres.Text = "Adres";
			this.Adres.Click += new System.EventHandler(this.Adres_Click);
			// 
			// stanowiskoPracownikaToolStripMenuItem
			// 
			this.stanowiskoPracownikaToolStripMenuItem.Name = "stanowiskoPracownikaToolStripMenuItem";
			this.stanowiskoPracownikaToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.stanowiskoPracownikaToolStripMenuItem.Text = "Stanowisko Pracownika";
			this.stanowiskoPracownikaToolStripMenuItem.Click += new System.EventHandler(this.stanowiskoPracownikaToolStripMenuItem_Click_1);
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Start";
			this.Text = "CRUD";
			this.Load += new System.EventHandler(this.Start_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tabeleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oddziałToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stanowiskoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pracownikToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Adres;
		private System.Windows.Forms.ToolStripMenuItem stanowiskoPracownikaToolStripMenuItem;
	}
}

