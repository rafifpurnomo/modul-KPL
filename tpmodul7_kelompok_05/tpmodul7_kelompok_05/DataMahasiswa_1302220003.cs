using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_05 { 

    class MahasiswaOBJ {
        public namaMahasiswa nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
    }

    class namaMahasiswa
    {
        public string depan { get; set; }
        public string belakang{ get; set; }
    }

    public class DataMahasiswa_1302220003
    {

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Users\\Muhammad Rafif A.P\\OneDrive - Telkom University\\KUYLIAH\\SEMESTER 4\\Praktikum Konstruksi PL\\tp7_1_1302220003.json");
            MahasiswaOBJ mahasiswa = JsonSerializer.Deserialize<MahasiswaOBJ>(json);

            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }
}
