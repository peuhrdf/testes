using Entidades;

namespace Testes;

public class ProdutoTests
{
    [Fact]
    public void AdicionarEstoque_DeveIncrementarQuantidade()
    {
        // Arrange
        var produto = new Produto("Teste", 10, 10.0);

        // Act
        produto.AdicionarEstoque(5);

        // Assert
        Assert.Equal(15, produto.Quantidade);
    }

    [Fact]
    public void AdicionarEstoque_ComQuantidadeNegativa_DeveLancarExcecao()
    {
        // Arrange
        var produto = new Produto("Teste", 10, 10.0);

        // Act and Assert
        Assert.Throws<ArgumentException>(() => produto.AdicionarEstoque(-5));
    }

    [Fact]
    public void RemoverEstoque_DeveDecrementarQuantidade()
    {
        // Arrange
        var produto = new Produto("Teste", 10, 10.0);

        // Act
        produto.RemoverEstoque(5);

        // Assert
        Assert.Equal(5, produto.Quantidade);
    }
    
    [Fact]
    public void RemoverEstoque_ComQuantidadeInsuficiente_DeveLancarExcecao()
    {
        // Arrange
        var produto = new Produto("Teste", 10, 10.0);

        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => produto.RemoverEstoque(11));
    }

    [Fact]
    public void ValorTotal_DeveCalcularValorTotalDoEstoque()
    {
        // Arrange
        var produto = new Produto("Teste", 10, 10.0);

        // Act
        var valorTotal = produto.ValorTotal();

        // Assert
        Assert.Equal(100.0, valorTotal);
    }

    [Fact]
    public void Construtor_DeveRetornarExcecaoComQuantidadeNegativaOuPrecoNegativo()
    {
        Assert.Throws<ArgumentException>(() => new Produto("Teste", -10, 10.0));
        Assert.Throws<ArgumentException>(() => new Produto("Teste", 10, -10.0));
    }

    [Fact]
    public void Construtor_DeveCriarObjetoComNomeValido()
    {
        // Arrange
        var nomeValido = "Teste";

        // Act
        var produto = new Produto(nomeValido, 10, 10.0);

        // Assert
        Assert.Equal(nomeValido, produto.Nome);
    }
    
}