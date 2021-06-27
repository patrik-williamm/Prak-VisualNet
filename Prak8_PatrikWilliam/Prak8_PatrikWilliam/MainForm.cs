/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 24/06/2021
 * Time: 13:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prak8_PatrikWilliam
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string host = "localhost";
			string pass = "";
			string user = "root";
			string db = "db_koneksi";
			string connStr = "server="+host+";user="+user+";password="+pass+";database="+db+";";
			MySqlConnection conn = new MySqlConnection(connStr);
			
			try{
				conn.Open();
				MessageBox.Show("koneksi berhasil");
			}catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
	}
}
