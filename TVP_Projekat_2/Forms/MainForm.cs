using Restoran.Handlers;
using Restoran.Storage;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restoran.Forms
{
    public partial class MainForm : Form
    {
        private IDataStorage storage;
        private IDictionary<string, RestoranEventHandler> handlers;
        public MainForm()
        {
            InitializeComponent();
            storage = new MicrosoftAccessImpl();
            InitHandlers();
            handlers["porucivanjeTab"].Initialize();
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            storage.Close();
        }

        private void HandleTabIndexChange(object sender, EventArgs e)
        {
            var currentTab = tabControl1.SelectedTab;
            if (handlers.TryGetValue(currentTab.Name, out var handler))
            {
                handler.Initialize();
            }

        }

        private void InitHandlers()
        {
            handlers = new Dictionary<string, RestoranEventHandler>
            {
                { "porucivanjeTab", new PorucivanjeHandler(jelaListBox, priloziGroupBox, jeloContext, storage) },
                { "priloziTab", new PriloziHandler(priloziListBox, dodajPrilogBtn, storage) }
            };
        }
    }
}
