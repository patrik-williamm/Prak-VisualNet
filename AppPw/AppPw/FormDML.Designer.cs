/*
 * Created by SharpDevelop.
 * User: Asus
 * Date: 22/06/2021
 * Time: 13:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AppPw
{
	partial class FormDML
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
			this.labelMid = new System.Windows.Forms.Label();
			this.labelNama = new System.Windows.Forms.Label();
			this.labelAlamat = new System.Windows.Forms.Label();
			this.labelTugas = new System.Windows.Forms.Label();
			this.txtMid = new System.Windows.Forms.TextBox();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.txtAlamat = new System.Windows.Forms.TextBox();
			this.txtTugas = new System.Windows.Forms.TextBox();
			this.labelMid2 = new System.Windows.Forms.Label();
			this.labelFinal = new System.Windows.Forms.Label();
			this.labelAkhir = new System.Windows.Forms.Label();
			this.labelHuruf = new System.Windows.Forms.Label();
			this.labelKet = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.btnViews = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnKeluar = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataView1 = new System.Data.DataView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMid
			// 
			this.labelMid.Location = new System.Drawing.Point(39, 41);
			this.labelMid.Name = "labelMid";
			this.labelMid.Size = new System.Drawing.Size(100, 23);
			this.labelMid.TabIndex = 0;
			this.labelMid.Text = "Nilai MID";
			// 
			// labelNama
			// 
			this.labelNama.Location = new System.Drawing.Point(39, 74);
			this.labelNama.Name = "labelNama";
			this.labelNama.Size = new System.Drawing.Size(100, 23);
			this.labelNama.TabIndex = 1;
			this.labelNama.Text = "Nama";
			// 
			// labelAlamat
			// 
			this.labelAlamat.Location = new System.Drawing.Point(39, 110);
			this.labelAlamat.Name = "labelAlamat";
			this.labelAlamat.Size = new System.Drawing.Size(100, 23);
			this.labelAlamat.TabIndex = 2;
			this.labelAlamat.Text = "Alamat";
			// 
			// labelTugas
			// 
			this.labelTugas.Location = new System.Drawing.Point(39, 143);
			this.labelTugas.Name = "labelTugas";
			this.labelTugas.Size = new System.Drawing.Size(100, 23);
			this.labelTugas.TabIndex = 3;
			this.labelTugas.Text = "Nilai Tugas";
			// 
			// txtMid
			// 
			this.txtMid.Location = new System.Drawing.Point(145, 38);
			this.txtMid.Name = "txtMid";
			this.txtMid.Size = new System.Drawing.Size(100, 20);
			this.txtMid.TabIndex = 4;
			// 
			// txtNama
			// 
			this.txtNama.Location = new System.Drawing.Point(145, 71);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(151, 20);
			this.txtNama.TabIndex = 5;
			// 
			// txtAlamat
			// 
			this.txtAlamat.Location = new System.Drawing.Point(145, 105);
			this.txtAlamat.Name = "txtAlamat";
			this.txtAlamat.Size = new System.Drawing.Size(151, 20);
			this.txtAlamat.TabIndex = 6;
			// 
			// txtTugas
			// 
			this.txtTugas.Location = new System.Drawing.Point(145, 143);
			this.txtTugas.Name = "txtTugas";
			this.txtTugas.Size = new System.Drawing.Size(100, 20);
			this.txtTugas.TabIndex = 7;
			// 
			// labelMid2
			// 
			this.labelMid2.Location = new System.Drawing.Point(323, 41);
			this.labelMid2.Name = "labelMid2";
			this.labelMid2.Size = new System.Drawing.Size(100, 23);
			this.labelMid2.TabIndex = 8;
			this.labelMid2.Text = "Nilai MID ";
			// 
			// labelFinal
			// 
			this.labelFinal.Location = new System.Drawing.Point(323, 74);
			this.labelFinal.Name = "labelFinal";
			this.labelFinal.Size = new System.Drawing.Size(100, 23);
			this.labelFinal.TabIndex = 9;
			this.labelFinal.Text = "Nilai Final";
			// 
			// labelAkhir
			// 
			this.labelAkhir.Location = new System.Drawing.Point(323, 110);
			this.labelAkhir.Name = "labelAkhir";
			this.labelAkhir.Size = new System.Drawing.Size(100, 23);
			this.labelAkhir.TabIndex = 10;
			this.labelAkhir.Text = "Nilai Akhir";
			// 
			// labelHuruf
			// 
			this.labelHuruf.Location = new System.Drawing.Point(323, 146);
			this.labelHuruf.Name = "labelHuruf";
			this.labelHuruf.Size = new System.Drawing.Size(100, 23);
			this.labelHuruf.TabIndex = 11;
			this.labelHuruf.Text = "Huruf";
			// 
			// labelKet
			// 
			this.labelKet.Location = new System.Drawing.Point(323, 182);
			this.labelKet.Name = "labelKet";
			this.labelKet.Size = new System.Drawing.Size(100, 23);
			this.labelKet.TabIndex = 12;
			this.labelKet.Text = "Keterangan";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(429, 38);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 13;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(429, 71);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 14;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(429, 107);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 15;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(429, 143);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 16;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(429, 179);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 17;
			// 
			// btnViews
			// 
			this.btnViews.Location = new System.Drawing.Point(596, 47);
			this.btnViews.Name = "btnViews";
			this.btnViews.Size = new System.Drawing.Size(75, 23);
			this.btnViews.TabIndex = 18;
			this.btnViews.Text = "Views";
			this.btnViews.UseVisualStyleBackColor = true;
			// 
			// btnHapus
			// 
			this.btnHapus.Location = new System.Drawing.Point(596, 76);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(75, 23);
			this.btnHapus.TabIndex = 19;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = true;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(677, 47);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(75, 23);
			this.btnInsert.TabIndex = 20;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(677, 76);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 21;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnKeluar
			// 
			this.btnKeluar.Location = new System.Drawing.Point(596, 105);
			this.btnKeluar.Name = "btnKeluar";
			this.btnKeluar.Size = new System.Drawing.Size(75, 23);
			this.btnKeluar.TabIndex = 22;
			this.btnKeluar.Text = "Keluar";
			this.btnKeluar.UseVisualStyleBackColor = true;
			this.btnKeluar.Click += new System.EventHandler(this.BtnKeluarClick);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(644, 177);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 23;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(39, 259);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(713, 229);
			this.dataGridView1.TabIndex = 24;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// FormDML
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 491);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.btnKeluar);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnViews);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelKet);
			this.Controls.Add(this.labelHuruf);
			this.Controls.Add(this.labelAkhir);
			this.Controls.Add(this.labelFinal);
			this.Controls.Add(this.labelMid2);
			this.Controls.Add(this.txtTugas);
			this.Controls.Add(this.txtAlamat);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.txtMid);
			this.Controls.Add(this.labelTugas);
			this.Controls.Add(this.labelAlamat);
			this.Controls.Add(this.labelNama);
			this.Controls.Add(this.labelMid);
			this.Name = "FormDML";
			this.Text = "FormDML";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Data.DataView dataView1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnKeluar;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnViews;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelKet;
		private System.Windows.Forms.Label labelHuruf;
		private System.Windows.Forms.Label labelAkhir;
		private System.Windows.Forms.Label labelFinal;
		private System.Windows.Forms.Label labelMid2;
		private System.Windows.Forms.TextBox txtTugas;
		private System.Windows.Forms.TextBox txtAlamat;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.TextBox txtMid;
		private System.Windows.Forms.Label labelTugas;
		private System.Windows.Forms.Label labelAlamat;
		private System.Windows.Forms.Label labelNama;
		private System.Windows.Forms.Label labelMid;
	}
}
