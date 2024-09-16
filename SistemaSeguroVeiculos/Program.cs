namespace SistemaSeguroVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Maria");

            SeguroCarro seguroCarro = new SeguroCarro(50000, 1000, 12);
            SeguroMoto seguroMoto = new SeguroMoto(20000, 500, 12);
            SeguroCaminhao seguroCaminhao = new SeguroCaminhao(150000, 3000, 12, 5);

            cliente.AdicionarSeguro(seguroCarro);
            cliente.AdicionarSeguro(seguroMoto);
            cliente.AdicionarSeguro(seguroCaminhao);

            cliente.ListarSeguros();

            double totalPremios = cliente.CalcularTotalPremios();
            Console.WriteLine($"\nTotal dos prêmios: R${totalPremios:F2}");
        }
    }
}
