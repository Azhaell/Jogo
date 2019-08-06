namespace WindowsFormsApp3
{
    partial class TelaJogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaJogo));
            this.Movimentos = new System.Windows.Forms.Timer(this.components);
            this.jogador = new System.Windows.Forms.PictureBox();
            this.tiros = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frequenciatiro = new System.Windows.Forms.Timer(this.components);
            this.Pulo = new System.Windows.Forms.Timer(this.components);
            this.chao = new System.Windows.Forms.PictureBox();
            this.chao1 = new System.Windows.Forms.PictureBox();
            this.chao2 = new System.Windows.Forms.PictureBox();
            this.chao3 = new System.Windows.Forms.PictureBox();
            this.chao4 = new System.Windows.Forms.PictureBox();
            this.chao5 = new System.Windows.Forms.PictureBox();
            this.chao6 = new System.Windows.Forms.PictureBox();
            this.chao7 = new System.Windows.Forms.PictureBox();
            this.chao8 = new System.Windows.Forms.PictureBox();
            this.chao9 = new System.Windows.Forms.PictureBox();
            this.chao10 = new System.Windows.Forms.PictureBox();
            this.chao11 = new System.Windows.Forms.PictureBox();
            this.chao12 = new System.Windows.Forms.PictureBox();
            this.chao13 = new System.Windows.Forms.PictureBox();
            this.chao14 = new System.Windows.Forms.PictureBox();
            this.chao15 = new System.Windows.Forms.PictureBox();
            this.chao16 = new System.Windows.Forms.PictureBox();
            this.chao17 = new System.Windows.Forms.PictureBox();
            this.chao18 = new System.Windows.Forms.PictureBox();
            this.chao19 = new System.Windows.Forms.PictureBox();
            this.Monstro = new System.Windows.Forms.PictureBox();
            this.Monstros = new System.Windows.Forms.Timer(this.components);
            this.SpawnMonstros = new System.Windows.Forms.Timer(this.components);
            this.Colisoes = new System.Windows.Forms.Timer(this.components);
            this.barravermelha = new System.Windows.Forms.PictureBox();
            this.barradevida = new System.Windows.Forms.PictureBox();
            this.vida = new System.Windows.Forms.Label();
            this.vidaescore = new System.Windows.Forms.Timer(this.components);
            this.monstrosM = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.highscore = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monstro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barravermelha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barradevida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.SuspendLayout();
            // 
            // Movimentos
            // 
            this.Movimentos.Enabled = true;
            this.Movimentos.Interval = 25;
            this.Movimentos.Tick += new System.EventHandler(this.Movimentos_Tick);
            // 
            // jogador
            // 
            this.jogador.BackColor = System.Drawing.Color.Transparent;
            this.jogador.Image = global::WindowsFormsApp3.Properties.Resources.coracao;
            this.jogador.Location = new System.Drawing.Point(472, 545);
            this.jogador.Name = "jogador";
            this.jogador.Size = new System.Drawing.Size(74, 96);
            this.jogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jogador.TabIndex = 0;
            this.jogador.TabStop = false;
            this.jogador.Tag = "jogador";
            this.jogador.Click += new System.EventHandler(this.jogador_Click);
            // 
            // tiros
            // 
            this.tiros.Enabled = true;
            this.tiros.Interval = 25;
            this.tiros.Tick += new System.EventHandler(this.tiros_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frequenciatiro
            // 
            this.frequenciatiro.Interval = 40;
            this.frequenciatiro.Tick += new System.EventHandler(this.frequenciatiro_Tick);
            // 
            // Pulo
            // 
            this.Pulo.Interval = 1;
            this.Pulo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chao
            // 
            this.chao.BackColor = System.Drawing.Color.Transparent;
            this.chao.Image = global::WindowsFormsApp3.Properties.Resources.Chão;
            this.chao.Location = new System.Drawing.Point(0, 637);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(54, 62);
            this.chao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao.TabIndex = 2;
            this.chao.TabStop = false;
            this.chao.Tag = "chao";
            // 
            // chao1
            // 
            this.chao1.BackColor = System.Drawing.Color.Transparent;
            this.chao1.Image = ((System.Drawing.Image)(resources.GetObject("chao1.Image")));
            this.chao1.Location = new System.Drawing.Point(51, 637);
            this.chao1.Name = "chao1";
            this.chao1.Size = new System.Drawing.Size(54, 62);
            this.chao1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao1.TabIndex = 3;
            this.chao1.TabStop = false;
            this.chao1.Tag = "chao";
            // 
            // chao2
            // 
            this.chao2.BackColor = System.Drawing.Color.Transparent;
            this.chao2.Image = ((System.Drawing.Image)(resources.GetObject("chao2.Image")));
            this.chao2.Location = new System.Drawing.Point(102, 637);
            this.chao2.Name = "chao2";
            this.chao2.Size = new System.Drawing.Size(54, 62);
            this.chao2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao2.TabIndex = 4;
            this.chao2.TabStop = false;
            this.chao2.Tag = "chao";
            // 
            // chao3
            // 
            this.chao3.BackColor = System.Drawing.Color.Transparent;
            this.chao3.Image = ((System.Drawing.Image)(resources.GetObject("chao3.Image")));
            this.chao3.Location = new System.Drawing.Point(152, 637);
            this.chao3.Name = "chao3";
            this.chao3.Size = new System.Drawing.Size(54, 62);
            this.chao3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao3.TabIndex = 5;
            this.chao3.TabStop = false;
            this.chao3.Tag = "chao";
            // 
            // chao4
            // 
            this.chao4.BackColor = System.Drawing.Color.Transparent;
            this.chao4.Image = ((System.Drawing.Image)(resources.GetObject("chao4.Image")));
            this.chao4.Location = new System.Drawing.Point(203, 637);
            this.chao4.Name = "chao4";
            this.chao4.Size = new System.Drawing.Size(54, 62);
            this.chao4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao4.TabIndex = 6;
            this.chao4.TabStop = false;
            this.chao4.Tag = "chao";
            // 
            // chao5
            // 
            this.chao5.BackColor = System.Drawing.Color.Transparent;
            this.chao5.Image = ((System.Drawing.Image)(resources.GetObject("chao5.Image")));
            this.chao5.Location = new System.Drawing.Point(252, 637);
            this.chao5.Name = "chao5";
            this.chao5.Size = new System.Drawing.Size(54, 62);
            this.chao5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao5.TabIndex = 7;
            this.chao5.TabStop = false;
            this.chao5.Tag = "chao";
            // 
            // chao6
            // 
            this.chao6.BackColor = System.Drawing.Color.Transparent;
            this.chao6.Image = ((System.Drawing.Image)(resources.GetObject("chao6.Image")));
            this.chao6.Location = new System.Drawing.Point(302, 637);
            this.chao6.Name = "chao6";
            this.chao6.Size = new System.Drawing.Size(54, 62);
            this.chao6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao6.TabIndex = 8;
            this.chao6.TabStop = false;
            this.chao6.Tag = "chao";
            // 
            // chao7
            // 
            this.chao7.BackColor = System.Drawing.Color.Transparent;
            this.chao7.Image = ((System.Drawing.Image)(resources.GetObject("chao7.Image")));
            this.chao7.Location = new System.Drawing.Point(353, 637);
            this.chao7.Name = "chao7";
            this.chao7.Size = new System.Drawing.Size(54, 62);
            this.chao7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao7.TabIndex = 9;
            this.chao7.TabStop = false;
            this.chao7.Tag = "chao";
            // 
            // chao8
            // 
            this.chao8.BackColor = System.Drawing.Color.Transparent;
            this.chao8.Image = ((System.Drawing.Image)(resources.GetObject("chao8.Image")));
            this.chao8.Location = new System.Drawing.Point(402, 637);
            this.chao8.Name = "chao8";
            this.chao8.Size = new System.Drawing.Size(54, 62);
            this.chao8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao8.TabIndex = 10;
            this.chao8.TabStop = false;
            this.chao8.Tag = "chao";
            // 
            // chao9
            // 
            this.chao9.BackColor = System.Drawing.Color.Transparent;
            this.chao9.Image = ((System.Drawing.Image)(resources.GetObject("chao9.Image")));
            this.chao9.Location = new System.Drawing.Point(452, 637);
            this.chao9.Name = "chao9";
            this.chao9.Size = new System.Drawing.Size(54, 62);
            this.chao9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao9.TabIndex = 11;
            this.chao9.TabStop = false;
            this.chao9.Tag = "chao";
            // 
            // chao10
            // 
            this.chao10.BackColor = System.Drawing.Color.Transparent;
            this.chao10.Image = ((System.Drawing.Image)(resources.GetObject("chao10.Image")));
            this.chao10.Location = new System.Drawing.Point(502, 637);
            this.chao10.Name = "chao10";
            this.chao10.Size = new System.Drawing.Size(54, 62);
            this.chao10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao10.TabIndex = 12;
            this.chao10.TabStop = false;
            this.chao10.Tag = "chao";
            // 
            // chao11
            // 
            this.chao11.BackColor = System.Drawing.Color.Transparent;
            this.chao11.Image = ((System.Drawing.Image)(resources.GetObject("chao11.Image")));
            this.chao11.Location = new System.Drawing.Point(552, 637);
            this.chao11.Name = "chao11";
            this.chao11.Size = new System.Drawing.Size(54, 62);
            this.chao11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao11.TabIndex = 13;
            this.chao11.TabStop = false;
            this.chao11.Tag = "chao";
            // 
            // chao12
            // 
            this.chao12.BackColor = System.Drawing.Color.Transparent;
            this.chao12.Image = ((System.Drawing.Image)(resources.GetObject("chao12.Image")));
            this.chao12.Location = new System.Drawing.Point(602, 637);
            this.chao12.Name = "chao12";
            this.chao12.Size = new System.Drawing.Size(54, 62);
            this.chao12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao12.TabIndex = 14;
            this.chao12.TabStop = false;
            this.chao12.Tag = "chao";
            // 
            // chao13
            // 
            this.chao13.BackColor = System.Drawing.Color.Transparent;
            this.chao13.Image = ((System.Drawing.Image)(resources.GetObject("chao13.Image")));
            this.chao13.Location = new System.Drawing.Point(653, 637);
            this.chao13.Name = "chao13";
            this.chao13.Size = new System.Drawing.Size(54, 62);
            this.chao13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao13.TabIndex = 15;
            this.chao13.TabStop = false;
            this.chao13.Tag = "chao";
            // 
            // chao14
            // 
            this.chao14.BackColor = System.Drawing.Color.Transparent;
            this.chao14.Image = ((System.Drawing.Image)(resources.GetObject("chao14.Image")));
            this.chao14.Location = new System.Drawing.Point(703, 637);
            this.chao14.Name = "chao14";
            this.chao14.Size = new System.Drawing.Size(54, 62);
            this.chao14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao14.TabIndex = 16;
            this.chao14.TabStop = false;
            this.chao14.Tag = "chao";
            // 
            // chao15
            // 
            this.chao15.BackColor = System.Drawing.Color.Transparent;
            this.chao15.Image = ((System.Drawing.Image)(resources.GetObject("chao15.Image")));
            this.chao15.Location = new System.Drawing.Point(753, 637);
            this.chao15.Name = "chao15";
            this.chao15.Size = new System.Drawing.Size(54, 62);
            this.chao15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao15.TabIndex = 17;
            this.chao15.TabStop = false;
            this.chao15.Tag = "chao";
            // 
            // chao16
            // 
            this.chao16.BackColor = System.Drawing.Color.Transparent;
            this.chao16.Image = ((System.Drawing.Image)(resources.GetObject("chao16.Image")));
            this.chao16.Location = new System.Drawing.Point(803, 637);
            this.chao16.Name = "chao16";
            this.chao16.Size = new System.Drawing.Size(54, 62);
            this.chao16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao16.TabIndex = 18;
            this.chao16.TabStop = false;
            this.chao16.Tag = "chao";
            // 
            // chao17
            // 
            this.chao17.BackColor = System.Drawing.Color.Transparent;
            this.chao17.Image = ((System.Drawing.Image)(resources.GetObject("chao17.Image")));
            this.chao17.Location = new System.Drawing.Point(853, 637);
            this.chao17.Name = "chao17";
            this.chao17.Size = new System.Drawing.Size(54, 62);
            this.chao17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao17.TabIndex = 19;
            this.chao17.TabStop = false;
            this.chao17.Tag = "chao";
            // 
            // chao18
            // 
            this.chao18.BackColor = System.Drawing.Color.Transparent;
            this.chao18.Image = ((System.Drawing.Image)(resources.GetObject("chao18.Image")));
            this.chao18.Location = new System.Drawing.Point(903, 637);
            this.chao18.Name = "chao18";
            this.chao18.Size = new System.Drawing.Size(54, 62);
            this.chao18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao18.TabIndex = 20;
            this.chao18.TabStop = false;
            this.chao18.Tag = "chao";
            // 
            // chao19
            // 
            this.chao19.BackColor = System.Drawing.Color.Transparent;
            this.chao19.Image = ((System.Drawing.Image)(resources.GetObject("chao19.Image")));
            this.chao19.Location = new System.Drawing.Point(954, 637);
            this.chao19.Name = "chao19";
            this.chao19.Size = new System.Drawing.Size(54, 62);
            this.chao19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao19.TabIndex = 21;
            this.chao19.TabStop = false;
            this.chao19.Tag = "chao";
            // 
            // Monstro
            // 
            this.Monstro.BackColor = System.Drawing.Color.Transparent;
            this.Monstro.Image = global::WindowsFormsApp3.Properties.Resources.monstro;
            this.Monstro.Location = new System.Drawing.Point(1024, 555);
            this.Monstro.Name = "Monstro";
            this.Monstro.Size = new System.Drawing.Size(51, 85);
            this.Monstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Monstro.TabIndex = 22;
            this.Monstro.TabStop = false;
            // 
            // Monstros
            // 
            this.Monstros.Enabled = true;
            this.Monstros.Interval = 25;
            this.Monstros.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // SpawnMonstros
            // 
            this.SpawnMonstros.Enabled = true;
            this.SpawnMonstros.Interval = 10;
            this.SpawnMonstros.Tick += new System.EventHandler(this.SpawnMonstros_Tick);
            // 
            // Colisoes
            // 
            this.Colisoes.Enabled = true;
            this.Colisoes.Interval = 1;
            this.Colisoes.Tick += new System.EventHandler(this.Colisoes_Tick);
            // 
            // barravermelha
            // 
            this.barravermelha.BackColor = System.Drawing.Color.Red;
            this.barravermelha.Location = new System.Drawing.Point(12, 12);
            this.barravermelha.Name = "barravermelha";
            this.barravermelha.Size = new System.Drawing.Size(300, 25);
            this.barravermelha.TabIndex = 23;
            this.barravermelha.TabStop = false;
            // 
            // barradevida
            // 
            this.barradevida.BackColor = System.Drawing.Color.Lime;
            this.barradevida.Location = new System.Drawing.Point(12, 12);
            this.barradevida.Name = "barradevida";
            this.barradevida.Size = new System.Drawing.Size(300, 25);
            this.barradevida.TabIndex = 24;
            this.barradevida.TabStop = false;
            // 
            // vida
            // 
            this.vida.BackColor = System.Drawing.Color.Transparent;
            this.vida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vida.Location = new System.Drawing.Point(334, 12);
            this.vida.Name = "vida";
            this.vida.Size = new System.Drawing.Size(122, 25);
            this.vida.TabIndex = 25;
            this.vida.Text = "a";
            // 
            // vidaescore
            // 
            this.vidaescore.Enabled = true;
            this.vidaescore.Interval = 1;
            this.vidaescore.Tick += new System.EventHandler(this.vidaescore_Tick);
            // 
            // monstrosM
            // 
            this.monstrosM.BackColor = System.Drawing.Color.Transparent;
            this.monstrosM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monstrosM.Location = new System.Drawing.Point(770, 12);
            this.monstrosM.Name = "monstrosM";
            this.monstrosM.Size = new System.Drawing.Size(205, 25);
            this.monstrosM.TabIndex = 26;
            this.monstrosM.Text = "a";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Location = new System.Drawing.Point(998, -1);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(10, 700);
            this.pictureBox22.TabIndex = 27;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "Parede";
            this.pictureBox22.Visible = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.Location = new System.Drawing.Point(0, -1);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(10, 700);
            this.pictureBox23.TabIndex = 28;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "Parede";
            this.pictureBox23.Visible = false;
            // 
            // highscore
            // 
            this.highscore.Enabled = true;
            this.highscore.Interval = 1000;
            this.highscore.Tick += new System.EventHandler(this.highscore_Tick);
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Campo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 699);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.monstrosM);
            this.Controls.Add(this.vida);
            this.Controls.Add(this.barradevida);
            this.Controls.Add(this.barravermelha);
            this.Controls.Add(this.chao16);
            this.Controls.Add(this.chao15);
            this.Controls.Add(this.Monstro);
            this.Controls.Add(this.chao17);
            this.Controls.Add(this.chao19);
            this.Controls.Add(this.chao18);
            this.Controls.Add(this.chao14);
            this.Controls.Add(this.chao13);
            this.Controls.Add(this.chao12);
            this.Controls.Add(this.chao11);
            this.Controls.Add(this.chao10);
            this.Controls.Add(this.chao9);
            this.Controls.Add(this.chao8);
            this.Controls.Add(this.chao7);
            this.Controls.Add(this.chao6);
            this.Controls.Add(this.chao5);
            this.Controls.Add(this.chao4);
            this.Controls.Add(this.chao3);
            this.Controls.Add(this.chao2);
            this.Controls.Add(this.chao1);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.jogador);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SURVIVE!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.Form1_BackgroundImageChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.jogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monstro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barravermelha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barradevida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox jogador;
        private System.Windows.Forms.Timer Movimentos;
        private System.Windows.Forms.Timer tiros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer frequenciatiro;
        private System.Windows.Forms.Timer Pulo;
        private System.Windows.Forms.PictureBox chao;
        private System.Windows.Forms.PictureBox chao1;
        private System.Windows.Forms.PictureBox chao2;
        private System.Windows.Forms.PictureBox chao3;
        private System.Windows.Forms.PictureBox chao4;
        private System.Windows.Forms.PictureBox chao5;
        private System.Windows.Forms.PictureBox chao6;
        private System.Windows.Forms.PictureBox chao7;
        private System.Windows.Forms.PictureBox chao8;
        private System.Windows.Forms.PictureBox chao9;
        private System.Windows.Forms.PictureBox chao10;
        private System.Windows.Forms.PictureBox chao11;
        private System.Windows.Forms.PictureBox chao12;
        private System.Windows.Forms.PictureBox chao13;
        private System.Windows.Forms.PictureBox chao14;
        private System.Windows.Forms.PictureBox chao15;
        private System.Windows.Forms.PictureBox chao16;
        private System.Windows.Forms.PictureBox chao17;
        private System.Windows.Forms.PictureBox chao18;
        private System.Windows.Forms.PictureBox chao19;
        private System.Windows.Forms.PictureBox Monstro;
        private System.Windows.Forms.Timer Monstros;
        private System.Windows.Forms.Timer SpawnMonstros;
        private System.Windows.Forms.Timer Colisoes;
        private System.Windows.Forms.PictureBox barravermelha;
        private System.Windows.Forms.PictureBox barradevida;
        private System.Windows.Forms.Label vida;
        private System.Windows.Forms.Timer vidaescore;
        private System.Windows.Forms.Label monstrosM;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.Timer highscore;
    }
}

