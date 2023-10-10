using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Arvin_Transport_And_Trading.Forms
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ALDN4IT;Initial Catalog=ArvinTransportDB;Integrated Security=True;Pooling=False");

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            // TODO: This line of code loads data into the 'arvinTransportDBDataSet8.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter3.Fill(this.arvinTransportDBDataSet8.CustomerTbl);
            // TODO: This line of code loads data into the 'arvinTransportDBDataSet7.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter2.Fill(this.arvinTransportDBDataSet7.CustomerTbl);
            // TODO: This line of code loads data into the 'arvinTransportDBDataSet6.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter1.Fill(this.arvinTransportDBDataSet6.CustomerTbl);
            // TODO: This line of code loads data into the 'arvinTransportDBDataSet6.CustomerTbl' table. You can move, or remove it, as needed.
            //   this.customerTblTableAdapter1.Fill(this.arvinTransportDBDataSet6.CustomerTbl);
            // TODO: This line of code loads data into the 'arvinTransportDBDataSet5.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter.Fill(this.arvinTransportDBDataSet5.CustomerTbl);
            //LoadTheme();
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

        void ResetContorols()
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxPhone.Clear();
            txtimage.Clear();
        }


        private void populate()
        {
            conn.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVCustomer.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxName.Text == "" || textBoxAddress.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "INSERT INTO CustomerTbl VALUES(" + textBoxId.Text + ",'" + textBoxName.Text + "','" + textBoxAddress.Text + "','" + textBoxPhone.Text + "','" + Path.GetFileName(txtimage.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Sucessfully Added");
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

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxName.Text == "" || textBoxAddress.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "update CustomerTbl set Name='" + textBoxName.Text + "',CustAddress='" + textBoxAddress.Text + "', Phone ='" + textBoxPhone.Text + "' where Id=" + textBoxId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Sucessfully Updated");
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
            if (textBoxId.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "Delete from CustomerTbl where Id=" + textBoxId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CustomerTbl Sucessfully Deleted");
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
        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = DGVCustomer.Rows[indexRow];

            textBoxId.Text = row.Cells[0].Value.ToString();
            textBoxName.Text = row.Cells[1].Value.ToString();
            textBoxAddress.Text = row.Cells[2].Value.ToString();
            textBoxPhone.Text = row.Cells[3].Value.ToString();
            txtimage.Text = row.Cells[4].Value.ToString();

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //pictureBox p = sender as pictureBox;
            //if (p != null)
            //{
            //    op.Filter = "(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
            //    if (op.ShowDialog() == DialogResult.OK)
            //    {
            //        p.Image = Image.FromFile(op.FileName);
            //    }
            //}

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string imagPath = open.FileName;
                pictureBox.Image = new Bitmap(imagPath);
                txtimage.Text = imagPath;

                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string correctName = System.IO.Path.GetFileName(open.FileName);
                System.IO.File.Copy(open.FileName, path + "\\Photo\\" + correctName);
            }
        }

        private void DGVCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
