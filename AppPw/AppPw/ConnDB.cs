/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 16/06/2021
 * Time: 10:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace AppPw
{
	public class ConnDB
	{
		string addressDB = "server=localhost; database=latihan; uid=root; pwd="; 
		public MySqlConnection Conn;
	
		public void openDb(){
			Conn = new MySqlConnection(addressDB);
			Conn.Open();
		}
		
		public void closeDb(){
			Conn = new MySqlConnection(addressDB);
			Conn.Close();
		}
	}
}
