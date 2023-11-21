using CS322_DZ07.model;
using CS322_DZ07.repository.impl;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ07
{
    public partial class Form1 : Form
    {


        UserRepositoryImpl repo = new UserRepositoryImpl();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ViewData_btn_Click(object sender, EventArgs e)
        {
                
            DataSet ds = new DataSet();
            dataGridView1.DataSource = ConvertListToDataTable(repo.FindAll());
        
        }

        private DataTable ConvertListToDataTable(List<User> userList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(long));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));

            foreach (User user in userList)
            {
                dt.Rows.Add(user.Id, user.FirstName, user.LastName, user.Age);
            }
            return dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(id_tb.Text);
            string firstName = first_name_tb.Text;
            string lastName = last_name_tb.Text;
            int age = Convert.ToInt32(age_tb.Text);

            User u = new User(id,firstName,lastName,age);
            repo.AddUser(u);
            id_tb.Clear();
            first_name_tb.Clear();
            last_name_tb.Clear();
            age_tb.Clear();

            DataSet ds = new DataSet();
            dataGridView1.DataSource = ConvertListToDataTable(repo.FindAll());

        }

        private void id_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
           if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow gr = dataGridView1.SelectedRows[0];
                repo.DeleteById(Convert.ToInt64(gr.Cells["Id"].Value.ToString()));

                DataSet ds = new DataSet();
                dataGridView1.DataSource = ConvertListToDataTable(repo.FindAll());

            } 
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow gr = dataGridView1.SelectedRows[0];
                id_tb.Text = gr.Cells["Id"].Value.ToString();
                first_name_tb.Text = gr.Cells["First Name"].Value.ToString();
                last_name_tb.Text = gr.Cells["Last Name"].Value.ToString();
                age_tb.Text = gr.Cells["Age"].Value.ToString();

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(id_tb.Text);
            string firstName = first_name_tb.Text;
            string lastName = last_name_tb.Text;
            int age = Convert.ToInt32(age_tb.Text);

           
            repo.EditById(id,firstName,lastName,age);
            id_tb.Clear();
            first_name_tb.Clear();
            last_name_tb.Clear();
            age_tb.Clear();

            DataSet ds = new DataSet();
            dataGridView1.DataSource = ConvertListToDataTable(repo.FindAll());


        }
    }
}
