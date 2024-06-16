using System;

class Program
{
    /// <summary>
    /// Kelas untuk menyapa user dengan tipe data generik.
    /// </summary>
    public class HaloGeneric
    {
        /// <summary>
        /// Menyapa user dengan nama yang diberikan.
        /// </summary>
        /// <typeparam name="T">Tipe data nama user.</typeparam>
        /// <param name="nama">Nama user.</param>
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }

    /// <summary>
    /// Kelas untuk menyimpan dan mencetak data generik.
    /// </summary>
    /// <typeparam name="T">Tipe data yang akan disimpan.</typeparam>
    public class DataGeneric<T>
    {
        private T data;

        /// <summary>
        /// Konstruktor untuk menginisialisasi data.
        /// </summary>
        /// <param name="inputData">Data yang akan disimpan.</param>
        public DataGeneric(T inputData)
        {
            data = inputData;
        }

        /// <summary>
        /// Mencetak data yang tersimpan.
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    /// <summary>
    /// Titik masuk utama untuk aplikasi.
    /// </summary>
    /// <param name="args">Argument baris perintah.</param>
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        // Meminta nama panggilan user
        Console.WriteLine("Masukkan nama panggilan Anda:");
        string namaPanggilan = Console.ReadLine();

        // Menyapa user dengan nama panggilan yang diberikan
        halo.SapaUser(namaPanggilan);

        // Membuat instance DataGeneric dengan tipe data string
        DataGeneric<string> dataGeneric = new DataGeneric<string>("1302223107");

        // Mencetak data yang tersimpan
        dataGeneric.PrintData();
    }
}
