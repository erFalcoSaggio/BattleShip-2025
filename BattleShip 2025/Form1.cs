namespace BattleShip_2025
{
    public partial class Form1 : Form
    {


        int[,] grigliaComputer = new int[10, 10]; // 0 = vuoto, 1 = nave

        Random rnd = new Random();

        // lista con la lunghezza delle navi da posizionare
        int[] navi = new int[] { 5, 4, 3, 3, 2, 1 };
        int[] quantita = new int[] { 1, 1, 1, 1, 2, 4 };


        bool[,] celleGiaVisitate = new bool[10, 10];
        int tentativi = 0;



        Button[,] bottoni = new Button[10, 10];
        public Form1()
        {
            InitializeComponent();
        }
        // logo posizione: 274; 140
        // Separatore posizione: 250; 210
        // btn gioca ora pos: 314; 243

        private void Form1_Load(object sender, EventArgs e)
        {
            pct_Logo.Location = new Point(274, 140);
            lbl_SeparatoreLogoHome.Location = new Point(250, 210);
            btn_GiocaOra.Location = new Point(314, 243);
            pnl_Grid.Visible = false;
            pnl_Infos.Visible = false;
        }

        private void btn_GiocaOra_Click(object sender, EventArgs e)
        {
            pct_Logo.Visible = false;
            lbl_SeparatoreLogoHome.Visible = false;
            btn_GiocaOra.Visible = false;
            pnl_Grid.Visible = true;
            pnl_Infos.Visible = true;
            PosizionaNavi();
            CreaBottoniGriglia();
        }

        private void CreaBottoniGriglia()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Button btn = new Button();
                    btn.Name = $"btn_{r}{c}";
                    btn.Size = new Size(56, 36);
                    btn.BackColor = Color.FromArgb(0, 192, 192);
                    btn.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold);
                    btn.ForeColor = SystemColors.Control;
                    btn.Text = "";
                    //btn.Click += btn_Griglia_Click;

                    // Salva nella matrice
                    bottoni[r, c] = btn;

                    bottoni[r, c].Click += Cella_ClickGiocatore;

                    // Aggiungi alla griglia
                    tbl_Grid.Controls.Add(btn, c, r);
                }
            }
        }


        //private void btn_Griglia_Click(object sender, EventArgs e)
        //{
        //    Button btnCliccato = sender as Button;

        //    if (btnCliccato != null)
        //    {
        //        string nome = btnCliccato.Name;
        //        // MessageBox.Show($"Hai cliccato il bottone: {nome}");

        //        int riga = int.Parse(nome.Substring(4, 1));
        //        int colonna = int.Parse(nome.Substring(5, 1)); 
        //    }
        //}


        public void PosizionaNavi()
        {
            for (int i = 0; i < navi.Length; i++)
            {
                int lunghezza = navi[i];
                int numeroNavi = quantita[i];

                for (int j = 0; j < numeroNavi; j++)
                {
                    bool posizionata = false;

                    while (!posizionata)
                    {
                        int r = rnd.Next(10);
                        int c = rnd.Next(10);
                        bool orizzontale = rnd.Next(2) == 0;

                        if (SpazioLibero(r, c, lunghezza, orizzontale))
                        {
                            InserisciNave(r, c, lunghezza, orizzontale);
                            posizionata = true;
                        }
                    }
                }
            }
        }

        public bool SpazioLibero(int r, int c, int lunghezza, bool orizzontale)
        {
            if (orizzontale)
            {
                if (c + lunghezza > 10) return false;
                for (int i = 0; i < lunghezza; i++)
                    if (grigliaComputer[r, c + i] != 0) return false;
            }
            else
            {
                if (r + lunghezza > 10) return false;
                for (int i = 0; i < lunghezza; i++)
                    if (grigliaComputer[r + i, c] != 0) return false;
            }
            return true;
        }

        public void InserisciNave(int r, int c, int lunghezza, bool orizzontale)
        {
            if (orizzontale)
                for (int i = 0; i < lunghezza; i++)
                    grigliaComputer[r, c + i] = 1;
            else
                for (int i = 0; i < lunghezza; i++)
                    grigliaComputer[r + i, c] = 1;
        }



        public void Cella_ClickGiocatore(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // trova le coordinate del bottone cliccato
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (bottoni[r, c] == btn && !celleGiaVisitate[r, c])
                    {
                        tentativi++;
                        celleGiaVisitate[r, c] = true;

                        if (grigliaComputer[r, c] == 1)
                        {
                            // COLPITO
                            btn.BackColor = Color.Red;
                            grigliaComputer[r, c] = 2;

                            if (TutteNaviAffondate())
                            {
                                MessageBox.Show("Hai vinto in " + tentativi + " tentativi!");
                            }
                        }
                        else
                        {
                            // ACQUA
                            btn.BackColor = Color.White;
                        }

                        lbl_TiriNumero.Text = tentativi.ToString();
                        return;
                    }
                }
            }
        }
        

        public bool TutteNaviAffondate()
        {
            for (int r = 0; r < 10; r++)
                for (int c = 0; c < 10; c++)
                    if (grigliaComputer[r, c] == 1) return false;

            return true;
        }



    }
}
