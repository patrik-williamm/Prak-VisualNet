﻿/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 31/05/2021
 * Time: 16:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace mid_191289_no1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(53, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "kode";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(53, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Barang";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(53, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "harga";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(53, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "jumlah";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(53, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 47);
			this.label5.TabIndex = 4;
			this.label5.Text = "status pembelian";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"101",
									"102",
									"103"});
			this.comboBox1.Location = new System.Drawing.Point(135, 29);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(216, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(135, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(216, 20);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(135, 107);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(216, 20);
			this.textBox2.TabIndex = 7;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(135, 190);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Member";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(247, 190);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Bukan member";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(135, 246);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 34);
			this.button1.TabIndex = 11;
			this.button1.Text = "Hitung";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(247, 246);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 34);
			this.button2.TabIndex = 12;
			this.button2.Text = "Bersihkan";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(135, 307);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(226, 20);
			this.textBox3.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(53, 310);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Total";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(135, 151);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 452);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "mid_191289_no1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
