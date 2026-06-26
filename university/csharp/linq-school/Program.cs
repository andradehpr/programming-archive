using LinqSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola istec = new Escola();
            // Mostra os alunos da turma B
            var turmaB = istec.Alunos.Where(t => t.Turma == "B");
            foreach(var t in turmaB) Console.WriteLine(t.ToString());

            // Mostra os alunos ordenados por turma e em caso de empate pelo nome
            foreach (var t in istec.Alunos.OrderByDescending(a => a.Nome).OrderBy(x => x.Nome))
            {
                Console.WriteLine(t.ToString());
            }

            // Mostra as diferentes turmas que existem na escola
            var turmas = istec.Alunos.Select(x => new{Turma = x.Turma}).Distinct();
            foreach(var t in turmas) Console.WriteLine(t.ToString());

            var nomes = istec.Alunos.Select(x => x.Turma).Distinct();
            foreach (var t in nomes) Console.WriteLine(t.ToString());

            // Mostra quantos alunos existem por turma
            var totais = istec.Alunos.GroupBy(x => x.Turma);
            foreach(var t in totais)
            {
                Console.WriteLine($"Turma: {t.Key} Total de Alunos: {t.Count()}");
                foreach (var a in t) { Console.WriteLine(a.ToString()); }
                Console.WriteLine("---------------------------------------------");
            }

            // Mostra os alunos e as respetivas notas
            // Faça a juncao das duas colecoes implementado a seguinte informacao
            // estrutura do registo Num-Nome-turma-discp-nota
            // MOstre estes registos ordenados por turma e disciplina
            var alfa = istec.Alunos.Join(
                istec.Exames,
                a => a.Num,
                e => e.Num,
                (x, y) => new
                {
                    Num = x.Num,
                    Nome = x.Nome,
                    Turma = x.Turma,
                    Disciplina = y.Disciplina,
                    Nota = y.Nota,
                }).OrderBy(z => z.Disciplina).OrderBy(z => z.Turma);

            foreach (var t in alfa) Console.WriteLine($"{t.Num} {t.Nome} {t.Turma} {t.Disciplina} {t.Nota}");

            // Mostra a média e desvio padrao das notas por aluno

            var final = istec.Alunos.GroupJoin(
                istec.Exames,
                a => a.Num,
                e => e.Num,
                (a, gn) => new
                {
                    Num = a.Num,
                    a.Nome,
                    Media = gn.Count() > 0 ? gn.Average(x => x.Nota) : 0,
                    Negativas = gn.Count() > 0 ? gn.Where(r => r.Nota < 10).Count() : 0,
                    Grupo = gn
                }

                );
            foreach (var f in final) {
                Console.WriteLine($"{f.Num} {f.Nome} Média: {f.Media.ToString("0.00")} Negas:{f.Negativas}");
            }

            // Mostra as médias por disciplina
            // Desvio Padrao sai no exame
            // Pedir a IA para fazer exercicios dificies 

        }


    }
}

//Escola istec = new Escola();
//foreach (var a in istec.Alunos)
//{
//    Console.WriteLine(a.ToString());
//    foreach (var e in istec.Exames.Where(e => e.Num == a.Num))
//    {
//        Console.WriteLine(e.ToString());
//    }
//}


//Aluno ze = new Aluno() { Num = 1, Nome = "Zé Carioca", Turma = "A" };
//Console.WriteLine(ze.ToString());

//Numeros Pares -var numeros = Utils.magico(1000000, x => x % 2 == 0);
//var numeros = Utils.magico(1000000, (new Utils()).Eprimo);
//foreach (var i in numeros) Console.Write($"{i} - "); ;