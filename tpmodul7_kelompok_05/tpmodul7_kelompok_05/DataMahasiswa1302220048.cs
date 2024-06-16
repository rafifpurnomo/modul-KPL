using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_05
{
    class NamaMahasiswa
    {
        public String depan { get; set; }
        public String belakang { get; set; }
    }

    public static class DataMahasiswa1302220048
    {
        class Data
        {
            public NamaMahasiswa nama { get; set; }
            public int nim { get; set; }
            public String fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\semester 4\\konstruksi perangkat lunak\\tp7_1_1302220048.json");
            Data data = JsonSerializer.Deserialize<Data>(jsonString);
            Console.WriteLine("Nama " + data.nama.depan + " " + data.nama.belakang + " dengan nim " + data.nim + " dari Fakultas " + data.fakultas);
        }
    }
}


