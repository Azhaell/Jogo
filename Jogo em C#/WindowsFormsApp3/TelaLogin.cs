using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class TelaLogin : MaterialSkin.Controls.MaterialForm
    {
        

        public TelaLogin()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ptbSenha_MouseEnter(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void ptbSenha_MouseLeave(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }
        public void ValidaDigitacao()
        {
            if (txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha os campos vazios.");
                return;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidaDigitacao();
            if (File.Exists("Dados.txt"))
            {
                string[] linhas = File.ReadAllLines("Dados.txt", Encoding.UTF8);
                bool teste = false;
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split('|');
                    for (int i = 0; i < dados.Length; i++)
                    {
                        if (dados[i] == txtUsuario.Text && dados[i + 1] != txtSenha.Text)
                        {
                            teste = false;
                            break;
                        }

                        if (dados[i] == txtUsuario.Text && dados[i + 1] == txtSenha.Text)
                        {  
                            teste = true;
                            break;
                        }


                    }
                }
                if (teste)
                {
                    Variaveis.login = txtUsuario.Text;
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                    if(Variaveis.sair == false)
                    {
                        this.Show();
                    }
                    if(Variaveis.sair == true)
                    {
                        this.Close();
                    }
                    return;
                }
                if(teste == false && txtUsuario.Text.Trim().Length != 0 && txtSenha.Text.Trim().Length != 0)
                {
                    MessageBox.Show("Usuário e/ou senha incorretos e/ou inexistentes.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Usuário inexistente.\nRealize um cadastro.");
                return;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
        }

    }
}
