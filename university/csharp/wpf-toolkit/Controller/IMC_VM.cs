using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1.Controller
{
    public class IMC_VM : INotifyPropertyChanged
    {
        public Cmd cmdimc {  get; set; }

        bool PodeCalcular(object param)
        {
            return true;
        }

        void Calcular(object param)
        {
            Taxa = Peso / (Altura * Altura);

            Func<double, string> fn = (t) => t switch
            {
                < 18.5f => "Abaixo do peso",
                <= 24.9f => "Peso normal",
                <= 29.9f => "Sobrepeso",
                <= 34.9f => "Obesidade grau I",
                <= 39.9f => "Obesidade grau II",
                _ => "Obesidade grau III"
            };
            Texto = fn(Taxa);

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double _altura;
        public double Altura { get=>_altura; 
            set { 
                _altura = value;
                OnPropertyChanged(nameof(Altura));
            } 
        }

        private double _peso;
        public double Peso
        {
            get => _peso;
            set
            {
                _peso = value;
                OnPropertyChanged(nameof(Peso));
            }
        }

        private double _taxa;
        public double Taxa
        {
            get => _taxa;
            set
            {
                _taxa= value;
                OnPropertyChanged(nameof(Taxa));
            }
        }

        private string _texto;
        public string Texto
        {
            get => _texto;
            set
            {
                _texto = value;
                OnPropertyChanged(nameof(Texto));
            }
        }

        public IMC_VM()
        {
            Peso = 91;
            Altura = 1.85;
            cmdimc = new Cmd(Calcular, PodeCalcular);
                
        }


    }
}
