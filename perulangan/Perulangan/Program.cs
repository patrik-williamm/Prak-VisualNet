/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 27/05/2021
 * Time: 13:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Perulanganfor
{
	class Program
	{
		public static void Main(string[] args)
		{
			for(int i=1; i<=10; i++) {
				Console.WriteLine("increment :-"+i);
			} 
			
			Console.WriteLine();
			
			for(int i=10; i>=1; i--) {
				Console.WriteLine("decrement :-"+i);
			}
			Console.ReadKey(true);
		}
	}
}