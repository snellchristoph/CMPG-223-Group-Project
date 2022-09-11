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
    public partial class BookForm : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Semester 2\CMPG 223\CMPG223_Assignment\CMPG223_Assignment\Books.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet dSet;
        SqlCommand com;
        SqlDataAdapter reader;

        public static int selectBook;
        public static int GenreId;

        public BookForm()
        {

            InitializeComponent();
            GenreId = Genre_Form.genreId;

        }


        //Load datagrid view 
        public void LoadDGW()
        {
            try
            {
                con = new SqlConnection(conString);

                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM BOOK";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "BOOK");


                DGWBook.DataSource = dSet;
                DGWBook.DataMember = "BOOK";

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Populate comboBox from Sql Table
        private void Populate()
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();



                string sql = "SELECT Book_ID FROM BOOK";
                com = new SqlCommand(sql, con);
                SqlDataReader reader = com.ExecuteReader();


                while (reader.Read())
                {
                    cbBookId.Items.Add(reader.GetValue(0));
                    cbSelect.Items.Add(reader.GetValue(0));
                }




                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //Load form for Books 
        private void BookForm_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            Populate();
            try
            {

                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM BOOK";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "BOOK");


                DGWBook.DataSource = dSet;
                DGWBook.DataMember = "BOOK";

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //Search Book via Id
        private void txtSearchBookID_TextChanged(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM BOOK WHERE Book_ID LIKE '%" + txtSearchBookID.Text + "%'";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "BOOK");



                DGWBook.DataSource = dSet;
                DGWBook.DataMember = "BOOK";

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Search book via title
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM BOOK WHERE Book_Title  LIKE '%" + txtSearch.Text + "%'";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "BOOK");

                DGWBook.DataSource = dSet;
                DGWBook.DataMember = "BOOK";

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //remove Book from dgw
        private void btnRemove_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {
                con.Open();

                string sql = "DELETE FROM BOOK WHERE Book_ID = @id";

                com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", cbBookId.SelectedItem);
                com.ExecuteNonQuery();


                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql2 = @"SELECT * FROM BOOK";

                com = new SqlCommand(sql2, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "BOOK");


                DGWBook.DataSource = dSet;
                DGWBook.DataMember = "BOOK";

                LoadDGW();

                //message Displayed
                MessageBox.Show("Book Removed ");

                con.Close();
                cbBookId.Items.Clear();
                cbSelect.Items.Clear();
                Populate();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Inserrt a new Book into dgw
        private void btnInsertBook_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {
                con.Open();



                string sql = @"INSERT INTO BOOK(Genre_ID,Book_Title,Book_Price) VALUES(@genre,@title,@price)";

                com = new SqlCommand(sql, con);



                com.Parameters.AddWithValue("@genre", GenreId);
                com.Parameters.AddWithValue("@title", txtEnterBookTitle.Text);
                com.Parameters.AddWithValue("@price", txtPrice.Text);
                com.ExecuteNonQuery();


                //Message Displayed
                MessageBox.Show("Book Inserted");
                LoadDGW();

                con.Close();
                cbBookId.Items.Clear();
                cbSelect.Items.Clear();
                Populate();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void sbPrice_Scroll(object sender, ScrollEventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {
                con = new SqlConnection(conString);

                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();
                string sql = "SELECT * FROM BOOK WHERE Book_Price <=" + sbPrice.Value;
                com = new SqlCommand(sql, con);

                lblPrice.Text = sbPrice.Value.ToString();

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "BOOK");

                DGWBook.DataSource = dSet;
                DGWBook.DataMember = "BOOK";

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

       

        //Update a Book in dgw
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {

                con.Open();



                string sql = @"UPDATE BOOK set Genre_ID = @genre, Book_Title = @title, Book_Price = @price   WHERE Book_ID = @id";

                com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@id", txtEnterBookId.Text);
                com.Parameters.AddWithValue("@title", txtEnterBookTitle.Text);
                com.Parameters.AddWithValue("@genre", GenreId);
                com.Parameters.AddWithValue("@price", txtPrice.Text);

                com.ExecuteNonQuery();


                //Display Message 
                MessageBox.Show("Book Updated");

                LoadDGW();

                con.Close();
                cbBookId.Items.Clear();
                cbSelect.Items.Clear();
                Populate();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        
        
        //Set instance variable to combobox selected item 
        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectBook = (int)(cbSelect.SelectedItem);
        }

        //Open genre form 
        private void btnGenre_Click(object sender, EventArgs e)
        {
            Genre_Form g1 = new Genre_Form();
            g1.Show();
        }

        //Open Acces Form 
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AccessForm f1 = new AccessForm();
            f1.ShowDialog();
            
        }

        //Open Order Form 
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OrderForm o1 = new OrderForm();
            o1.ShowDialog();
        }
    }  
}
