using System;


    namespace SistemaSeguroVeiculos
    {
        public class SeguroCarro : Seguro
        {
            private const double TaxaRisco = 0.05; 

            public SeguroCarro(double valorVeiculo, double franquia, int duracao)
                : base(valorVeiculo, franquia, duracao)
            {
            }

            public override double CalcularPremio()
            {
                return ValorVeiculo * TaxaRisco;
            }
        }
    }


