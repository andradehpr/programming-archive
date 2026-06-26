using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace JogoGaloGUI_SemScoreBoard
{



    public enum EstadoJogo
    {
        Vitoria1,
        Vitoria2,
        Empate,
        Ocupado,
        Valido,
        Invalido
    }



    public class JogoDePollo
    {

        public string[] Quadro;

        public int Jogador { get; private set; }

        public string Peca { get; private set; }

        public bool EndGame { get; set; }








        public JogoDePollo()
        {
            IniciarJogo();
        }

        public void IniciarJogo()
        {
            Quadro = new string[9];
            Jogador = 1;
            Peca = "X";
            EndGame = false;

            for (int i = 0; i < 9; ++i)
            {
                Quadro[i] = (i + 1).ToString();
            }
        }

        public EstadoJogo Jogar(int posicao)
        {
            bool jogadaValida = false;
            do
            {
                if ((posicao < 1) || (posicao > 9))
                {
                    return EstadoJogo.Invalido;
                }
                else
                {

                    jogadaValida = !(Quadro[posicao - 1] == "X" || Quadro[posicao - 1] == "O");

                    if (!jogadaValida)
                    {
                        return EstadoJogo.Ocupado;
                    }
                }


            } while (!jogadaValida);

            Quadro[posicao - 1] = Peca;
            if (VerificaVitoria())
            {
                EndGame = true;
                if (Jogador == 1)
                {
                    basedados(2);
                    return EstadoJogo.Vitoria1;
                }
                else
                {
                    basedados(1);
                    return EstadoJogo.Vitoria2;
                }

            }
            else
            {
                /*
                jogador = jogador == 1 ? 2 : 1;
                peca = jogador == 1 ? "X" : "O";
                */

                if (Jogador == 1)
                {
                    Jogador = 2;
                    Peca = "O";
                }
                else
                {
                    Jogador = 1;
                    Peca = "X";
                }
            }

            bool temVaga = false;
            for (int i = 0; i < 9; ++i)
            {
                if ((Quadro[i] != "X") && (Quadro[i] != "O"))
                {
                    temVaga = true;
                    break;
                }
            }

            if (!temVaga)
            {
                EndGame = true;
                return EstadoJogo.Empate;
            }

            return EstadoJogo.Valido;
        }

        private bool VerificaVitoria()
        {
            return (
                    // 3 em linha
                    (Quadro[0] == Peca) && (Quadro[1] == Peca) && (Quadro[2] == Peca) ||
                    (Quadro[3] == Peca) && (Quadro[4] == Peca) && (Quadro[5] == Peca) ||
                    (Quadro[6] == Peca) && (Quadro[7] == Peca) && (Quadro[8] == Peca) ||
                    // 3 em coluna
                    (Quadro[0] == Peca) && (Quadro[3] == Peca) && (Quadro[6] == Peca) ||
                    (Quadro[1] == Peca) && (Quadro[4] == Peca) && (Quadro[7] == Peca) ||
                    (Quadro[2] == Peca) && (Quadro[5] == Peca) && (Quadro[8] == Peca) ||
                    // 3 em diagonal
                    (Quadro[2] == Peca) && (Quadro[4] == Peca) && (Quadro[6] == Peca) ||
                    (Quadro[0] == Peca) && (Quadro[4] == Peca) && (Quadro[8] == Peca)
                    );
        }

        static void basedados()
        {

            string Cnstring = "Data Source=.\\SQLEXPRESS;Initial Catalog=galoPSI;Integrated Security=true;TrustServerCertificate=true;MultipleActiveResultSets=True;";
            SqlConnection dbCn = new SqlConnection(Cnstring);
            dbCn.Open();

            
           
            
           
            if (Jogador == 1)
            {
                string sql_cmd = "INSERT INTO jogada1(id, vencedor) values (newvid(), 'Jogador', null, 'A')";
                SqlCommand cmdIns = new SqlCommand(sql_cmd, dbCn);
                int rows = cmdIns.ExecuteNonQuery();
            }
            else
            {

            }
            




    }



}
