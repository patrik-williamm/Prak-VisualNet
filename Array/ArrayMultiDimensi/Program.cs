/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 03/06/2021
 * Time: 14:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ArrayMultiDimensi
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] Matriks = new int[2,3];
			Matriks[0,0] = 2;
			Matriks[0,1] = 3;
			Matriks[0,2] = 5;
			Matriks[1,0] = 8;
			Matriks[1,1] = 2;
			Matriks[1,2] = 4;
			
			Console.WriteLine("Element matriks : ");
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j < 3; j++) {
					Console.Write(Matriks[i,j]+ " ");
				}
				Console.WriteLine();
			}
			Console.ReadKey(true);
		}
	}
}