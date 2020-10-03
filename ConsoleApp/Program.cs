using System;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi nilai a = ";
            
            Console.Write("Inputkan nilai a =");
            float a = float.Parse(Console.ReadLine()); //casting

            Console.Write("Inputkan nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine()); //casting

            Console.WriteLine(); // tambahan baris kosong
            Console.WriteLine("Hasil penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil perkalian : {0} x {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil pembagian : {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.ReadKey();
        }
        static float Penambahan(float a, float b)
        {
            return a + b;
        }
        static float Pengurangan(float a, float b)
        {
            return a - b;
        }
        static float Perkalian(float a, float b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }

    }
}
