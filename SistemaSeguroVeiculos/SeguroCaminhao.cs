namespace SistemaSeguroVeiculos
{
    public class SeguroCaminhao : Seguro
    {
        public double CapacidadeCarga { get; private set; } 
        private const double TaxaRiscoBase = 0.08; 

        public SeguroCaminhao(double valorVeiculo, double franquia, int duracao, double capacidadeCarga)
            : base(valorVeiculo, franquia, duracao)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override double CalcularPremio()
        {
            double taxaRiscoVariavel = CapacidadeCarga * 0.02; 
            return ValorVeiculo * (TaxaRiscoBase + taxaRiscoVariavel);
        }
    }
}
