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

namespace Arvin_Transport_And_Trading.Forms
{
    public partial class FormRental : Form
    {
        public FormRental()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ALDN4IT;Initial Catalog=ArvinTransportDB;Integrated Security=True;Pooling=False");

        private void fillcombo()
        {
            conn.Open();
            string query = "select  RegNum from CarTbl";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
            comboBoxCarReg.ValueMember = "RegNum";
            comboBoxCarReg.DataSource = dt;
            conn.Close();
        }
        private void fillCustomer()
        {
            conn.Open();
            string query = "select  Id from CustomerTbl";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Load(rdr);
            comboBoxCustId.ValueMember = "Id";
            comboBoxCustId.DataSource = dt;
            conn.Close();
        }

        private void FormRental_Load(object sender, EventArgs e)
        {
            LoadTheme();
            fillcombo();
            fillCustomer();
            populate();
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
        private void fetchCustName()
        {
            conn.Open();
            string query = "Select * from CustomerTbl where Id =" + comboBoxCustId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBoxCustName.Text = dr["Name"].ToString();
            }
            conn.Close();
        }

        private void populate()
        {
            conn.Open();
            string query = "select * from RentalTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void comboBoxCarReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxCustId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxCustName.Text == "" || textBoxFees.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "INSERT INTO RentalTbl VALUES(" + textBoxId.Text + ",'" + comboBoxCarReg.SelectedValue.ToString() + "','" + textBoxCustName.Text + "','" + DateTime.Parse(RentDate.Text) + "','" + DateTime.Parse(ReturnDate.Text) + "','" + textBoxFees.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Sucessfully Rented");
                    //ResetContorols();
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
