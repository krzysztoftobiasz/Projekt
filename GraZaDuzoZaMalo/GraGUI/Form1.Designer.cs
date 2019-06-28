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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.groupBoxZgaduj = new System.Windows.Forms.GroupBox();
            this.buttonPoddaj = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxLosuj = new System.Windows.Forms.TextBox();
            this.labelSprobuj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRuchy = new System.Windows.Forms.Label();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxZgaduj.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(93, 37);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLosowanie.Location = new System.Drawing.Point(13, 56);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(301, 92);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            this.groupBoxLosowanie.Enter += new System.EventHandler(this.groupBoxLosowanie_Enter);
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWylosuj.Location = new System.Drawing.Point(197, 23);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 36);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxZakresDo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZakresDo.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxZakresDo.Location = new System.Drawing.Point(111, 53);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(63, 28);
            this.textBoxZakresDo.TabIndex = 3;
            this.textBoxZakresDo.Text = "100";
            this.textBoxZakresDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZakresDo.TextChanged += new System.EventHandler(this.textBoxZakresDo_TextChanged);
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.BackColor = System.Drawing.Color.Silver;
            this.labelZakresDo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZakresDo.Location = new System.Drawing.Point(7, 59);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(87, 21);
            this.labelZakresDo.TabIndex = 2;
            this.labelZakresDo.Text = "zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.BackColor = System.Drawing.Color.DarkGray;
            this.labelZakresOd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZakresOd.Location = new System.Drawing.Point(7, 22);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(87, 21);
            this.labelZakresOd.TabIndex = 1;
            this.labelZakresOd.Text = "zakres od:";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxZakresOd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZakresOd.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxZakresOd.Location = new System.Drawing.Point(111, 19);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(63, 28);
            this.textBoxZakresOd.TabIndex = 0;
            this.textBoxZakresOd.Text = "1";
            this.textBoxZakresOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZakresOd.TextChanged += new System.EventHandler(this.textBoxZakresOd_TextChanged);
            // 
            // groupBoxZgaduj
            // 
            this.groupBoxZgaduj.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxZgaduj.Controls.Add(this.buttonPoddaj);
            this.groupBoxZgaduj.Controls.Add(this.labelWynik);
            this.groupBoxZgaduj.Controls.Add(this.buttonSprawdz);
            this.groupBoxZgaduj.Controls.Add(this.textBoxLosuj);
            this.groupBoxZgaduj.Controls.Add(this.labelSprobuj);
            this.groupBoxZgaduj.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxZgaduj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxZgaduj.Location = new System.Drawing.Point(2, 177);
            this.groupBoxZgaduj.Name = "groupBoxZgaduj";
            this.groupBoxZgaduj.Size = new System.Drawing.Size(312, 178);
            this.groupBoxZgaduj.TabIndex = 2;
            this.groupBoxZgaduj.TabStop = false;
            this.groupBoxZgaduj.Text = "Wynik";
            this.groupBoxZgaduj.Visible = false;
            this.groupBoxZgaduj.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonPoddaj
            // 
            this.buttonPoddaj.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoddaj.Location = new System.Drawing.Point(110, 145);
            this.buttonPoddaj.Name = "buttonPoddaj";
            this.buttonPoddaj.Size = new System.Drawing.Size(75, 30);
            this.buttonPoddaj.TabIndex = 3;
            this.buttonPoddaj.Text = "Poddaj się";
            this.buttonPoddaj.UseVisualStyleBackColor = true;
            this.buttonPoddaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.BackColor = System.Drawing.Color.Transparent;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelWynik.Location = new System.Drawing.Point(24, 86);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(0, 51);
            this.labelWynik.TabIndex = 3;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSprawdz.Location = new System.Drawing.Point(194, 21);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(89, 30);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "Sprawdź!";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // textBoxLosuj
            // 
            this.textBoxLosuj.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLosuj.Location = new System.Drawing.Point(11, 45);
            this.textBoxLosuj.Name = "textBoxLosuj";
            this.textBoxLosuj.Size = new System.Drawing.Size(115, 28);
            this.textBoxLosuj.TabIndex = 1;
            this.textBoxLosuj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelSprobuj
            // 
            this.labelSprobuj.AutoSize = true;
            this.labelSprobuj.BackColor = System.Drawing.Color.Silver;
            this.labelSprobuj.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSprobuj.Location = new System.Drawing.Point(-2, 21);
            this.labelSprobuj.Name = "labelSprobuj";
            this.labelSprobuj.Size = new System.Drawing.Size(146, 21);
            this.labelSprobuj.TabIndex = 0;
            this.labelSprobuj.Text = "Spróbuj szczęścia:";
            this.labelSprobuj.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość ruchów";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelRuchy
            // 
            this.labelRuchy.AutoSize = true;
            this.labelRuchy.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuchy.Location = new System.Drawing.Point(266, 32);
            this.labelRuchy.Name = "labelRuchy";
            this.labelRuchy.Size = new System.Drawing.Size(19, 21);
            this.labelRuchy.TabIndex = 4;
            this.labelRuchy.Text = "0";
            this.labelRuchy.Click += new System.EventHandler(this.labelRuchy_Click);
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Enabled = false;
            this.buttonHistoria.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoria.Location = new System.Drawing.Point(111, 3);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(107, 56);
            this.buttonHistoria.TabIndex = 5;
            this.buttonHistoria.Text = "Sprawdź Historię";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.buttonHistoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 367);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.labelRuchy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxZgaduj);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Gra Zgadywanka";
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
        private System.Windows.Forms.Button buttonHistoria;
    }
}

