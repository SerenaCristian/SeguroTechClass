using System;



namespace SistemaSeguroVeiculos
{
    public class SeguroMoto : Seguro
    {
        private const double TaxaRisco = 0.10; 

        public SeguroMoto(double valorVeiculo, double franquia, int duracao)
            : base(valorVeiculo, franquia, duracao)
        {
        }

        public override double CalcularPremio()
        {
            return ValorVeiculo * TaxaRisco;
        }
    }
}
