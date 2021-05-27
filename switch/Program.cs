/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 06/05/2021
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace program3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int ipk;
			Console.Write("masukkan kode [1-5] : ");
			ipk = Convert.ToInt16(Console.ReadLine());
			
			switch(ipk) {
				case 1:
					Console.WriteLine("sistem informasi ");
					break;
				case 2:
					Console.WriteLine("teknik informatika");
					break;
				case 3:
					Console.WriteLine("rekayasa perangkat lunak");
					break;
				case 4: 
					Console.WriteLine("manajemen informatika");
					break;
				case 5 : 
					Console.WriteLine("teknik sipil");
					break;
				default:
					Console.WriteLine("code anda masukkan tidak di temukan!!!");
					break;
			}
	
			Console.ReadKey(true);
		}
	}
}