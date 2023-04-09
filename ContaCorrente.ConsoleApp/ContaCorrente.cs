using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
     
        public double saldo { get; set; }
        public bool ehEspecial { get; set; }
        public int numero { get; set; }
        public double limite { get; set; }
        public double[] guardar { get; set; } = new double[10];
        public Movimentacao tipoMovimentacao = new Movimentacao();

        public  ContaCorrente (double saldo, bool ehEspecial, int numero, double limite)
        {
         
            this.saldo = saldo;
            this.ehEspecial = ehEspecial;
            this.numero = numero;
            this.limite = limite;

        }



        public void Sacar(double sacar)
        {
            int contador = 0;
            if (limite + saldo > sacar)
            {
                if (saldo > 0)
                {

                    if (saldo >= sacar)
                    {
                        tipoMovimentacao.tipo = 1;
                        saldo -= sacar;

                        tipoMovimentacao.valor = sacar;
                        tipoMovimentacao.Tipo();

                    }
                }
            }

        
        }

        public void Depositar(double depositar)
        {
            if (depositar > 0)
            {
                saldo += depositar;
            }

          

        }

        public void VisualizarSaldo()
        {
            Console.WriteLine($"Saldo da conta \nR${saldo}");
            
        }

        public void Transferir(double valor, ContaCorrente conta)
        {
            if (valor > 0)
            {
                if (saldo >= valor)
                {
                    saldo -= valor;
                    conta.saldo += valor;

                }
            }
        }

        public void ExtratoMovimentcao()
        {
            Console.WriteLine(tipoMovimentacao);


        }

      





    }

  
}
