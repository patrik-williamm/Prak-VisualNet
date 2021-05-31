/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 31/05/2021
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Mid_191289_no2
{
	class Tanggal
	{
		public string tgl;
		public string bln;
		public string tahun;
		
		public Tanggal(string tgllhr, string blnlhr, string tahunlhr){
			tgl = tgllhr;
			bln = blnlhr;
			tahun = tahunlhr;
		}
	
		public string getTanggal() {
			string my = "tanggal lahir saya adalah "+tgl+"-"+bln+"-"+tahun;
			return my;
	}
		public static void Main(string[] args)
		{
			Tanggal ok = new Tanggal("11","5","2001");
			Console.WriteLine(ok.getTanggal());
			
			Console.ReadKey(true);
		}
	}
}
