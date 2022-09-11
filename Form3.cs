using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Assignment
{
    public partial class OrderForm : Form
    {

        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Semester 2\CMPG 223\CMPG223_Assignment\CMPG223_Assignment\Books.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet dSet;
        SqlCommand com;
        SqlDataAdapter reader;
        public static int clientId;
        public static int bookId;
        public static int authorId;
        public static int genreId;

        public OrderForm()
        {
            InitializeComponent();
            clientId = ClientForm.selectClient;
            bookId = BookForm.selectBook;
            authorId = Author_Form.authorId;
            genreId = Genre_Form.genreId;
        }

        //Looad Listbox
        private void load()
        {
            lbOrder.Items.Clear();
            lbOrder.Items.Add("Order ID" +"\t"+" Client ID" + "\t"+ " Book ID" + "\t" + "  Date " + "\n");
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM ORDER";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "ORDER");


                SqlDataReader reader = com.ExecuteReader();

                //Includes OrderId, ClientId,BookId,date,Price 
                while (reader.Read())
                {
                    lbOrder.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\n\n");
                }

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Populate combobox from SQL Table
        private void Populate()
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();



                string sql = "SELECT Order_ID FROM ORDER";
                com = new SqlCommand(sql, con);
                SqlDataReader reader = com.ExecuteReader();


                while (reader.Read())
                {
                    cbOrder.Items.Add(reader.GetValue(0));
                }




                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
       

        private void OrderForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            Populate();
            load();

         
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
               
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "ORDER");

                //Still have to add BookForm info & ClientForm

                string sql = @"INSERT INTO ORDER(Client_ID,Book_ID,Order_Date) VALUES(@cId,@bId,@date)";

                com = new SqlCommand(sql, con);

                //com.Parameters.AddWithValue("@oid", txtOrderID.Text);
                com.Parameters.AddWithValue("@cId", ClientForm.selectClient); //from clientForm
                com.Parameters.AddWithValue("@bId", BookForm.selectBook) ; // from bookForm
                com.Parameters.AddWithValue("@date", txtDate.Text);
              

                com.ExecuteNonQuery();

                //message displayed
                MessageBox.Show("Order Placed");
                

                //Includes OrderId, ClientId,BookId,date,Price 
                load();


                con.Close();
                cbOrder.Items.Clear();
                Populate();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //Open client form 
        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm f1 = new ClientForm();
            f1.ShowDialog();
            this.Close();


        }

        //Open Book form 
        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm f1 = new BookForm();
            f1.ShowDialog();
            this.Close();

        }

        
       

        //Update Order in Listbox
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                BookForm f1 = new BookForm();
                ClientForm c1 = new ClientForm();
              

                con.Open();



                string sql = @"UPDATE ORDER set Client_ID = @cId, Book_ID= @bId, Order_Date = @date WHERE Order_ID = @oId";

                com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@oid", txtOrderID.Text);
                com.Parameters.AddWithValue("@cId", clientId); //from clientForm
                com.Parameters.AddWithValue("@bId", bookId); // from bookForm
                com.Parameters.AddWithValue("@date", txtDate.Text);
                

                com.ExecuteNonQuery();


                //message displayed 
                MessageBox.Show("Order Updated");
                load();

                con.Close();

                cbOrder.Items.Clear();
                Populate();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //delete order from listBox
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();


                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = "Delete FROM ORDER WHERE Order_ID = @id";

                com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", cbOrder.SelectedItem);
                com.ExecuteNonQuery();


                string sql2 = @"SELECT * FROM ORDER";

                com = new SqlCommand(sql2, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "ORDER");

                SqlDataReader reader = com.ExecuteReader();

                lbOrder.Items.Clear();


                //Includes OrderId, ClientId,BookId,date,Price 
                while (reader.Read())
                {
                    lbOrder.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\n");
                }


                //Display Message 
                MessageBox.Show("Order Removed ");
                load();

                con.Close();
                cbOrder.Items.Clear();
                Populate();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
          


        }

        //Open access Form 
        private void btnBack_Click(object sender, EventArgs e)
        {
            AccessForm f1 = new AccessForm();
            f1.Show();
        }
    }
}
