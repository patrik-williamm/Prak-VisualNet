/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 27/05/2021
 * Time: 14:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Perulanganwhile
{
	class Program
	{
		public static void Main(string[] args)
		{
			int bil;
			int i=1;
			int banyak;
			int besar=0;
			
			Console.Write("Masukkan bilangan yang dicek : ");
			banyak = Convert.ToInt32(Console.ReadLine());
			
			while(i<=banyak) {
				Console.Write("masukkan bilangan ke-"+i+" : ");
				bil = Convert.ToInt32(Console.ReadLine());
				
				if (bil>=besar) {
					besar=bil;
				}
				i++;				
			}
			
			Console.Write("jadi bilangan yang terbesar adalah : "+besar);
			Console.ReadKey(true);
		}
	}
}