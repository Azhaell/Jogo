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
    public partial class TelaConfiguracao : Form
    {

        public TelaConfiguracao()
        {
            InitializeComponent();
        }



        private void label3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Variaveis.musica = false;
            }
            else
            {
                Variaveis.musica = true;
            }
            if (checkBox2.Checked)
            {
                Variaveis.som = false;
            }
            else
            {
                Variaveis.som = true;
            }
            if (checkBox3.Checked)
            {
                Variaveis.dificuldade = "facil";
                checkBox4.Checked = false;
            }
            else
            {
                Variaveis.dificuldade = "dificil";
                checkBox3.Checked = false;
            }

            string[] linhas = File.ReadAllLines("Dados.txt");
            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].Contains(Variaveis.login))
                {
                    string[] dadosantigos = linhas[i].Split('|');
                    string[] dados = new string[6];
                    dados[0] = "";
                    dados[1] = "";
                    dados[2] = "";
                    dados[3] = "";
                    dados[4] = "";
                    for (int j=0 ;j<dadosantigos.Length;j++)
                    {
                        dados[j] = dadosantigos[j];
                    }
                    
                    dados[2] = "M"+Convert.ToString(Variaveis.musica);
                    dados[3] = "S"+Convert.ToString(Variaveis.som);
                    dados[4] = Convert.ToString(Variaveis.dificuldade);
                    linhas[i] = dados[0] + '|' + dados[1] + '|' + dados[2] + '|' + dados[3] + '|' + dados[4];


                }
            }
            string texto = "";
            for (int i = 0; i < linhas.Length; i++)
            {
                texto += linhas[i] + Environment.NewLine;
            }
            File.WriteAllText("Dados.txt", texto);
            MessageBox.Show("Configurações Salvas");
        }
        private void TelaConfiguracao_Load(object sender, EventArgs e)
        {
            if (Variaveis.dificuldade == "facil")
            {
                checkBox3.Checked = true;
                
            }
            if (Variaveis.dificuldade == "dificil")
            {
                checkBox4.Checked = true;
                
            }
            if (Variaveis.musica == true)
            {
                checkBox1.Checked = true;
            }
            if (Variaveis.musica == false)
            {
                checkBox1.Checked = false;
            }
            if (Variaveis.som == true)
            {
                checkBox2.Checked = true;
            }
            if (Variaveis.som == false)
            {
                checkBox2.Checked = false;
            }

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size - 1);
            label3.Font = tamanho;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            System.Drawing.Font tamanho = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size + 1);
            label3.Font = tamanho;
        }



        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
            }
        }
    }
}
