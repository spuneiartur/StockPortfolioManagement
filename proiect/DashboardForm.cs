using proiect.Entities;
using System;
using System.Data.SQLite;
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
                int clientId = client.getId();
                return new Portfolio(porfolioId, clientId);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return createPortfolio(connection); ;

            }


        }

        private void insertStockToDB(Stock stock, Portfolio portfolio, SQLiteConnection connection)
        {
            try
            {
                string query = "INSERT INTO STOCKS(stockId, name, quantity, price, portfolioId) VALUES (@value1, @value2, @value3, @value4, @value5)";
                SQLiteCommand insertCommand = new SQLiteCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@value1", stock.getId());
                insertCommand.Parameters.AddWithValue("@value2", stock.name);
                insertCommand.Parameters.AddWithValue("@value3", stock.quantity);
                insertCommand.Parameters.AddWithValue("@value4", stock.price);
                insertCommand.Parameters.AddWithValue("@value5", portfolio.getId());
                if (insertCommand.ExecuteNonQuery() != 0)
                    Console.WriteLine("Stock was inserted to DB");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw ex;
            }


        }

        public int getPortfolioIdFromDB()
        {
            try
            {
                int maxId;
                string query;
                // Get the last id issued from DB
                query = "SELECT MAX(portfolioId) FROM portfolios";
                SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                reader.Read();
                maxId = reader.GetInt32(0);
                return maxId + 1;
            }
            catch (Exception ex)
            {
                return 1;
            }

        }

        public Portfolio createPortfolio(SQLiteConnection connection)
        {

            try
            {
                portfolio = new Portfolio(getPortfolioIdFromDB(), client.getId());

                // Inserting new Portfolio to DB
                string query = "INSERT INTO Portfolios(portfolioId, clientId) VALUES(@value1, @value2)";
                SQLiteCommand insertCommand = new SQLiteCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@value1", portfolio.getId());
                insertCommand.Parameters.AddWithValue("@value2", client.getId());
                insertCommand.ExecuteNonQuery();
                return portfolio;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
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
            StockAddForm stockAddForm = new StockAddForm(connection);
            if (stockAddForm.ShowDialog() == DialogResult.OK)
            {
                Stock stock = stockAddForm.stock;
                insertStockToDB(stock, this.portfolio, this.connection);


            }

        }



        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
}
}
