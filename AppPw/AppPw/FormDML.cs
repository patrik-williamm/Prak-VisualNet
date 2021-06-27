	/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 22/06/2021
 * Time: 13:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppPw
{
	/// <summary>
	/// Description of FormDML.
	/// </summary>
	public partial class FormDML : Form
	{
		public FormDML()
		{
			InitializeComponent();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
					
		}
		
		void BtnKeluarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
