
namespace lab4VP
{
    partial class NovProdukt
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddIme = new System.Windows.Forms.TextBox();
            this.tbAddKategoija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // tbAddIme
            // 
            this.tbAddIme.Location = new System.Drawing.Point(13, 32);
            this.tbAddIme.Name = "tbAddIme";
            this.tbAddIme.Size = new System.Drawing.Size(280, 23);
            this.tbAddIme.TabIndex = 1;
            this.tbAddIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddIme_Validating);
            // 
            // tbAddKategoija
            // 
            this.tbAddKategoija.Location = new System.Drawing.Point(13, 82);
            this.tbAddKategoija.Name = "tbAddKategoija";
            this.tbAddKategoija.Size = new System.Drawing.Size(280, 23);
            this.tbAddKategoija.TabIndex = 3;
            this.tbAddKategoija.TextChanged += new System.EventHandler(this.tbAddKategoija_TextChanged);
            this.tbAddKategoija.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddKategoija_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категорија:";
            // 
            // tbAddCena
            // 
            this.tbAddCena.Location = new System.Drawing.Point(13, 138);
            this.tbAddCena.Name = "tbAddCena";
            this.tbAddCena.Size = new System.Drawing.Size(139, 23);
            this.tbAddCena.TabIndex = 5;
            this.tbAddCena.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddCena_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(136, 175);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 6;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(218, 175);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 23);
            this.btnDodadi.TabIndex = 7;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NovProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 210);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.tbAddCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddKategoija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddIme);
            this.Controls.Add(this.label1);
            this.Name = "NovProdukt";
            this.Text = "NovProdukt";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddIme;
        private System.Windows.Forms.TextBox tbAddKategoija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}