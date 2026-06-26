using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for JogoDados.xaml
    /// </summary>
    public partial class JogoDados : Page, INotifyPropertyChanged
    {
        public static readonly RoutedEvent OnPremioEvent = EventManager.RegisterRoutedEvent(
            "OnPremio",
            RoutingStrategy.Direct,
            typeof(RoutedEvent),
            typeof(JogoDados)
            );

        public event RoutedEventHandler OnPremio
        {
            add
            {
                AddHandler(OnPremioEvent, value);
            }
            remove { 
                RemoveHandler(OnPremioEvent, value); 
            }
        }

        public class OnPremioEventArgs: RoutedEventArgs
        {
            public int Aposta;
            public OnPremioEventArgs(RoutedEvent evt, int aposta):base(evt)
            {
                Aposta = aposta;
            }
        }

        void disparaEvento(int aposta)
        {
            OnPremioEventArgs args = new OnPremioEventArgs(OnPremioEvent, aposta);
            RaiseEvent(args);
        }

        public JogoDados()
        {
            InitializeComponent();
            Montante = 2000;
            Jogador = "Zé Carioca";
            Dado0 = 3;
            Dado1 = 5;
            this.OnPremio += JogoDados_OnPremio;
        }

        private void JogoDados_OnPremio(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("PArabéns");
        }

        private int _dado1;
        public int Dado1
        {
            get => _dado1;
            set
            {
                if (value >= 1 && value <= 6)
                {
                    _dado1 = value;
                    OnPropertyChanged(nameof(Dado1));
                }

            }
        }


        private int _dado0;
        public int Dado0
        {
            get => _dado0;

            set
            {
                if (value >= 1 && value <= 6)
                {
                    _dado0 = value;
                    OnPropertyChanged(nameof(Dado0));
                }


            }
        }


        private int _montante;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private string _jogador;
        public string Jogador
        {
            get => _jogador; set
            {
                _jogador = value;
                OnPropertyChanged(nameof(Jogador));
            }
        }

        public int Montante
        {
            get => _montante;

            set
            {
                if (value >= 0) _montante = value;
                OnPropertyChanged(nameof(Montante));
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int aposta = int.Parse(lblaposta.Content.ToString());
            if (Montante >= aposta) Montante -= aposta;
            else if (Montante > 0)
            {
                aposta = Montante;
                Montante = 0;
            }
            else
            {

                aposta = 0;
            }
            if (aposta > 0)
            {
                Random r = new Random();
                Dado0 = r.Next(1, 7);
                Dado1 = r.Next(1, 7);
                if (Dado0 == Dado1) disparaEvento(aposta);
            }

        }


    }
}
