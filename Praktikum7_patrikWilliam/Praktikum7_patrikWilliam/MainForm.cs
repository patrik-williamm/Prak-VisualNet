/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 17/06/2021
 * Time: 15:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Praktikum7_patrikWilliam
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			for (int i = 1; i <= 31; i++) {
				txtTanggal.Items.Add(i);
			}				
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
