
namespace lab4VP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProdukti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzprazniLista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKosnicka = new System.Windows.Forms.ListBox();
            this.btnDodadivoKosnicka = new System.Windows.Forms.Button();
            this.btnIzbrisiodKosnicka = new System.Windows.Forms.Button();
            this.btnNovProdukt = new System.Windows.Forms.Button();
            this.btnIzbrisiProdukt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIzprazniKosnicka = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProdukti
            // 
            this.lbProdukti.FormattingEnabled = true;
            this.lbProdukti.ItemHeight = 15;
            this.lbProdukti.Location = new System.Drawing.Point(13, 32);
            this.lbProdukti.Name = "lbProdukti";
            this.lbProdukti.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbProdukti.Size = new System.Drawing.Size(279, 349);
            this.lbProdukti.TabIndex = 0;
            this.lbProdukti.SelectedIndexChanged += new System.EventHandler(this.lbProdukti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа на продукти:";
            // 
            // btnIzprazniLista
            // 
            this.btnIzprazniLista.Location = new System.Drawing.Point(12, 415);
            this.btnIzprazniLista.Name = "btnIzprazniLista";
            this.btnIzprazniLista.Size = new System.Drawing.Size(279, 23);
            this.btnIzprazniLista.TabIndex = 2;
            this.btnIzprazniLista.Text = "Испразни ја листата со продукти?";
            this.btnIzprazniLista.UseVisualStyleBackColor = true;
            this.btnIzprazniLista.Click += new System.EventHandler(this.btnIzprazniLista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbKategorija);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(300, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за производот";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(6, 131);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(70, 23);
            this.tbCena.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена:";
            // 
            // tbKategorija
            // 
            this.tbKategorija.Location = new System.Drawing.Point(7, 84);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.ReadOnly = true;
            this.tbKategorija.Size = new System.Drawing.Size(187, 23);
            this.tbKategorija.TabIndex = 3;
            this.tbKategorija.TextChanged += new System.EventHandler(this.tbKategorija_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категорија:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(7, 42);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(187, 23);
            this.tbIme.TabIndex = 1;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име:";
            // 
            // lbKosnicka
            // 
            this.lbKosnicka.FormattingEnabled = true;
            this.lbKosnicka.ItemHeight = 15;
            this.lbKosnicka.Location = new System.Drawing.Point(509, 32);
            this.lbKosnicka.Name = "lbKosnicka";
            this.lbKosnicka.Size = new System.Drawing.Size(279, 349);
            this.lbKosnicka.TabIndex = 0;
            this.lbKosnicka.SelectedIndexChanged += new System.EventHandler(this.lbKosnicka_SelectedIndexChanged);
            // 
            // btnDodadivoKosnicka
            // 
            this.btnDodadivoKosnicka.Location = new System.Drawing.Point(307, 200);
            this.btnDodadivoKosnicka.Name = "btnDodadivoKosnicka";
            this.btnDodadivoKosnicka.Size = new System.Drawing.Size(193, 23);
            this.btnDodadivoKosnicka.TabIndex = 5;
            this.btnDodadivoKosnicka.Text = "Додади во кошничка >>";
            this.btnDodadivoKosnicka.UseVisualStyleBackColor = true;
            this.btnDodadivoKosnicka.Click += new System.EventHandler(this.btnDodadivoKosnicka_Click);
            // 
            // btnIzbrisiodKosnicka
            // 
            this.btnIzbrisiodKosnicka.Location = new System.Drawing.Point(306, 238);
            this.btnIzbrisiodKosnicka.Name = "btnIzbrisiodKosnicka";
            this.btnIzbrisiodKosnicka.Size = new System.Drawing.Size(193, 23);
            this.btnIzbrisiodKosnicka.TabIndex = 6;
            this.btnIzbrisiodKosnicka.Text = "Избриши од кошничка";
            this.btnIzbrisiodKosnicka.UseVisualStyleBackColor = true;
            this.btnIzbrisiodKosnicka.Click += new System.EventHandler(this.btnIzbrisiodKosnicka_Click);
            // 
            // btnNovProdukt
            // 
            this.btnNovProdukt.Location = new System.Drawing.Point(306, 276);
            this.btnNovProdukt.Name = "btnNovProdukt";
            this.btnNovProdukt.Size = new System.Drawing.Size(193, 23);
            this.btnNovProdukt.TabIndex = 7;
            this.btnNovProdukt.Text = "Додади нов продукт";
            this.btnNovProdukt.UseVisualStyleBackColor = true;
            this.btnNovProdukt.Click += new System.EventHandler(this.btnNovProdukt_Click);
            // 
            // btnIzbrisiProdukt
            // 
            this.btnIzbrisiProdukt.Location = new System.Drawing.Point(306, 316);
            this.btnIzbrisiProdukt.Name = "btnIzbrisiProdukt";
            this.btnIzbrisiProdukt.Size = new System.Drawing.Size(193, 23);
            this.btnIzbrisiProdukt.TabIndex = 8;
            this.btnIzbrisiProdukt.Text = "Избриши продукт";
            this.btnIzbrisiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrisiProdukt.Click += new System.EventHandler(this.btnIzbrisiProdukt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кошничка";
            // 
            // tbVkupno
            // 
            this.tbVkupno.Location = new System.Drawing.Point(580, 389);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.ReadOnly = true;
            this.tbVkupno.Size = new System.Drawing.Size(208, 23);
            this.tbVkupno.TabIndex = 6;
            this.tbVkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbVkupno.TextChanged += new System.EventHandler(this.tbVkupno_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Вкупно:";
            // 
            // btnIzprazniKosnicka
            // 
            this.btnIzprazniKosnicka.Location = new System.Drawing.Point(509, 418);
            this.btnIzprazniKosnicka.Name = "btnIzprazniKosnicka";
            this.btnIzprazniKosnicka.Size = new System.Drawing.Size(279, 23);
            this.btnIzprazniKosnicka.TabIndex = 10;
            this.btnIzprazniKosnicka.Text = "Испразни ја кошничката?";
            this.btnIzprazniKosnicka.UseVisualStyleBackColor = true;
            this.btnIzprazniKosnicka.Click += new System.EventHandler(this.btnIzprazniKosnicka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzprazniKosnicka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVkupno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIzbrisiProdukt);
            this.Controls.Add(this.btnNovProdukt);
            this.Controls.Add(this.btnIzbrisiodKosnicka);
            this.Controls.Add(this.btnDodadivoKosnicka);
            this.Controls.Add(this.lbKosnicka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzprazniLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProdukti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProdukti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzprazniLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbKosnicka;
        private System.Windows.Forms.Button btnDodadivoKosnicka;
        private System.Windows.Forms.Button btnIzbrisiodKosnicka;
        private System.Windows.Forms.Button btnNovProdukt;
        private System.Windows.Forms.Button btnIzbrisiProdukt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIzprazniKosnicka;
    }
}

