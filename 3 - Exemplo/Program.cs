using _3___Exemplo;

Aluno aluno1 = new Aluno();//elementos //primeiro construtor vazio
aluno1.Nome = "Julia";

Aluno aluno2 = new Aluno(11, "Julia", "00388267893", new DateOnly(1995, 07, 23));//elementos  //segundo construtor com parametro

List<Aluno> alunos = new List<Aluno>();//adicionando elementos
alunos.Add(aluno1); 
alunos.Add(aluno2); 

foreach (Aluno a in alunos)//percorrendo elementos  //++ automatico
{  
    Console.WriteLine("O nome é "+ a.Nome + " " +a.Cpf);
}
  
