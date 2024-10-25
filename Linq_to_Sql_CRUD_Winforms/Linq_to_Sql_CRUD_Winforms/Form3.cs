using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_to_Sql_CRUD_Winforms
{
	public partial class Form3 : Form
	{
		// before continue , create stored new procedure
		// i.e fetching data from student table
		// and then convert into procedure into method that is ORM method
		StudentDBDataContext db;
		public Form3()
		{
			InitializeComponent();
		}

		private void Insertbutton_Click(object sender, EventArgs e)
		{
			// Creating obj for context class
			db = new StudentDBDataContext();

			// inserting data into student table using procedure 
			//(only in single line data will be added to student table)
			db.InsertData(NametextBox.Text, GendertextBox.Text, int.Parse(AgetextBox.Text), int.Parse(ClasstextBox.Text));
			
			MessageBox.Show("Data inserted Successfully..");

			// Remaining work that i have to do clear, update delete fetch through stored procedure
		}
		
	}
}
