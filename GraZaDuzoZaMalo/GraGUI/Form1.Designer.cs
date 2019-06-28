namespace GraGUI
{
    partial class Form1
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.groupBoxZgaduj = new System.Windows.Forms.GroupBox();
            this.labelSprobuj = new System.Windows.Forms.Label();
            this.textBoxLosuj = new System.Windows.Forms.TextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.buttonPoddaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRuchy = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxZgaduj.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(109, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(13, 52);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(301, 89);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            this.groupBoxLosowanie.Enter += new System.EventHandler(this.groupBoxLosowanie_Enter);
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(148, 33);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(69, 52);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(46, 20);
            this.textBoxZakresDo.TabIndex = 3;
            this.textBoxZakresDo.Text = "100";
            this.textBoxZakresDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(7, 55);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(56, 13);
            this.labelZakresDo.TabIndex = 2;
            this.labelZakresDo.Text = "zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(7, 20);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(56, 13);
            this.labelZakresOd.TabIndex = 1;
            this.labelZakresOd.Text = "zakres od:";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(69, 17);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(46, 20);
            this.textBoxZakresOd.TabIndex = 0;
            this.textBoxZakresOd.Text = "1";
            this.textBoxZakresOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZakresOd.TextChanged += new System.EventHandler(this.textBoxZakresOd_TextChanged);
            // 
            // groupBoxZgaduj
            // 
            this.groupBoxZgaduj.Controls.Add(this.buttonPoddaj);
            this.groupBoxZgaduj.Controls.Add(this.labelWynik);
            this.groupBoxZgaduj.Controls.Add(this.buttonSprawdz);
            this.groupBoxZgaduj.Controls.Add(this.textBoxLosuj);
            this.groupBoxZgaduj.Controls.Add(this.labelSprobuj);
            this.groupBoxZgaduj.Location = new System.Drawing.Point(2, 164);
            this.groupBoxZgaduj.Name = "groupBoxZgaduj";
            this.groupBoxZgaduj.Size = new System.Drawing.Size(312, 126);
            this.groupBoxZgaduj.TabIndex = 2;
            this.groupBoxZgaduj.TabStop = false;
            this.groupBoxZgaduj.Text = "Wynik";
            this.groupBoxZgaduj.Visible = false;
            this.groupBoxZgaduj.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelSprobuj
            // 
            this.labelSprobuj.AutoSize = true;
            this.labelSprobuj.Location = new System.Drawing.Point(-3, 22);
            this.labelSprobuj.Name = "labelSprobuj";
            this.labelSprobuj.Size = new System.Drawing.Size(95, 13);
            this.labelSprobuj.TabIndex = 0;
            this.labelSprobuj.Text = "Spróbuj szczęścia:";
            this.labelSprobuj.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxLosuj
            // 
            this.textBoxLosuj.Location = new System.Drawing.Point(93, 18);
            this.textBoxLosuj.Name = "textBoxLosuj";
            this.textBoxLosuj.Size = new System.Drawing.Size(59, 20);
            this.textBoxLosuj.TabIndex = 1;
            this.textBoxLosuj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(158, 16);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "Sprawdź!";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelWynik.Location = new System.Drawing.Point(24, 57);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(0, 46);
            this.labelWynik.TabIndex = 3;
            // 
            // buttonPoddaj
            // 
            this.buttonPoddaj.Location = new System.Drawing.Point(239, 16);
            this.buttonPoddaj.Name = "buttonPoddaj";
            this.buttonPoddaj.Size = new System.Drawing.Size(75, 23);
            this.buttonPoddaj.TabIndex = 3;
            this.buttonPoddaj.Text = "Poddaj się";
            this.buttonPoddaj.UseVisualStyleBackColor = true;
            this.buttonPoddaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość ruchów";
            // 
            // labelRuchy
            // 
            this.labelRuchy.AutoSize = true;
            this.labelRuchy.Location = new System.Drawing.Point(293, 9);
            this.labelRuchy.Name = "labelRuchy";
            this.labelRuchy.Size = new System.Drawing.Size(13, 13);
            this.labelRuchy.TabIndex = 4;
            this.labelRuchy.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 341);
            this.Controls.Add(this.labelRuchy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxZgaduj);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxZgaduj.ResumeLayout(false);
            this.groupBoxZgaduj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.GroupBox groupBoxZgaduj;
        private System.Windows.Forms.TextBox textBoxLosuj;
        private System.Windows.Forms.Label labelSprobuj;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Button buttonPoddaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRuchy;
    }
}

