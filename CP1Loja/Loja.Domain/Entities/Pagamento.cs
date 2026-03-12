using Loja.Domain.Commons;

namespace Loja.Domain.Entities;

public class Pagamento : BaseEntity
{
    public String TipoPagamento { get; private set; }
    public decimal Valor { get; private set; }
    public DateTime Data { get; private set; }
    public Pedido Pedido { get; private set; }
    
    //1 Pedido tem 1 Pagamento 

    public Pagamento(String tipoPagamento, decimal valor, DateTime data)
    {
        TipoPagamento = tipoPagamento;
        Valor = valor;
        Data = data;
    }
}