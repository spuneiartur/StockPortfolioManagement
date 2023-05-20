using proiect.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proiect
{
    public partial class DashboardForm : Form
    {
        public Portfolio portfolio { get; set; }
        public Client client { get; private set; }  
        public SQLiteConnection connection { get; private set; }
        public DashboardForm(Client client, SQLiteConnection connection)
        {
            InitializeComponent();
            fullNameLabel.Text = client.firstName + " " + client.lastName;  
            emailLabel.Text = client.email; 
            phoneNumberLabel.Text = client.phoneNumber;
            this.client = client;
            this.connection = connection;
            this.portfolio = retrievePorfolioFromDB(this.connection);

        }

        private Portfolio retrievePorfolioFromDB(SQLiteConnection connection)
        {
            try
            {
                string query = "SELECT portfolioId FROM Portfolios WHERE clientId = @value1";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                selectCommand.Parameters.AddWithValue("@value1", client.getId());
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                reader.Read();
                int porfolioId = reader.GetInt32(0);
                int clientId = reader.GetInt32(1);
                return new Portfolio(porfolioId, clientId); 
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
                
            }
            
            
        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addStockBtn_Click(object sender, EventArgs e)
        {
            StockAddForm stockAddForm = new StockAddForm();
            if(stockAddForm.ShowDialog() == DialogResult.OK)
            {
                Stock stock = stockAddForm.stock;
            }
           
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
