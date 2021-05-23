/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 29/04/2021
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;

namespace praktikum1 {
	class Program {
		public static void Main(string[] args) {
			
			string nama, nim, jurusan, address, tglLahir, jnsKelamin, golDarah;
			int age;
			double beratBadan, tinggiBadan;
			
			Console.Write("masukkan Nama 	: ");
			nama = Console.ReadLine();
			Console.Write("masukkan Nim 	: ");
			nim = Console.ReadLine();
			
			Console.Write("masukkan Jurusan 	: ");
			jurusan = Console.ReadLine();
			Console.Write("masukkan ALamat 	: ");
			address = Console.ReadLine();
			
			Console.Write("masukkan tempat tgl lahir 	: ");
			tglLahir = Console.ReadLine();
			Console.Write("masukkan jenis-kelamin 	: ");
			jnsKelamin = Console.ReadLine();
			
			Console.Write("masukkan Age 	: ");
			age = int.Parse(Console.ReadLine());
			Console.Write("masukkan gol Darah 	: ");
			golDarah =Console.ReadLine();
			
			Console.Write("masukkan berat Badan 	: ");
			beratBadan =double.Parse(Console.ReadLine());
			Console.Write("masukkan tinggi Badan 	: ");
			tinggiBadan = double.Parse(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("Nama : "+nama);
			Console.WriteLine("Nim : "+nim);
			Console.WriteLine("Jurusan : "+jurusan);
			Console.WriteLine("Alamat : "+address);
			Console.WriteLine("Tempat tanggal lahir : "+tglLahir);
			Console.WriteLine("jenis kelamin : "+jnsKelamin);
			Console.WriteLine("gol darah : "+golDarah);
			Console.WriteLine("umur : "+age);
			Console.WriteLine("berat badan : "+beratBadan);
			Console.WriteLine("tinggi badan : "+tinggiBadan);
			
			
			// TODO: Implement Functionality Here
			Console.ReadKey(true);
		}
	}
}