using Loja.Domain.Commons;

namespace Loja.Domain.Entities;

public class Produto : BaseEntity
{
    public String NomeProduto { get; private set; }
    public String Descricao { get; private set; }
    public decimal Preco { get; private set; }
    public int Estoque { get; private set; }
    public int IdCategoria {get; private set; } //fk 
    public Categoria Categoria { get; set; }

    public Produto(String nomeProduto, String descricao, decimal preco, int estoque, int idCategoria,
        Categoria categoria, int idProduto, int idEstoque)
    {
        NomeProduto = nomeProduto;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
        IdCategoria = idCategoria;
        Categoria = categoria;
        
    }
    //Produto tem relacionamento com  Categoria
    //1 CATEGORIA tem vários  N produtos
    
}