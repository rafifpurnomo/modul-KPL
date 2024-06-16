public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

public class DataGeneric<T>
{
    private T Data;
    public DataGeneric(T data) => Data = data;

    public void printData()
    {
        Console.WriteLine("data yang tersimpan :" + Data);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("masukan nama anda: ");
        string nama = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(nama);

        Console.WriteLine("masukan NIM anda");
        string nim = Console.ReadLine();
        DataGeneric<string> dataNim = new DataGeneric<string>(nim);
        dataNim.printData();
    }
}