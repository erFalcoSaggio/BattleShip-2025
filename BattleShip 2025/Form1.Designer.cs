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
            lbl_TIriNumero = new Label();
            lbl_TiriTitolo = new Label();
            lbl_InfosTitolo = new Label();
            btn_00 = new Button();
            btn_01 = new Button();
            btn_02 = new Button();
            btn_03 = new Button();
            btn_04 = new Button();
            btn_05 = new Button();
            btn_06 = new Button();
            btn_07 = new Button();
            btn_08 = new Button();
            btn_09 = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_Logo).BeginInit();
            pnl_Grid.SuspendLayout();
            tbl_Grid.SuspendLayout();
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
            tbl_Grid.Controls.Add(btn_00, 0, 0);
            tbl_Grid.Controls.Add(btn_01, 1, 0);
            tbl_Grid.Controls.Add(btn_02, 2, 0);
            tbl_Grid.Controls.Add(btn_03, 3, 0);
            tbl_Grid.Controls.Add(btn_04, 4, 0);
            tbl_Grid.Controls.Add(btn_05, 5, 0);
            tbl_Grid.Controls.Add(btn_06, 6, 0);
            tbl_Grid.Controls.Add(btn_07, 7, 0);
            tbl_Grid.Controls.Add(btn_08, 8, 0);
            tbl_Grid.Controls.Add(btn_09, 9, 0);
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
            pnl_Infos.Controls.Add(lbl_TIriNumero);
            pnl_Infos.Controls.Add(lbl_TiriTitolo);
            pnl_Infos.Controls.Add(lbl_InfosTitolo);
            pnl_Infos.Location = new Point(646, 211);
            pnl_Infos.Name = "pnl_Infos";
            pnl_Infos.Size = new Size(142, 227);
            pnl_Infos.TabIndex = 4;
            // 
            // lbl_TIriNumero
            // 
            lbl_TIriNumero.AutoSize = true;
            lbl_TIriNumero.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_TIriNumero.Location = new Point(58, 49);
            lbl_TIriNumero.Name = "lbl_TIriNumero";
            lbl_TIriNumero.Size = new Size(25, 30);
            lbl_TIriNumero.TabIndex = 1;
            lbl_TIriNumero.Text = "0";
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
            // btn_00
            // 
            btn_00.BackColor = Color.FromArgb(0, 192, 192);
            btn_00.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_00.ForeColor = SystemColors.Control;
            btn_00.Location = new Point(3, 3);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(56, 36);
            btn_00.TabIndex = 2;
            btn_00.UseVisualStyleBackColor = false;
            btn_00.Click += btn_GiocaOra_Click;
            // 
            // btn_01
            // 
            btn_01.BackColor = Color.FromArgb(0, 192, 192);
            btn_01.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_01.ForeColor = SystemColors.Control;
            btn_01.Location = new Point(65, 3);
            btn_01.Name = "btn_01";
            btn_01.Size = new Size(56, 36);
            btn_01.TabIndex = 2;
            btn_01.UseVisualStyleBackColor = false;
            btn_01.Click += btn_GiocaOra_Click;
            // 
            // btn_02
            // 
            btn_02.BackColor = Color.FromArgb(0, 192, 192);
            btn_02.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_02.ForeColor = SystemColors.Control;
            btn_02.Location = new Point(127, 3);
            btn_02.Name = "btn_02";
            btn_02.Size = new Size(56, 36);
            btn_02.TabIndex = 2;
            btn_02.UseVisualStyleBackColor = false;
            btn_02.Click += btn_GiocaOra_Click;
            // 
            // btn_03
            // 
            btn_03.BackColor = Color.FromArgb(0, 192, 192);
            btn_03.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_03.ForeColor = SystemColors.Control;
            btn_03.Location = new Point(189, 3);
            btn_03.Name = "btn_03";
            btn_03.Size = new Size(56, 36);
            btn_03.TabIndex = 2;
            btn_03.UseVisualStyleBackColor = false;
            btn_03.Click += btn_GiocaOra_Click;
            // 
            // btn_04
            // 
            btn_04.BackColor = Color.FromArgb(0, 192, 192);
            btn_04.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_04.ForeColor = SystemColors.Control;
            btn_04.Location = new Point(251, 3);
            btn_04.Name = "btn_04";
            btn_04.Size = new Size(56, 36);
            btn_04.TabIndex = 2;
            btn_04.UseVisualStyleBackColor = false;
            btn_04.Click += btn_GiocaOra_Click;
            // 
            // btn_05
            // 
            btn_05.BackColor = Color.FromArgb(0, 192, 192);
            btn_05.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_05.ForeColor = SystemColors.Control;
            btn_05.Location = new Point(313, 3);
            btn_05.Name = "btn_05";
            btn_05.Size = new Size(56, 36);
            btn_05.TabIndex = 2;
            btn_05.UseVisualStyleBackColor = false;
            btn_05.Click += btn_GiocaOra_Click;
            // 
            // btn_06
            // 
            btn_06.BackColor = Color.FromArgb(0, 192, 192);
            btn_06.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_06.ForeColor = SystemColors.Control;
            btn_06.Location = new Point(375, 3);
            btn_06.Name = "btn_06";
            btn_06.Size = new Size(56, 36);
            btn_06.TabIndex = 2;
            btn_06.UseVisualStyleBackColor = false;
            btn_06.Click += btn_GiocaOra_Click;
            // 
            // btn_07
            // 
            btn_07.BackColor = Color.FromArgb(0, 192, 192);
            btn_07.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_07.ForeColor = SystemColors.Control;
            btn_07.Location = new Point(437, 3);
            btn_07.Name = "btn_07";
            btn_07.Size = new Size(56, 36);
            btn_07.TabIndex = 2;
            btn_07.UseVisualStyleBackColor = false;
            btn_07.Click += btn_GiocaOra_Click;
            // 
            // btn_08
            // 
            btn_08.BackColor = Color.FromArgb(0, 192, 192);
            btn_08.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_08.ForeColor = SystemColors.Control;
            btn_08.Location = new Point(499, 3);
            btn_08.Name = "btn_08";
            btn_08.Size = new Size(56, 36);
            btn_08.TabIndex = 2;
            btn_08.UseVisualStyleBackColor = false;
            btn_08.Click += btn_GiocaOra_Click;
            // 
            // btn_09
            // 
            btn_09.BackColor = Color.FromArgb(0, 192, 192);
            btn_09.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_09.ForeColor = SystemColors.Control;
            btn_09.Location = new Point(561, 3);
            btn_09.Name = "btn_09";
            btn_09.Size = new Size(56, 36);
            btn_09.TabIndex = 2;
            btn_09.UseVisualStyleBackColor = false;
            btn_09.Click += btn_GiocaOra_Click;
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
            tbl_Grid.ResumeLayout(false);
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
        private Label lbl_TIriNumero;
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
