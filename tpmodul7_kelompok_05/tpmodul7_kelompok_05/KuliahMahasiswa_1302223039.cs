using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_05
{
    public class CourseList
    {
        [JsonPropertyName("courses")]
        public List<Course> Courses { get; set; }
    }

    internal class KuliahMahasiswa_1302223039
    {
        public void ReadJSON()
        {
            
                string jsonString = File.ReadAllText("C:\\Kuliah\\semester 4\\P_Konstruksi Perangkat Lunak\\Minggu 7\\tp7_2_1302223039.json");

                // Deserialize JSON menjadi objek CourseList
                CourseList courseList = JsonSerializer.Deserialize<CourseList>(jsonString);

                // Lakukan sesuatu dengan data yang terbaca, misalnya menampilkan ke konsol
                int index = 1;
                foreach (var course in courseList.Courses)
                {
                    Console.WriteLine($"MK {index} {course.code} - {course.name}");
                    index++;
                }
            
            
        }
    }

    public class Course
    {
        [JsonPropertyName("code")]
        public string code { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }
    }
}
