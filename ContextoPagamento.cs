using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaPagamentoStrategyMethod
{
    public class ContextoPagamento
    {
        private IMetodoPagamento _metodoPagamento;

        public void DefinirMetodoPagamento(IMetodoPagamento metodoPagamento)
        {
            _metodoPagamento = metodoPagamento;
        }

        public void ProcessarPagamento(decimal valor)
        {
            if (_metodoPagamento == null)
            {
                Console.WriteLine("Nenhum método de pagamento definido.");
                return;
            }

            _metodoPagamento.Pagar(valor);
        }
    }
}
