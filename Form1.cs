using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-BID4H6M\\SQLEXPRESS;Initial Catalog=LAB10;Integrated Security=True";
        SqlCommand cmd;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_record_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                cmd = new SqlCommand("insert into Table_1(Name,Address,CNIC,Class,Section,[Roll No],[D.O.B]) values(@Name,@Address,@CNIC,@Class,@Section,@RollNO,@DOB)", con);
                cmd.Parameters.AddWithValue("@Name", name_Box.Text);
                cmd.Parameters.AddWithValue("@Address", address_box.Text);
                cmd.Parameters.AddWithValue("@CNIC", cnic_Box.Text);
                cmd.Parameters.AddWithValue("@Class", class_Box.Text);
                cmd.Parameters.AddWithValue("@Section", Section_Box.Text);
                cmd.Parameters.AddWithValue("@RollNo", Roll_Box.Text);
                cmd.Parameters.AddWithValue("@DOB", dob_Box.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted");
            }
            con.Close();
        }

        private void Section_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Table_1 where cnic =" +cnic_Box.Text, con);
                adapter.Fill(dt);
                DGV.DataSource = dt;
                con.Close();

            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void search_part_Click(object sender, EventArgs e)
        {

        }

        private void update_record_Click(object sender, EventArgs e)
        {
            if(name_Box.Text!=" " && address_box.Text!=" " && cnic_Box.Text!=" " && class_Box.Text!=" " && Section_Box.Text!=" " && Roll_Box.Text!=" " && dob_Box.Text!=" ")
            {
                SqlConnection con = new SqlConnection(constring);
                cmd = new SqlCommand("update Table_1 set Name=@Name,Address=@Address, CNIC=@CNIC, Class=@Class, Section=@Section ,[Roll No]=@RollNo where [D.O.B]=@DOB", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Name", name_Box.Text);
                cmd.Parameters.AddWithValue("@Address", address_box.Text);
                cmd.Parameters.AddWithValue("@CNIC", cnic_Box.Text);
                cmd.Parameters.AddWithValue("@Class", class_Box.Text);
                cmd.Parameters.AddWithValue("@Section", Section_Box.Text);
                cmd.Parameters.AddWithValue("@RollNo", Roll_Box.Text);
                cmd.Parameters.AddWithValue("@DOB", dob_Box.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Upddate Successfully");
                con.Close();
            }
        }
    }
}