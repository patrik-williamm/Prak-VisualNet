/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 06/05/2021
 * Time: 14:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace if_else {
	class Program {
		public static void Main(string[] args) {
			
			float ipk;
			string predikat;
			Console.Write("Masukkan Ipk 	: ");
			ipk = Convert.ToSingle(Console.ReadLine());
			
			if (ipk>3.5)
				predikat = "cumlaude";
			else if(ipk > 3)
				predikat = "sangat memuaskan";
			else if(ipk >= 2.75) 
				predikat = "memuaskan";
			else if(ipk >= 2)
				predikat = "cukup";
			else
				predikat = "memuakkan";
			
			Console.WriteLine("predikat anda adalah : "+predikat);
			Console.ReadKey(true);
		}
	}
}