/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 24/06/2021
 * Time: 15:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace View_data
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			View.Text = ("Nama : "+textBox1.Text+"\r\n");
			View.Text = (View.Text+"alamat : "+textBox2.Text+"\r\n");
			View.Text = (View.Text+"univeristas : "+textBox3.Text+"\r\n");
			View.Text = (View.Text+"jurusan : "+textBox4.Text+"\r\n");
			View.Text = (View.Text+"Ipk : "+textBox5.Text+"\r\n");
			View.Text = (View.Text+"Predikat : "+textBox6.Text+"\r\n");			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			View.Text = ("");			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ViewSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
