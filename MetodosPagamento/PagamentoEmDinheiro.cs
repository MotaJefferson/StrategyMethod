using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaPagamentoStrategyMethod.MetodosPagamento
{
    public class PagamentoEmDinheiro : IMetodoPagamento
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Processando pagamento em dinheiro de {valor:C}. Obrigado pelo pagamento!");
        }
    }
}
