
namespace Riflessi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PG = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Titolo = new System.Windows.Forms.Label();
            this.Punti = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Alien1 = new System.Windows.Forms.PictureBox();
            this.Alien12 = new System.Windows.Forms.PictureBox();
            this.Alien6 = new System.Windows.Forms.PictureBox();
            this.Alien8 = new System.Windows.Forms.PictureBox();
            this.Alien10 = new System.Windows.Forms.PictureBox();
            this.Alien7 = new System.Windows.Forms.PictureBox();
            this.Alien2 = new System.Windows.Forms.PictureBox();
            this.Alien5 = new System.Windows.Forms.PictureBox();
            this.Alien11 = new System.Windows.Forms.PictureBox();
            this.Alien9 = new System.Windows.Forms.PictureBox();
            this.Alien4 = new System.Windows.Forms.PictureBox();
            this.Alien3 = new System.Windows.Forms.PictureBox();
            this.Mosse = new System.Windows.Forms.Label();
            this.Sfondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sfondo)).BeginInit();
            this.SuspendLayout();
            // 
            // PG
            // 
            this.PG.InitialImage = ((System.Drawing.Image)(resources.GetObject("PG.InitialImage")));
            this.PG.Location = new System.Drawing.Point(520, 380);
            this.PG.Name = "PG";
            this.PG.Size = new System.Drawing.Size(40, 40);
            this.PG.TabIndex = 0;
            this.PG.TabStop = false;
            this.PG.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Titolo
            // 
            this.Titolo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.Location = new System.Drawing.Point(0, 0);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(1080, 60);
            this.Titolo.TabIndex = 1;
            this.Titolo.Text = "UCCIDI GLI ALIENI";
            this.Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Punti
            // 
            this.Punti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Punti.Location = new System.Drawing.Point(0, 60);
            this.Punti.Name = "Punti";
            this.Punti.Size = new System.Drawing.Size(80, 40);
            this.Punti.TabIndex = 2;
            this.Punti.Text = "Punti:";
            // 
            // Alien1
            // 
            this.Alien1.Location = new System.Drawing.Point(40, 140);
            this.Alien1.Name = "Alien1";
            this.Alien1.Size = new System.Drawing.Size(40, 40);
            this.Alien1.TabIndex = 3;
            this.Alien1.TabStop = false;
            this.Alien1.Visible = false;
            // 
            // Alien12
            // 
            this.Alien12.Location = new System.Drawing.Point(40, 380);
            this.Alien12.Name = "Alien12";
            this.Alien12.Size = new System.Drawing.Size(40, 40);
            this.Alien12.TabIndex = 4;
            this.Alien12.TabStop = false;
            this.Alien12.Visible = false;
            // 
            // Alien6
            // 
            this.Alien6.Location = new System.Drawing.Point(1000, 380);
            this.Alien6.Name = "Alien6";
            this.Alien6.Size = new System.Drawing.Size(40, 40);
            this.Alien6.TabIndex = 5;
            this.Alien6.TabStop = false;
            this.Alien6.Visible = false;
            // 
            // Alien8
            // 
            this.Alien8.Location = new System.Drawing.Point(760, 620);
            this.Alien8.Name = "Alien8";
            this.Alien8.Size = new System.Drawing.Size(40, 40);
            this.Alien8.TabIndex = 7;
            this.Alien8.TabStop = false;
            this.Alien8.Visible = false;
            // 
            // Alien10
            // 
            this.Alien10.Location = new System.Drawing.Point(230, 620);
            this.Alien10.Name = "Alien10";
            this.Alien10.Size = new System.Drawing.Size(40, 40);
            this.Alien10.TabIndex = 8;
            this.Alien10.TabStop = false;
            this.Alien10.Visible = false;
            // 
            // Alien7
            // 
            this.Alien7.Location = new System.Drawing.Point(1000, 620);
            this.Alien7.Name = "Alien7";
            this.Alien7.Size = new System.Drawing.Size(40, 40);
            this.Alien7.TabIndex = 9;
            this.Alien7.TabStop = false;
            this.Alien7.Visible = false;
            // 
            // Alien2
            // 
            this.Alien2.Location = new System.Drawing.Point(260, 140);
            this.Alien2.Name = "Alien2";
            this.Alien2.Size = new System.Drawing.Size(40, 40);
            this.Alien2.TabIndex = 10;
            this.Alien2.TabStop = false;
            this.Alien2.Visible = false;
            // 
            // Alien5
            // 
            this.Alien5.Location = new System.Drawing.Point(1000, 140);
            this.Alien5.Name = "Alien5";
            this.Alien5.Size = new System.Drawing.Size(40, 40);
            this.Alien5.TabIndex = 11;
            this.Alien5.TabStop = false;
            this.Alien5.Visible = false;
            // 
            // Alien11
            // 
            this.Alien11.Location = new System.Drawing.Point(40, 620);
            this.Alien11.Name = "Alien11";
            this.Alien11.Size = new System.Drawing.Size(40, 40);
            this.Alien11.TabIndex = 12;
            this.Alien11.TabStop = false;
            this.Alien11.Visible = false;
            // 
            // Alien9
            // 
            this.Alien9.Location = new System.Drawing.Point(520, 620);
            this.Alien9.Name = "Alien9";
            this.Alien9.Size = new System.Drawing.Size(40, 40);
            this.Alien9.TabIndex = 13;
            this.Alien9.TabStop = false;
            this.Alien9.Visible = false;
            // 
            // Alien4
            // 
            this.Alien4.Location = new System.Drawing.Point(520, 140);
            this.Alien4.Name = "Alien4";
            this.Alien4.Size = new System.Drawing.Size(40, 40);
            this.Alien4.TabIndex = 15;
            this.Alien4.TabStop = false;
            this.Alien4.Visible = false;
            // 
            // Alien3
            // 
            this.Alien3.Location = new System.Drawing.Point(760, 140);
            this.Alien3.Name = "Alien3";
            this.Alien3.Size = new System.Drawing.Size(40, 40);
            this.Alien3.TabIndex = 16;
            this.Alien3.TabStop = false;
            this.Alien3.Visible = false;
            // 
            // Mosse
            // 
            this.Mosse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Mosse.Location = new System.Drawing.Point(1000, 60);
            this.Mosse.Name = "Mosse";
            this.Mosse.Size = new System.Drawing.Size(80, 40);
            this.Mosse.TabIndex = 17;
            this.Mosse.Text = "Mosse:";
            // 
            // Sfondo
            // 
            this.Sfondo.Location = new System.Drawing.Point(20, 120);
            this.Sfondo.Name = "Sfondo";
            this.Sfondo.Size = new System.Drawing.Size(1040, 560);
            this.Sfondo.TabIndex = 18;
            this.Sfondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.PG);
            this.Controls.Add(this.Mosse);
            this.Controls.Add(this.Alien3);
            this.Controls.Add(this.Alien4);
            this.Controls.Add(this.Alien9);
            this.Controls.Add(this.Alien11);
            this.Controls.Add(this.Alien5);
            this.Controls.Add(this.Alien2);
            this.Controls.Add(this.Alien7);
            this.Controls.Add(this.Alien10);
            this.Controls.Add(this.Alien8);
            this.Controls.Add(this.Alien6);
            this.Controls.Add(this.Alien12);
            this.Controls.Add(this.Alien1);
            this.Controls.Add(this.Punti);
            this.Controls.Add(this.Titolo);
            this.Controls.Add(this.Sfondo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sfondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PG;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.Label Punti;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Alien1;
        private System.Windows.Forms.PictureBox Alien12;
        private System.Windows.Forms.PictureBox Alien6;
        private System.Windows.Forms.PictureBox Alien8;
        private System.Windows.Forms.PictureBox Alien10;
        private System.Windows.Forms.PictureBox Alien7;
        private System.Windows.Forms.PictureBox Alien2;
        private System.Windows.Forms.PictureBox Alien5;
        private System.Windows.Forms.PictureBox Alien11;
        private System.Windows.Forms.PictureBox Alien9;
        private System.Windows.Forms.PictureBox Alien4;
        private System.Windows.Forms.PictureBox Alien3;
        private System.Windows.Forms.Label Mosse;
        private System.Windows.Forms.PictureBox Sfondo;
    }
}

