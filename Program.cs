﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Lab_9.ClassInduk;
using Tugas_Lab_9.ClassAnak;

namespace Tugas_Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection #2";
            int pilihan;
            List<Karyawan> listKaryawan = new List<Karyawan>();
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomor Menu [1..4] : ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Tambah Data Karyawan\n");
                        Console.Write("Jenis Karyawan[1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                        int Pilihan = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (Pilihan)
                        {
                            case 1:
                                KaryawanTetap karyawanTetap = new KaryawanTetap();
                                Console.Write("NIK : ");
                                karyawanTetap.NIK = Console.ReadLine();
                                Console.Write("NAMA : ");
                                karyawanTetap.NAMA = Console.ReadLine();
                                Console.Write("Gaji Bulanan : ");
                                karyawanTetap.gajibulanan = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(karyawanTetap);
                                break;
                            case 2:
                                KaryawanHarian karyawanHarian = new KaryawanHarian();
                                Console.Write("NIK : ");
                                karyawanHarian.NIK = Console.ReadLine();
                                Console.Write("NAMA : ");
                                karyawanHarian.NAMA = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                karyawanHarian.jumlahjamkerja = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                karyawanHarian.upahperjam = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(karyawanHarian);
                                break;
                            case 3:
                                Sales sales = new Sales();
                                Console.Write("NIK : ");
                                sales.NIK = Console.ReadLine();
                                Console.Write("NAMA : ");
                                sales.NAMA = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                sales.jumlahpenjualan = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                sales.komisi = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(sales);
                                break;
                           
                        }
                        break;

                        case 2:
                        int no = -1, hapus = -1;
                        Console.WriteLine("Hapus Data Karyawan\n");
                        Console.Write("NIK : ");
                        string nik = Console.ReadLine();
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            no++;
                            if (karyawan.NIK == nik)
                            {
                                hapus = no;
                            }
                        }
                        if (hapus != -1)
                        {
                            listKaryawan.RemoveAt(hapus);
                            Console.WriteLine("\nData Dihapus");
                        }
                        else
                        {
                            Console.WriteLine("\nData NIK tidak ditemukan");
                        }
                        break;

                        case 3:
                        int noUrut = 0;
                        string jenis = " ";
                        Console.WriteLine("Data Karyawan\n");
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            if (karyawan is KaryawanTetap)
                            {
                                jenis = "Karyawan Tetap";
                            }
                            else if (karyawan is KaryawanHarian)
                            {
                                jenis = "Karyawan Harian";
                            }
                            else
                            {
                                jenis = "Sales";
                            }
                            noUrut++;
                            Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, {4}", noUrut, karyawan.NIK, karyawan.NAMA, karyawan.GAJI(), jenis);
                        }
                        if (noUrut < 1)
                        {
                            Console.WriteLine("Data Karyawan Kosong");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Menu Yang Anda Masukkan SALAH");
                        break;
                }
                Console.WriteLine("\n\nTekan Enter Untuk kembali ke Menu");
                Console.ReadKey();
            }
            while (pilihan != 4);
        }
    }
}