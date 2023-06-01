using Restoran.Storage;
using System;
using System.Windows.Forms;

namespace Restoran.Forms
{
    public partial class DodajPrilogForm : Form
    {
        private readonly IDataStorage storage;
        public DodajPrilogForm(IDataStorage storage)
        {
            InitializeComponent();
            this.storage = storage;
        }

        private void HandleClick(object sender, EventArgs e)
        {
            string naziv = nazivTb.Text;
            if (naziv.Length < 3)
            {
                MessageBox.Show("Naziv mora imati najmanje 3 karaktera !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cenaTb.Text, out int cena) || cena < 0)
            {
                MessageBox.Show("Cena mora biti pozitivan ceo broj !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = storage.DodajPrilog(naziv, cena);
            if (result != -1)
            {
                MessageBox.Show("Uspesno ste dodali novi prilog !", "Uspeh !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
