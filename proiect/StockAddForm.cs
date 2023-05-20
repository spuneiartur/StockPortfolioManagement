using proiect.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class StockAddForm : Form
    {
        public Stock stock { get; private set; }    

        public SQLiteConnection connection { get; private set; }
        public StockAddForm(SQLiteConnection connection)
        {
            InitializeComponent();
            addBtn.Click += addBtn_Click;
            this.connection = connection;
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(stockNameTextbox.Text) && priceNumericUpDown.Value != 0 && quantityNumericUpDown.Value != 0)
            {
                stock = new Stock(getStockIdFromDB(), stockNameTextbox.Text, priceNumericUpDown.Value, quantityNumericUpDown.Value);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Make sure you filled all input fields", "Add Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private int getStockIdFromDB()
        {
            try
            {
                int maxId;
                string query;
                // Get the last id issued from DB
                query = "SELECT MAX(stockId) FROM Stocks";
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

        private void StockAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
