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

namespace Emergency_Management_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("update_status", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar);
            id.Direction = ParameterDirection.Input;
            id.Value = comboBox3.Text;

            cmd.Parameters.Add(id);

            SqlParameter stat = new SqlParameter("@stat", SqlDbType.NVarChar);
            stat.Direction = ParameterDirection.Input;
            stat.Value = listBox1.GetItemText(listBox1.SelectedItem);

            cmd.Parameters.Add(stat);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            /*foreach (DataRow DR in dt.Rows)
            {
                textBox2.Text = (DR["Status"].ToString());
            }
            */
            cnn.Close();
        }

        private void Subunitate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Autospeciala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Echipaj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("select_subunit", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow DR in dt.Rows)
            {
                comboBox1.Items.Add(DR["Nume"].ToString());
            }

            cnn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("select_autospec", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter subunit = new SqlParameter("@subunit",SqlDbType.NVarChar);
            subunit.Direction = ParameterDirection.Input;
            subunit.Value = comboBox1.Text;

            cmd.Parameters.Add(subunit);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow DR in dt.Rows)
            {
                comboBox2.Items.Add(DR["Id"].ToString());
            }

            cnn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("select_ech", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar);
            id.Direction = ParameterDirection.Input;
            id.Value = comboBox2.Text;

            cmd.Parameters.Add(id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow DR in dt.Rows)
            {
                comboBox3.Items.Add(DR["Id"].ToString());
            }

            cnn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("get_tip", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar);
            id.Direction = ParameterDirection.Input;
            id.Value = comboBox2.Text;

            cmd.Parameters.Add(id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow DR in dt.Rows)
            {
                textBox1.Text = (DR["Tip"].ToString());
            }

            cnn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("get_status", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar);
            id.Direction = ParameterDirection.Input;
            id.Value = comboBox3.Text;

            cmd.Parameters.Add(id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow DR in dt.Rows)
            {
                textBox2.Text = (DR["Status"].ToString());
            }

            cnn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
