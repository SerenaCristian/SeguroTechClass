using System;
using System.Collections.Generic;

namespace SistemaSeguroVeiculos
{
    public class Cliente
    {
        public string Nome { get; private set; }
        private List<Seguro> seguros;

        public Cliente(string nome)
        {
            Nome = nome;
            seguros = new List<Seguro>();
        }

        public void AdicionarSeguro(Seguro seguro)
        {
            seguros.Add(seguro);
            Console.WriteLine($"Seguro adicionado para {Nome}: Veículo com valor de R${seguro.ValorVeiculo:F2}");
        }

        public double CalcularTotalPremios()
        {
            double totalPremios = 0;
            foreach (var seguro in seguros)
            {
                totalPremios += seguro.CalcularPremio();
            }
            return totalPremios;
        }

        public void ListarSeguros()
        {
            Console.WriteLine($"Seguros de {Nome}:");
            foreach (var seguro in seguros)
            {
                Console.WriteLine($"Valor do veículo: R${seguro.ValorVeiculo:F2}, Prêmio: R${seguro.CalcularPremio():F2}");
            }
        }
    }
}
