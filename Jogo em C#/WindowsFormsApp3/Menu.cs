using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{

    public partial class Menu : Form
    {

        WMPLib.WindowsMediaPlayer sons = new WMPLib.WindowsMediaPlayer();
        int musica = 0;
        public Menu()
        {
            InitializeComponent();

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label2.Font.FontFamily, label2.Font.Size + 1);
            label2.Font = tamanho;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label2.Font.FontFamily, label2.Font.Size - 1);
            label2.Font = tamanho;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size + 1);
            label3.Font = tamanho;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size - 1);
            label3.Font = tamanho;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label4.Font.FontFamily, label4.Font.Size + 1);
            label4.Font = tamanho;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label4.Font.FontFamily, label4.Font.Size - 1);
            label4.Font = tamanho;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label5.Font.FontFamily, label5.Font.Size + 1);
            label5.Font = tamanho;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label5.Font.FontFamily, label5.Font.Size - 1);
            label5.Font = tamanho;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TelaMododeJogar mododejogar = new TelaMododeJogar();
            this.Hide();
            mododejogar.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TelaSobre sobre = new TelaSobre();
            this.Hide();
            sobre.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TelaJogo form1 = new TelaJogo();
            this.Hide();
            sons.controls.stop();
            form1.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            string[] linhas = File.ReadAllLines("Dados.txt");
            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].Contains(Variaveis.login))
                {
                    if (linhas[i].Contains("MTrue"))
                    {
                        Variaveis.musica = true;
                        musica = 1;
                    }
                    if (linhas[i].Contains("MFalse"))
                    {
                        Variaveis.musica = false;
                        musica = 0;
                    }
                    if ((linhas[i].Contains("MTrue") || linhas[i].Contains("MFalse")) == false)
                    {
                        Variaveis.musica = true;
                        musica = 1;
                    }
                    if (linhas[i].Contains("STrue"))
                    {
                        Variaveis.som = false;
                    }
                    if (linhas[i].Contains("SFalse"))
                    {
                        Variaveis.som = true;
                    }
                    if ((linhas[i].Contains("STrue") || linhas[i].Contains("SFalse")) == false)
                    {
                        Variaveis.som = true;
                    }
                    if (linhas[i].Contains("facil"))
                    {
                        Variaveis.dificuldade = "facil";
                    }
                    if (linhas[i].Contains("dificil"))
                    {
                        Variaveis.dificuldade = "dificil";
                    }
                    if ((linhas[i].Contains("facil") || linhas[i].Contains("dificil")) == false)
                    {
                        Variaveis.dificuldade = "facil";
                    }
                }
            }
            
        }


        private void label6_Click(object sender, EventArgs e)
        {
            TelaRanking ranking = new TelaRanking();
            this.Hide();
            ranking.ShowDialog();
            this.Show();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label5.Font.FontFamily, label6.Font.Size + 1);
            label6.Font = tamanho;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label6.Font.FontFamily, label5.Font.Size - 1);
            label6.Font = tamanho;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TelaConfiguracao configuracao = new TelaConfiguracao();
            this.Hide();
            configuracao.ShowDialog();
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Variaveis.sair = false;
            sons.controls.stop();
            this.Close();
        }

        private void Musica_Tick(object sender, EventArgs e)
        {
            if (Variaveis.musica == true && musica == 1)
            {
                musica = 0;
                sons.URL = @"Musicadefundo.mp3";
                sons.controls.play();
                sons.settings.setMode("loop", true);
            }
            if (Variaveis.musica == false && musica == 0)
            {
                musica = 1;
                sons.URL = @"Musicadefundo.mp3";
                sons.controls.play();
                sons.settings.setMode("loop", true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variaveis.sair = true;
            this.Close();
        }
    }
}
