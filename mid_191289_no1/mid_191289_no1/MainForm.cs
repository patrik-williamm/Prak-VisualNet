/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 31/05/2021
 * Time: 16:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mid_191289_no1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			textBox1.Enabled = false;
			textBox3.Enabled = false;
			textBox2.Enabled = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
				
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text=="101") {
				textBox1.Text = "MouseOptik";
				textBox2.Text = "120000";
				
			}else if (comboBox1.Text=="102") {
				textBox1.Text = "Flash Disk 16GB";
				textBox2.Text = "210000";
				
			}else if (comboBox1.Text=="103") {
				textBox1.Text = "Hardisk 1TB";
				textBox2.Text = "750000";
			}else{
				textBox1.Text = "";
				textBox2.Text = "";
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			textBox3.Text = textBox2.Text; 
		}
	}
}
