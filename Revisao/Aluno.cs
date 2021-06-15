namespace Revisao
{
    public class Aluno
    {
        public readonly string Nome;
        public readonly decimal Nota;
        public Aluno(string Nome, decimal Nota)
        {
            this.Nome = Nome;
            this.Nota = Nota;
        }
    }
}