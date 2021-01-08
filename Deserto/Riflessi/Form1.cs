using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riflessi
{
    public partial class Form1 : Form
    {
       
        private struct alieno
        {
            public PictureBox img;
            public bool morto;
        }

        private Random casuale = new Random();
        private int pos = 0;
        alieno[] alieni = new alieno[100];
        bool playing = false;
        int punti = 0;
        int mosse = 0;


        public Form1()
        {
            InitializeComponent();
            Sfondo.Load("./IMG/Sfondo.png");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Reset
            if(!playing)
            {
                //Riposizionare gli alieni
                //Alien1
                this.Alien1.Location = new System.Drawing.Point(40, 140);
                this.Alien1.Visible = false;
                // Alien12
                this.Alien12.Location = new System.Drawing.Point(40, 380);
                this.Alien12.Visible = false;
                // Alien6
                this.Alien6.Location = new System.Drawing.Point(1000, 380);
                this.Alien6.Visible = false;
                // Alien8
                this.Alien8.Location = new System.Drawing.Point(760, 620);
                this.Alien8.Visible = false;
                // Alien10
                this.Alien10.Location = new System.Drawing.Point(260, 620);
                this.Alien10.Visible = false;
                // Alien7
                this.Alien7.Location = new System.Drawing.Point(1000, 620);
                this.Alien7.Visible = false; 
                // Alien2
                this.Alien2.Location = new System.Drawing.Point(260, 140);
                this.Alien2.Visible = false;
                // Alien5
                this.Alien5.Location = new System.Drawing.Point(1000, 140);
                this.Alien5.Visible = false;
                // Alien11
                this.Alien11.Location = new System.Drawing.Point(40, 620);
                this.Alien11.Visible = false;
                // Alien9
                this.Alien9.Location = new System.Drawing.Point(520, 620);
                this.Alien9.Visible = false;
                // Alien4                
                this.Alien4.Location = new System.Drawing.Point(520, 140);
                this.Alien4.Visible = false;
                // Alien3
                this.Alien3.Location = new System.Drawing.Point(760, 140);
                this.Alien3.Visible = false;
                //Inizializzare alieni
                alieni[0].img = Alien1;
                alieni[1].img = Alien2;
                alieni[2].img = Alien3;
                alieni[3].img = Alien4;
                alieni[4].img = Alien5;
                alieni[5].img = Alien6;
                alieni[6].img = Alien7;
                alieni[7].img = Alien8;
                alieni[8].img = Alien9;
                alieni[9].img = Alien10;
                alieni[10].img = Alien11;
                alieni[11].img = Alien12;
                //Resettare gli alieni
                alieni[0].morto = false;
                alieni[1].morto = false;
                alieni[2].morto = false;
                alieni[3].morto = false;
                alieni[4].morto = false;
                alieni[5].morto = false;
                alieni[6].morto = false;
                alieni[7].morto = false;
                alieni[8].morto = false;
                alieni[9].morto = false;
                alieni[10].morto = false;
                alieni[11].morto = false;

                //Movimento PG
                this.PG.Load("./IMG/PG-Sx.png");
                this.PG.Location = new System.Drawing.Point(520, 380);
                this.PG.Visible = true;
                pos = 1;

                Titolo.Text = "Uccidi gli alieni";
                playing = true;
                punti = 0;
                mosse = 0;

                timer1.Start();


                Punti.Text = $"Punti:\n{punti.ToString("000")}";
                Mosse.Text = $"Mosse:\n0";

                return;
            }                     
            
            //Gioco
            if(playing)
            {
                bool move = false;

                //Movimento
                if (e.KeyCode == Keys.Right)
                {
                    PG.Load("./IMG/PG-Dx.png");
                    if (PG.Left < 1020)
                    {
                        PG.Left += 10;
                        move = true;
                        pos = 3;
                    }
                }

                if (e.KeyCode == Keys.Left)
                {
                    PG.Load("./IMG/PG-Sx.png");
                    if (PG.Left > 20)
                    {
                        PG.Left -= 10;
                        move = true;
                        pos = 1;
                    }
                }

                if (e.KeyCode == Keys.Up)
                {
                    PG.Load("./IMG/PG-Up.png");
                    if (PG.Top > 120)
                    {
                        PG.Top -= 10;
                        move = true;
                        pos = 2;
                    }
                }

                if (e.KeyCode == Keys.Down)
                {
                    PG.Load("./IMG/PG-Dn.png");
                    if (PG.Top < 640)
                    {
                        PG.Top += 10;
                        move = true;
                        pos = 4;
                    }
                }
                Punti.Text = $"Punti:\n{punti.ToString("000")}";

                //Spara
                if (e.KeyCode == Keys.Enter)
                {

                    if (pos == 0)
                        return;

                    //1=sx, 2=up, 3=dx, 4=down
                    if (pos == 1)
                    {
                        int x = 0;

                        while (x < 12)
                        {

                            
                            if (alieni[x].img.Left < PG.Left && ((alieni[x].img.Top >= (PG.Top - 20)) && (alieni[x].img.Top <= (PG.Top + 20))) && alieni[x].img.Visible)
                            {
                                alieni[x].img.Load("./IMG/AlienoMorto.png");
                                if (!alieni[x].morto)
                                    punti += 100;
                                alieni[x].morto = true;
                            }

                            x++;
                        }

                        move = true;
                    }

                    if (pos == 2)
                    {
                        int x = 0;

                        while (x < 12)
                        {

                            if (alieni[x].img.Top < PG.Top && ((alieni[x].img.Left >= (PG.Left - 20)) && (alieni[x].img.Left <= (PG.Left + 20))) && alieni[x].img.Visible)
                            {
                                alieni[x].img.Load("./IMG/AlienoMorto.png");
                                if (!alieni[x].morto)
                                    punti += 100;
                                alieni[x].morto = true;
                            }

                            x++;
                        }

                        move = true;
                    }

                    if (pos == 3)
                    {
                        int x = 0;

                        while (x < 12)
                        {

                            if (alieni[x].img.Left > PG.Left && ((alieni[x].img.Top >= (PG.Top - 20)) && (alieni[x].img.Top <= (PG.Top + 20))) && alieni[x].img.Visible)
                            {
                                alieni[x].img.Load("./IMG/AlienoMorto.png");
                                if (!alieni[x].morto)
                                    punti += 100;
                                alieni[x].morto = true;

                            }

                            x++;
                        }

                        move = true;
                    }

                    if (pos == 4)
                    {
                        int x = 0;

                        while (x < 12)
                        {

                            if (alieni[x].img.Top > PG.Top && ((alieni[x].img.Left >= (PG.Left - 20)) && (alieni[x].img.Left <= (PG.Left + 20))) && alieni[x].img.Visible)
                            {
                                alieni[x].img.Load("./IMG/AlienoMorto.png");
                                if(!alieni[x].morto)
                                    punti += 100;
                                alieni[x].morto = true;
                            }

                            x++;
                        }

                        move = true;

                    }

                }

                //Movimento alieni
                if (move)
                {
                    mosse += 1;

                    if(mosse == 1)
                    {
                        int comparsa = casuale.Next(1, 12);
                            alieni[comparsa].img.Visible = true;
                            alieni[comparsa].img.Load("./IMG/Alieno.png");
                    }

                    if (mosse == 10)
                    {
                        int i = 0;

                        while(i<2)
                        {
                            int comparsa = casuale.Next(1, 12);
                            if(!alieni[comparsa].img.Visible)
                            {
                                alieni[comparsa].img.Visible = true;
                                alieni[comparsa].img.Load("./IMG/Alieno.png");
                                i++;
                            }
                        }
                    }

                    if (mosse == 30)
                    {
                        int i = 0;

                        while (i < 3)
                        {
                            int comparsa = casuale.Next(1, 12);
                            if (!alieni[comparsa].img.Visible)
                            {
                                alieni[comparsa].img.Visible = true;
                                alieni[comparsa].img.Load("./IMG/Alieno.png");
                                i++;
                            }
                        }
                    }

                    if (mosse == 40)
                    {
                        int i = 0;

                        while (i < 3)
                        {
                            int comparsa = casuale.Next(1, 12);
                            if (!alieni[comparsa].img.Visible)
                            {
                                alieni[comparsa].img.Visible = true;
                                alieni[comparsa].img.Load("./IMG/Alieno.png");
                                i++;
                            }
                        }
                    }

                    if (mosse == 50)
                    {
                        int i = 0;

                        while (i < 12)
                        {
                            if(!alieni[i].img.Visible)
                            {
                                alieni[i].img.Visible = true;
                                alieni[i].img.Load("./IMG/Alieno.png");
                            }
                                
                                i++;
                        }
                    }

                    bool vinto = true;
                    if(mosse>50)
                    {
                        int i = 0;

                        while (i < 12)
                        {
                            if(!alieni[i].morto)
                            {
                                vinto = false;
                                break;
                            }
                                
                            i++;                            
                        }

                        if (vinto)
                        {
                            Titolo.Text = "Hai vinto!";
                            playing = false;
                            timer1.Stop();
                            return;
                        }
                    }

                }

                Punti.Text = $"Punti:\n{punti.ToString("000")}";
                Mosse.Text = $"Mosse:\n{mosse.ToString("0")}";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int x = 0;

            while (x < 12)
            {
                //Se L'alieno è visibile e non morto
                if (!alieni[x].morto && alieni[x].img.Visible)
                {

                    int left, top;

                    left = alieni[x].img.Left - PG.Left;
                    top = alieni[x].img.Top - PG.Top;

                    int Aleft = Math.Abs(left);
                    int Atop = Math.Abs(top);

                    if (Aleft >= Atop && left >= 0)
                    {
                        alieni[x].img.Left -= 20;
                    }
                    if (Aleft >= Atop && left < 0)
                    {
                        alieni[x].img.Left += 20;
                    }
                    if (Atop > Aleft && top >= 0)
                    {
                        alieni[x].img.Top -= 20;
                    }
                    if (Atop > Aleft && top < 0)
                    {
                        alieni[x].img.Top += 20;
                    }

                    if ((((alieni[x].img.Top >= (PG.Top - 20)) && (alieni[x].img.Top <= (PG.Top + 20))) && ((alieni[x].img.Left >= (PG.Left - 20)) && (alieni[x].img.Left <= (PG.Left + 20)))))
                    {
                        Titolo.Text = "Hai perso";
                        playing = false;
                        timer1.Stop();
                        return;
                    }
                }

                x++;
            }
        }
    }
}
