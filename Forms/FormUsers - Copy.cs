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
using System.Configuration;
using System.IO;


namespace Arvin_Transport_And_Trading.Forms
{
    public partial class FormUsers : Form
    {
        //SqlConnection conn;
        public FormUsers()
        {
            InitializeComponent();

            //string myConString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            //conn = new SqlConnection(myConString);

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ALDN4IT;Initial Catalog=ArvinTransportDB;Integrated Security=True;Pooling=False");
        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadTheme();
            populate();
        }
        private void populate()
        {
            conn.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewUser.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxName.Text == "" || textBoxID.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "INSERT INTO UserTbl VALUES(" + textBoxID.Text + ",'" + textBoxName.Text + "','" + textBoxPassWord.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Sucessfully Added");
                    conn.Close();
                    populate();
                }
                catch (Exception Myex)
                {

                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text=="")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "Delete from UserTbl where Id=" + textBoxID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Sucessfully Deleted");
                    conn.Close();
                    populate();
                }
                catch (Exception Myex)
                {

                    MessageBox.Show(Myex.Message);
                }
            }
        }

        DataTable table = new DataTable();
        int indexRow;

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dataGridViewUser.Rows[indexRow];

            textBoxID.Text = row.Cells[0].Value.ToString();
            textBoxName.Text = row.Cells[1].Value.ToString();
            textBoxPassWord.Text = row.Cells[2].Value.ToString();

            //textBoxID.Text = dataGridViewUser.SelectedRows[0].Cells[0].Value.ToString();
            //textBoxName.Text = dataGridViewUser.SelectedRows[0].Cells[1].Value.ToString();
            //textBoxPassWord.Text = dataGridViewUser.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxName.Text == "" || textBoxID.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "update UserTbl set Uname='" + textBoxName.Text + "', Upass='" + textBoxPassWord.Text + "' where Id=" + textBoxID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Sucessfully Updated");
                    conn.Close();
                    populate();
                }
                catch (Exception Myex)
                {

                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
