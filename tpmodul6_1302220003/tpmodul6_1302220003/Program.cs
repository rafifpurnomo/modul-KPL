using tpmodul6_1302220003;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo newVideo01 = new SayaTubeVideo("Tutorial Design By Contract – RAFIF PURNOMO");
        newVideo01.IncreasePlayCount(1);
        newVideo01.PrintVideoDetails();

        Console.WriteLine(" ");
        // CEK KONDISI
        SayaTubeVideo newVideo02 = new SayaTubeVideo("");
        newVideo02.IncreasePlayCount(10000009);
        for (int i = 0; i <= 5; i++)
        {
            newVideo02.IncreasePlayCount(10000009);
        }
        newVideo02.PrintVideoDetails();
    }
}