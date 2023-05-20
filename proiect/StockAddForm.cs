using proiect.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class StockAddForm : Form
    {
        public Stock stock { get; private set; }    
        public StockAddForm()
        {
            InitializeComponent();
            addBtn.Click += addBtn_Click;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(stockNameTextbox.Text) && priceNumericUpDown.Value != 0 && quantityNumericUpDown.Value != 0)
            {
                stock = new Stock(stockNameTextbox.Text, priceNumericUpDown.Value, quantityNumericUpDown.Value);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Make sure you filled all input fields", "Add Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void StockAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
