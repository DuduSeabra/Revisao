using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "1";
            Aluno[] alunos = new Aluno[10];
            int count = 0;

            while(opcao != "0") 
            {
                string Nome;
                decimal Nota;

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1- Cadastrar novo aluno");
                Console.WriteLine("2- Calcular média geral");
                Console.WriteLine("3- Listar alunos");
                Console.WriteLine("0- Sair");
                Console.WriteLine();

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":

                        Console.WriteLine("Informe o nome do aluno:");
                        Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal aux))
                        {
                            Nota = aux;
                            Aluno aluno = new Aluno();
                            aluno.Nome = Nome;
                            aluno.Nota = Nota;
                            alunos[count] = aluno;
                            count++;
                        }
                        else 
                            throw new ArgumentException("Valor da nota deve ser decimal.");
                        
                        break;

                    case "2":
                        decimal media = 0;
                        int n_alunos = 0;

                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(alunos[i] != null)
                            {
                            media = alunos[i].Nota + media;
                            n_alunos++;
                            }
                        }

                        media = media/n_alunos;

                        ConceitoEnum conceitogeral;

                        if(media <= 2)
                            conceitogeral = ConceitoEnum.E;
                        else if(media <= 4)
                            conceitogeral = ConceitoEnum.D;
                        else if(media <= 6)
                            conceitogeral = ConceitoEnum.C;
                        else if(media <= 8)
                            conceitogeral = ConceitoEnum.B;
                        else
                            conceitogeral= ConceitoEnum.A;

                        Console.WriteLine($"A média entre os alunos é de {media} | O conceito geral entre os alunos é {conceitogeral}");
                        break;
                    case "3":
                        foreach(Aluno i in alunos)
                        {
                            if(i != null)
                                Console.WriteLine($"Nome: {i.Nome} | Nota: {i.Nota}");
                        }
                        break;
                    case "0":
                        continue;
                    default:
                        throw new ArgumentOutOfRangeException("Opção inválida, digite novamente.");
                }
            }            
        }
    }
}
