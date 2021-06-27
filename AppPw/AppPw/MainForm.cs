/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 16/06/2021
 * Time: 10:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppPw
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ConnDB Conn = new ConnDB();
			try {
				Conn.openDb();
				MessageBox.Show("Database terhubung");
			} catch (Exception) {
				Conn.closeDb();
				MessageBox.Show("terjadi kesalahan!!!");
				throw;
			}			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
