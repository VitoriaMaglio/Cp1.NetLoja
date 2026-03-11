using Loja.Domain.Commons;

namespace Loja.Domain.Entities;

public class Categoria : BaseEntity
{
    public String NomeCategoria {get; private set;}
    public String Descricao {get; private set;}

    public Categoria(String nomeCategoria, String descricao)
    {
        NomeCategoria = nomeCategoria;
        Descricao = descricao;
    }
}