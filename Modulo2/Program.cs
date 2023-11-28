using Modulo2.Models;

Pessoa p1 = new Pessoa("Otavio", "Lemes");


Pessoa p2 = new Pessoa("Napoleon", "Bonapart");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListaAlunosDoCurso();