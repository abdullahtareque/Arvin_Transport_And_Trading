using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arvin_Transport_And_Trading.Forms
{
    public partial class FormCar : Form
    {
        public FormCar()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ALDN4IT;Initial Catalog=ArvinTransportDB;Integrated Security=True;Pooling=False");

        //private void FormUsers_Load(object sender, EventArgs e)
        //{
        //    LoadTheme();
        //    populate();
        //}

        private void populate()
        {
            conn.Open();
            string query = "select * from CarTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVCars.DataSource = ds.Tables[0];
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


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textBoxRegNo.Text == "" || textBoxBrand.Text == "" || textBoxModel.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "INSERT INTO CarTbl VALUES(" + textBoxRegNo.Text + ",'" + textBoxBrand.Text + "','" + textBoxModel.Text + "','" + textBoxPrice.Text + "','" + comboBoxAvailable.SelectedItem.ToString() + "' )";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Sucessfully Added");
                    ResetContorols();
                    conn.Close();
                    populate();
                }
                catch (Exception Myex)
                {

                    MessageBox.Show(Myex.Message);
                }
            }
            
        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arvinTransportDBDataSet4.CarTbl' table. You can move, or remove it, as needed.
            this.carTblTableAdapter1.Fill(this.arvinTransportDBDataSet4.CarTbl);
            populate();
            LoadTheme();

            // TODO: This line of code loads data into the 'arvinTransportDBDataSet3.CarTbl' table. You can move, or remove it, as needed.
            // this.carTblTableAdapter.Fill(this.arvinTransportDBDataSet3.CarTbl);

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (textBoxRegNo.Text == "" || textBoxBrand.Text == "" || textBoxModel.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "update CarTbl set Brand='" + textBoxBrand.Text + "',Model='" + textBoxModel.Text + "', Available ='"+ comboBoxAvailable.SelectedItem.ToString()+"',Price="+textBoxPrice.Text+" where RegNum='" + textBoxRegNo.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Sucessfully Updated");
                    ResetContorols();
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
            if (textBoxRegNo.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "Delete from CarTbl where RegNum=" + textBoxRegNo.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Sucessfully Deleted");
                    ResetContorols();
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
        private void DGVCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = DGVCars.Rows[indexRow];

            textBoxRegNo.Text = row.Cells[1].Value.ToString();
            textBoxBrand.Text = row.Cells[2].Value.ToString();
            textBoxModel.Text = row.Cells[3].Value.ToString();
            textBoxPrice.Text = row.Cells[4].Value.ToString();
            comboBoxAvailable.SelectedItem = row.Cells[5].Value.ToString();
            
        }


        void ResetContorols()
        {
            textBoxRegNo.Clear();
            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxPrice.Clear();
            // comboBoxAvailable.SelectedItem.Clear();
        }
    }
}
