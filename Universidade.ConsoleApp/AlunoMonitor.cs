using System;

namespace Universidade.ConsoleApp
{
    public class AlunoMonitor : Aluno
    {

        public string disciplinaDaMonitoria;

        public void CuidarDoLaboratorio(Aula aula)
        {
            FormatarMaquinas();
            ApagarLuzes();
            Chamada();

        }

        private void Chamada()
        {
            throw new NotImplementedException();
        }

        private void ApagarLuzes()
        {
            throw new NotImplementedException();
        }

        private void FormatarMaquinas()
        {
            throw new NotImplementedException();
        }
    }

}
