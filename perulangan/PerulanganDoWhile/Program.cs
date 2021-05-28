/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 27/05/2021
 * Time: 14:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PerulanganDoWhile
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1;
			int nextDigit;
			
			Console.Write("Masukkan 2 bilangan atau lebih : ");
			num1 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("bilangan sebelum dibalik : "+num1+"\n");
			
			Console.Write("bilangan setelah di balik : ");
			do{
				nextDigit = num1 %10;
				Console.Write(nextDigit);
				num1 = num1/10;
			}while (num1 > 0);
			
			Console.ReadKey(true);
		}
	}
}