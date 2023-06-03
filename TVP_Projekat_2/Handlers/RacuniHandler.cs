using Restoran.Entiteti;
using Restoran.Storage;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restoran.Handlers
{
    internal class RacuniHandler : RestoranEventHandler
    {
        private readonly ListBox racunListBox;
        private readonly ListBox stavkeListBox;
        private readonly IDataStorage storage;

        public RacuniHandler(ListBox racunListBox, ListBox stavkeListBox, IDataStorage storage)
        {
            this.racunListBox = racunListBox;
            this.stavkeListBox = stavkeListBox;
            this.storage = storage;
            racunListBox.SelectedIndexChanged += HandleIndexChange;
            stavkeListBox.DrawItem += HandleRacunListDraw;
            stavkeListBox.MeasureItem += HandleRacunMeasureItem;
        }

        public void Initialize()
        {
            racunListBox.DataSource = storage.GetRacuni();
        }

        private void HandleIndexChange(object sender, EventArgs e)
        {
            var selected = racunListBox.SelectedItem;
            if (selected != null)
            {
                Racun racun = selected as Racun;
                stavkeListBox.DataSource = racun.GetDisplay();
            }
        }

        private void HandleRacunListDraw(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.DrawBackground();
            e.Graphics.DrawString(stavkeListBox.Items[e.Index].ToString(),
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
    }
}
