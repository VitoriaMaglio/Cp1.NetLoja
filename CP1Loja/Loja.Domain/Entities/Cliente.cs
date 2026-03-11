using Loja.Domain.Commons;

namespace Loja.Domain.Entities;

public class Cliente : BaseEntity
{
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }
    public DateTime DataCadastro { get; private set; }

    public Cliente(string nome, string cpf, string email, string telefone)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
        DataCadastro = DateTime.Now;
    }
}
