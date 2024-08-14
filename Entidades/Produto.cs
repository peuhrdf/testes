namespace Entidades;

public class Produto
{
    public string Nome { get; private set; }
    public int Quantidade { get; private set; }
    public double Preco { get; private set; }

    public Produto(string nome, int quantidade, double preco)
    {
        if (quantidade < 0 || preco < 0)
            throw new ArgumentException("Quantidade e preço devem ser não negativos.");

        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade < 0)
            throw new ArgumentException("Quantidade deve ser positiva.");
        
        Quantidade += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > Quantidade)
            throw new InvalidOperationException("Quantidade insuficiente em estoque.");

        Quantidade -= quantidade;
    }

    public double ValorTotal()
    {
        return Quantidade * Preco;
    }
}