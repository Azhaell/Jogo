using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace WindowsFormsApp3
{
    public partial class TelaJogo : Form


    {
        Keys ultimatecla;
        //variaveis de movimentação
        static bool vaiparadireita = false;
        static bool vaiparaesquerda = false;
        static bool parado = true;
        static bool atirar = false;
        static bool pular = false;
        static int alturadopulo = 40;
        static int ftiro = 0;
        //contador para barra de vida
        static int i = 0;
        //variaveis relacionadas a morte dos monstros
        static int monstrosmortos = 0;
        int contador = 0;
        //imagens dos monstros
        Bitmap monstro;
        Bitmap monstroinvertido;
        //variaveis relacionadas a velocidade de passagem das imagens dos personagens
        int frames = 0, maxFrames = 4, index = 0, maxIndex = 4;
        //variaveis relacionadas a frequencia dos tiros
        int framestiro = 0, maxFramestiro = 3, indextiro = 0, maxIndextiro = 3;
        //inicializa o mediaplayer para reproduzir as musicas do jogo
        WMPLib.WindowsMediaPlayer sons = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer tiro = new WMPLib.WindowsMediaPlayer();
        int trocademapa = 0;
        int monstroscriados = 0;
        int tempo = 0;




        public TelaJogo()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assim que o jogo é iniciado,a musica de funda começa a tocar
            if (Variaveis.musica == true)
            {
                sons.URL = @"Musicadefundo.mp3";
                sons.controls.play();
                sons.settings.setMode("loop", true);
            }

        }
        //Este é o evento que detecta quando o jogador apertou uma tecla
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {

                vaiparadireita = true;
                parado = false;

            }

            if (e.KeyCode == Keys.Left)
            {
                vaiparaesquerda = true;
                parado = false;

            }
            //esse atirar == false é o q limita a frequencia de tiro do jogo
            if (e.KeyCode == Keys.Space && atirar == false)
            {
                atirar = true;
                frequenciatiro.Start();


            }
            if (e.KeyCode == Keys.Up)
            {
                //o jogador só pode pular se ele não estiver pulando
                //A variavel alturadopulo sera melhor explicada no timer de pulo
                if (pular == false && alturadopulo >= 0)
                {
                    pular = true;
                    Pulo.Start();
                }
            }


        }
        //evento que detecta quando o jogador soltou a tecla
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                vaiparadireita = false;
                parado = true;

            }
            if (e.KeyCode == Keys.Left)
            {
                vaiparaesquerda = false;
                parado = true;

            }
            if (e.KeyCode == Keys.Space)
            {
                atirar = false;
            }
            if (e.KeyCode != Keys.Space)
            {
                ultimatecla = e.KeyCode;
            }
        }
        private void Movimentos_Tick(object sender, EventArgs e)
        {
            //Esta parte consiste em passar varias imagens em sequencia do personagem se movendo para dar uma sensação de movimento
            //Basicamente o timer fica trocando as imagens dentro da picturebox
            //Foi necessario usar as variaveis frames,index, etc, pois sem elas as imagens eram trocadas tão rapido dentro da picturebox
            //que parecia que elas não estavam sendo trocadas, então essas variaveis servem para dar um "delay" nessa troca de imagens
            if (vaiparadireita == true)
            {
                jogador.Left += 5;
                frames++;
                if (frames == maxFrames)
                {
                    frames = 0;
                    if (index == 0)
                    {
                        jogador.Image = Properties.Resources.Andando_1;
                    }
                    if (index == 1)
                    {
                        jogador.Image = Properties.Resources.Andando_2;
                    }
                    if (index == 2)
                    {
                        jogador.Image = Properties.Resources.Andando_3;
                    }
                    if (index == 3)
                    {
                        jogador.Image = Properties.Resources.Andando_4;
                    }
                    if (index == 4)
                    {
                        jogador.Image = Properties.Resources.Andando_5;
                    }
                    index++;
                    if (index > maxIndex)
                    {
                        index = 0;
                    }
                }
            }
            if (vaiparaesquerda == true)
            {
                jogador.Left += -5;
                frames++;
                if (frames == maxFrames)
                {
                    frames = 0;
                    if (index == 0)
                    {
                        Bitmap imagem;
                        imagem = Properties.Resources.Andando_1;
                        //Para não ter que adicionar mais 5 imagens do personagem virado para o outro lado, foi usado o comando RotateFlip
                        imagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                        jogador.Image = imagem;
                    }
                    if (index == 1)
                    {
                        Bitmap imagem;
                        imagem = Properties.Resources.Andando_2;
                        imagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                        jogador.Image = imagem;
                    }
                    if (index == 2)
                    {
                        Bitmap imagem;
                        imagem = Properties.Resources.Andando_3;
                        imagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                        jogador.Image = imagem;
                    }
                    if (index == 3)
                    {
                        Bitmap imagem;
                        imagem = Properties.Resources.Andando_4;
                        imagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                        jogador.Image = imagem;
                    }
                    if (index == 4)
                    {
                        Bitmap imagem;
                        imagem = Properties.Resources.Andando_5;
                        imagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                        jogador.Image = imagem;
                    }
                    index++;
                    if (index > maxIndex)
                    {
                        index = 0;
                    }
                }
            }
            if (vaiparaesquerda == false && vaiparadireita == false)
            {
                jogador.Image = Properties.Resources.Soldado_Parado;

            }
            if (ultimatecla == Keys.Left && vaiparaesquerda == false && vaiparadireita == false)
            {
                Bitmap imagem;
                imagem = Properties.Resources.Soldado_Parado;
                imagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                jogador.Image = imagem;
            }


        }
        //Timer que faz o jogador pular
        private void timer1_Tick(object sender, EventArgs e)
        {
            jogador.Refresh();
            //a altura do pulo é definida inicialmente como 40, então quando for pressionado o botão de pulo, o programa entrara nesse if
            if (pular == true && alturadopulo >= 0)
            {
                //aqui o personagem sobe uma determinada altura
                jogador.Top -= 5;
                //a cada tick do timer, vai descontando 1 na variavel altura
                alturadopulo -= 1;

            }
            //quando a altura for menor ou igual a 0, ele para de subir
            if (alturadopulo <= 0)
            {
                pular = false;

            }
            if (pular == false)
            {
                jogador.Top += 6;
            }
            //Assim que o personagem colide com o chão novamente no timer de Colisões,o timer de pulo é encerrado (.Stop())

        }
        private void frequenciatiro_Tick(object sender, EventArgs e)
        {

            ftiro++;
            if (ftiro == 10)
            {

                NovaBala();
                ftiro = 0;
                atirar = false;
                frequenciatiro.Stop();
            }



        }
        public void NovaBala()
        {


            // cria uma nova bala
            PictureBox bala = new PictureBox();
            Bitmap imagem;
            imagem = Properties.Resources.Bala;
            //detecta se o personagem esta atirando para direita ou para esquerda
            if (vaiparadireita == true || parado == true && (ultimatecla == Keys.Left && vaiparaesquerda == false && vaiparadireita == false) == false)
            {
                //a imagem inicialmente é colocada virada para cima, então o rotate serve para deixar ela do lado certo
                imagem.RotateFlip(RotateFlipType.Rotate90FlipY);
                //aqui estão todas as variaveis da criação da bala
                bala.Image = imagem;
                bala.Size = new Size(10, 20);
                bala.Tag = "bulletD";
                bala.Left = jogador.Left + jogador.Width;
                bala.Top = jogador.Top + 30;
                bala.BackColor = Color.Transparent;
                this.Controls.Add(bala);
                bala.BringToFront();
                if (Variaveis.som == true)
                {
                    tiro.URL = @"somdetiro.mp3";
                    tiro.controls.play();
                }

            }
            else if (vaiparaesquerda == true || (vaiparaesquerda == true && pular == true) || (ultimatecla == Keys.Left && vaiparaesquerda == false && vaiparadireita == false))
            {
                imagem.RotateFlip(RotateFlipType.Rotate270FlipY);
                bala.Image = imagem;
                bala.Size = new Size(10, 20);
                bala.Tag = "bulletE";
                bala.Left = jogador.Right - jogador.Width - 20;
                bala.Top = jogador.Top + 30;
                bala.BackColor = Color.Transparent;
                this.Controls.Add(bala);
                bala.BringToFront();
                if (Variaveis.som == true)
                {
                    tiro.URL = @"somdetiro.mp3";
                    tiro.controls.play();
                }
            }

        }
        private void tiros_Tick_1(object sender, EventArgs e)
        {
            //como a bala é uma picturebox que é criada durante a execução do jogo,foi necessario usar o "Control"
            //pois não aparecia a opção  "bala.Left" por exemplo
            foreach (Control y in this.Controls)
            {
                //se for uma picturebox e se a tag dessa picturebox for bulletD, então é uma bala que foi disparada para direita
                if (y is PictureBox && y.Tag == "bulletD")
                {
                    y.Left += 20;


                }
                if (y is PictureBox && y.Tag == "bulletE")
                {
                    y.Left -= 20;

                }
            }
        }

        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {
            Bitmap imagem = Properties.Resources.chao2;
            if (monstrosmortos == 10 && trocademapa == 1)
            {
                imagem = Properties.Resources.chao2;
            }
            if (monstrosmortos == 20 && trocademapa == 2)
            {
                imagem = Properties.Resources.chao4;

            }
            chao.Image = imagem;
            chao1.Image = imagem;
            chao2.Image = imagem;
            chao3.Image = imagem;
            chao4.Image = imagem;
            chao5.Image = imagem;
            chao6.Image = imagem;
            chao7.Image = imagem;
            chao8.Image = imagem;
            chao9.Image = imagem;
            chao10.Image = imagem;
            chao11.Image = imagem;
            chao12.Image = imagem;
            chao13.Image = imagem;
            chao14.Image = imagem;
            chao15.Image = imagem;
            chao16.Image = imagem;
            chao17.Image = imagem;
            chao18.Image = imagem;
            chao19.Image = imagem;

        }

        private void SpawnMonstros_Tick(object sender, EventArgs e)
        {
            if (monstroscriados <= 3)
            {
                Random random = new Random();
                int a = random.Next(0, 400);
                int b = random.Next(0, 400);
                if (a == 150)
                {
                    NovoMonstro();
                }
                if (a == 151)
                {
                    NovoMonstroInvertido();
                }
                if (b == 150)
                {
                    NovaMumia();
                }
                if (b == 151)
                {
                    NovaMumiaInvertida();
                }
            }

        }

        private void jogador_Click(object sender, EventArgs e)
        {

        }

        private void highscore_Tick(object sender, EventArgs e)
        {
            tempo++;
            Variaveis.highscore = monstrosmortos * tempo;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void NovoMonstro()
        {
            //são criadas 3 imagens do mesmo monstro ao mesmo tempo,isso da um efeito de que o monstro tem mais vida
            //pois a cada tiro,uma das imagens é apagada, então com 3 tiros o monstro morre


            monstroscriados++;
            Monstros monstro = new Monstros();
            Bitmap imagem;
            imagem = Properties.Resources.monstro;
            monstro.Name = "monstros" + Convert.ToString(monstroscriados);
            monstro.Image = imagem;
            monstro.Size = new Size(51, 85);
            monstro.SizeMode = PictureBoxSizeMode.StretchImage;
            monstro.Tag = "monstros";
            monstro.Left = 1024;
            monstro.Top = 555;
            monstro.Vida = 2;
            if (Variaveis.dificuldade == "dificil")
            {
                monstro.Vida = 4;
            }
            monstro.BackColor = Color.Transparent;
            this.Controls.Add(monstro);
            monstro.BringToFront();

        }
        public void NovaMumia()
        {
            monstroscriados++;
            Monstros monstro = new Monstros();
            Bitmap imagem;
            imagem = Properties.Resources.mumia_invertida;
            monstro.Name = "mumia" + Convert.ToString(monstroscriados);
            monstro.Image = imagem;
            monstro.Size = new Size(51, 85);
            monstro.SizeMode = PictureBoxSizeMode.StretchImage;
            monstro.Tag = "mumia";
            monstro.Left = 1024;
            monstro.Top = 555;
            monstro.Vida = 3;
            if (Variaveis.dificuldade == "dificil")
            {
                monstro.Vida = 5;
            }
            monstro.BackColor = Color.Transparent;
            this.Controls.Add(monstro);
            monstro.BringToFront();
        }
        public void NovoMonstroInvertido()
        {

            monstroscriados++;
            Monstros monstro = new Monstros();
            Bitmap imagem;
            imagem = Properties.Resources.monstroinvertido;
            monstro.Name = "monstrosinvertidos" + Convert.ToString(monstroscriados);
            monstro.Image = imagem;
            monstro.Size = new Size(51, 85);
            monstro.SizeMode = PictureBoxSizeMode.StretchImage;
            monstro.Tag = "monstrosinvertidos";
            monstro.Left = 0 - 85;
            monstro.Top = 555;
            monstro.Vida = 2;
            if (Variaveis.dificuldade == "dificil")
            {
                monstro.Vida = 4;
            }
            monstro.BackColor = Color.Transparent;
            this.Controls.Add(monstro);
            monstro.BringToFront();
        }
        public void NovaMumiaInvertida()
        {
            monstroscriados++;
            Monstros monstro = new Monstros();
            Bitmap imagem;
            imagem = Properties.Resources.mumia;
            monstro.Name = "mumiainvertida" + Convert.ToString(monstroscriados);
            monstro.Image = imagem;
            monstro.Size = new Size(51, 85);
            monstro.SizeMode = PictureBoxSizeMode.StretchImage;
            monstro.Tag = "mumiainvertida";
            monstro.Left = 0 - 85;
            monstro.Top = 555;
            monstro.Vida = 3;
            if (Variaveis.dificuldade == "dificil")
            {
                monstro.Vida = 5;
            }
            monstro.BackColor = Color.Transparent;
            this.Controls.Add(monstro);
            monstro.BringToFront();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (Control y in this.Controls)
            {
                //detecta se é uma picturebox e se ela tem a tag monstro, se sim faz o monstro andar para frente
                if (y is PictureBox && y.Tag == "monstros")
                {
                    y.Left -= 6;


                }
                if (y is PictureBox && y.Tag == "monstrosinvertidos")
                {
                    y.Left += 6;


                }
                if (y is PictureBox && y.Tag == "mumia")
                {
                    y.Left -= 6;
                }
                if (y is PictureBox && y.Tag == "mumiainvertida")
                {
                    y.Left += 6;
                }
            }
        }

        public void Colisoes_Tick(object sender, EventArgs e)
        {
            #region colisão tiro/monstro
            //aqui são utilizados dois foreachs com duas variaveis, y e j, quando y for uma bala e j for um monstro e eles se encostarem
            //essas duas picturebox são removidas
            foreach (Control y in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (y is PictureBox && (y.Tag == "bulletD" || y.Tag == "bulletE"))
                    {
                        if (j is Monstros && (j.Tag == "monstros" || j.Tag == "monstrosinvertidos" || j.Tag == "mumia" || j.Tag == "mumiainvertida"))
                        {
                            //detecta se teve colisão entre as picturebox
                            if (y.Bounds.IntersectsWith(j.Bounds))
                            {

                                int dano = 1;
                                ((Monstros)this.Controls.Find(j.Name, false)[0]).Vida -= dano;
                                if (((Monstros)this.Controls.Find(j.Name, false)[0]).Vida == 0)
                                {

                                    monstrosmortos++;
                                    monstroscriados--;
                                    Random coracaodevida = new Random();
                                    int a = coracaodevida.Next(0, 5);
                                    if (a == 2)
                                    {
                                        PictureBox coracao = new PictureBox();
                                        Bitmap imagem;
                                        imagem = Properties.Resources.coracao;
                                        coracao.Image = imagem;
                                        coracao.Size = new Size(51, 51);
                                        coracao.SizeMode = PictureBoxSizeMode.StretchImage;
                                        coracao.Tag = "coracao";
                                        coracao.Location = ((Monstros)this.Controls.Find(j.Name, false)[0]).Location;
                                        coracao.BackColor = Color.Transparent;
                                        this.Controls.Add(coracao);
                                        coracao.BringToFront();
                                    }
                                    this.Controls.Remove(j);
                                }
                                this.Controls.Remove(y);

                            }
                        }

                    }
                }
            }
            #endregion
            #region colisão jogador/monstro
            //essa parte do programa é o que faz o jogador tomar dano, e o monstro virar para o outro lado quando encosta no jogador
            foreach (Control y in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (y is PictureBox && y.Tag == "jogador")
                    {
                        //perceba que aqui é se a tag do for "monstros",e mais abaixo é se a tag for "monstrosinvertidos"
                        //isso foi feito pois se o monstro esta vindo da direita e ele colide com o personagem,ele vira para a esquerda e vice-versa
                        if (j is Monstros && (j.Tag == "monstros"))
                        {

                            if (y.Bounds.IntersectsWith(j.Bounds))
                            {
                                if (jogador.Top > 535)
                                {
                                    Bitmap imagem;
                                    imagem = Properties.Resources.monstroinvertido;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Image = imagem;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Tag = "monstrosinvertidos";
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Left = j.Left + 15;
                                    barradevida.Width = barradevida.Width - 12;
                                }
                            }
                        }
                        if (j is Monstros && (j.Tag == "monstrosinvertidos"))
                        {
                            if (y.Bounds.IntersectsWith(j.Bounds))
                            {
                                if (jogador.Top > 535)
                                {
                                    Bitmap imagem;
                                    imagem = Properties.Resources.monstro;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Image = imagem;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Tag = "monstros";
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Left = j.Left - 15;

                                    barradevida.Width = barradevida.Width - 12;
                                }
                            }
                        }
                        if (j is Monstros && (j.Tag == "mumia"))
                        {
                            if (y.Bounds.IntersectsWith(j.Bounds))
                            {
                                if (jogador.Top > 535)
                                {
                                    Bitmap imagem;
                                    imagem = Properties.Resources.mumia;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Image = imagem;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Tag = "mumiainvertida";
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Left = j.Left + 15;

                                    barradevida.Width = barradevida.Width - 24;
                                }
                            }

                        }
                        if (j is Monstros && (j.Tag == "mumiainvertida"))
                        {
                            if (y.Bounds.IntersectsWith(j.Bounds))
                            {
                                if (jogador.Top > 535)
                                {
                                    Bitmap imagem;
                                    imagem = Properties.Resources.mumia_invertida;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Image = imagem;
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Tag = "mumia";
                                    ((Monstros)this.Controls.Find(j.Name, false)[0]).Left = j.Left - 15;

                                    barradevida.Width = barradevida.Width - 24;
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region colisão tiro/parede invisivel
            //existe duas paredes invisiveis nas bordas da tela, se o tiro encostar nessas paredes ele some
            foreach (Control y in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (y is PictureBox && (y.Tag == "bulletD" || y.Tag == "bulletE"))
                    {
                        if (j is PictureBox && (j.Tag == "Parede"))
                        {
                            if (y.Bounds.IntersectsWith(j.Bounds))
                            {

                                this.Controls.Remove(y);

                            }
                        }

                    }
                }
            }
            #endregion
            #region personagem/chao
            //aqui,se o personagem estiver pulando e começar a cair, ele só para de cair quando encostar no chão
            foreach (Control y in this.Controls)
            {

                if (y is PictureBox && (y.Tag == "plataforma" || y.Tag == "chao"))
                {
                    if (jogador.Bounds.IntersectsWith(y.Bounds) == true)
                    {
                        if (pular == false)
                        {
                            //a altura do pulo é definida para 40 novamente e assim ele pode pular novamente
                            alturadopulo = 40;
                            //deixa o jogador exatamente em cima da picturebox do chão
                            jogador.Top = y.Top - jogador.Height;
                            //para o timer do pulo
                            Pulo.Stop();

                        }
                    }

                }

            }
            #endregion
            #region personagem/vida
            foreach (Control y in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (y is PictureBox && y.Tag == "jogador")
                    {

                        if (j is PictureBox && (j.Tag == "coracao"))
                        {
                            if (barradevida.Width <= 270)
                            {
                                if (y.Bounds.IntersectsWith(j.Bounds))
                                {
                                    barradevida.Width += 30;
                                    this.Controls.Remove(j);
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region monstros saindo da tela
            foreach (Control y in this.Controls)
            {
                if (y is Monstros && (y.Tag == "monstros" || y.Tag == "mumia"))
                {
                    if (((Monstros)this.Controls.Find(y.Name, false)[0]).Left < 0)
                    {
                        this.Controls.Remove(y);
                        monstroscriados--;
                    }

                }
                if (y is Monstros && (y.Tag == "monstrosinvertidos" || y.Tag == "mumiainvertida"))
                {
                    if (((Monstros)this.Controls.Find(y.Name, false)[0]).Left > 1024)
                    {
                        this.Controls.Remove(y);
                        monstroscriados--;
                    }

                }
            }
            #endregion
            #region personagem pulando/monstro
            foreach (Control y in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (y is PictureBox && y.Tag == "jogador")
                    {
                        //perceba que aqui é se a tag do for "monstros",e mais abaixo é se a tag for "monstrosinvertidos"
                        //isso foi feito pois se o monstro esta vindo da direita e ele colide com o personagem,ele vira para a esquerda e vice-versa
                        if (j is Monstros && (j.Tag == "monstros" || j.Tag == "monstrosinvertidos" || j.Tag == "mumia" || j.Tag == "mumiainvertida"))
                        {
                            if (jogador.Top < 535)
                            {
                                if (y.Bounds.IntersectsWith(j.Bounds))
                                {
                                    this.Controls.Remove(j);
                                    barradevida.Width = barradevida.Width - 30;
                                    monstroscriados--;
                                }

                            }
                        }
                    }
                }
            }
            #endregion
        }
        private void vidaescore_Tick(object sender, EventArgs e)
        {
            Bitmap cidade = Properties.Resources.Cidade;
            //aqui existe um label que mostra a vida do personagem
            vida.Text = "Vida: " + Convert.ToString(barradevida.Width / 3);
            //outro label que mostra os monstros mortos
            monstrosM.Text = "Monstros Mortos: " + Convert.ToString(monstrosmortos);

            if (monstrosmortos == 10 && trocademapa == 0)
            {
                trocademapa++;
                this.BackgroundImage = Properties.Resources.Cidade;

            }
            if (monstrosmortos == 20 && trocademapa == 1)
            {
                trocademapa++;
                this.BackgroundImage = Properties.Resources.neve;
            }
            //se a barra de vida zerar então o jogo acaba e aparece outra tela dizendo que voce morreu
            if (barradevida.Width == 0)
            {
                i += 1;
            }
            if (barradevida.Width == 0 && i == 1)
            {
                TelaMorte morte = new TelaMorte();
                Movimentos.Stop();
                tiros.Stop();
                frequenciatiro.Stop();
                Pulo.Stop();
                Monstros.Stop();
                SpawnMonstros.Stop();
                Colisoes.Stop();
                vidaescore.Stop();
                sons.controls.stop();
                tiro.controls.stop();
                highscore.Stop();
                monstrosmortos = 0;
                monstroscriados = 0;
                vaiparadireita = false;
                vaiparaesquerda = false;
                parado = true;
                atirar = false;
                pular = false;
                if (File.Exists("pontuacao.txt"))
                {
                    
                    bool existe = false;
                    string[] linhas = File.ReadAllLines("pontuacao.txt");
                    for (int i = 0; i < linhas.Length; i++)
                    {
                        if (linhas[i].Contains(Variaveis.login))
                        {
                            existe = true;
                            string[] dados = linhas[i].Split('|');
                            if (Variaveis.highscore > Convert.ToInt32(dados[1]))
                            {
                                dados[1] = Convert.ToString(Variaveis.highscore);
                                linhas[i] = dados[0] + '|' + dados[1];
                                existe = true;
                                string texto = "";
                                for (int j = 0; j < linhas.Length; j++)
                                {
                                    texto += linhas[j] + Environment.NewLine;
                                }
                                File.WriteAllText("pontuacao.txt", texto);
                                MessageBox.Show("Pontuação Salva");
                                
                            }
                           
                            
                        }


                    }
                    if (existe == false)
                    {
                            File.AppendAllText("pontuacao.txt", Variaveis.login + "|" +
                            Convert.ToString(Variaveis.highscore) + Environment.NewLine);
                    }
                    
                }
                else
                {
                    File.AppendAllText("pontuacao.txt", Variaveis.login + "|" +
                           Convert.ToString(Variaveis.highscore) + Environment.NewLine);
                }
                this.Hide();
                morte.ShowDialog();
                i = 0;
                this.Close();

            }
        }
    }
}
