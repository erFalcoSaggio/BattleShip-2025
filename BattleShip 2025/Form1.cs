namespace BattleShip_2025
{
    public partial class Form1 : Form
    {
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
        }
    }
}
