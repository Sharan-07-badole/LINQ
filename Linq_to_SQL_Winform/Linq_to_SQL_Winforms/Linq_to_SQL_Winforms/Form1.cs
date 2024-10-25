using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_to_SQL_Winforms
{
	public partial class Form1 : Form
	{
		//StudentDBDataContext db;
		//List<Student> std_list;
		//int index_no = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StudentDBDataContext db = new StudentDBDataContext();
			dataGridView1.DataSource = db.Students ;
			//Table<Student> tbl_data = db.Students;
			//dataGridView1.DataSource = tbl_data;

			//db = new StudentDBDataContext();
			// std_list = db.Students.ToList();
			
			//DisplayData();
		}
  //      private void DisplayData()
		//{
		//	MessageBox.Show("YEs got it");
		//	IdtextBox.Text = std_list[index_no].Id.ToString();
		//	NametextBox.Text = std_list[index_no].name;
		//	GendertextBox.Text = std_list[index_no].gender;
		//	AgetextBox.Text = std_list[index_no].age.ToString();
		//	ClasstextBox.Text = std_list[index_no].standard.ToString();
		//}

    }
}
