using System;

namespace pjrSobreposicao
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatórios por ano!");
        }
    }
}