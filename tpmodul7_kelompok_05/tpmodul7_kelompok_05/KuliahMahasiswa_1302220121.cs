using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_05
{
    public class KuliahMahasiswa_1302220121
    {
        public List<MataKuliah> courses { get; set; }

        public KuliahMahasiswa_1302220121()
        {
            courses = new List<MataKuliah>();
        }

        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\rizky\\Downloads\\tp7_2_1302220121.json");
            KuliahMahasiswa_1302220121 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa_1302220121>(jsonString);
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int count = 1;
            foreach (MataKuliah mk in kuliah.courses)
            {
                Console.WriteLine($"MK {count} {mk.code} - {mk.name}");
                count++;
            }
        }
    }
}

