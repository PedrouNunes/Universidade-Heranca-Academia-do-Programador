namespace Universidade.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nome = "Pedro";
            aluno.email = "pedrou";
            aluno.matricula = "1234";
            aluno.cpf = "121314";
            aluno.rg = "678";

            AlunoMonitor alunoMonitor = new AlunoMonitor();
            alunoMonitor.nome = "Arthur";
            alunoMonitor.disciplinaDaMonitoria = "Programação";
            alunoMonitor.email = "artt";
            alunoMonitor.matricula = "4567";
            alunoMonitor.cpf = "5782";
            alunoMonitor.rg = "343985";
        }
    }
}
