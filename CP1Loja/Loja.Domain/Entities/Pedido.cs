using System.Runtime.InteropServices.JavaScript;
using DefaultNamespace;
using Loja.Domain.Commons;

namespace Loja.Domain.Entities;

public class Pedido : BaseEntity
{
    public DateTime DataPedido { get; private set; }

    public string Status { get; private set; }

    public decimal ValorTotal { get; private set; }
    
    //FK relacionamento com Cliente N-1 muitos pedidos pertencem a um
    // Obrigatório, Pedido precisa obrigatóriamente estar relacionado a um Cliente
    // Opcional o Cliente ter Pedidos, Pedido pode ser nulo.
    public int IdCliente { get; private set; }
    
    //Relacionamento N-1 
    //Lado N tem o objeto de navegação
    //Lado 1 tem a lista 
    public Cliente Cliente { get; set; }

    //Um pedido possui vários itens 1-N
    // Obrigatório, cada Pedido precisa ter um ItemPedido associado.
    public List<ItemPedido> Itens { get; set; } = new();

    //1-1 Um pedido tem 1 pagamento
    public Pagamento Pagamento { get; set; }

}