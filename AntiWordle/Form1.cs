namespace AntiWordle
{
    public partial class Form1 : Form
    {
        private int numeroRiga = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //prima riga
            bottone1.Riga = 0;
            bottone2.Riga = 0;
            bottone3.Riga = 0;
            bottone4.Riga = 0;
            bottone5.Riga = 0;
            //Seconda riga
            bottone6.Riga = 1;
            bottone7.Riga = 1;
            bottone8.Riga = 1;
            bottone9.Riga = 1;
            bottone10.Riga = 1;
            //Terza riga
            bottone11.Riga = 2;
            bottone12.Riga = 2;
            bottone13.Riga = 2;
            bottone14.Riga = 2;
            bottone15.Riga = 2;
            //Quarta riga 
            bottone16.Riga = 3;
            bottone17.Riga = 3;
            bottone18.Riga = 3;
            bottone19.Riga = 3;
            bottone20.Riga = 3;
            //Quinta riga
            bottone21.Riga = 4;
            bottone22.Riga = 4;
            bottone23.Riga = 4;
            bottone24.Riga = 4;
            bottone25.Riga = 4;
            //Quinta riga
            bottone26.Riga = 5;
            bottone27.Riga = 5;
            bottone28.Riga = 5;
            bottone29.Riga = 5;
            bottone30.Riga = 5;
            //1 colonna
            bottone1.Colonna = 0;
            bottone6.Colonna = 0;
            bottone11.Colonna = 0;
            bottone16.Colonna = 0;
            bottone21.Colonna = 0;
            bottone26.Colonna = 0;
            //2 colonna
            bottone2.Colonna = 1;
            bottone7.Colonna = 1;
            bottone12.Colonna = 1;
            bottone17.Colonna = 1;
            bottone22.Colonna = 1;
            bottone27.Colonna = 1;
            //3 colonna
            bottone3.Colonna = 2;
            bottone8.Colonna = 2;
            bottone13.Colonna = 2;
            bottone18.Colonna = 2;
            bottone23.Colonna = 2;
            bottone28.Colonna = 2;
            //4 colonna
            bottone4.Colonna = 3;
            bottone9.Colonna = 3;
            bottone14.Colonna = 3;
            bottone19.Colonna = 3;
            bottone24.Colonna = 3;
            bottone23.Colonna = 3;
            //5 colonna
            bottone5.Colonna = 4;
            bottone10.Colonna = 4;
            bottone15.Colonna = 4;
            bottone20.Colonna = 4;
            bottone25.Colonna = 4;
            bottone30.Colonna = 4;

            //caricamento
            ricerca.LettoreFile();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (numeroRiga == 0 & textBox1.Text.Length == 5)
            {
                bottone1.Text = textBox1.Text[0].ToString();
                bottone2.Text = textBox1.Text[1].ToString();
                bottone3.Text = textBox1.Text[2].ToString();
                bottone4.Text = textBox1.Text[3].ToString();
                bottone5.Text = textBox1.Text[4].ToString();
                //numeroRiga++;
            }
            if (numeroRiga == 1 & textBox1.Text.Length == 5)
            {
                bottone6.Text = textBox1.Text[0].ToString();
                bottone7.Text = textBox1.Text[1].ToString();
                bottone8.Text = textBox1.Text[2].ToString();
                bottone9.Text = textBox1.Text[3].ToString();
                bottone10.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 2 & textBox1.Text.Length == 5)
            {
                bottone11.Text = textBox1.Text[0].ToString();
                bottone12.Text = textBox1.Text[1].ToString();
                bottone13.Text = textBox1.Text[2].ToString();
                bottone14.Text = textBox1.Text[3].ToString();
                bottone15.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 3 & textBox1.Text.Length == 5)
            {
                bottone16.Text = textBox1.Text[0].ToString();
                bottone17.Text = textBox1.Text[1].ToString();
                bottone18.Text = textBox1.Text[2].ToString();
                bottone19.Text = textBox1.Text[3].ToString();
                bottone20.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 4 & textBox1.Text.Length == 5)
            {
                bottone21.Text = textBox1.Text[0].ToString();
                bottone22.Text = textBox1.Text[1].ToString();
                bottone23.Text = textBox1.Text[2].ToString();
                bottone24.Text = textBox1.Text[3].ToString();
                bottone25.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 5 & textBox1.Text.Length == 5)
            {
                bottone26.Text = textBox1.Text[0].ToString();
                bottone27.Text = textBox1.Text[1].ToString();
                bottone28.Text = textBox1.Text[2].ToString();
                bottone29.Text = textBox1.Text[3].ToString();
                bottone30.Text = textBox1.Text[4].ToString();
            }
        }

        

        private void ClickCheckBox(object sender, EventArgs e)
        {
            foreach (var bottone in this.Controls.OfType<Bottone>())
            {
                if(sender is CheckBox cB)
                {
                    if (cB.Checked & cB.Name.Equals("letteraVerdeAt0"))
                    {
                        if(bottone.Riga==numeroRiga & bottone.Colonna == 0)
                        {
                            bottone.BackColor = Color.Green;
                            ricerca.AggiungiLetteraTrovataV(bottone.Text[0], bottone.Colonna);
                        }
                    }
                    if (cB.Checked & cB.Name.Equals("letteraVerdeAt1"))
                    {
                        if (bottone.Riga == numeroRiga & bottone.Colonna == 1)
                        {
                            bottone.BackColor = Color.Green;
                            ricerca.AggiungiLetteraTrovataV(bottone.Text[0], bottone.Colonna);
                            //TODO RICERCA VERDE
                        }
                    }
                    if (cB.Checked & cB.Name.Equals("letteraVerdeAt2"))
                    {
                        if (bottone.Riga == numeroRiga & bottone.Colonna == 2)
                        {
                            bottone.BackColor = Color.Green;
                            ricerca.AggiungiLetteraTrovataV(bottone.Text[0], bottone.Colonna);
                            //TODO RICERCA VERDE
                        }
                    }
                    if (cB.Checked & cB.Name.Equals("letteraVerdeAt3"))
                    {
                        if (bottone.Riga == numeroRiga & bottone.Colonna == 3)
                        {
                            bottone.BackColor = Color.Green;
                            ricerca.AggiungiLetteraTrovataV(bottone.Text[0], bottone.Colonna);
                            //TODO RICERCA VERDE
                        }
                    }
                    if (cB.Checked & cB.Name.Equals("letteraVerdeAt4"))
                    {
                        if (bottone.Riga == numeroRiga & bottone.Colonna == 4)
                        {
                            bottone.BackColor = Color.Green;
                            ricerca.AggiungiLetteraTrovataV(bottone.Text[0], bottone.Colonna);
                            //TODO RICERCA VERDE
                        }
                    }
                }
            }

        }

        private void Avanti_Click(object sender, EventArgs e)
        {
            foreach (var button in this.Controls.OfType<Bottone>())
            {
                if (button.Riga == numeroRiga)
                {
                    if (button.BackColor == Color.DarkGray)
                    {
                        ricerca.AggiungiLetteraNon(button.Text[0]);
                    }
                }
            }
            ricerca.Ricerca();
            listBox1.Items.Clear();
            listBox1.Items.Add("CIAO");
            
            foreach (var item in ricerca.parolePossibili)
            {
                listBox1.Items.Add(item.ParolaChiave);
            }
            numeroRiga++;
        }


        private void ClickBottone(object sender, EventArgs e)
        {
            if (sender is Bottone b)
            {
                if (b.BackColor != Color.Orange &b.Riga==numeroRiga)
                {
                    b.BackColor = Color.Orange;
                    ricerca.AggiungiLetteraTrovataG(b.Text[0], b.Colonna);
                }
                
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}