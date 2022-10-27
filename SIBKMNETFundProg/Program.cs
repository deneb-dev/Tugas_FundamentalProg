using System;

namespace SIBKMNETFundProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama, nim, prodi, in_uas;
            double uas;

            //Input
            Console.WriteLine("-------------------------------- Masukan Data Mahasiswa -----------------------------");
            Console.Write(" Masukan Nama = "); nama = Console.ReadLine();
            Console.Write(" Masukan NIM = "); nim = Console.ReadLine();
            Console.Write(" Masukan Prodi = "); prodi = Console.ReadLine();
            Console.Write(" Masukan Nilai UAS = "); in_uas = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------------------------");
            uas = Convert.ToDouble(in_uas);



            //Hasil
            Console.WriteLine("--------------------------------- Hasil Data Mahasiswa ------------------------------");
            Console.WriteLine(" NIM = {0}", nim);
            Console.WriteLine(" Nama = {0}", nama);
            Console.WriteLine(" Program Studi = {0}", prodi);

            //Proses Grade
            if (uas >= 85 & uas <= 100)
            {
                Console.WriteLine(" Nilai Huruf = A");
                Console.WriteLine(" Status = LULUS");
            }
            else if (uas >= 75 & uas <= 85)
            {
                Console.WriteLine(" Nilai Huruf = B");
                Console.WriteLine(" Status = LULUS");
            }
            else if (uas >= 60 & uas <= 75)
            {
                Console.WriteLine(" Nilai Huruf = C");
                Console.WriteLine(" Status = *Perbaikan");
            }
            else if (uas <= 60)
            {
                Console.WriteLine(" Nilai Huruf = D");
                Console.WriteLine(" Status = TIDAK LULUS");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
    }
}
