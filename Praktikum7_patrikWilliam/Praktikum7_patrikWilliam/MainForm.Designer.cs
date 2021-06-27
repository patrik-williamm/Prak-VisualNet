/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 17/06/2021
 * Time: 15:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Praktikum7_patrikWilliam
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
			this.labelNama = new System.Windows.Forms.Label();
			this.labelNim = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.txtNim = new System.Windows.Forms.TextBox();
			this.txtJurusan = new System.Windows.Forms.TextBox();
			this.txtTanggal = new System.Windows.Forms.ComboBox();
			this.txtJs = new System.Windows.Forms.ComboBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelNama
			// 
			this.labelNama.Location = new System.Drawing.Point(55, 38);
			this.labelNama.Name = "labelNama";
			this.labelNama.Size = new System.Drawing.Size(100, 23);
			this.labelNama.TabIndex = 0;
			this.labelNama.Text = "Nama";
			// 
			// labelNim
			// 
			this.labelNim.Location = new System.Drawing.Point(55, 81);
			this.labelNim.Name = "labelNim";
			this.labelNim.Size = new System.Drawing.Size(100, 23);
			this.labelNim.TabIndex = 1;
			this.labelNim.Text = "NIM";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(55, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Jurusan";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(55, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tangga lahir";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(55, 212);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Jenis kelamin";
			// 
			// txtNama
			// 
			this.txtNama.Location = new System.Drawing.Point(248, 38);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(154, 20);
			this.txtNama.TabIndex = 5;
			// 
			// txtNim
			// 
			this.txtNim.Location = new System.Drawing.Point(248, 81);
			this.txtNim.Name = "txtNim";
			this.txtNim.Size = new System.Drawing.Size(154, 20);
			this.txtNim.TabIndex = 6;
			// 
			// txtJurusan
			// 
			this.txtJurusan.Location = new System.Drawing.Point(248, 123);
			this.txtJurusan.Name = "txtJurusan";
			this.txtJurusan.Size = new System.Drawing.Size(154, 20);
			this.txtJurusan.TabIndex = 7;
			// 
			// txtTanggal
			// 
			this.txtTanggal.FormattingEnabled = true;
			this.txtTanggal.Location = new System.Drawing.Point(248, 166);
			this.txtTanggal.Name = "txtTanggal";
			this.txtTanggal.Size = new System.Drawing.Size(121, 21);
			this.txtTanggal.TabIndex = 8;
			// 
			// txtJs
			// 
			this.txtJs.FormattingEnabled = true;
			this.txtJs.Location = new System.Drawing.Point(248, 212);
			this.txtJs.Name = "txtJs";
			this.txtJs.Size = new System.Drawing.Size(121, 21);
			this.txtJs.TabIndex = 9;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(310, 321);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(405, 321);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 11;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 427);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtJs);
			this.Controls.Add(this.txtTanggal);
			this.Controls.Add(this.txtJurusan);
			this.Controls.Add(this.txtNim);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelNim);
			this.Controls.Add(this.labelNama);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Praktikum 7 Patrik William";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSave;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ComboBox txtJs;
		private System.Windows.Forms.ComboBox txtTanggal;
		private System.Windows.Forms.TextBox txtJurusan;
		private System.Windows.Forms.TextBox txtNim;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelNim;
		private System.Windows.Forms.Label labelNama;
	}
}
