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
    public partial class Form2 : Form
    {
        public Form2()
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
            SqlCommand cmd = new SqlCommand("Echipaj_ineff", cnn);
            cmd.CommandType = CommandType.StoredProcedure;



            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow DR in dt.Rows)
            {
                ListViewItem item = new ListViewItem(DR["Id"].ToString());
                item.SubItems.Add(DR["Autospeciala_dedicata"].ToString());
                item.SubItems.Add(DR["Status"].ToString());
                item.SubItems.Add(DR["Cazuri_pierdute"].ToString());

                listView1.Items.Add(item);

            }




            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\george.caloian\\Desktop\\MyApp\\Emergency_Management_App\\Emergency_Management_App\\DataBase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("Membrii_inef", cnn);
            cmd.CommandType = CommandType.StoredProcedure;



            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow DR in dt.Rows)
            {
                ListViewItem item = new ListViewItem(DR["Id"].ToString());
                item.SubItems.Add(DR["Echipaj"].ToString());
                item.SubItems.Add(DR["Post"].ToString());

                listView2.Items.Add(item);

            }




            cnn.Close();
        }
    }
}
