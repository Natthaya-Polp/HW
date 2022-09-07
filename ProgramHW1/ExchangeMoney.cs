public class ExchangeMoney
{
    public static string InputMoney()
    {
        Console.Write("\nPlease input Money : ");
        return Console.ReadLine();
    }

    public static double ConvertStringToDouble(string money)
    {
        if (double.TryParse(money, out double input)) 
        {
            return input;
        }

        throw new Exception("Please input decimal data.");
    }

    public static void Exchange()
    {
        double thousand,fivehundred,onehundred,fifty,twenty,ten,five,two,one,pointfifty,pointtwentyfive;
        string inputmoney = InputMoney();
        double money = ConvertStringToDouble(inputmoney);

        if (money > 0)
        {
            thousand = Math.Floor(money/1000);
            fivehundred = Math.Floor((money%1000)/500);
            onehundred = Math.Floor((money%1000%500)/100);
            fifty = Math.Floor((money%1000%500%100)/50);
            twenty = Math.Floor((money%1000%500%100%50)/20);
            ten = Math.Floor((money%1000%500%100%50%20)/10);
            five = Math.Floor((money%1000%500%100%50%20%10)/5);
            two = Math.Floor((money%1000%500%100%50%20%10%5)/2);
            one = Math.Floor((money%1000%500%100%50%20%10%5%2)/1);
            pointfifty = Math.Floor((money%1000%500%100%50%20%10%5%2%1)/(0.5));
            pointtwentyfive = Math.Floor((money%100%1000%500%100%50%20%10%5%2%1%0.5)/(0.25));

            Console.WriteLine("1000 : {0}",thousand);
            Console.WriteLine("500 : {0}",fivehundred);
            Console.WriteLine("100 : {0}",onehundred);
            Console.WriteLine("50 : {0}",fifty);
            Console.WriteLine("20 : {0}",twenty);
            Console.WriteLine("10 : {0}",ten);
            Console.WriteLine("5 : {0}",five);
            Console.WriteLine("2 : {0}",two);
            Console.WriteLine("1 : {0}",one);
            Console.WriteLine(".50 : {0}",pointfifty);
            Console.WriteLine(".25 : {0}",pointtwentyfive);
        }
        else
        {
            throw new Exception("Please input positive number of money.");
        }
    }
}