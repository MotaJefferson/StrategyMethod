using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistemaPagamentoStrategyMethod.MetodosPagamento
{
    public class PagamentoCartaoDebito : IMetodoPagamento
    {
        private string _numeroCartao;
        private string _titularCartao;
        private string _dataValidade;
        private string _codigoSeguranca;

        public PagamentoCartaoDebito(string numeroCartao, string titularCartao, string dataValidade, string codigoSeguranca)
        {
            _numeroCartao = numeroCartao;
            _titularCartao = titularCartao;
            _dataValidade = dataValidade;
            _codigoSeguranca = codigoSeguranca;
        }

        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Processando pagamento com cartão de débito de {valor:C} para {_titularCartao}.");
        }
    }
}
