/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 04/05/2021
 * Time: 14:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace appGui_1
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e) {
			
		}
		
		void Label1Click(object sender, EventArgs e) {
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e) {
			textBox2.Text = "123";
		}
	}
}
