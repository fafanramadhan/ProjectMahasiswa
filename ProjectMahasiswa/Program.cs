using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        Mahasiswa Mahasiswa = new Mahasiswa();
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
            Console.Write("Nomor Menu [1..3]: ");

            int nomorMenu = Convert.ToInt32(Console.ReadLine());

            switch (nomorMenu)
            {
                case 1:
                    TambahMahasiswa();
                    break;
                case 2:
                    TampilMahasiswa();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pilihan menu tidak tersedia...");
                    break;
            }
            
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Mahasiswa Mahasiswa = new Mahasiswa();

            Console.Write("NIM: ");
            Mahasiswa.NIM = Console.ReadLine();
            Console.Write("Nama: ");
            Mahasiswa.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            Mahasiswa.JenisKelamin = Console.ReadLine();
            if (Mahasiswa.JenisKelamin == "L")
            {
                Mahasiswa.JenisKelamin = "Laki-Laki";
            }
            else if (Mahasiswa.JenisKelamin == "P")
            {
                Mahasiswa.JenisKelamin = "Perempuan";
            }
            Console.Write("IPK : ");
            Mahasiswa.IPK = Console.ReadLine();

            daftarMahasiswa.Add(Mahasiswa);




            Console.WriteLine();
            Console.WriteLine("Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();

            TampilMenu();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("No\tNIM\tNama \tJenis Kelamin\tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}",mahasiswa.NIM, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.IPK);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
