using System;

namespace pjrSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Anual a = new Anual();
            Mensal m = new Mensal();

            a.MostrarRelatorio();
            m.MostrarRelatorio();
        }
    }
}
