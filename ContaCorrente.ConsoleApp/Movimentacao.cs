using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public double valor { get; set; }
        public int tipo { get; set; }

        public void Tipo()
        {
            int contador = 0;
            if (tipo == 1) //Debito
            {
                this.valor = valor;
                tipo = 1;
                Console.WriteLine($"Tipo movimentaçãp {tipo} Debito, no valor {valor}");
            }
            else if (tipo == 2) //Credito
            {
                this.valor = valor;
                tipo = 2;
            }
        }
    }
}
