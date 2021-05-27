/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 27/05/2021
 * Time: 11:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace method{
	
	class test{
		private string nama;
		private int age;
		
		public test() {
		}
		
		public test(string nama="nama", int age = 0) {
			this.nama = nama;
			this.age = age;
		}
		private void setNama(string nama) {
		 	this.nama = nama;
		}
		private string getNama() {
			return nama;
		}
		
		private void setAge(int age){
			this.age = age;
		}
		
		private int getAge(){
			return age;
		}
		
		
//		private int testXY(int x, int y) {
//			int total = x *  y;
//			return total;
//		}
		
		public static void Main(string[] args){
			
			test test1 = new test("patrik william", 20);
			test1.setNama("Naruto Uzumaki");
			test1.setAge(25);
			Console.WriteLine(test1.getNama());
			Console.WriteLine(test1.getAge());
			Console.ReadKey(true);
		}
	}
}