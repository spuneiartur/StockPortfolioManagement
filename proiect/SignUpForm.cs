using proiect.Entities;
using System;
using System.Linq;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proiect
{
    public partial class SignUpForm : Form
    {
        public Client client { get; private set; }
        public SignUpForm()
        {
            InitializeComponent();
            //emailTextbox.TextChanged += textBoxEmail_Validating;
            phoneTextbox.KeyPress += phoneTextbox_KeyPress;
            saveBtn.Click += saveBtn_Click;
            firstNameTextbox.KeyPress += firstLastName_KeyPress;
            lastNameTextbox.KeyPress += firstLastName_KeyPress;
        }

        public Client Client { get { return client; } }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void phoneTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void firstLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        //private void textBoxEmail_Validating(object sender, EventArgs e)
        //{
        //    string email = emailTextbox.Text;

        //    // Regular expression pattern for email validation
        //    string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

        //    if (!Regex.IsMatch(email, emailPattern))
        //    {

        //        emailErrorProvider.SetError(emailTextbox, "Invalid email address"); // Display error message
        //    }
        //    else
        //    {
        //        emailErrorProvider.SetError(emailTextbox, ""); // Clear error message
        //    }
        //}

        private bool phoneValidation()
        {
            string phone = phoneTextbox.Text.Trim();

            if (phone.Length != 10 || phone[0] != '0' || phone[1] != '7')
            {
                phoneErrorProvider.SetError(phoneTextbox, "Invalid phone number"); // Display error message
                return false;
            }
            else
            {

                phoneErrorProvider.SetError(phoneTextbox, ""); // Clear error message
                return true;
            }
        }

        private bool emailValidation()
        {
            string email = emailTextbox.Text;

            // Regular expression pattern for email validation
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            if (!Regex.IsMatch(email, emailPattern))
            {

                emailErrorProvider.SetError(emailTextbox, "Invalid email address"); // Display error message
                return false;
            }
            else
            {
                emailErrorProvider.SetError(emailTextbox, ""); // Clear error message
                return true;
            }
        }

        private bool passwordValidation()
        {
            string password = passwordTextbox.Text;

            // Perform password validation checks
            if (string.IsNullOrWhiteSpace(password))
            {

                passwordTextbox.SelectAll(); // Select the invalid text for easy correction
                passwordErrorProvider.SetError(passwordTextbox, "Password is required"); // Display error message
                return false;
            }
            else if (password.Length < 8)
            {

                passwordTextbox.SelectAll(); // Select the invalid text for easy correction
                passwordErrorProvider.SetError(passwordTextbox, "Password must be at least 8 characters long"); // Display error message
                return false;
            }
            else if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                passwordTextbox.SelectAll(); // Select the invalid text for easy correction
                passwordErrorProvider.SetError(passwordTextbox, "Password must contain at least one uppercase and one lowercase character"); // Display error message
                
                return false;
            }else if (!password.Any(char.IsDigit))
            {
                passwordTextbox.SelectAll(); // Select the invalid text for easy correction
                passwordErrorProvider.SetError(passwordTextbox, "Password must contain at least one digit");
                return false;
            }
            else if (!password.Any(IsSpecialCharacter))
            {
                passwordTextbox.SelectAll(); // Select the invalid text for easy correction
                passwordErrorProvider.SetError(passwordTextbox, "Password must contain at least one special character: !@#$%^&*()_+{}[]|\\;:'\\\",.<>/?");
                return false; 
            }
            else
            {
                passwordErrorProvider.SetError(passwordTextbox, ""); // Clear error message
                // Check the password confirmation
                string passwordConfirmation = confirmPasswordTextbox.Text;
                if (string.IsNullOrWhiteSpace(passwordConfirmation))
                {

                    confirmPasswordTextbox.SelectAll(); // Select the invalid text for easy correction
                    confirmPasswordErrorProvider.SetError(confirmPasswordTextbox, "Confirmation password is required"); // Display error message
                    return false;
                }
                else if (passwordConfirmation.Length < 6)
                {

                    confirmPasswordTextbox.SelectAll(); // Select the invalid text for easy correction
                    confirmPasswordErrorProvider.SetError(confirmPasswordTextbox, "Password must be at least 6 characters long"); // Display error message
                    return false;
                }
                else if (string.Compare(passwordConfirmation, password) != 0)
                {
                    confirmPasswordTextbox.SelectAll(); // Select the invalid text for easy correction
                    confirmPasswordErrorProvider.SetError(confirmPasswordTextbox, "Passwords do not match"); // Display error message
                    return false;
                }
                else
                {
                    confirmPasswordErrorProvider.SetError(confirmPasswordTextbox, ""); // Clear error message
                }

                return true;
            }

        }

        private bool IsSpecialCharacter(char c)
        {
            // Define the set of special characters you consider acceptable
            string specialCharacters = "!@#$%^&*()_+{}[]|\\;:'\",.<>/?";

            return specialCharacters.Contains(c);
        }

        private bool loginValidation()
        {

            string username = loginTextbox.Text;

            // Perform username validation checks
            if (string.IsNullOrWhiteSpace(username))
            {

                loginTextbox.SelectAll(); // Select the invalid text for easy correction
                loginErrorProvider.SetError(loginTextbox, "Username is required"); // Display error message
                return false;
            }
            else
            {
                loginErrorProvider.SetError(loginTextbox, ""); // Clear error message
                return true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNameTextbox.Text) && !string.IsNullOrEmpty(lastNameTextbox.Text) && !string.IsNullOrEmpty(emailTextbox.Text) && !string.IsNullOrEmpty(phoneTextbox.Text) && !string.IsNullOrEmpty(loginTextbox.Text) && !string.IsNullOrEmpty(passwordTextbox.Text) && !string.IsNullOrEmpty(confirmPasswordTextbox.Text))
            {
                if (!emailValidation())
                {
                    MessageBox.Show("Email address is incorrect", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!phoneValidation())
                {
                    MessageBox.Show("Phone number is incorrect", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!loginValidation())
                {
                    MessageBox.Show("Login is incorrect", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!passwordValidation())
                {
                    MessageBox.Show("Password is incorrect", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Checks if login is not used already;
                if (Client.usernameExists(loginTextbox.Text) != null)
                {
                    MessageBox.Show("Username already exists", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Client.phoneNumberExists(phoneTextbox.Text) != null)
                {
                    MessageBox.Show("Phone number already exists", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Client.emailExists(emailTextbox.Text) != null)
                {
                    MessageBox.Show("Email already exists", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



                // Code to execute if validation was passed with success
                string firstName = firstNameTextbox.Text;
                string lastName = lastNameTextbox.Text;
                string email = emailTextbox.Text;
                string phone = phoneTextbox.Text;
                string login = loginTextbox.Text;
                string password = passwordTextbox.Text;

                client = new Client(firstName, lastName, email, phone, login, password);
                DialogResult = DialogResult.OK;





            }
            else
            {
                // At least one text box is empty
                MessageBox.Show("Make sure you filled all input fields", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
