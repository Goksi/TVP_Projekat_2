﻿using Restoran.Entiteti;
using Restoran.Handlers;
using Restoran.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restoran.Forms
{
    public partial class MainForm : Form
    {
        private IDataStorage storage;
        private IDictionary<string, RestoranEventHandler> handlers;
        private Racun trenutniRacun;
        public MainForm()
        {
            InitializeComponent();
            storage = new MicrosoftAccessImpl();
            InitHandlers();
            handlers["porucivanjeTab"].Initialize();
            trenutniRacun = new Racun();

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
                { "porucivanjeTab", new PorucivanjeHandler(jelaListBox, priloziGroupBox, jeloContext, filterNazivTb, cenaRastuceCb, cenaOpadajuceCb, storage) },
                { "priloziTab", new PriloziHandler(priloziListBox, dodajPrilogBtn, storage) },
                {"racuniTab", new RacuniHandler(racuniListBox, stavkeListBox, odTimePicker, doTimePicker,resetBtn, filterDatumBtn, storage)}
            };
        }

        private void HandleDodajJelo(object sender, EventArgs e)
        {
            var selected = jelaListBox.SelectedItem;
            if (selected == null)
            {
                MessageBox.Show("Morate izabrati jedno jelo !", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Jelo jelo = selected as Jelo;
            Prilog prilog = null;
            foreach (var control in priloziGroupBox.Controls)
            {
                if (!(control is CheckBox cb)) return;
                if (cb.Checked)
                {
                    prilog = cb.Tag as Prilog;
                    break;
                }
            }
            trenutniRacun.DodajStavku(jelo, prilog);
            jelaListBox.SelectedIndex = -1;
            RefreshRacun();
        }

        private void HandleRacunListDraw(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.DrawBackground();
            e.Graphics.DrawString(racunListBox.Items[e.Index].ToString(),
                e.Font, new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void HandleRacunMeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.ItemHeight = 13;
            ListBox listBox = sender as ListBox;
            string text = listBox.Items[e.Index].ToString();
            int count = text.Split('\n').Length;
            e.ItemHeight = count * 15;
        }

        private void RefreshRacun()
        {
            racunListBox.DataSource = trenutniRacun.GetDisplay();
            racunCenaLbl.Text = $"{trenutniRacun.UkupnaCena} din";
        }

        private void HandleObnoviRacun(object sender, EventArgs e)
        {
            trenutniRacun = new Racun();
            RefreshRacun();
        }

        private void HandleRacunContextOpen(object sender, MouseEventArgs e)
        {
            racunContext.Items[0].Enabled = true;
            if (e.Button != MouseButtons.Right) return;
            var listBoxIndex = racunListBox.IndexFromPoint(e.Location);
            if (listBoxIndex < 0 || listBoxIndex == 65535)
            {
                racunContext.Items[0].Enabled = false;
            }
            else racunListBox.SelectedIndex = listBoxIndex;
            racunContext.Show(racunListBox, e.Location);
        }

        private void HandleRacunContextClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == racunContext.Items[0])
            {
                var stavkaDisplay = racunListBox.SelectedItem as StavkaDisplay;
                trenutniRacun.ObrisiStavku(stavkaDisplay.Stavka);
                RefreshRacun();
                racunListBox.SelectedIndex = -1;
            }
        }

        private void HandleIzdajRacun(object sender, EventArgs e)
        {
            if (trenutniRacun.IsEmpty())
            {
                MessageBox.Show("Ne mozete izdati prazan racun !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = storage.DodajRacun(trenutniRacun);
            if (result == -1) return;
            MessageBox.Show("Racun je uspesno izdat !", "Uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            trenutniRacun = new Racun();
            RefreshRacun();
        }
    }
}
