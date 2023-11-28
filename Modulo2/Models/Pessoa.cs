using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo2.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }
        public Pessoa(String nome, String sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }
        private string _nome;
        private int _idade;
       public String Nome { 
        get => _nome.ToUpper();
        
        set{
            if(value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio");
            }
            _nome = value;
        }
        } 
        public string Sobrenome{get; set;}
        public String NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        
       public int Idade 
       { 
        get => _idade;
        set
        {
            if(Idade < 0)
            {
                throw new ArgumentException("idade incorreta");
            }
            _idade = value;
 
        }
       }
       public void Apresentar(){
        Console.WriteLine($"Nome:{NomeCompleto} \n Idade:{Idade}");
       }
    }
}