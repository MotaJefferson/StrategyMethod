using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaPagamentoStrategyMethod.MetodosPagamento
{
    public class PagamentoPix : IMetodoPagamento
    {
        private string _chavePix;

        public PagamentoPix(string chavePix)
        {
            _chavePix = chavePix;
        }

        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Processando pagamento via PIX de {valor:C} para a chave {_chavePix}.");
        }
    }
}
