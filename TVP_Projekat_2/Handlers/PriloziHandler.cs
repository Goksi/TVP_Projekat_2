using Restoran.Forms;
using Restoran.Storage;
using System;
using System.Windows.Forms;

namespace Restoran.Handlers
{
    internal class PriloziHandler : RestoranEventHandler
    {
        private readonly ListBox priloziListBox;
        private readonly Button dodajPrilogBtn;
        private readonly IDataStorage storage;

        public PriloziHandler(ListBox priloziListBox, Button dodajPrilogBtn, IDataStorage storage)
        {
            this.priloziListBox = priloziListBox;
            this.dodajPrilogBtn = dodajPrilogBtn;
            this.storage = storage;

            dodajPrilogBtn.Click += HandleDodajPrilog;
        }

        public void Initialize()
        {
            priloziListBox.DataSource = storage.GetPrilozi();
        }

        private void HandleDodajPrilog(object sender, EventArgs e)
        {
            dodajPrilogBtn.Enabled = false;
            DodajPrilogForm forma = new DodajPrilogForm(storage);
            forma.Show();
            forma.FormClosing += (obj, args) =>
            {
                dodajPrilogBtn.Enabled = true;
                this.Initialize();
            };
        }
    }
}
