using System;

namespace SistemaSeguroVeiculos
{
    public class Seguro
    {
        public double ValorVeiculo { get; private set; }
        public double Franquia { get; private set; }
        public int Duracao { get; private set; } 

        public Seguro(double valorVeiculo, double franquia, int duracao)
        {
            ValorVeiculo = valorVeiculo;
            Franquia = franquia;
            Duracao = duracao;
        }

        public virtual double CalcularPremio()
        {
            return 0;
        }
    }
}
