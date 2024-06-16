using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tpmodul7_kelompok_05
{
    class DataMahasiswa
    {
        public NamaMahasiswa nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
    }
    class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    public class DataMahasiswa_1302220121
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\rizky\\Downloads\\tp7_1_1302220121.json");
            DataMahasiswa mahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);
            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }
}