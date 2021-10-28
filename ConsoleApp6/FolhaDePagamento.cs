using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class FolhaDePagamento
    {
        public static decimal Calcular(Remuneravel remuneravel)
        {
            return remuneravel.Remuneracao();
        }
    }
}
