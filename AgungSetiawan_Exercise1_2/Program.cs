using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_Exercise1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("System akan menghitung (X+Y) x (Z/2)");

            Console.WriteLine("Input value X dalam bilangan bulat ");
            int nilaiIntX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input value Y dalam bilangan bulat ");
            int nilaiIntY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input value Z dalam bilangan bulat ");
            double nilaiDoubleZ = Convert.ToDouble(Console.ReadLine());

            double hasilPerhitungan = (nilaiIntX + nilaiIntY) * (nilaiDoubleZ / 2);
            Console.WriteLine("Hasilnya adalah {0}",hasilPerhitungan);

            Console.WriteLine("Ubah value X menjadi ");
            nilaiIntX = Convert.ToInt32(Console.ReadLine());

            int nilaiIntZ = Convert.ToInt32(nilaiDoubleZ);

            hasilPerhitungan = (nilaiIntX + nilaiIntY) * (nilaiDoubleZ / 2);
            Console.WriteLine("Hasilnya sekarang adalah {0}", Convert.ToInt32(hasilPerhitungan));

            Console.WriteLine("Ubah value Y menjadi ");
            nilaiIntY = Convert.ToInt32(Console.ReadLine());

            hasilPerhitungan = (nilaiIntX + nilaiIntY) * (nilaiIntZ / 2);
            Console.WriteLine("Hasilnya sekarang adalah {0}", hasilPerhitungan);

            Console.WriteLine("Ubah value Z menjadi ");
            nilaiIntZ = Convert.ToInt32(Console.ReadLine());

            hasilPerhitungan = (nilaiIntX + nilaiIntY) * (nilaiIntZ / 2);
            Console.WriteLine("Hasilnya sekarang adalah {0}", Convert.ToInt32(hasilPerhitungan));


        }
    }
}
