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

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.Length);
            listBox1.Items.Add(textBox1.Text);
            if (numeroRiga == 0 & textBox1.Text.Length == 5)
            {
                button0_0.Text = textBox1.Text[0].ToString();
                button0_1.Text = textBox1.Text[1].ToString();
                button0_2.Text = textBox1.Text[2].ToString();
                button0_3.Text = textBox1.Text[3].ToString();
                button0_4.Text = textBox1.Text[4].ToString();
                //numeroRiga++;
            }
            if (numeroRiga == 1 & textBox1.Text.Length == 5)
            {
                button1_0.Text = textBox1.Text[0].ToString();
                button1_1.Text = textBox1.Text[1].ToString();
                button1_2.Text = textBox1.Text[2].ToString();
                button1_3.Text = textBox1.Text[3].ToString();
                button1_4.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 2 & textBox1.Text.Length == 5)
            {
                button2_0.Text = textBox1.Text[0].ToString();
                button2_1.Text = textBox1.Text[1].ToString();
                button2_2.Text = textBox1.Text[2].ToString();
                button2_3.Text = textBox1.Text[3].ToString();
                button2_4.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 3 & textBox1.Text.Length == 5)
            {
                button3_0.Text = textBox1.Text[0].ToString();
                button3_1.Text = textBox1.Text[1].ToString();
                button3_2.Text = textBox1.Text[2].ToString();
                button3_3.Text = textBox1.Text[3].ToString();
                button3_4.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 4 & textBox1.Text.Length == 5)
            {
                button4_0.Text = textBox1.Text[0].ToString();
                button4_1.Text = textBox1.Text[1].ToString();
                button4_2.Text = textBox1.Text[2].ToString();
                button4_3.Text = textBox1.Text[3].ToString();
                button4_4.Text = textBox1.Text[4].ToString();
            }
            if (numeroRiga == 5 & textBox1.Text.Length == 5)
            {
                button5_0.Text = textBox1.Text[0].ToString();
                button5_1.Text = textBox1.Text[1].ToString();
                button5_2.Text = textBox1.Text[2].ToString();
                button5_3.Text = textBox1.Text[3].ToString();
                button5_4.Text = textBox1.Text[4].ToString();
            }

        }

        private void ClickButton(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (b.BackColor != Color.Orange)
                {
                    b.BackColor = Color.Orange;
                }
                else
                {
                    b.BackColor = Color.Red;
                }
            }
        }

        private void ClickCheckBox(object sender, EventArgs e)
        {
            if (sender is CheckBox cB)
            {
                if (cB.Checked)
                {
                    cB.BackColor = Color.Green;
                    switch (cB.Name)
                    {
                        case "letteraVerdeAt0":
                            button0_0.BackColor = Color.Green;
                            button1_0.BackColor = Color.Green;
                            button2_0.BackColor = Color.Green;
                            button3_0.BackColor = Color.Green;
                            button4_0.BackColor = Color.Green;
                            button5_0.BackColor = Color.Green;

                            break;
                        case "letteraVerdeAt1":
                            button0_1.BackColor = Color.Green;
                            button1_1.BackColor = Color.Green;
                            button2_1.BackColor = Color.Green;
                            button3_1.BackColor = Color.Green;
                            button4_1.BackColor = Color.Green;
                            button5_1.BackColor = Color.Green;
                            break;
                        case "letteraVerdeAt2":
                            button0_2.BackColor = Color.Green;
                            button1_2.BackColor = Color.Green;
                            button2_2.BackColor = Color.Green;
                            button3_2.BackColor = Color.Green;
                            button4_2.BackColor = Color.Green;
                            button5_2.BackColor = Color.Green;
                            break;
                        case "letteraVerdeAt3":
                            button0_3.BackColor = Color.Green;
                            button1_3.BackColor = Color.Green;
                            button2_3.BackColor = Color.Green;
                            button3_3.BackColor = Color.Green;
                            button4_3.BackColor = Color.Green;
                            button5_3.BackColor = Color.Green;
                            break;
                        case "letteraVerdeAt4":
                            button0_4.BackColor = Color.Green;
                            button1_4.BackColor = Color.Green;
                            button2_4.BackColor = Color.Green;
                            button3_4.BackColor = Color.Green;
                            button4_4.BackColor = Color.Green;
                            button5_4.BackColor = Color.Green;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    cB.BackColor = Color.Red;
                }
            }
        }

        private void Avanti_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ColoreVerde(object sender, EventArgs e)
        {
            if (sender is Button b)
            {

                switch (numeroRiga)
                {
                    case 0:
                        int pos = (int)b.Name[8];
                        listBox1.Items.Add(b.Name[8]);
                        //ricerca.AggiungiLetteraTrovataV(b.Text[0], pos);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                    default:
                        break;
                }
            }
        }
    }
}