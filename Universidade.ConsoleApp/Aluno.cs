using System;

namespace Universidade.ConsoleApp
{
    public class Aluno
    {
        public string nome;
        public string matricula;
        public string email;
        public string cpf;
        public string rg;
        
        public void ValidarCPF()
        {

        }

        public void AssistirAulas(Aula aula)
        {
            Console.WriteLine("Responder presença...");
            Console.WriteLine("Prestar atenção...");
        }
    }

}
