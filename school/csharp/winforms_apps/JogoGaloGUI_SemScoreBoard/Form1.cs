using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGaloGUI_SemScoreBoard
{
    public partial class Form1 : Form
    {
        private JogoDePollo jogo;
        public Form1()
        {
            InitializeComponent();
            jogo = new JogoDePollo();
            Startup();
        }

        private void Startup()
        {
            jogo.IniciarJogo();

            foreach (var item in Controls)
            {
                if ((item is Button) && 
                    (
                        (item as Button).Text == "X" ||
                        (item as Button).Text == "O"
                    ) 
                   )
                {
                    (item as Button).Text = "";

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /* 
         * // primeira versão do evento dos botões
        private void btn1_Click(object sender, EventArgs e)
        {
            jogo.Jogar(1);
            btn1.Text = jogo.Peca;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            jogo.Jogar(2);
            btn2.Text = jogo.Peca;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            jogo.Jogar(3);
            btn3.Text = jogo.Peca;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            jogo.Jogar(4);
            btn4.Text = jogo.Peca;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            jogo.Jogar(5);
            btn5.Text = jogo.Peca;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            jogo.Jogar(6);
            btn6.Text = jogo.Peca;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            jogo.Jogar(7);
            btn7.Text = jogo.Peca;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            jogo.Jogar(8);
            btn8.Text = jogo.Peca;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            jogo.Jogar(9);
            btn9.Text = jogo.Peca;
        }

        */
        private void btnJogada_Click(object sender, EventArgs e)
        {
            EstadoJogo estadoJogada = EstadoJogo.Invalido;

            if (jogo.EndGame)
            {
                MessageBox.Show("Jogo Terminado");
                return;
            }


            Button button = (sender as Button);

            string txtNome = button.Name.ToLowerInvariant();
            string pecaJogo = jogo.Peca;

            /* // versão 1 da jogada

            if (txtNome.Contains("btn1"))
                estadoJogada = jogo.Jogar(1);

            if (txtNome.Contains("btn2"))
                estadoJogada = jogo.Jogar(2);

            if (txtNome.Contains("btn3"))
                estadoJogada = jogo.Jogar(3);

            if (txtNome.Contains("btn4"))
                estadoJogada = jogo.Jogar(4);

            if (txtNome.Contains("btn5"))
                estadoJogada = jogo.Jogar(5);

            if (txtNome.Contains("btn6"))
                estadoJogada = jogo.Jogar(6);

            if (txtNome.Contains("btn7"))
                estadoJogada = jogo.Jogar(7);

            if (txtNome.Contains("btn8"))
                estadoJogada = jogo.Jogar(8);

            if (txtNome.Contains("btn9"))
                estadoJogada = jogo.Jogar(9);

            */
            
            string strPosicao = (sender as Button).Tag.ToString();
            int posicao = Convert.ToInt32(strPosicao);

            estadoJogada = jogo.Jogar(posicao);



            if (jogo.EndGame)
            {
                string mensagem = "";
                button.Text = pecaJogo;
                switch (estadoJogada)
                {
                    case EstadoJogo.Vitoria1:
                        mensagem = "Venceu o Jogador 1";
                        break;
                    case EstadoJogo.Vitoria2:
                        mensagem = "Venceu o Jogador 2";
                        break;
                    case EstadoJogo.Empate:
                        mensagem = "Empate";
                        break;
                }

                MessageBox.Show(mensagem);
                listBox1.Items.Add(mensagem); // adiciona um elemento à listBox. 
                                              // A mesma técnica funciona para combobox
                return;
            }

            if ((estadoJogada != EstadoJogo.Invalido) && (estadoJogada != EstadoJogo.Ocupado))
            {
                button.Text = pecaJogo;
            }
            else
            {
                MessageBox.Show($"Posição ocupada!");
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Startup();
        }
    }
}
