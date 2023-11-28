using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo2.Models;

namespace Modulo2.Models
{
    public class Curso
    {
        public String Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void RemoveAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }
        public void ListaAlunosDoCurso()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");
            for(int count = 0; count<Alunos.Count; count++){
                string texto = "N° " + (count + 1 )+ " " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }      
        }
    }
}