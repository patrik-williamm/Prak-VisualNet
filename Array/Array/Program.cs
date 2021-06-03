/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 03/06/2021
 * Time: 14:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Array1Dimensi
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] jurusan = new String[4];
			for (int i = 0; i < jurusan.Length; i++) {
				Console.Write("masukkan nama jurusan : ");
				jurusan[i]=Console.ReadLine();
			}
			Console.WriteLine("");
			Console.WriteLine("nama jurusan ");
			Console.WriteLine("");
			for (int i = 0; i < jurusan.Length; i++) {
				Console.WriteLine(jurusan[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}