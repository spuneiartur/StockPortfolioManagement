using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Entities
{
    public class Client
    {
        private static int noOfClients = 0;
        private static Dictionary<string, Client> clientsByUsername = new Dictionary<string, Client>();
        private static Dictionary<string, Client> clientsByPhoneNumber = new Dictionary<string, Client>();
        private static Dictionary<string, Client> clientsByEmail = new Dictionary<string, Client>();

        private readonly int id;


        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string email { get; private set; }
        public string phoneNumber { get; private set; }
        public string login { get; private set; }
        public string password { get; private set; }


        public Client()
        {
            id = ++noOfClients;
        }

        public Client(string firstName, string lastName, string email, string phoneNumber, string login, string password)
        {
            id = ++noOfClients;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.login = login;
            this.password = password;
            this.phoneNumber = phoneNumber;

            clientsByUsername.Add(login, this);
            clientsByPhoneNumber.Add(phoneNumber, this);
            clientsByEmail.Add(email, this);    


        }

        public int getId()
        {
            return id;
        }

        // Methods --------------------------

       

        public static Client loginDataValidation(string loginPassed, string passwordPassed)
        {
            if (clientsByUsername.ContainsKey(loginPassed))
            {
                Client client = clientsByUsername[loginPassed];
                if (string.Equals(client.password, passwordPassed))
                {
                    return client;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }


        }

        public static Client usernameExists(string username)
        {
            if(clientsByUsername.ContainsKey(username)) { return clientsByUsername[username]; }
            else { return null; }
        }

        public static Client phoneNumberExists(string phoneNumber)
        {
            if(clientsByPhoneNumber.ContainsKey(phoneNumber)) { return clientsByPhoneNumber[phoneNumber]; }
            else{ return null; }
        }

        public static Client emailExists(string email)
        {
            if (clientsByEmail.ContainsKey(email)) { return clientsByEmail[email]; }
            else { return null; }
        }




    }
}
