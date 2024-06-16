using tpmodul7_kelompok_05;
internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302220003.ReadJSON();
        KuliahMahasiswa_1302220003.ReadJSON();
        
        DataMahasiswa1302220048.ReadJSON();
        KuliahMahasiswa1302220048.ReadJSON();

        DataMahasiswa_1302223039.ReadJSON();
        KuliahMahasiswa_1302223039 kuliahMahasiswa = new KuliahMahasiswa_1302223039();
        kuliahMahasiswa.ReadJSON();
      
        DataMahasiswa_1302220121.ReadJSON();
        KuliahMahasiswa_1302220121.ReadJSON();
    }
}