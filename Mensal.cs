using System;
namespace pjrSobreposicao
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatórios por mês!");
        }
    }
}