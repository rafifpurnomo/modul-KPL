using TP_MOD4;

internal class Program
{
    private static void Main(string[] args)
    {
        // MEMANGGIL DATA DARI CLASS KODEPOS
        KodePos DataKodePos= new KodePos();

        String kodePosWates = DataKodePos.GetKodePos("Wates");
        String kodePosCijaura = DataKodePos.GetKodePos("Cijaura");
        String kodePosMargasari = DataKodePos.GetKodePos("Margasari");
        Console.WriteLine("INI SOAL NOMOR 1");
        Console.WriteLine("ini kode post Wates: " + kodePosWates);
        Console.WriteLine("ini kode post Cijaura: " + kodePosCijaura);
        Console.WriteLine("ini kode post Margasari: " + kodePosMargasari);
        Console.WriteLine(" ");

        Console.WriteLine("INI SOAL NOMOR 2");
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.kunciPintu();
        doorMachine.bukaPintu();
        doorMachine.kunciPintu();
        doorMachine.bukaPintu();
    }
}