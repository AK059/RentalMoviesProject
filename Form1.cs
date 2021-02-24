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

namespace RentalMoviesProject
{
    public partial class Form1 : Form
    {
        Database Database = new Database();
        string WhichButtonClicked = "";
        string RMID = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomer(CustomerIDtxtbox.Text, FirstNtxtbox.Text, LastNtxtbox.Text, Phonetxtbox.Text, Addresstxtbox.Text);
            btnShowCustomer_Click(null, null);
        }

        private void btnShowMovies_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = Database.loadMovies();
            WhichButtonClicked = "Movies";
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = Database.ShowCustomers();
            WhichButtonClicked = "Customer";
        }

        private void btnShowRentedMovies_Click(object sender, EventArgs e)
        {
           dgvCustomer.DataSource = Database.loadRentedMovies();
            WhichButtonClicked = "Rental";
        }

        private void btnFamousMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.FamousMovie());
        }

        private void btnFamousCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.FamousCustomer());
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            
           Database.IssueMovie(Movietxtbox.Text, CustomerIDtxtbox.Text);
            btnShowRentedMovies_Click(null, null);
            
            
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {

          //  Database.ReturnMovie(RMID);
          //  btnShowRentedMovies_Click(null, null);

        }

       

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            
            Database.DeleteCustomer(Convert.ToInt32(CustomerIDtxtbox.Text));
            btnShowCustomer_Click(null, null);
        }

        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            Database.InsertMovies(Ranktxtbox.Text, Headlinetxtbox.Text,Yeartxtbox.Value.Date,Convert.ToDecimal( RentalChargetxtbox.Text), Copiestxtbox.Text,Plottxtbox.Text, Categorytextbox.Text);
            
            btnShowMovies_Click(null, null);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustomerIDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvCustomer.Rows[index];



            if (WhichButtonClicked == "Customer")
            {
                CustomerIDtxtbox.Text = row.Cells[0].Value.ToString();
                FirstNtxtbox.Text = row.Cells[1].Value.ToString();
                LastNtxtbox.Text = row.Cells[2].Value.ToString();
                Addresstxtbox.Text = row.Cells[3].Value.ToString();
                Phonetxtbox.Text = row.Cells[4].Value.ToString();
            }
            else if (WhichButtonClicked == "Movies")
            {
                Movietxtbox.Text = row.Cells[0].Value.ToString();
                Ranktxtbox.Text = row.Cells[1].Value.ToString();
                Headlinetxtbox.Text = row.Cells[2].Value.ToString();
                Yeartxtbox.Text = row.Cells[3].Value.ToString();
                RentalChargetxtbox.Text = row.Cells[4].Value.ToString();
                Copiestxtbox.Text = row.Cells[5].Value.ToString();
                Plottxtbox.Text = row.Cells[6].Value.ToString();
                Categorytextbox.Text = row.Cells[7].Value.ToString();
            }
            else if (WhichButtonClicked == "Rented")
            {
                RMID = row.Cells[0].Value.ToString();
                Console.WriteLine(RMID);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            Database.DeleteMovies(Convert.ToInt32(Movietxtbox.Text));
            btnShowMovies_Click(null, null);
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
           
        {
            Database.UpdateMovies(Movietxtbox.Text,Ranktxtbox.Text, Headlinetxtbox.Text, Yeartxtbox.Value.Date, Convert.ToDecimal(RentalChargetxtbox.Text),Copiestxtbox.Text, Plottxtbox.Text, Categorytextbox.Text);
            btnShowMovies_Click(null, null);
        }

        private void Yeartxtbox_ValueChanged(object sender, EventArgs e)
        {
            if(Yeartxtbox.Value.Date<= DateTime.Now.Date.AddYears(-5))
            {

                RentalChargetxtbox.Text = "2";

            }
            else
            {
                RentalChargetxtbox.Text = "5";
            }
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            Database.InsertCustomer(FirstNtxtbox.Text, LastNtxtbox.Text, Phonetxtbox.Text, Addresstxtbox.Text);
            btnShowCustomer_Click(null, null);
         
            return ;


        }
    }
    }

