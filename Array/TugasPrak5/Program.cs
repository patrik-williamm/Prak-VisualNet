/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 03/06/2021
 * Time: 14:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TugasPrak5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] arr = {
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9},
				{1,2,3,4,5,6,7,8,9}
				
			};
			
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 9; j++) {
					Console.Write(arr[i,j]+" ");
				}
				Console.WriteLine("");
			}
			
			
			Console.ReadKey(true);
		}
	}
}