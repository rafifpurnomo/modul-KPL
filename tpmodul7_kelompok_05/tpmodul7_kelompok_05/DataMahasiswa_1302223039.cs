using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_05
{
    public class DataMahasiswa_1302223039
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa_1302223039(Nama nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        public static void ReadJSON()
        {
            //Baca file Json yang diinginkan
            String jsonString = File.ReadAllText("C:\\Kuliah\\semester 4\\P_Konstruksi Perangkat Lunak\\Minggu 7\\tpmod7\\tpmodul7_kelompok_05\\tp7_1_1302223039.json");

            //Deserialize file json menjadi object 
            DataMahasiswa_1302223039 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302223039>(jsonString);

            Console.WriteLine($"{mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");

        }

    }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
}
