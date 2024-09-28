using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class Moeda
    {
        private string ladoSorteado;

        public string LadoSorteado { get; set; }
        public void SortearLado()
        {
            int lado = new Random().Next(2);
            if (lado == 0)
            {
                LadoSorteado = "cara";
            }
            else
            {
                LadoSorteado = "coroa";
            }
        }
    }
}
