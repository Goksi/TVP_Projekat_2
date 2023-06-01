using Restoran.Entiteti;
using Restoran.Forms;
using Restoran.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restoran.Handlers
{
    internal class PorucivanjeHandler : RestoranEventHandler
    {
        private readonly ListBox jelaListBox;
        private readonly GroupBox piloziGroupBox;
        private readonly ContextMenuStrip jeloContext;
        private readonly IDataStorage storage;
        private bool otvorenMenu = false;

        public PorucivanjeHandler(ListBox jelaListBox, GroupBox piloziGroupBox, ContextMenuStrip jeloContext, IDataStorage storage)
        {
            this.jelaListBox = jelaListBox;
            this.piloziGroupBox = piloziGroupBox;
            this.storage = storage;
            this.jeloContext = jeloContext;

            jelaListBox.MouseUp += HandleContextOpen;
            jeloContext.ItemClicked += HandleContextClick;
            jelaListBox.SelectedIndexChanged += HandleJeloLbChange;

        }

        public void Initialize()
        {
            jelaListBox.DataSource = storage.GetJela();
            jelaListBox.SelectedIndex = -1;
        }

        private void HandleContextOpen(object sender, MouseEventArgs e)
        {
            jeloContext.Items[0].Enabled = true;
            if (e.Button != MouseButtons.Right) return;
            if (otvorenMenu) jeloContext.Items[0].Enabled = false;
            jeloContext.Show(jelaListBox, e.Location);
        }

        private void HandleContextClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Dodaj jelo")
            {
                otvorenMenu = true;
                DodajJeloForm forma = new DodajJeloForm(storage);
                forma.FormClosing += (obj, args) =>
                {
                    otvorenMenu = false;
                    jelaListBox.DataSource = storage.GetJela();
                };

                forma.Show();
            }
        }

        private void HandleJeloLbChange(object sender, EventArgs e)
        {
            piloziGroupBox.Controls.Clear();
            if (jelaListBox.SelectedIndex == -1) return;
            Jelo jelo = jelaListBox.SelectedItem as Jelo;
            if (jelo == null) return;
            IList<Prilog> prilozi = jelo.MoguciPrilozi;
            int x = 10;
            int y = 20;
            foreach (Prilog prilog in prilozi)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Tag = prilog;
                checkBox.Text = prilog.Naziv;
                checkBox.AutoSize = true;
                checkBox.Location = new Point(x, y);
                checkBox.Click += (obj, args) =>
                {
                    CheckBox current = obj as CheckBox;
                    if (current.Checked)
                    {
                        foreach (var control in piloziGroupBox.Controls)
                        {
                            CheckBox box = control as CheckBox;
                            if (!box.Checked) box.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (var control in piloziGroupBox.Controls)
                        {
                            CheckBox box = control as CheckBox;
                            box.Enabled = true;
                        }
                    }
                };
                piloziGroupBox.Controls.Add(checkBox);
                y += checkBox.Height + 5;
                if (y > piloziGroupBox.Height - checkBox.Height)
                {
                    y = 20;
                    x += checkBox.Width;
                }
            }
        }
    }
}
