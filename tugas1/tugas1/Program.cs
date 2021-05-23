/*
 * Created by SharpDevelop.
 * User: patrik william
 * Date: 14/04/2021
 * Time: 19:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tugas1 {
	class Program {		
		void isOpen(){
		}
		
		int jumlahBayar(int x, int y) {
			int jlh = x * y;
			return jlh;
		}
		
		double totalByr(int x, double y){
			double total = x-y;
			return total;
		}
		
		void tampil(string a, string b, int c, int d, int e, double f, double g){
			Console.WriteLine("=====================");
			Console.WriteLine("Data Pembelian Barang");
			Console.WriteLine("=====================");
			Console.WriteLine("Kode Barang "+a+" Nama Barang "+b);
			Console.WriteLine("Harga Barang 	: "+c);
			Console.WriteLine("Jumlah Beli 	: "+d);
			Console.WriteLine("Jumlah Bayar 	: "+e);
			Console.WriteLine("Diskon 		: "+f);
			int ab = (int)g;
			Console.WriteLine("Total Bayar 	: "+ab);
		}
		
		public static void Main(string[] args) {
					
			string kd_barang;
			string jns_barang;
			int jlh_beli;
			string nama_brg = "";
			int price=0;
			double diskon = 0, totalbyr = 0;
			int jlh_bayar = 0;
			
			//obj
			Program my = new Program();
			
			bool isNext=true;
			int i=1;
			while (isNext) {
				Console.WriteLine("Data Ke-"+i++);
				
				Console.Write("kode Barang 	: ");	
				kd_barang = Console.ReadLine();
			
				Console.Write("Jenis Barang[A-D] : ");
				jns_barang = Console.ReadLine();
			
				Console.Write("Jumlah Beli 	: ");
				jlh_beli = int.Parse(Console.ReadLine());
				
				if (jlh_beli > 5) {
					diskon = 0.1;
				}else{
					diskon = 0;
				}
				switch (jns_barang.ToUpper()) {
					case "A":
				        nama_brg = "Baju Kemeja";
				        price = 50000;
				        jlh_bayar = my.jumlahBayar(price, jlh_beli);
				        totalbyr = my.totalByr(jlh_bayar, diskon);
				        break;	
				    case "B":
				        nama_brg = "celana panjang";
				        price = 10000;
				        jlh_bayar = my.jumlahBayar(price, jlh_beli);
				        totalbyr=my.totalByr(jlh_bayar, diskon);
				        break;
				    case "C":
				        nama_brg = "Topi";
				        price = 80000;
				        jlh_bayar = my.jumlahBayar(price, jlh_beli);
				        totalbyr=my.totalByr(jlh_bayar, diskon);
				        break;	
				    case "D":
				        nama_brg = "Sepatu";
				        price = 100000;
				        jlh_bayar = my.jumlahBayar(price, jlh_beli);
				        totalbyr=my.totalByr(jlh_bayar, diskon);
				        break;
				    default:
				        Console.WriteLine("Jenis Barang Tidak tersedia");
				        break;
				}
				
				my.tampil(kd_barang, nama_brg, price, jlh_beli, jlh_bayar, diskon, totalbyr);
				Console.Write("Lanjutkan Program [y/n] 	: ");
				string yesOrNo = Console.ReadLine();
				
				if (yesOrNo=="y") {
					isNext=true;
				}else if (yesOrNo=="n") {
					isNext=false;
				}else {
					while (yesOrNo != "y" && yesOrNo != "n") {
						Console.Write("Lanjutkan Program [y/n] 	: ");
						yesOrNo = Console.ReadLine();
						if (yesOrNo=="y") {
							isNext=true;
						}else if (yesOrNo=="n") {
							isNext=false;
						}
					}
				}
			}
			Console.WriteLine("-----++++++-----+++++");
			Console.ReadKey(true);
		}
	}
}