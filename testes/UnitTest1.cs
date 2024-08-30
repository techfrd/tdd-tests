using tdd.Class;

namespace testes;

public class UnitTest1
{
    [Theory]
    [InlineData (2, 3, 5)]
    public void Test1(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();
        int result = calc.Somar(val1,val2);
        Assert.Equal(res, result);
    }
}