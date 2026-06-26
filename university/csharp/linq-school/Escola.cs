using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSchool
{
    public class Aluno
    {
        public int Num { get; set; }
        public string Nome { get; set; }
        public string Turma { get; set; }

        public override string ToString()
        {
            return $"Num: {Num}-> {Nome}::Turma:{Turma}";
        }
    }

    public class Exame
    {
        public int Num { get; set; }

        public string Disciplina { get; set; }

        public int Nota { get; set; }

        public override string ToString()
        {
            return $"Num:{Num} Disciplina:{Disciplina} Nota:{Nota}";
        }
    }

    public class Escola
    {
        string[] disciplinas = new string[] {"port", "ing", "fra", "prog"};
        Random rnd = new Random(); // Random = class , rnd = Objeto 
        public List<Aluno> Alunos {  get; set; }
        public List<Exame> Exames { get; set; } = new List<Exame>();

        //ctor AKA construtor é o metodo que esta na craiçºao da instancia do objeto
        public Escola()
        {
            Alunos = new List<Aluno>()
            {
                new Aluno{Num=1, Nome="Tio Patinhas", Turma="A"},
                new Aluno{Num=1, Nome="Pato Donald", Turma="B"},
                new Aluno{Num=1, Nome="Margarida", Turma="A"},
                new Aluno{Num=1, Nome="Pateta", Turma="B"},
                new Aluno{Num=1, Nome="Pluto", Turma="B"},
                new Aluno{Num=1, Nome="Mickey", Turma="A"},
            };
            foreach(var a in Alunos)
            {
                foreach(string d in disciplinas)
                {
                    Exames.Add(new Exame { Num = a.Num, Disciplina = d, Nota = rnd.Next(0,21) });
                }
            }

        }
    }
}
