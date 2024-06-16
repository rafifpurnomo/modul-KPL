using System;

namespace tpmodul2_1302220003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Huruf: ");
            string v = Console.ReadLine().ToLower();

            if ("aiueo".Contains(v))
            {
                Console.Write("huruf ");
                Console.Write(v);
                Console.WriteLine(" adalah huruf vokal");
            }
            else
            {
                Console.Write("huruf ");
                Console.Write(v);
                Console.WriteLine(" adalah huruf konsonan");
            }

            int[] arr = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Angka genap ");
                Console.Write(i + 1);
                Console.Write(" : ");
                Console.WriteLine(arr[i]);
            }


        }
    }
}