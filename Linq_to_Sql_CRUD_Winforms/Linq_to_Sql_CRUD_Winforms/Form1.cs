using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_to_Sql_CRUD_Winforms
{
	// Code for form 1 where we can do CRUD operaation i.e insert update delete fetch
	// and we can do CRUD operation by using stored procedure 
	// in form 2 we are showing data through stored procedure,
	// by creating stored procedure and after that inside form2 itself,
	// we are updating the stored procedure and showing data according to user search the standard,
	// so user will get data according to the standard.
	// In form 3 we are just inserting the data into database using stored procedure,
	// as we seen in form 1 that is normal CRUD operation and in form 3 inserting data
	// using stored only (and upodate delete we can do , do it later)
	public partial class Form1 : Form
	{
		// initializing the object for datacontext class
		StudentDBDataContext db;

		//// Initializing Student obj as students to store data into student table
		//// and list we are taking because of it has more than one row
		//List<Student> students;

		//int index_no = 0;
		public Form1()
		{
			InitializeComponent();
		}

		// Creating private method for clear all the textboxes
		private void ClearTextBoxes()
		{
			// Fetching all the controls in an object 
			foreach (Control ctr in this.Controls)
			{
				// If only ctr object is control then only i have to clear
				if (ctr is TextBox)
				{
					TextBox txt = ctr as TextBox;
					txt.Clear();
				}
			}
			// Now i have to focus on first textbox i.e name textbox after clearing all the textboxes
			NametextBox.Focus();
		}

		//creating method to bind data from db to gridview
		private void GridViewBind()
		{
			// creating obj for datacontext to insert or fetch data from db
			db = new StudentDBDataContext();

			// Bind data from database db of student table to gridview datasource
			dataGridView1.DataSource = db.Students;
		}

		private void Insertbutton_Click(object sender, EventArgs e)
		{
			if (NametextBox.Text == "" || GendertextBox.Text == "" || AgetextBox.Text == "" || ClasstextBox.Text == "")
			{
				MessageBox.Show("Please first fill all data..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				// creating obj for data context
				db = new StudentDBDataContext();

				// We have to insert data into student property , so creating object gor student class
				Student std = new Student();

				// Inserting user data from text box to student class method 
				std.Name = NametextBox.Text;
				std.Gender = GendertextBox.Text;
				std.Age = int.Parse(AgetextBox.Text);    // Converting string value into int
				std.Standard = int.Parse(ClasstextBox.Text);

				// Now,inserting data into dbcontext i.e into database
				db.Students.InsertOnSubmit(std);  // It's just temporary cahnges happened in db

				// Now, its permanately saved into db , it's compulsory we have to make changes
				db.SubmitChanges();

				// Showing text box for successful inserted..with ok button and showing information,and success design
				MessageBox.Show("Data inserted Successfully..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Calling cleartextboxes method to clear and focus on name textbox
				ClearTextBoxes();

				//Call gridviewbind method to show inserted record into gridview
				GridViewBind();
			}
		}

		private void Clearbutton_Click(object sender, EventArgs e)
		{
			// When click on clear button , we have to call cleartextboxes method 
			ClearTextBoxes();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// call gridviewbind method, because when Page loads whatever records are into student table display on gridview
			GridViewBind();
		}

		private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			// Now when click on any row in gridview i have to show details in textboes accordign to id 
			NametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			GendertextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			AgetextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			ClasstextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
		}

		private void Updatebutton_Click(object sender, EventArgs e)
		{
			// We fisrt have to check user selected the row or not
			if (dataGridView1.SelectedRows.Count > 0)
			{
				db = new StudentDBDataContext();
				// Selecting id of which user selected the row from gridview datasourse  
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

				// Now selecting row from database where id matched from user to table
				Student std = db.Students.FirstOrDefault(s => s.Id == id);

				std.Name = NametextBox.Text;
				std.Gender = GendertextBox.Text;
				std.Age = int.Parse(AgetextBox.Text);  //  We have to change into int type from textbox
				std.Standard = int.Parse(ClasstextBox.Text);

				// There is no any method for changes , we directly submitchanges we have to do.
				db.SubmitChanges();
				MessageBox.Show("Data Updated Successfully..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearTextBoxes();
				GridViewBind();
			}
			else
			{
				MessageBox.Show("Please select a row..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DialogResult confirm = MessageBox.Show("Are you seure to delete data", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirm == DialogResult.Yes)
				{
					db = new StudentDBDataContext();
					int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
					Student std = db.Students.FirstOrDefault(s => s.Id == id);

					// Deleting data from database student table where id selected by user
					db.Students.DeleteOnSubmit(std);

					db.SubmitChanges();
					MessageBox.Show("Data Deleted Successfully..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearTextBoxes();
					GridViewBind();
				}

			}
			else
			{
				MessageBox.Show("Please select a row..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
