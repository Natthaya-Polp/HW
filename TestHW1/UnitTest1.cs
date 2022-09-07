namespace Test;

public class UnitTest1
{
    [Fact]
    public void TestConvertStringToDouble()
    {
        double number = Exchange.ConvertStringToDouble("2512");

        Assert.Equal(number, 2512);
    }

    [Fact]
    public void TestConvertStringToDoubleIsInCorrect()
    {
        Assert.Throws<Exception>(() => ExchangeMoney.ConvertStringToDouble("merrychristmas"));
    }

    [Fact]
    public void TestExchange()
    {
        double number = Exchange.ConvertStringToDouble("123");

        Assert.Equal(number, 123);
    }

    [Fact]
    public void TestExchangeIsInCorrect()
    {
        Assert.Throws<Exception>(() => ExchangeMoney.InputMoney("-321"));
    }
}