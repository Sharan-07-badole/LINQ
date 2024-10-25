namespace Linq_to_Sql_CRUD_Winforms
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
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.GendertextBox = new System.Windows.Forms.TextBox();
			this.Genderlabel = new System.Windows.Forms.Label();
			this.AgetextBox = new System.Windows.Forms.TextBox();
			this.Agelabel = new System.Windows.Forms.Label();
			this.ClasstextBox = new System.Windows.Forms.TextBox();
			this.Standardlabel = new System.Windows.Forms.Label();
			this.Namelabel = new System.Windows.Forms.Label();
			this.Insertbutton = new System.Windows.Forms.Button();
			this.Clearbutton = new System.Windows.Forms.Button();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.Updatebutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// NametextBox
			// 
			this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NametextBox.Location = new System.Drawing.Point(379, 104);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(190, 30);
			this.NametextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(264, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "STUDENT DETAILS";
			// 
			// GendertextBox
			// 
			this.GendertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GendertextBox.Location = new System.Drawing.Point(379, 149);
			this.GendertextBox.Name = "GendertextBox";
			this.GendertextBox.Size = new System.Drawing.Size(190, 30);
			this.GendertextBox.TabIndex = 1;
			// 
			// Genderlabel
			// 
			this.Genderlabel.AutoSize = true;
			this.Genderlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Genderlabel.Location = new System.Drawing.Point(266, 149);
			this.Genderlabel.Name = "Genderlabel";
			this.Genderlabel.Size = new System.Drawing.Size(106, 25);
			this.Genderlabel.TabIndex = 1;
			this.Genderlabel.Text = "GENDER";
			// 
			// AgetextBox
			// 
			this.AgetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AgetextBox.Location = new System.Drawing.Point(379, 195);
			this.AgetextBox.Name = "AgetextBox";
			this.AgetextBox.Size = new System.Drawing.Size(190, 30);
			this.AgetextBox.TabIndex = 2;
			// 
			// Agelabel
			// 
			this.Agelabel.AutoSize = true;
			this.Agelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Agelabel.Location = new System.Drawing.Point(266, 195);
			this.Agelabel.Name = "Agelabel";
			this.Agelabel.Size = new System.Drawing.Size(58, 25);
			this.Agelabel.TabIndex = 2;
			this.Agelabel.Text = "AGE";
			// 
			// ClasstextBox
			// 
			this.ClasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClasstextBox.Location = new System.Drawing.Point(379, 241);
			this.ClasstextBox.Name = "ClasstextBox";
			this.ClasstextBox.Size = new System.Drawing.Size(190, 30);
			this.ClasstextBox.TabIndex = 3;
			// 
			// Standardlabel
			// 
			this.Standardlabel.AutoSize = true;
			this.Standardlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Standardlabel.Location = new System.Drawing.Point(266, 241);
			this.Standardlabel.Name = "Standardlabel";
			this.Standardlabel.Size = new System.Drawing.Size(83, 25);
			this.Standardlabel.TabIndex = 3;
			this.Standardlabel.Text = "CLASS";
			// 
			// Namelabel
			// 
			this.Namelabel.AutoSize = true;
			this.Namelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Namelabel.Location = new System.Drawing.Point(266, 104);
			this.Namelabel.Name = "Namelabel";
			this.Namelabel.Size = new System.Drawing.Size(78, 25);
			this.Namelabel.TabIndex = 0;
			this.Namelabel.Text = "NAME";
			// 
			// Insertbutton
			// 
			this.Insertbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insertbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Insertbutton.Location = new System.Drawing.Point(179, 293);
			this.Insertbutton.Name = "Insertbutton";
			this.Insertbutton.Size = new System.Drawing.Size(99, 38);
			this.Insertbutton.TabIndex = 4;
			this.Insertbutton.Text = "INSERT";
			this.Insertbutton.UseVisualStyleBackColor = false;
			this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
			// 
			// Clearbutton
			// 
			this.Clearbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Clearbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Clearbutton.Location = new System.Drawing.Point(613, 293);
			this.Clearbutton.Name = "Clearbutton";
			this.Clearbutton.Size = new System.Drawing.Size(99, 38);
			this.Clearbutton.TabIndex = 7;
			this.Clearbutton.Text = "CLEAR";
			this.Clearbutton.UseVisualStyleBackColor = false;
			this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
			// 
			// Deletebutton
			// 
			this.Deletebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deletebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Deletebutton.Location = new System.Drawing.Point(471, 293);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(99, 38);
			this.Deletebutton.TabIndex = 6;
			this.Deletebutton.Text = "DELETE";
			this.Deletebutton.UseVisualStyleBackColor = false;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// Updatebutton
			// 
			this.Updatebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updatebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Updatebutton.Location = new System.Drawing.Point(325, 293);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(99, 38);
			this.Updatebutton.TabIndex = 5;
			this.Updatebutton.Text = "UPDATE";
			this.Updatebutton.UseVisualStyleBackColor = false;
			this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(184, 351);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(528, 150);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 551);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Updatebutton);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.Clearbutton);
			this.Controls.Add(this.Insertbutton);
			this.Controls.Add(this.Namelabel);
			this.Controls.Add(this.Standardlabel);
			this.Controls.Add(this.Agelabel);
			this.Controls.Add(this.Genderlabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ClasstextBox);
			this.Controls.Add(this.AgetextBox);
			this.Controls.Add(this.GendertextBox);
			this.Controls.Add(this.NametextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NametextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox GendertextBox;
		private System.Windows.Forms.Label Genderlabel;
		private System.Windows.Forms.TextBox AgetextBox;
		private System.Windows.Forms.Label Agelabel;
		private System.Windows.Forms.TextBox ClasstextBox;
		private System.Windows.Forms.Label Standardlabel;
		private System.Windows.Forms.Label Namelabel;
		private System.Windows.Forms.Button Insertbutton;
		private System.Windows.Forms.Button Clearbutton;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.Button Updatebutton;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

