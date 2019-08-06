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
    public partial class TelaRanking : Form
    {
        public TelaRanking()
        {
            InitializeComponent();
        }
        public struct pontos
        {
            public string nome;
            public int pontuacao;
        }
        private void TelaRanking_Load(object sender, EventArgs e)
        {
            pontos[] v = new pontos[10];
            if (File.Exists("pontuacao.txt"))
            {
                string[] linhas = File.ReadAllLines("pontuacao.txt");
                {
                    for (int i = 0; i < v.Length; i++)
                    {
                        string[] dados = linhas[i].Split('|');
                        v[i].nome = dados[0];
                        v[i].pontuacao = Convert.ToInt32(dados[1]);
                    }
                }
                for (int i = 1; i < v.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (v[i].pontuacao > v[j].pontuacao)
                        {
                            int numero = v[i].pontuacao;
                            string nome = v[i].nome;
                            v[i].pontuacao = v[j].pontuacao;
                            v[i].nome = v[j].nome;
                            v[j].pontuacao = numero;
                            v[j].nome = nome;
                        }
                    }
                }
                lbnome1.Text = v[0].nome;
                lbponto1.Text = Convert.ToString(v[0].pontuacao);
                lbnome2.Text = v[1].nome;
                lbponto2.Text = Convert.ToString(v[1].pontuacao);
                lbnome3.Text = v[2].nome;
                lbponto3.Text = Convert.ToString(v[2].pontuacao);
                lbnome4.Text = v[3].nome;
                lbponto4.Text = Convert.ToString(v[3].pontuacao);
                lbnome5.Text = v[4].nome;
                lbponto5.Text = Convert.ToString(v[4].pontuacao);
                lbnome6.Text = v[5].nome;
                lbponto6.Text = Convert.ToString(v[5].pontuacao);
                lbnome7.Text = v[6].nome;
                lbponto7.Text = Convert.ToString(v[6].pontuacao);
                lbnome8.Text = v[7].nome;
                lbponto8.Text = Convert.ToString(v[7].pontuacao);
                lbnome9.Text = v[8].nome;
                lbponto9.Text = Convert.ToString(v[8].pontuacao);
                lbnome10.Text = v[9].nome;
                lbponto10.Text = Convert.ToString(v[9].pontuacao);
            }
            else
            {
                MessageBox.Show("Ainda não existe nenhum ranking");
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
