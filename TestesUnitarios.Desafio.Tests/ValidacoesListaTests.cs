using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 5, 8, 10 })]
    public void NaoDeveConterONumero10NaLista(int[] numeros)
    {
        // Arrange
        var lista = numeros.ToList();
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 5, 8, 10 })]
    public void DeveMultiplicarOsElementosDaListaPor2(int[] numeros)
    {
        // Arrange
        var lista = numeros.ToList();
        var resultadoEsperado = new List<int> { 10, 16, 20 };
        var numeroMultiplicacao = 2;

        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, numeroMultiplicacao);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }


    [Theory]
    [InlineData(new int[] { 5, -1, -8, 9 })]
    public void DeveRetornar9ComoMaiorNumeroDaLista(int[] numeros)
    {
        // Arrange
        var lista = numeros.ToList();

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(9, resultado);
    }

    [Theory]
    [InlineData(new int[] { 5, -1, -8, 9 })]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista(int[] numeros)
    {
        // Arrange
        var lista = numeros.ToList();

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(-8, resultado);
    }
}
