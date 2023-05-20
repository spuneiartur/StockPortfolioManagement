using proiect.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.CodeDom;

namespace proiect
{
    public partial class LoginForm : Form
    {

        private const string ConnectionString = "Data Source=../../../Database/SQLiteDatabase.db";
        public SQLiteConnection connection { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            try
            {
                // SQLite Database
                connection = new SQLiteConnection(ConnectionString);
                connection.Open();
                retrieveDataFromDB(connection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                throw ex;
            }
           

            // Styling
            SignUpBtn.FlatAppearance.BorderSize = 0;

            // Event handlers
            LogInBtn.Click += new EventHandler(btnLogIn_Click);
            SignUpBtn.Click += new EventHandler(btnSignUp_Click);
            this.FormClosed += MainForm_FormClosed;


        }

        private void retrieveDataFromDB(SQLiteConnection connection)
        {
            try {
                string query = "SELECT * FROM Clients order by clientId";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while(reader.Read()) {
                    Console.WriteLine();
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string email = reader.GetString(3);
                    string phone = reader.GetString(4);
                    string login = reader.GetString(5); 
                    string password = reader.GetString(6);
                    Client client = new Client(firstName, lastName, email, phone, login, password);
                }
                
                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void insertClientToDB(Client client)
        {
            try {
                string insertQuery = "INSERT INTO Clients (clientId, firstName, lastName, email, phone, login, password) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)";
                SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@Value1", client.getId());
                insertCommand.Parameters.AddWithValue("@Value2", client.firstName);
                insertCommand.Parameters.AddWithValue("@Value3", client.lastName);
                insertCommand.Parameters.AddWithValue("@Value4", client.email);
                insertCommand.Parameters.AddWithValue("@Value5", client.phoneNumber);
                insertCommand.Parameters.AddWithValue("@Value6", client.login);
                insertCommand.Parameters.AddWithValue("@Value7", client.password);
                Console.WriteLine($"Rows inserted: {insertCommand.ExecuteNonQuery()}");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Generate Sign in form
            SignUpForm signUpForm = new SignUpForm();
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                insertClientToDB(signUpForm.client);


            }
        }

            private void btnLogIn_Click(object sender, EventArgs e)
        {
            //DashboardForm dashboardForm = new DashboardForm(new Client("Spunei", "Artur", "spuneiartur21@stud.ase.ro", "0799443942", "spuneiartur", "Knoxer1403!"), connection);
            //dashboardForm.ShowDialog();
            if (!string.IsNullOrEmpty(loginTextbox.Text) && !string.IsNullOrEmpty(passwordTextbox.Text))
            {
                // Both text boxes have non-empty values
                Client client = Client.loginDataValidation(loginTextbox.Text, passwordTextbox.Text);
                if (client != null)
                {
                    // Generating the user form
                    Console.WriteLine($"{client.email} was logged in!");
                    DashboardForm dashboardForm = new DashboardForm(client, connection);
                    dashboardForm.ShowDialog();
                }
                else
                {

                    // Display an error message
                    MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //loginTextbox.Text = "";
                    passwordTextbox.Text = "";
                    return;
                }
            }
            else
            {
                // At least one text box is empty
                MessageBox.Show("Make sure you filled both input fields", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
