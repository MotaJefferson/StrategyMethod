using ProjetoSistemaPagamentoStrategyMethod.MetodosPagamento;
using ProjetoSistemaPagamentoStrategyMethod;

class Program
{
    static void Main(string[] args)
    {
        var contextoPagamento = new ContextoPagamento();

        Console.WriteLine("Escolha um método de pagamento: 1 - Dinheiro, 2 - Crédito, 3 - Débito, 4 - PIX");
        var escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                contextoPagamento.DefinirMetodoPagamento(new PagamentoEmDinheiro());
                break;
            case "2":
                contextoPagamento.DefinirMetodoPagamento(new PagamentoCartaoCredito("1234 5678 8765 4321", "João Silva", "12/25", "123"));
                break;
            case "3":
                contextoPagamento.DefinirMetodoPagamento(new PagamentoCartaoDebito("4321 8765 5678 1234", "Maria Souza", "10/24", "456"));
                break;
            case "4":
                contextoPagamento.DefinirMetodoPagamento(new PagamentoPix("chave-pix-exemplo"));
                break;
            default:
                Console.WriteLine("Método de pagamento inválido.");
                return;
        }

        Console.WriteLine("Informe o valor do pagamento:");
        var valor = decimal.Parse(Console.ReadLine() ?? "0");

        contextoPagamento.ProcessarPagamento(valor);
    }
}