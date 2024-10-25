namespace Linq_to_SQL_Winforms
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.Idlabel = new System.Windows.Forms.Label();
			this.IdtextBox = new System.Windows.Forms.TextBox();
			this.Namelabel = new System.Windows.Forms.Label();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.Genderlabel = new System.Windows.Forms.Label();
			this.GendertextBox = new System.Windows.Forms.TextBox();
			this.Agelabel = new System.Windows.Forms.Label();
			this.AgetextBox = new System.Windows.Forms.TextBox();
			this.Classlabel = new System.Windows.Forms.Label();
			this.ClasstextBox = new System.Windows.Forms.TextBox();
			this.Nextbutton = new System.Windows.Forms.Button();
			this.Previousbutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(204, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Students Details";
			// 
			// Idlabel
			// 
			this.Idlabel.AutoSize = true;
			this.Idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Idlabel.Location = new System.Drawing.Point(141, 83);
			this.Idlabel.Name = "Idlabel";
			this.Idlabel.Size = new System.Drawing.Size(30, 25);
			this.Idlabel.TabIndex = 1;
			this.Idlabel.Text = "Id";
			// 
			// IdtextBox
			// 
			this.IdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IdtextBox.Location = new System.Drawing.Point(289, 78);
			this.IdtextBox.Name = "IdtextBox";
			this.IdtextBox.Size = new System.Drawing.Size(268, 30);
			this.IdtextBox.TabIndex = 2;
			// 
			// Namelabel
			// 
			this.Namelabel.AutoSize = true;
			this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Namelabel.Location = new System.Drawing.Point(146, 132);
			this.Namelabel.Name = "Namelabel";
			this.Namelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Namelabel.Size = new System.Drawing.Size(68, 25);
			this.Namelabel.TabIndex = 1;
			this.Namelabel.Text = "Name";
			// 
			// NametextBox
			// 
			this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NametextBox.Location = new System.Drawing.Point(289, 127);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(268, 30);
			this.NametextBox.TabIndex = 2;
			// 
			// Genderlabel
			// 
			this.Genderlabel.AutoSize = true;
			this.Genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Genderlabel.Location = new System.Drawing.Point(141, 178);
			this.Genderlabel.Name = "Genderlabel";
			this.Genderlabel.Size = new System.Drawing.Size(83, 25);
			this.Genderlabel.TabIndex = 1;
			this.Genderlabel.Text = "Gender";
			// 
			// GendertextBox
			// 
			this.GendertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GendertextBox.Location = new System.Drawing.Point(289, 176);
			this.GendertextBox.Name = "GendertextBox";
			this.GendertextBox.Size = new System.Drawing.Size(268, 30);
			this.GendertextBox.TabIndex = 2;
			// 
			// Agelabel
			// 
			this.Agelabel.AutoSize = true;
			this.Agelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Agelabel.Location = new System.Drawing.Point(141, 230);
			this.Agelabel.Name = "Agelabel";
			this.Agelabel.Size = new System.Drawing.Size(51, 25);
			this.Agelabel.TabIndex = 1;
			this.Agelabel.Text = "Age";
			// 
			// AgetextBox
			// 
			this.AgetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AgetextBox.Location = new System.Drawing.Point(289, 223);
			this.AgetextBox.Name = "AgetextBox";
			this.AgetextBox.Size = new System.Drawing.Size(268, 30);
			this.AgetextBox.TabIndex = 2;
			// 
			// Classlabel
			// 
			this.Classlabel.AutoSize = true;
			this.Classlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Classlabel.Location = new System.Drawing.Point(141, 281);
			this.Classlabel.Name = "Classlabel";
			this.Classlabel.Size = new System.Drawing.Size(67, 25);
			this.Classlabel.TabIndex = 1;
			this.Classlabel.Text = "Class";
			// 
			// ClasstextBox
			// 
			this.ClasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClasstextBox.Location = new System.Drawing.Point(289, 276);
			this.ClasstextBox.Name = "ClasstextBox";
			this.ClasstextBox.Size = new System.Drawing.Size(268, 30);
			this.ClasstextBox.TabIndex = 2;
			// 
			// Nextbutton
			// 
			this.Nextbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nextbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Nextbutton.Location = new System.Drawing.Point(393, 332);
			this.Nextbutton.Name = "Nextbutton";
			this.Nextbutton.Size = new System.Drawing.Size(126, 35);
			this.Nextbutton.TabIndex = 3;
			this.Nextbutton.Text = "Next";
			this.Nextbutton.UseVisualStyleBackColor = false;
			// 
			// Previousbutton
			// 
			this.Previousbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Previousbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Previousbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Previousbutton.Location = new System.Drawing.Point(185, 332);
			this.Previousbutton.Name = "Previousbutton";
			this.Previousbutton.Size = new System.Drawing.Size(126, 35);
			this.Previousbutton.TabIndex = 4;
			this.Previousbutton.Text = "Previous";
			this.Previousbutton.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(681, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 5;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(1199, 413);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Previousbutton);
			this.Controls.Add(this.Nextbutton);
			this.Controls.Add(this.ClasstextBox);
			this.Controls.Add(this.Classlabel);
			this.Controls.Add(this.AgetextBox);
			this.Controls.Add(this.Agelabel);
			this.Controls.Add(this.GendertextBox);
			this.Controls.Add(this.Genderlabel);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.Namelabel);
			this.Controls.Add(this.IdtextBox);
			this.Controls.Add(this.Idlabel);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Idlabel;
		private System.Windows.Forms.TextBox IdtextBox;
		private System.Windows.Forms.Label Namelabel;
		private System.Windows.Forms.TextBox NametextBox;
		private System.Windows.Forms.Label Genderlabel;
		private System.Windows.Forms.TextBox GendertextBox;
		private System.Windows.Forms.Label Agelabel;
		private System.Windows.Forms.TextBox AgetextBox;
		private System.Windows.Forms.Label Classlabel;
		private System.Windows.Forms.TextBox ClasstextBox;
		private System.Windows.Forms.Button Nextbutton;
		private System.Windows.Forms.Button Previousbutton;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

