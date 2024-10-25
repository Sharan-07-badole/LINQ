namespace Linq_to_Sql_CRUD_Winforms
{
	partial class Form3
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
			this.Updatebutton = new System.Windows.Forms.Button();
			this.Insertbutton = new System.Windows.Forms.Button();
			this.Namelabel = new System.Windows.Forms.Label();
			this.Standardlabel = new System.Windows.Forms.Label();
			this.Agelabel = new System.Windows.Forms.Label();
			this.Genderlabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ClasstextBox = new System.Windows.Forms.TextBox();
			this.AgetextBox = new System.Windows.Forms.TextBox();
			this.GendertextBox = new System.Windows.Forms.TextBox();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Updatebutton
			// 
			this.Updatebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updatebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Updatebutton.Location = new System.Drawing.Point(465, 333);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(99, 38);
			this.Updatebutton.TabIndex = 16;
			this.Updatebutton.Text = "UPDATE";
			this.Updatebutton.UseVisualStyleBackColor = false;
			// 
			// Insertbutton
			// 
			this.Insertbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insertbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Insertbutton.Location = new System.Drawing.Point(319, 333);
			this.Insertbutton.Name = "Insertbutton";
			this.Insertbutton.Size = new System.Drawing.Size(99, 38);
			this.Insertbutton.TabIndex = 15;
			this.Insertbutton.Text = "INSERT";
			this.Insertbutton.UseVisualStyleBackColor = false;
			this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
			// 
			// Namelabel
			// 
			this.Namelabel.AutoSize = true;
			this.Namelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Namelabel.Location = new System.Drawing.Point(292, 144);
			this.Namelabel.Name = "Namelabel";
			this.Namelabel.Size = new System.Drawing.Size(78, 25);
			this.Namelabel.TabIndex = 6;
			this.Namelabel.Text = "NAME";
			// 
			// Standardlabel
			// 
			this.Standardlabel.AutoSize = true;
			this.Standardlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Standardlabel.Location = new System.Drawing.Point(292, 281);
			this.Standardlabel.Name = "Standardlabel";
			this.Standardlabel.Size = new System.Drawing.Size(83, 25);
			this.Standardlabel.TabIndex = 13;
			this.Standardlabel.Text = "CLASS";
			// 
			// Agelabel
			// 
			this.Agelabel.AutoSize = true;
			this.Agelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Agelabel.Location = new System.Drawing.Point(292, 235);
			this.Agelabel.Name = "Agelabel";
			this.Agelabel.Size = new System.Drawing.Size(58, 25);
			this.Agelabel.TabIndex = 11;
			this.Agelabel.Text = "AGE";
			// 
			// Genderlabel
			// 
			this.Genderlabel.AutoSize = true;
			this.Genderlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Genderlabel.Location = new System.Drawing.Point(292, 189);
			this.Genderlabel.Name = "Genderlabel";
			this.Genderlabel.Size = new System.Drawing.Size(106, 25);
			this.Genderlabel.TabIndex = 8;
			this.Genderlabel.Text = "GENDER";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(290, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 36);
			this.label1.TabIndex = 9;
			this.label1.Text = "STUDENT DETAILS";
			// 
			// ClasstextBox
			// 
			this.ClasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClasstextBox.Location = new System.Drawing.Point(405, 281);
			this.ClasstextBox.Name = "ClasstextBox";
			this.ClasstextBox.Size = new System.Drawing.Size(190, 30);
			this.ClasstextBox.TabIndex = 14;
			// 
			// AgetextBox
			// 
			this.AgetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AgetextBox.Location = new System.Drawing.Point(405, 235);
			this.AgetextBox.Name = "AgetextBox";
			this.AgetextBox.Size = new System.Drawing.Size(190, 30);
			this.AgetextBox.TabIndex = 12;
			// 
			// GendertextBox
			// 
			this.GendertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GendertextBox.Location = new System.Drawing.Point(405, 189);
			this.GendertextBox.Name = "GendertextBox";
			this.GendertextBox.Size = new System.Drawing.Size(190, 30);
			this.GendertextBox.TabIndex = 10;
			// 
			// NametextBox
			// 
			this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NametextBox.Location = new System.Drawing.Point(405, 144);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(190, 30);
			this.NametextBox.TabIndex = 7;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Updatebutton);
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
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Updatebutton;
		private System.Windows.Forms.Button Insertbutton;
		private System.Windows.Forms.Label Namelabel;
		private System.Windows.Forms.Label Standardlabel;
		private System.Windows.Forms.Label Agelabel;
		private System.Windows.Forms.Label Genderlabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ClasstextBox;
		private System.Windows.Forms.TextBox AgetextBox;
		private System.Windows.Forms.TextBox GendertextBox;
		private System.Windows.Forms.TextBox NametextBox;
	}
}