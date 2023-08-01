using _3___Exemplo;

/*Aluno aluno1 = new Aluno();//elementos //primeiro construtor vazio
aluno1.Nome = "Julia";
aluno1.Cpf = "234";
//Aluno aluno2 = new Aluno(11, "Julia", "00388267893", new DateOnly(1995, 07, 23));//elementos  //segundo construtor com parametro

List<Aluno> alunos = new List<Aluno>();//adicionando elementos
alunos.Add(aluno1); 
alunos.Add(aluno2); 

foreach (Aluno a in alunos)//percorrendo elementos  //++ automatico
{  
    Console.WriteLine("O nome é "+ a.Nome + " " +a.Cpf);
}*/

List<Aluno> alunos = new List<Aluno>();

while (true)
{
    Aluno aluno = new Aluno();
    Console.WriteLine("Digite o número da sua matrícula: ");
    aluno.Matricula = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite seu nome: ");
    aluno.Nome = Console.ReadLine();
    Console.WriteLine("Digite seu cpf: ");
    aluno.Cpf = Console.ReadLine();
    Console.WriteLine("Digite sua data de nascimento: ");
    DateOnly dataNasc = DateOnly.Parse(Console.ReadLine());

    alunos.Add(aluno);

    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Continuar");
    Console.WriteLine("2 - Sair");
    Console.WriteLine("Digite o número da opção escolhida: ");
    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

    if (opcaoEscolhida == 1)
    {
       
           

    }
    else if (opcaoEscolhida == 2)
    {
        break;

    }
    
    

}

foreach (Aluno a in alunos)
{
    Console.WriteLine("O nome é " + a.Nome + "CPF: " + a.Cpf);
}







