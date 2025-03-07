using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGerenciamento
{
    public class Executar
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;

        public MainForm()
        {
            this.Text = "Sistema de Gerenciamento";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza o formulário na tela

            // Criando o Controle de Abas
            tabControl = new TabControl { Dock = DockStyle.Fill };

            // Criando as abas
            tabPage1 = new TabPage { Text = "Usuários" };
            tabPage2 = new TabPage { Text = "Máquinas" };
            tabPage3 = new TabPage { Text = "Software" };

            // Adicionando as telas às abas
            AdicionarTelaAba(tabPage1, new TelaUsuarios());
            AdicionarTelaAba(tabPage2, new TelaMaquinas());
            AdicionarTelaAba(tabPage3, new TelaSoftware());

            // Adicionando as abas ao controle de abas
            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);
            tabControl.TabPages.Add(tabPage3);

            // Adicionando o controle de abas ao formulário
            this.Controls.Add(tabControl);
        }

        // Método para adicionar uma tela a uma aba
        private void AdicionarTelaAba(TabPage aba, Form tela)
        {
            tela.TopLevel = false; // Define que a tela não é de nível superior
            tela.FormBorderStyle = FormBorderStyle.None; // Remove a borda da tela
            tela.Dock = DockStyle.Fill; // Faz a tela preencher toda a aba
            aba.Controls.Add(tela); // Adiciona a tela à aba
            tela.Show(); // Exibe a tela
        }
    }

    // Tela de Usuários (Tela1)
    public class TelaUsuarios : Form
    {
        public TelaUsuarios()
        {
            Color cor = Color.White;
            // this.BackColor = Color.Black;

            // Configuração das labels e TextBox para a tabela Usuarios
            Font fontePadrao = new Font("Arial", 10, FontStyle.Bold);

            Label lblIdUsuario = new Label { Text = "ID Usuário:", Location = new Point(20, 20), Font = fontePadrao, ForeColor =cor };
            TextBox txtIdUsuario = new TextBox { Location = new Point(150, 20), Width = 200 };

            Label lblPassword = new Label { Text = "Senha:", Location = new Point(20, 60), Font = fontePadrao };
            TextBox txtPassword = new TextBox { Location = new Point(150, 60), Width = 200 };

            Label lblNomeUsuario = new Label { Text = "Nome do Usuário:", Location = new Point(20, 100), Font = fontePadrao };
            TextBox txtNomeUsuario = new TextBox { Location = new Point(150, 100), Width = 200 };

            Label lblRamal = new Label { Text = "Ramal:", Location = new Point(20, 140), Font = fontePadrao };
            TextBox txtRamal = new TextBox { Location = new Point(150, 140), Width = 200 };

            Label lblEspecialidade = new Label { Text = "Especialidade:", Location = new Point(20, 180), Font = fontePadrao };
            TextBox txtEspecialidade = new TextBox { Location = new Point(150, 180), Width = 200 };

            // Adicionando os controles ao formulário
            this.Controls.AddRange(new Control[] {
                lblIdUsuario, txtIdUsuario,
                lblPassword, txtPassword,
                lblNomeUsuario, txtNomeUsuario,
                lblRamal, txtRamal,
                lblEspecialidade, txtEspecialidade
            });
        }
    }

    // Tela de Máquinas (Tela2)
    public class TelaMaquinas : Form
    {
        public TelaMaquinas()
        {
            this.BackColor = Color.Black;

            // Configuração das labels e TextBox para a tabela Maquina
            Font fontePadrao = new Font("Arial", 10, FontStyle.Bold);
            Color cor = Color.White;

            Label lblIdMaquina = new Label { Text = "ID Máquina:", Location = new Point(20, 20), Font = fontePadrao };
            TextBox txtIdMaquina = new TextBox { Location = new Point(150, 20), Width = 200 };

            Label lblTipo = new Label { Text = "Tipo:", Location = new Point(20, 60), Font = fontePadrao };
            TextBox txtTipo = new TextBox { Location = new Point(150, 60), Width = 200 };

            Label lblVelocidade = new Label { Text = "Velocidade:", Location = new Point(20, 100), Font = fontePadrao };
            TextBox txtVelocidade = new TextBox { Location = new Point(150, 100), Width = 200 };

            Label lblHardDisk = new Label { Text = "Hard Disk:", Location = new Point(20, 140), Font = fontePadrao };
            TextBox txtHardDisk = new TextBox { Location = new Point(150, 140), Width = 200 };

            Label lblPlacaRede = new Label { Text = "Placa de Rede:", Location = new Point(20, 180), Font = fontePadrao };
            TextBox txtPlacaRede = new TextBox { Location = new Point(150, 180), Width = 200 };

            Label lblMemoriaRam = new Label { Text = "Memória RAM:", Location = new Point(20, 220), Font = fontePadrao };
            TextBox txtMemoriaRam = new TextBox { Location = new Point(150, 220), Width = 200 };

            Label lblFkUsuario = new Label { Text = "FK Usuário:", Location = new Point(20, 260), Font = fontePadrao };
            TextBox txtFkUsuario = new TextBox { Location = new Point(150, 260), Width = 200 };

            // Adicionando os controles ao formulário
            this.Controls.AddRange(new Control[] {
                lblIdMaquina, txtIdMaquina,
                lblTipo, txtTipo,
                lblVelocidade, txtVelocidade,
                lblHardDisk, txtHardDisk,
                lblPlacaRede, txtPlacaRede,
                lblMemoriaRam, txtMemoriaRam,
                lblFkUsuario, txtFkUsuario
            });
        }
    }

    // Tela de Software (Tela3)
    public class TelaSoftware : Form
    {
        public TelaSoftware()
        {
            this.BackColor = Color.Black;
            Color cor = Color.White;

            // Configuração das labels e TextBox para a tabela Software
            Font fontePadrao = new Font("Arial", 10, FontStyle.Bold);

            Label lblIdSoftware = new Label { Text = "ID Software:", Location = new Point(20, 20), Font = fontePadrao };
            TextBox txtIdSoftware = new TextBox { Location = new Point(150, 20), Width = 200 };

            Label lblProduto = new Label { Text = "Produto:", Location = new Point(20, 60), Font = fontePadrao };
            TextBox txtProduto = new TextBox { Location = new Point(150, 60), Width = 200 };

            Label lblHardDisk = new Label { Text = "Hard Disk:", Location = new Point(20, 100), Font = fontePadrao };
            TextBox txtHardDisk = new TextBox { Location = new Point(150, 100), Width = 200 };

            Label lblMemoriaRam = new Label { Text = "Memória RAM:", Location = new Point(20, 140), Font = fontePadrao };
            TextBox txtMemoriaRam = new TextBox { Location = new Point(150, 140), Width = 200 };

            Label lblFkMaquina = new Label { Text = "FK Máquina:", Location = new Point(20, 180), Font = fontePadrao };
            TextBox txtFkMaquina = new TextBox { Location = new Point(150, 180), Width = 200 };

            // Adicionando os controles ao formulário
            this.Controls.AddRange(new Control[] {
                lblIdSoftware, txtIdSoftware,
                lblProduto, txtProduto,
                lblHardDisk, txtHardDisk,
                lblMemoriaRam, txtMemoriaRam,
                lblFkMaquina, txtFkMaquina
            });
        }
    }
}