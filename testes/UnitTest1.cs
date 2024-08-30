using tdd.Class;

namespace testes;

public class UnitTest1
{
    [Theory]
    [InlineData (2, 3, 5)]
    public void TesteSomar(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();
        int result = calc.Somar(val1,val2);
        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData (3, 2, 1)]
    public void TesteSubtrair(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();
        int result = calc.Subtrair(val1,val2);
        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData (2, 3, 6)]
    public void TesteMultiplicar(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();
        int result = calc.Multiplicar(val1,val2);
        Assert.Equal(res, result);
    }

    [Theory]
    [InlineData (4, 2, 2)]
    public void TesteDividir(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();
        int result = calc.Dividir(val1,val2);
        Assert.Equal(res, result);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.Somar(1, 2);
        calc.Somar(2, 9);
        calc.Somar(3, 9);
        calc.Somar(4, 2);

        var lista = calc.HistoricoDasOperacoes();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
        
    }
}