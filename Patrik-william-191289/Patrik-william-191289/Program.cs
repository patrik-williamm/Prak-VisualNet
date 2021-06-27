/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 10/06/2021
 * Time: 14:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Patrik_william_191289
{
	class Program
	{
		public static void Main(string[] args)
		{
			int pilih;	
			
			Console.WriteLine("Daftar Barang \n");
			Console.WriteLine("1.Laptop");
			Console.WriteLine("2.SmartPhone");
			Console.WriteLine("3.mouse");
			Console.WriteLine("4.CPU");
			
			Console.Write("masukkan Pilihan : ");
			pilih = int.Parse(Console.ReadLine());
			
			switch (pilih) {
				case 1:
					Console.WriteLine("Nama barang : Laptop");
					Console.WriteLine("ketegory barang : Elektronik");
					Console.WriteLine("harga barang : 5000000");
					break;
				case 2:
					Console.WriteLine("Nama barang : smartphone");
					Console.WriteLine("ketegory barang : Elektronik");
					Console.WriteLine("harga barang : 2000000");
					break;
				case 3:
					Console.WriteLine("Nama barang : mouse");
					Console.WriteLine("ketegory barang : Elektronik");
					Console.WriteLine("harga barang : 50000");
					break;
				case 4:
					Console.WriteLine("Nama barang : CPU");
					Console.WriteLine("ketegory barang : Elektronik");
					Console.WriteLine("harga barang : 5000000");
					break;
				default:
					Console.WriteLine("Barang tidak ditemukan");
					
					break;
			}
			
			
			Console.ReadKey(true);
		}
	}
}