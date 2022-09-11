using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_Assignment
{
    public partial class ClientForm : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Semester 2\CMPG 223\CMPG223_Assignment\CMPG223_Assignment\Books.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet dSet;
        SqlCommand com;
        SqlDataAdapter reader;
        

        public ClientForm()
        {
            InitializeComponent();
        }
        public static int selectClient;

       //Populate comboboxes from Table
        private void Populate()
        {
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();



                string sql = "SELECT Client_ID FROM CLIENT ";
                com = new SqlCommand(sql, con);
                SqlDataReader reader = com.ExecuteReader();


                while (reader.Read())
                {
                    cbID.Items.Add(reader.GetValue(0));
                    cbSelect.Items.Add(reader.GetValue(0));
                }

           
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Load Data Grid View
        public void LoadDGW()
        {
            con = new SqlConnection(conString);
            try
            {
              

                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM CLIENT";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "CLIENT");


                DGWClient.DataSource = dSet;
                DGWClient.DataMember = "CLIENT";

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }


      //Search Dgw by Name or Id 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                //Only Search when string is detected
                if (txtSearch.Text != "")
                {
                    string sql = @"SELECT * FROM CLIENT WHERE First_Name LIKE '%" + txtSearch.Text + "%'";

                    com = new SqlCommand(sql, con);

                    adapt.SelectCommand = com;
                    adapt.Fill(dSet, "CLIENT");


                    DGWClient.DataSource = dSet;
                    DGWClient.DataMember = "CLIENT";

                    string sql2 = @"SELECT * FROM CLIENT WHERE Client_ID LIKE '%" + txtSearch.Text + "%'";

                    com = new SqlCommand(sql2, con);

                    adapt.SelectCommand = com;
                    adapt.Fill(dSet, "CLIENT");


                    DGWClient.DataSource = dSet;
                    DGWClient.DataMember = "CLIENT";
                }
                else 
                {
                    LoadDGW();
                }
                

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Insert New Client into dgw
        private void btnInsert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();



                string sql = @"INSERT INTO CLIENT(First_Name, Last_Name, Phone_No) VALUES(@name,@surname,@num)";

                com = new SqlCommand(sql, con);

               
                com.Parameters.AddWithValue("@name", txtClientName.Text);
                com.Parameters.AddWithValue("@surname", txtClientSurname.Text);
                com.Parameters.AddWithValue("@num", txtNumber.Text);
                com.ExecuteNonQuery();


                //Dispaly message 
                MessageBox.Show("Client Inserted");

                LoadDGW();

                con.Close();

                cbID.Items.Clear();
                cbSelect.Items.Clear();
                Populate();
               
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //delete Client from dgw
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();

                string sql = "Delete FROM CLIENT WHERE Client_ID = @id";

                com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", cbID.SelectedItem);
                com.ExecuteNonQuery();


                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql2 = @"SELECT * FROM CLIENT";

                com = new SqlCommand(sql2, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "CLIENT");


                DGWClient.DataSource = dSet;
                DGWClient.DataMember = "CLIENT";

                //Display message
                MessageBox.Show("Client Deleted ");

                LoadDGW();

                con.Close();

                cbID.Items.Clear();
                cbSelect.Items.Clear();
                Populate();



            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

       
        //Open Acces Form 
        private void button2_Click(object sender, EventArgs e)
        {
            AccessForm f1 = new AccessForm();
            f1.ShowDialog();
            this.Close();

        }

        //Open Order Form 
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OrderForm f1 = new OrderForm();
            f1.ShowDialog();

         
        }

        //Set varaible to instance in combobox
        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectClient = (int)(cbSelect.SelectedItem);
        }

        //Update Client in dgw
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {

                con.Open();


                string sql = @"UPDATE CLIENT set First_Name = @name,Last_Name = @surname,Phone_No = @num  WHERE Client_ID = @cId";

                com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", txtClientName.Text);
                com.Parameters.AddWithValue("@surname", txtClientSurname.Text); 
                com.Parameters.AddWithValue("@num", txtNumber.Text);
                com.Parameters.AddWithValue("@cId", txtClientId.Text);


                com.ExecuteNonQuery();


                //Display message
                MessageBox.Show("Client Updated");

                LoadDGW();

                con.Close();

                cbID.Items.Clear();
                cbSelect.Items.Clear();
                Populate();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Load Load form 
        private void ClientForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            Populate();
            LoadDGW();

        }
    }
}
