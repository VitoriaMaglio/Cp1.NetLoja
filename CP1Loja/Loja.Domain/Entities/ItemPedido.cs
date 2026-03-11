using System.Runtime.InteropServices.JavaScript;
using Loja.Domain.Commons;
using Loja.Domain.Entities;

namespace DefaultNamespace;

public class ItemPedido : BaseEntity
{
    public int Quantidade {get; private set;}
    public decimal PrecoUnitario {get; private set;}
    public int IdPedido {get; private set;}//fk
    public int IdProduto {get; private set;}//fk
    public Pedido Pedido {get; private set;}// Relacionamento N-1 muitos itens pertencem a um só pedido
    //public Produto Produto {get; private set;}// Relacionamento N-1 muitos itens pertencem a um produto
    
    //Lógica para criação de construtor da classe
    /*
     O objeto só é criado se existir itens no pedido com valor maior que zero para realizar pagamento.
     */
    public ItemPedido(int quantidade, decimal precoUnitario, int idPedido, int idProduto)
    {
        if (quantidade <= 0)
            throw new Exception("Quantidade deve ser maior que zero");

        if (precoUnitario <= 0)
            throw new Exception("Preço unitário inválido");

        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
        IdPedido = idPedido;
        IdProduto = idProduto;
    }
    
}