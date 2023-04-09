namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta1 = new ContaCorrente(1000, true, 12, 0 );
            conta1.Sacar(200);
            conta1.Depositar(300);
            conta1.Depositar(500);
            conta1.Sacar(300);

            conta1.VisualizarSaldo();

            ContaCorrente conta2 = new ContaCorrente(300, true, 13, 0);
            conta1.Transferir(400, conta2);
            conta1.VisualizarSaldo();
            conta2.VisualizarSaldo();


            conta1.ExtratoMovimentcao();

        }
    }
}