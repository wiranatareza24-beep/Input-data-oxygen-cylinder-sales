using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dataTabungDepot
{
    internal class Program
    {
        static ArrayList namaPelanggan = new ArrayList();
        static List<int> pembelianO2 = new List<int>();
        static List<int> pembelianN2 = new List<int>();
        static List<int> pembelianAr = new List<int>();
        static List<int> pembelianC2h2 = new List<int>();
        static List<int> pembelianLpg = new List<int>();
        static List<int> pembelianCo2 = new List<int>();
        static List<int> o2 = new List<int>();
        static List<int> n2 = new List<int>();
        static List<int> ar = new List<int>();
        static List<int> c2h2 = new List<int>();
        static List<int> lpg = new List<int>();
        static List<int> co2 = new List<int>();
        static List<int> TKo2 = new List<int>() {0};
        static List<int> TKn2 = new List<int>() { 0 };
        static List<int> TKar = new List<int>() { 0 };
        static List<int> TKc2h2 = new List<int>() { 0 };
        static List<int> TKlpg = new List<int>() { 0 };
        static List<int> TKco2 = new List<int>() { 0 };
        
        static void pembelianTabung(ArrayList a)
        {
            string nama;
            int nomorTabung;
            {
                Console.Clear();
                Console.WriteLine("Menu Pembelian Tabung");
                Console.WriteLine("=====================");
                Console.WriteLine();
                
                Console.Write("Masukan Nama Pelanggan : ");
                nama = Console.ReadLine();
                namaPelanggan.Add(nama);
                Console.WriteLine("[1.] Oksigen");
                Console.WriteLine("[2.] Nitrogen");
                Console.WriteLine("[3.] Karbon Dioksida");
                Console.WriteLine("[4.] Acytlene");
                Console.WriteLine("[5.] Argon");
                
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Masukan nomor di atas dari tabung yang ingin di beli : ");
                string jenisTabung = Console.ReadLine().Trim().ToUpper();

                Dictionary<string, int> hargaTabung = new Dictionary<string, int>()
            {
                {"1", 1500000 },
                {"2", 1500000 },
                {"5", 1500000 },
                {"3", 1500000 },
                {"4", 2000000 },
            };
                if (jenisTabung == "1")
                {
                    Console.WriteLine($"Jenis tabung                  : Oksigen 6M³");
                    Console.WriteLine($"Harga per Tabung              : {hargaTabung[jenisTabung]}");
                    Console.WriteLine($"Stock Oksigen                 :{string.Join("", o2)}");
                    Console.Write("Masukan jumlah tabung yang di beli : ");
                    int jumlah = int.Parse(Console.ReadLine());
                    pembelianO2.Add(jumlah);
                    
                        if (jumlah > o2[0])
                        {
                            Console.WriteLine("Maaf Stock Tidak Mencukupi");
                        
                        }
                        else if (pembelianO2.Contains(jumlah))
                        {
                            o2[0] = o2[0] - jumlah;
                        TKo2[0] = TKo2[0] + jumlah;
                        
                        int totalharga = hargaTabung[jenisTabung] * jumlah;
                        Console.WriteLine($"Total harga tabung (belum dengan isi) : {totalharga}");
                        Console.WriteLine("==============================================");
                        Console.Write("Ingin dengan isi? [iya/tidak] : ");
                        string isi = Console.ReadLine();
                        if (isi == "iya")
                        {
                            int satuan = 70000 * jumlah;
                            int totalIsi = totalharga + satuan;
                            Console.WriteLine($"Total Harga Menjadi : {totalIsi}");
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                    }
                }
                else if (jenisTabung == "2")
                {
                    Console.WriteLine($"Jenis tabung                  : Nitrogen 6M³");
                    Console.WriteLine($"Harga per Tabung              : {hargaTabung[jenisTabung]}");
                    Console.WriteLine($"Stock Nitrogen                :{string.Join("", n2)}");
                    Console.Write("Masukan jumlah tabung yang di beli : ");
                    int jumlah = int.Parse(Console.ReadLine());
                    pembelianN2.Add(jumlah);
                    if (jumlah > n2[0])
                    {
                        Console.WriteLine("Maaf Stock Tidak Mencukupi");
                    }
                    else if (pembelianN2.Contains(jumlah))
                    {
                        n2[0] = n2[0] - jumlah;
                        TKn2[0] = TKn2[0] + jumlah;
                        int totalharga = hargaTabung[jenisTabung] * jumlah;
                        Console.WriteLine($"Total harga tabung (belum dengan isi) : {totalharga}");
                        Console.WriteLine("==============================================");
                        Console.Write("Ingin dengan isi? [iya/tidak] : ");
                        string isi = Console.ReadLine();
                        if (isi == "iya")
                        {
                            int satuan = 275000 * jumlah;
                            int totalIsi = totalharga + satuan;
                            Console.WriteLine($"Total Harga Menjadi : {totalIsi}");
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                    }
                        
                }
                else if (jenisTabung == "5")
                {
                    Console.WriteLine($"Jenis tabung     : Argon 6M³");
                    Console.WriteLine($"Harga per Tabung : {hargaTabung[jenisTabung]}");

                    Console.Write("Masukan jumlah tabung yang di beli : ");
                    int jumlah = int.Parse(Console.ReadLine());
                    pembelianAr.Add(jumlah);
                    if (jumlah > ar[0])
                    {
                        Console.WriteLine("Maaf Stock Tidak Mencukupi");
                    }
                    else if (pembelianAr.Contains(jumlah))
                    {
                        ar[0] = ar[0] - jumlah;
                        TKar[0] = TKar[0] + jumlah;
                        int totalharga = hargaTabung[jenisTabung] * jumlah;
                        Console.WriteLine($"Total harga tabung (belum dengan isi) : {totalharga}");
                        Console.WriteLine("==============================================");
                        Console.Write("Ingin dengan isi? [iya/tidak] : ");
                        string isi = Console.ReadLine();
                        if (isi == "iya")
                        {
                            int satuan = 400000 * jumlah;
                            int totalIsi = totalharga + satuan;
                            Console.WriteLine($"Total Harga Menjadi : {totalIsi}");
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                    }
                        
                }
                else if (jenisTabung == "3")
                {
                    Console.WriteLine($"Jenis tabung     : Karbon dioksida 6M³");
                    Console.WriteLine($"Harga per Tabung : {hargaTabung[jenisTabung]}");

                    Console.Write("Masukan jumlah tabung yang di beli : ");
                    int jumlah = int.Parse(Console.ReadLine());
                    pembelianCo2.Add(jumlah);
                    if (jumlah > co2[0])
                    {
                        Console.WriteLine("Maaf Stock Tidak Mencukupi");
                    }
                    else if (pembelianCo2.Contains(jumlah))
                    {
                        co2[0] = co2 [0]-jumlah;
                        TKco2[0] = TKco2[0] + jumlah;
                        int totalharga = hargaTabung[jenisTabung] * jumlah;
                        Console.WriteLine($"Total harga tabung (belum dengan isi) : {totalharga}");
                        Console.WriteLine("==============================================");
                        Console.Write("Ingin dengan isi? [iya/tidak] : ");
                        string isi = Console.ReadLine();
                        if (isi == "iya")
                        {
                            int satuan = 300000 * jumlah;
                            int totalIsi = totalharga + satuan;
                            Console.WriteLine($"Total Harga Menjadi : {totalIsi}");
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }
                    }
                }
                       
                else if (jenisTabung == "4")
                {
                    Console.WriteLine($"Jenis tabung     : Acytlene 6M³");
                    Console.WriteLine($"Harga per Tabung : {hargaTabung[jenisTabung]}");

                    Console.Write("Masukan jumlah tabung yang di beli : ");
                    int jumlah = int.Parse(Console.ReadLine());
                    pembelianC2h2.Add(jumlah);
                    if (jumlah > c2h2[0])
                    {
                        Console.WriteLine("Maaf Stock Tidak Mencukupi");
                    }
                    else if (pembelianC2h2.Contains(jumlah))
                    {
                        c2h2[0] = c2h2[0] - jumlah;
                        TKc2h2[0] = TKc2h2[0] + jumlah;
                        int totalharga = hargaTabung[jenisTabung] * jumlah;
                        Console.WriteLine($"Total harga tabung (belum dengan isi) : {totalharga}");
                        Console.WriteLine("==============================================");
                        Console.Write("Ingin dengan isi? [iya/tidak] : ");
                        string isi = Console.ReadLine();
                        if (isi == "iya")
                        {
                            int satuan = 350000 * jumlah;
                            int totalIsi = totalharga + satuan;
                            Console.WriteLine($"Total Harga Menjadi : {totalIsi}");
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Terimakasih telah berbelanja.");
                        }

                    }
                }
                        
                else
                {
                    Console.WriteLine("Maaf kode yang dimasukan salah.");
                }
                Console.WriteLine("===================================================");
            }
            
        }
        static void isiUlangTabung(ArrayList b)
        {
            string nama;
            int nomorTabung;
            
            
                Console.Clear();
                Console.WriteLine("Data Isi ulang Tabung");
                Console.WriteLine("======================");
                Console.WriteLine();
                
                Console.Write("Masukan Nama Pelanggan : ");
                nama = Console.ReadLine();
                namaPelanggan.Add(nama);
                Console.WriteLine("[1.] Oksigen");
                Console.WriteLine("[2.] Nitrogen");
                Console.WriteLine("[3.] Karbon Dioksida");
                Console.WriteLine("[4.] Acytlene");
                Console.WriteLine("[5.] Argon");
                Console.WriteLine("[6.] LPG");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Masukan nomor di atas dari tabung yang ingin di beli : ");
                string nomor = Console.ReadLine().Trim().ToUpper();

                Dictionary<string, int> hargaTabung = new Dictionary<string, int>()
            {
                {"O2 6m3", 70000 },
                {"O2 2m3", 60000 },
                {"O2 1m3", 50000 },
                {"N2", 275000 },
                {"Ar", 400000 },
                {"CO2", 300000 },
                {"C2H2", 350000 },
                {"LPG 12Kg", 220000 },
            };

            if (nomor == "1")
            {
                Console.WriteLine("Menu pengisian Oksigen");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.Write("Masukan kode ukuran oksigen [6m3 / 2m3 / 1m3] : ");
                string jenisO2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");
                if (jenisO2 == "6m3")
                {
                    Console.Write("masukan jumlah pengisian tabung : ");
                    int jumlahO2 = int.Parse(Console.ReadLine());
                    pembelianO2.Add(jumlahO2);

                    if (jumlahO2 > o2[0])
                    {
                        Console.WriteLine("Maaf Stock Tidak Mencukupi");

                    }
                    else if (pembelianO2.Contains(jumlahO2))
                    {
                        o2[0] = o2[0] - jumlahO2;
                        int totalHarga = 70000 * jumlahO2;

                        Console.WriteLine($"Total harga : {totalHarga}");
                    }
                }
                else if (jenisO2 == "2m3")
                {
                    Console.Write("masukan jumlah pengisian tabung : ");
                    int jumlahO2 = int.Parse(Console.ReadLine());
                    int totalHarga = 60000 * jumlahO2;

                    Console.WriteLine($"Total harga : {totalHarga}");
                }
                else if (jenisO2 == "1m3")
                {
                    Console.Write("masukan jumlah pengisian tabung : ");
                    int jumlahO2 = int.Parse(Console.ReadLine());
                    int totalHarga = 50000 * jumlahO2;

                    Console.WriteLine($"Total harga : {totalHarga}");
                }
                else
                {
                    Console.WriteLine("Maaf kode yang anda masukan tidak sesuai.");
                }
            }
            else if (nomor == "2")
            {
                Console.WriteLine("Menu pengisian Nitrogen");
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                Console.Write("Masukan Jumlah pengisian tabung : ");
                int jumlahN2 = int.Parse(Console.ReadLine());
                int total = 275000 * jumlahN2;
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Total Harga : {total}");
            }
            else if (nomor == "5")
            {
                Console.WriteLine("Menu pengisian Argon");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.Write("Masukan jumlah pengisian tabung : ");
                int jumlahAr = int.Parse(Console.ReadLine());
                int total = 400000 * jumlahAr;
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Total harga : {total}");
            }
            else if (nomor == "3")
            {
                Console.WriteLine("Menu pengisian Karbon Dioksida");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.Write("Masukan jumlah pengisian tabung : ");
                int jumlahCo = int.Parse(Console.ReadLine());
                int total = 300000 * jumlahCo;
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Total harga : {total}");
            }
            else if (nomor == "4")
            {
                Console.WriteLine("Menu pengisian Karbon Acytlene");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.Write("Masukan jumlah pengisian tabung : ");
                int jumlahAC = int.Parse(Console.ReadLine());
                int total = 350000 * jumlahAC;
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Total harga : {total}");
            }
            else if (nomor == "6")
            {
                Console.WriteLine("Menu pengisian LPG 12 Kg");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.Write("Masukan jumlah pengisian tabung : ");
                int jumlahLpg = int.Parse(Console.ReadLine());
                pembelianLpg.Add(jumlahLpg);
                if (jumlahLpg > lpg[0])
                {
                    Console.WriteLine("Maaf Stock Tidak Mencukupi");
                }
                else if (pembelianLpg.Contains(jumlahLpg))
                {
                    lpg[0] = lpg[0] - jumlahLpg;
                    TKlpg[0] = TKlpg[0] + jumlahLpg;
                    int total = 220000 * jumlahLpg;
                    Console.WriteLine();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Total harga : {total}");
                }
            }
            else
            {
                Console.WriteLine("Maaf Kode yang anda masukan salah.");
            }
                Console.WriteLine();
                Console.WriteLine("===================================================");
        }
        static List<int> Rm = new List<int>();
        static List<int> Rr = new List<int>();
        static void stockTabung (ArrayList c)
        {

            Console.Clear();
            Console.WriteLine("Menu Stock Tabung & Barang");
            Console.WriteLine("============================");
            Console.WriteLine();
            Console.Write("Masukan Stock Regulator Medis        : ");
            int regM = int.Parse(Console.ReadLine());
            Rm.Add(regM);
            Console.WriteLine();
            Console.Write("Masukan Stock Regulator rekhnik      : ");
            int regR = int.Parse(Console.ReadLine());
            Rr.Add(regR);
            Console.WriteLine();
            Console.Write("Masukan stock tabung oksigen         : ");
            int stocko2 = int.Parse (Console.ReadLine());
            o2.Add(stocko2);
            Console.WriteLine();
            Console.Write("Masukan stock tabung nitrogen        : ");
            int stockn2 = int.Parse (Console.ReadLine());
            n2.Add(stockn2);
            Console.WriteLine();
            Console.Write("Masukan stock tabung Hidrogen        : ");
            int stockC2h2 = int.Parse (Console.ReadLine());
            c2h2.Add(stockC2h2);
            Console.WriteLine();
            Console.Write("Masukan stock tabung Karbon Dioksida : ");
            int stockCo2 = int.Parse (Console.ReadLine());
            co2.Add(stockCo2);
            Console.WriteLine();
            Console.Write("Masukan stock tabung LPG             : ");
            int stockLpg = int.Parse (Console.ReadLine());
            lpg.Add(stockLpg);
            Console.WriteLine();
            Console.Write("Masukan stock tabung Argon           : ");
            int stockAr = int.Parse (Console.ReadLine());
            ar.Add(stockAr);
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine ("Stock berhasil di tambahkan");
            Console.WriteLine();
            
        }
         static List<int> pembelianRm = new List<int> ();
         static List<int> pembelianRr = new List<int> ();
        static void alatMedis (ArrayList d)
        {

            Console.WriteLine("Menu Pembelian Alat Medis");
            Console.WriteLine("-------------------------");
            Console.WriteLine("[1.] Regulator Medis");
            Console.WriteLine("[2.] Regulator Rekhnik");
            Console.WriteLine("-------------------------");
            Console.Write("Masukan alat nomor alat yang di beli [1/2] : ");
            string alat = Console.ReadLine();

            if (alat == "1")
            {
                Console.WriteLine("Pembelian Regulator Medis");
                Console.WriteLine("-------------------------");
                Console.Write("Masukan Jumlah Regulator Medis yang dibeli : ");
                int jumlah = int.Parse(Console.ReadLine());
                pembelianRm.Add(jumlah);
                if (jumlah > Rm[0])
                {
                    Console.WriteLine("Maaf Stock Regulator Medis Tidak Mencukupi");
                }
                else if (pembelianRm.Contains(jumlah))
                {
                    Rm[0] = Rm[0] - jumlah;
                    int satuan = 250000 * jumlah;
                    Console.WriteLine($"Harga Totalnya adalah : {satuan}");
                }
                    
            }
            else if (alat == "2")
            {
                Console.WriteLine("Pembelian Regulator Rekhnik");
                Console.WriteLine("---------------------------");
                Console.Write("Masukan Jumlah Regulator Medis yang dibeli : ");
                int jumlah = int.Parse(Console.ReadLine());
                pembelianRr.Add(jumlah);
                if (jumlah > Rr[0])
                {
                    Console.WriteLine("Maaf Stock Regulator Rekhnik Tidak Mencukupi");
                }
                else if (pembelianRr.Contains(jumlah))
                {
                    Rr[0] = Rr[0] - jumlah;
                    int satuan = 180000 * jumlah;
                    Console.WriteLine($"Harga Totalnya adalah : {satuan}");
                }        
            }
            else
            {
                Console.WriteLine("Maaf Nomor yang anda masukan salah...");
            }


        }
        
        static void Main(string[] args)
        {
           
            ArrayList tampilkan = new ArrayList();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Stock Tabung & Barang");
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Stock Oksigen           :{string.Join("", o2)}");
                Console.WriteLine($"Stock Nitrogen          :{string.Join("", n2)}");
                Console.WriteLine($"Stock Argon             :{string.Join("", ar)}");
                Console.WriteLine($"Stock LPG               :{string.Join("", lpg)}");
                Console.WriteLine($"Stock Acytlene          :{string.Join("", c2h2)}");
                Console.WriteLine($"Stock Karbon Dioksida   :{string.Join("", co2)}");
                Console.WriteLine($"Stock Regulator Medis   :{string.Join("", Rm)}");
                Console.WriteLine($"Stock Regulator Rekhnik :{string.Join("", Rr)}");
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Stock Tabung Kosong");
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Tabung Kosong Oksigen             :{string.Join("",TKo2)}");
                Console.WriteLine($"Tabung Kosong Nitrogen            :{string.Join("",TKn2)}");
                Console.WriteLine($"Tabung Kosong Argon               :{string.Join("",TKar)}");
                Console.WriteLine($"Tabung Kosong LPG                 :{string.Join("",TKlpg)}");
                Console.WriteLine($"Tabung Kosong Acytlene            :{string.Join("",TKc2h2)}");
                Console.WriteLine($"Tabung Kosong Karbon Dioksida     :{string.Join("",TKco2)}");
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine("Menu Pilihan ");
                Console.WriteLine("-------------------------");
                Console.WriteLine("[1] Hitunng Stok Tabung");
                Console.WriteLine("[2] Pembelian Tabung");
                Console.WriteLine("[3] Isi ulang tabung");
                Console.WriteLine("[4] Pembelian alat medis");
                Console.WriteLine("[5] Keluar");
                Console.WriteLine("-------------------------");
                Console.Write("Masukan menu pilihan anda : ");
                string pilihan = Console.ReadLine();

                if (pilihan == "1")
                {
                    stockTabung(tampilkan);

                }
                else if (pilihan == "2")
                {
                    pembelianTabung(tampilkan);

                }
                else if (pilihan == "3")
                {
                    isiUlangTabung(tampilkan);

                }
                else if (pilihan == "4")
                {
                    alatMedis(tampilkan);
                }
                else if (pilihan == "5")
                {
                    Console.WriteLine("Keluar dari program...");
                    break;
                }
                    Console.WriteLine("tekan enter untuk lanjutkan...");
                Console.ReadLine();
            }
            
        }
    }
}
