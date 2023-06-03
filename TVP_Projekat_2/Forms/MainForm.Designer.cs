namespace Restoran.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.porucivanjeTab = new System.Windows.Forms.TabPage();
            this.dodajJeloBtn = new System.Windows.Forms.Button();
            this.priloziGroupBox = new System.Windows.Forms.GroupBox();
            this.jelaListBox = new System.Windows.Forms.ListBox();
            this.priloziTab = new System.Windows.Forms.TabPage();
            this.dodajPrilogBtn = new System.Windows.Forms.Button();
            this.priloziListBox = new System.Windows.Forms.ListBox();
            this.racuniTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stavkeListBox = new System.Windows.Forms.ListBox();
            this.racuniListBox = new System.Windows.Forms.ListBox();
            this.statistikaTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.racunListBox = new System.Windows.Forms.ListBox();
            this.izdajRacunBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.racunCenaLbl = new System.Windows.Forms.Label();
            this.jeloContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajJeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiRacunBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.racunContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrisiStavkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cenaRastuceCb = new System.Windows.Forms.CheckBox();
            this.cenaOpadajuceCb = new System.Windows.Forms.CheckBox();
            this.filterNazivTb = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.porucivanjeTab.SuspendLayout();
            this.priloziTab.SuspendLayout();
            this.racuniTab.SuspendLayout();
            this.jeloContext.SuspendLayout();
            this.racunContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.porucivanjeTab);
            this.tabControl1.Controls.Add(this.priloziTab);
            this.tabControl1.Controls.Add(this.racuniTab);
            this.tabControl1.Controls.Add(this.statistikaTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 411);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.HandleTabIndexChange);
            // 
            // porucivanjeTab
            // 
            this.porucivanjeTab.Controls.Add(this.filterNazivTb);
            this.porucivanjeTab.Controls.Add(this.cenaOpadajuceCb);
            this.porucivanjeTab.Controls.Add(this.cenaRastuceCb);
            this.porucivanjeTab.Controls.Add(this.dodajJeloBtn);
            this.porucivanjeTab.Controls.Add(this.priloziGroupBox);
            this.porucivanjeTab.Controls.Add(this.jelaListBox);
            this.porucivanjeTab.Location = new System.Drawing.Point(4, 22);
            this.porucivanjeTab.Name = "porucivanjeTab";
            this.porucivanjeTab.Padding = new System.Windows.Forms.Padding(3);
            this.porucivanjeTab.Size = new System.Drawing.Size(708, 385);
            this.porucivanjeTab.TabIndex = 0;
            this.porucivanjeTab.Text = "Porucivanje";
            this.porucivanjeTab.UseVisualStyleBackColor = true;
            // 
            // dodajJeloBtn
            // 
            this.dodajJeloBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajJeloBtn.Location = new System.Drawing.Point(324, 154);
            this.dodajJeloBtn.Name = "dodajJeloBtn";
            this.dodajJeloBtn.Size = new System.Drawing.Size(87, 59);
            this.dodajJeloBtn.TabIndex = 2;
            this.dodajJeloBtn.Text = "Dodaj jelo na racun";
            this.dodajJeloBtn.UseVisualStyleBackColor = true;
            this.dodajJeloBtn.Click += new System.EventHandler(this.HandleDodajJelo);
            // 
            // priloziGroupBox
            // 
            this.priloziGroupBox.Location = new System.Drawing.Point(505, 7);
            this.priloziGroupBox.Name = "priloziGroupBox";
            this.priloziGroupBox.Size = new System.Drawing.Size(197, 368);
            this.priloziGroupBox.TabIndex = 1;
            this.priloziGroupBox.TabStop = false;
            this.priloziGroupBox.Text = "Prilozi";
            // 
            // jelaListBox
            // 
            this.jelaListBox.FormattingEnabled = true;
            this.jelaListBox.Location = new System.Drawing.Point(7, 7);
            this.jelaListBox.Name = "jelaListBox";
            this.jelaListBox.Size = new System.Drawing.Size(230, 368);
            this.jelaListBox.TabIndex = 0;
            // 
            // priloziTab
            // 
            this.priloziTab.Controls.Add(this.dodajPrilogBtn);
            this.priloziTab.Controls.Add(this.priloziListBox);
            this.priloziTab.Location = new System.Drawing.Point(4, 22);
            this.priloziTab.Name = "priloziTab";
            this.priloziTab.Padding = new System.Windows.Forms.Padding(3);
            this.priloziTab.Size = new System.Drawing.Size(708, 385);
            this.priloziTab.TabIndex = 1;
            this.priloziTab.Text = "Prilozi";
            this.priloziTab.UseVisualStyleBackColor = true;
            // 
            // dodajPrilogBtn
            // 
            this.dodajPrilogBtn.Location = new System.Drawing.Point(238, 7);
            this.dodajPrilogBtn.Name = "dodajPrilogBtn";
            this.dodajPrilogBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajPrilogBtn.TabIndex = 1;
            this.dodajPrilogBtn.Text = "Dodaj prilog";
            this.dodajPrilogBtn.UseVisualStyleBackColor = true;
            // 
            // priloziListBox
            // 
            this.priloziListBox.FormattingEnabled = true;
            this.priloziListBox.Location = new System.Drawing.Point(6, 6);
            this.priloziListBox.Name = "priloziListBox";
            this.priloziListBox.Size = new System.Drawing.Size(225, 368);
            this.priloziListBox.TabIndex = 0;
            // 
            // racuniTab
            // 
            this.racuniTab.Controls.Add(this.label4);
            this.racuniTab.Controls.Add(this.label3);
            this.racuniTab.Controls.Add(this.stavkeListBox);
            this.racuniTab.Controls.Add(this.racuniListBox);
            this.racuniTab.Location = new System.Drawing.Point(4, 22);
            this.racuniTab.Name = "racuniTab";
            this.racuniTab.Size = new System.Drawing.Size(708, 385);
            this.racuniTab.TabIndex = 2;
            this.racuniTab.Text = "Racuni";
            this.racuniTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stavke racuna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Racuni:";
            // 
            // stavkeListBox
            // 
            this.stavkeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.stavkeListBox.FormattingEnabled = true;
            this.stavkeListBox.Location = new System.Drawing.Point(412, 29);
            this.stavkeListBox.Name = "stavkeListBox";
            this.stavkeListBox.Size = new System.Drawing.Size(262, 329);
            this.stavkeListBox.TabIndex = 1;
            // 
            // racuniListBox
            // 
            this.racuniListBox.FormattingEnabled = true;
            this.racuniListBox.Location = new System.Drawing.Point(14, 29);
            this.racuniListBox.Name = "racuniListBox";
            this.racuniListBox.Size = new System.Drawing.Size(262, 329);
            this.racuniListBox.TabIndex = 0;
            // 
            // statistikaTab
            // 
            this.statistikaTab.Location = new System.Drawing.Point(4, 22);
            this.statistikaTab.Name = "statistikaTab";
            this.statistikaTab.Size = new System.Drawing.Size(708, 385);
            this.statistikaTab.TabIndex = 3;
            this.statistikaTab.Text = "Statistika";
            this.statistikaTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(758, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutni racun";
            // 
            // racunListBox
            // 
            this.racunListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.racunListBox.FormattingEnabled = true;
            this.racunListBox.Location = new System.Drawing.Point(745, 49);
            this.racunListBox.Name = "racunListBox";
            this.racunListBox.Size = new System.Drawing.Size(193, 342);
            this.racunListBox.TabIndex = 2;
            this.racunListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.HandleRacunListDraw);
            this.racunListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.HandleRacunMeasureItem);
            this.racunListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleRacunContextOpen);
            // 
            // izdajRacunBtn
            // 
            this.izdajRacunBtn.Location = new System.Drawing.Point(863, 397);
            this.izdajRacunBtn.Name = "izdajRacunBtn";
            this.izdajRacunBtn.Size = new System.Drawing.Size(75, 41);
            this.izdajRacunBtn.TabIndex = 3;
            this.izdajRacunBtn.Text = "Izdaj racun";
            this.izdajRacunBtn.UseVisualStyleBackColor = true;
            this.izdajRacunBtn.Click += new System.EventHandler(this.HandleIzdajRacun);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ukupna cena:";
            // 
            // racunCenaLbl
            // 
            this.racunCenaLbl.AutoSize = true;
            this.racunCenaLbl.Location = new System.Drawing.Point(763, 417);
            this.racunCenaLbl.Name = "racunCenaLbl";
            this.racunCenaLbl.Size = new System.Drawing.Size(30, 13);
            this.racunCenaLbl.TabIndex = 5;
            this.racunCenaLbl.Text = "0 din";
            this.racunCenaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jeloContext
            // 
            this.jeloContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajJeloToolStripMenuItem});
            this.jeloContext.Name = "jeloContext";
            this.jeloContext.Size = new System.Drawing.Size(128, 26);
            // 
            // dodajJeloToolStripMenuItem
            // 
            this.dodajJeloToolStripMenuItem.Name = "dodajJeloToolStripMenuItem";
            this.dodajJeloToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dodajJeloToolStripMenuItem.Text = "Dodaj jelo";
            // 
            // obrisiRacunBtn
            // 
            this.obrisiRacunBtn.Image = ((System.Drawing.Image)(resources.GetObject("obrisiRacunBtn.Image")));
            this.obrisiRacunBtn.Location = new System.Drawing.Point(908, 16);
            this.obrisiRacunBtn.Name = "obrisiRacunBtn";
            this.obrisiRacunBtn.Size = new System.Drawing.Size(30, 30);
            this.obrisiRacunBtn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.obrisiRacunBtn, "Resetuj racun");
            this.obrisiRacunBtn.UseVisualStyleBackColor = true;
            this.obrisiRacunBtn.Click += new System.EventHandler(this.HandleObnoviRacun);
            // 
            // racunContext
            // 
            this.racunContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrisiStavkuToolStripMenuItem});
            this.racunContext.Name = "racunContext";
            this.racunContext.Size = new System.Drawing.Size(143, 26);
            this.racunContext.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HandleRacunContextClick);
            // 
            // obrisiStavkuToolStripMenuItem
            // 
            this.obrisiStavkuToolStripMenuItem.Name = "obrisiStavkuToolStripMenuItem";
            this.obrisiStavkuToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.obrisiStavkuToolStripMenuItem.Text = "Obrisi stavku";
            // 
            // cenaRastuceCb
            // 
            this.cenaRastuceCb.AutoSize = true;
            this.cenaRastuceCb.Location = new System.Drawing.Point(244, 7);
            this.cenaRastuceCb.Name = "cenaRastuceCb";
            this.cenaRastuceCb.Size = new System.Drawing.Size(89, 17);
            this.cenaRastuceCb.TabIndex = 3;
            this.cenaRastuceCb.Text = "Cena rastuce";
            this.cenaRastuceCb.UseVisualStyleBackColor = true;
            // 
            // cenaOpadajuceCb
            // 
            this.cenaOpadajuceCb.AutoSize = true;
            this.cenaOpadajuceCb.Location = new System.Drawing.Point(244, 31);
            this.cenaOpadajuceCb.Name = "cenaOpadajuceCb";
            this.cenaOpadajuceCb.Size = new System.Drawing.Size(104, 17);
            this.cenaOpadajuceCb.TabIndex = 4;
            this.cenaOpadajuceCb.Text = "Cena opadajuce";
            this.cenaOpadajuceCb.UseVisualStyleBackColor = true;
            // 
            // filterNazivTb
            // 
            this.filterNazivTb.Location = new System.Drawing.Point(243, 54);
            this.filterNazivTb.Name = "filterNazivTb";
            this.filterNazivTb.Size = new System.Drawing.Size(105, 20);
            this.filterNazivTb.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.obrisiRacunBtn);
            this.Controls.Add(this.racunCenaLbl);
            this.Controls.Add(this.izdajRacunBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.racunListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restoran | Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.tabControl1.ResumeLayout(false);
            this.porucivanjeTab.ResumeLayout(false);
            this.porucivanjeTab.PerformLayout();
            this.priloziTab.ResumeLayout(false);
            this.racuniTab.ResumeLayout(false);
            this.racuniTab.PerformLayout();
            this.jeloContext.ResumeLayout(false);
            this.racunContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage porucivanjeTab;
        private System.Windows.Forms.TabPage priloziTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox racunListBox;
        private System.Windows.Forms.Button izdajRacunBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label racunCenaLbl;
        private System.Windows.Forms.TabPage racuniTab;
        private System.Windows.Forms.TabPage statistikaTab;
        private System.Windows.Forms.GroupBox priloziGroupBox;
        private System.Windows.Forms.ListBox jelaListBox;
        private System.Windows.Forms.Button dodajPrilogBtn;
        private System.Windows.Forms.ListBox priloziListBox;
        private System.Windows.Forms.ContextMenuStrip jeloContext;
        private System.Windows.Forms.ToolStripMenuItem dodajJeloToolStripMenuItem;
        private System.Windows.Forms.Button dodajJeloBtn;
        private System.Windows.Forms.Button obrisiRacunBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip racunContext;
        private System.Windows.Forms.ToolStripMenuItem obrisiStavkuToolStripMenuItem;
        private System.Windows.Forms.ListBox stavkeListBox;
        private System.Windows.Forms.ListBox racuniListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cenaOpadajuceCb;
        private System.Windows.Forms.CheckBox cenaRastuceCb;
        private System.Windows.Forms.TextBox filterNazivTb;
    }
}

