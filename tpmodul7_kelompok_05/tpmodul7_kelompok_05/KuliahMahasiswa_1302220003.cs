using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_05
{
    class MatkulData
    {
        public List<Course> courses { get; set; }
    }

    class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    class KuliahMahasiswa_1302220003
    {
        public static void ReadJSON()
        {
            Console.WriteLine("Mata kuliah yang diambil");

            string jsonCourses = File.ReadAllText("C:\\Users\\Muhammad Rafif A.P\\OneDrive - Telkom University\\KUYLIAH\\SEMESTER 4\\Praktikum Konstruksi PL\\tp7_2_1302220003.json");
            MatkulData MataKuliah = JsonSerializer.Deserialize<MatkulData>(jsonCourses);

            int i =  1;
            foreach (var matKul in MataKuliah.courses)
            {
                Console.WriteLine($"MK: {i} Code: {matKul.code}, Name: {matKul.name}");
                i++;
            }
        }
    }
}
