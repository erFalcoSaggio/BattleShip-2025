namespace BattleShip_2025
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            img_Logo = new ImageList(components);
            pct_Logo = new PictureBox();
            lbl_SeparatoreLogoHome = new Label();
            btn_GiocaOra = new Button();
            pnl_Grid = new Panel();
            tbl_Grid = new TableLayoutPanel();
            pnl_Infos = new Panel();
            lbl_TiriNumero = new Label();
            lbl_TiriTitolo = new Label();
            lbl_InfosTitolo = new Label();
            ((System.ComponentModel.ISupportInitialize)pct_Logo).BeginInit();
            pnl_Grid.SuspendLayout();
            pnl_Infos.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // img_Logo
            // 
            img_Logo.ColorDepth = ColorDepth.Depth8Bit;
            img_Logo.ImageSize = new Size(16, 16);
            img_Logo.TransparentColor = Color.Transparent;
            // 
            // pct_Logo
            // 
            pct_Logo.Image = Properties.Resources._250px_Battleship_naval_game_logo;
            pct_Logo.Location = new Point(695, 12);
            pct_Logo.Name = "pct_Logo";
            pct_Logo.Size = new Size(252, 67);
            pct_Logo.TabIndex = 0;
            pct_Logo.TabStop = false;
            // 
            // lbl_SeparatoreLogoHome
            // 
            lbl_SeparatoreLogoHome.AutoSize = true;
            lbl_SeparatoreLogoHome.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SeparatoreLogoHome.Location = new Point(646, 82);
            lbl_SeparatoreLogoHome.Name = "lbl_SeparatoreLogoHome";
            lbl_SeparatoreLogoHome.Size = new Size(301, 30);
            lbl_SeparatoreLogoHome.TabIndex = 1;
            lbl_SeparatoreLogoHome.Text = "--------------------------------";
            // 
            // btn_GiocaOra
            // 
            btn_GiocaOra.BackColor = Color.FromArgb(0, 192, 192);
            btn_GiocaOra.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GiocaOra.ForeColor = SystemColors.Control;
            btn_GiocaOra.Location = new Point(718, 115);
            btn_GiocaOra.Name = "btn_GiocaOra";
            btn_GiocaOra.Size = new Size(172, 53);
            btn_GiocaOra.TabIndex = 2;
            btn_GiocaOra.Text = "GIOCA ORA!";
            btn_GiocaOra.UseVisualStyleBackColor = false;
            btn_GiocaOra.Click += btn_GiocaOra_Click;
            // 
            // pnl_Grid
            // 
            pnl_Grid.Controls.Add(tbl_Grid);
            pnl_Grid.Location = new Point(12, 12);
            pnl_Grid.Name = "pnl_Grid";
            pnl_Grid.Size = new Size(628, 426);
            pnl_Grid.TabIndex = 3;
            // 
            // tbl_Grid
            // 
            tbl_Grid.ColumnCount = 10;
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_Grid.Location = new Point(3, 3);
            tbl_Grid.Name = "tbl_Grid";
            tbl_Grid.RowCount = 10;
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000982F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000982F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 9.9991F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            tbl_Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            tbl_Grid.Size = new Size(622, 420);
            tbl_Grid.TabIndex = 0;
            // 
            // pnl_Infos
            // 
            pnl_Infos.Controls.Add(lbl_TiriNumero);
            pnl_Infos.Controls.Add(lbl_TiriTitolo);
            pnl_Infos.Controls.Add(lbl_InfosTitolo);
            pnl_Infos.Location = new Point(646, 211);
            pnl_Infos.Name = "pnl_Infos";
            pnl_Infos.Size = new Size(142, 227);
            pnl_Infos.TabIndex = 4;
            // 
            // lbl_TiriNumero
            // 
            lbl_TiriNumero.AutoSize = true;
            lbl_TiriNumero.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_TiriNumero.Location = new Point(58, 49);
            lbl_TiriNumero.Name = "lbl_TiriNumero";
            lbl_TiriNumero.Size = new Size(25, 30);
            lbl_TiriNumero.TabIndex = 1;
            lbl_TiriNumero.Text = "0";
            // 
            // lbl_TiriTitolo
            // 
            lbl_TiriTitolo.AutoSize = true;
            lbl_TiriTitolo.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_TiriTitolo.Location = new Point(6, 49);
            lbl_TiriTitolo.Name = "lbl_TiriTitolo";
            lbl_TiriTitolo.Size = new Size(46, 30);
            lbl_TiriTitolo.TabIndex = 1;
            lbl_TiriTitolo.Text = "Tiri:";
            // 
            // lbl_InfosTitolo
            // 
            lbl_InfosTitolo.AutoSize = true;
            lbl_InfosTitolo.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_InfosTitolo.Location = new Point(6, 5);
            lbl_InfosTitolo.Name = "lbl_InfosTitolo";
            lbl_InfosTitolo.Size = new Size(54, 30);
            lbl_InfosTitolo.TabIndex = 1;
            lbl_InfosTitolo.Text = "Info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Infos);
            Controls.Add(pnl_Grid);
            Controls.Add(btn_GiocaOra);
            Controls.Add(lbl_SeparatoreLogoHome);
            Controls.Add(pct_Logo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BattleShip 2025";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Logo).EndInit();
            pnl_Grid.ResumeLayout(false);
            pnl_Infos.ResumeLayout(false);
            pnl_Infos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private ImageList img_Logo;
        private PictureBox pct_Logo;
        private Label lbl_SeparatoreLogoHome;
        private Button btn_GiocaOra;
        private Panel pnl_Grid;
        private TableLayoutPanel tbl_Grid;
        private Panel pnl_Infos;
        private Label lbl_TiriNumero;
        private Label lbl_TiriTitolo;
        private Label lbl_InfosTitolo;
        private Button btn_00;
        private Button btn_01;
        private Button btn_02;
        private Button btn_03;
        private Button btn_04;
        private Button btn_05;
        private Button btn_06;
        private Button btn_07;
        private Button btn_08;
        private Button btn_09;
    }
}
