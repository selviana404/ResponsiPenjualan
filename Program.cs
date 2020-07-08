using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Nama: Selviana";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..5]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        Tambahpenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilkanPenjualan();
                        break;
                    
                    case 4:
                        EditData();
                        break;

                    case 5: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Edit Data penjualan");
            Console.WriteLine("5. Keluar\n");
        }

        static void Tambahpenjualan()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("| Nama: Selviana     |");
            Console.WriteLine("| Nim : 19.11.2875   |");
            Console.WriteLine("----------------------");
			Console.WriteLine("Tambahkan Penjualan\n");
			Penjualan penjualan = new Penjualan();
			Console.Write("Nota : ");
            penjualan.Nota = Console.ReadLine();
			Console.Write("Tanggal : ");
			penjualan.Tanggal = Console.ReadLine();
			Console.Write("Customer: ");
			penjualan.Customer = Console.ReadLine();
			Console.Write("Jenis [T/K] : ");
			penjualan.Jenis = Console.ReadLine();
			Console.Write("Total Nota : ");
			penjualan.TotalNota = Console.ReadLine();

			daftarPenjualan.Add(penjualan);

			Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
			Console.WriteLine("----------------------");
            Console.WriteLine("| Nama: Selviana     |");
            Console.WriteLine("| Nim : 19.11.2875   |");
            Console.WriteLine("----------------------");
			Console.WriteLine("Hapus penjualan\n");
			Console.Write("Nota : ");
			string Nota = Console.ReadLine();

            Penjualan delPro = daftarPenjualan.SingleOrDefault(f => f.Nota == Nota);
            if (daftarPenjualan.Contains(delPro) == true)
            {
                daftarPenjualan.Remove(delPro);
                Console.WriteLine("Data Penjualan telah dihapus");
            }
            else
            {
                Console.WriteLine("Nota tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilkanPenjualan()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("| Nama: Selviana     |");
            Console.WriteLine("| Nim : 19.11.2875   |");
            Console.WriteLine("----------------------");
			Console.WriteLine("Data Penjualan\n");
			int noUrut = 1;
			foreach (Penjualan penjualan in daftarPenjualan)
			{
				Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", noUrut, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.Jenis, penjualan.TotalNota);
                noUrut++;
			}
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
        static void EditData()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("| Nama: Selviana     |");
            Console.WriteLine("| Nim : 19.11.2875   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("Edit Data penjualan \n");
            HapusPenjualan();
            Console.Clear();
            Tambahpenjualan();
        }
    }
}