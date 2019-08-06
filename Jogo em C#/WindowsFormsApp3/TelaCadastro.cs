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
    public partial class TelaCadastro : MaterialSkin.Controls.MaterialForm
    {
        public TelaCadastro()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        public bool ValidaDigitacao(bool teste)
        {
            teste = true;
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o usuário.");
                txtUsuario.Select();
                teste = false;
            }
            if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha a senha.");
                txtSenha.Select();
                teste = false;
            }
            if (txtConfirma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha a confirmação de senha.");
                txtConfirma.Select();
                teste = false;
            }
            if (txtSenha.Text.Trim() != txtConfirma.Text.Trim())
            {
                MessageBox.Show("Senhas distintas.\nDigite Novamente.");
                txtSenha.Clear();
                txtConfirma.Clear();
                txtSenha.Select();
                teste = false;
            }
            return teste;
        }
        public bool ValidaUsuario(bool teste)
        {
            teste = true;
            if (File.Exists("Dados.txt"))
            {
                string[] linhas = File.ReadAllLines("Dados.txt", Encoding.UTF8);
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split('|');
                    for (int i = 0; i < dados.Length; i++)
                    {
                        if (dados[i] == txtUsuario.Text)
                        {
                            MessageBox.Show("Usuário já existente.\nDigite novamente.");
                            txtUsuario.Clear();
                            txtUsuario.Select();
                            teste = false;
                        }


                    }
                }


            }
            return teste;
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            bool teste = true;
            if (ValidaDigitacao(teste))
            {
                if (ValidaUsuario(teste))
                {
                    File.AppendAllText("Dados.txt",
                        txtUsuario.Text + "|" + txtSenha.Text +
                        Environment.NewLine, Encoding.UTF8);
                    MessageBox.Show("Cadastro realizado!");
                }
            }


        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
