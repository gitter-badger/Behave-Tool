using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MassRepo
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        const string myConnectionString = "Server=massrepo.com;Database=massrepo;Uid=massrepo_client;Pwd=Ksia29@#sis!2";

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            bool usernameExists = false;
            bool emailExists = false;
            using (var connection = new MySqlConnection(myConnectionString))
            using (MySqlCommand command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    return;
                }
                else
                {
                    using (MySqlDataReader sqlDataReader = new MySqlCommand("SELECT id FROM users WHERE username='" + Username.Text + "'", connection).ExecuteReader())
                    {
                        try
                        {
                            while (sqlDataReader.Read())
                            {

                                if (sqlDataReader.HasRows)
                                {
                                    usernameExists = true;
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    using (MySqlDataReader sqlDataReader = new MySqlCommand("SELECT id FROM users WHERE email='" + Email.Text + "'", connection).ExecuteReader())
                    {
                        try
                        {
                            while (sqlDataReader.Read())
                            {

                                if (sqlDataReader.HasRows)
                                {
                                    emailExists = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                if (usernameExists == false && emailExists == false)
                {
                    addAccount();
                    Close();
                }
                else if (usernameExists == true && emailExists == false)
                {
                    MessageBox.Show("Username: " + Username.Text + " already exists");
                }
                else if (usernameExists == false && emailExists == true)
                {
                    MessageBox.Show("Email: " + Email.Text + " already exists");
                }
                else if (usernameExists == true && emailExists == true)
                {
                    MessageBox.Show("Both Username: " + Username.Text + " and Email: " + Email.Text + " already exists");
                }

            }

        }
        private void addAccount()
        {
            string ip = Tools.Network.IPinfo.getPublicIP();
            string Query = "INSERT into users(username,password,email,firstname,lastname,lastIP) values('" + Username.Text + "','" + encrypt(Password.Text) + "','" + Email.Text + "','" + Firstname.Text + "','" + Lastname.Text +"','" + ip + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string. 
            try
            {
                using (MySqlConnection MyConn2 = new MySqlConnection(myConnectionString))
                {
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    
                    //while (MyReader2.Read())
                    //{
                    //}
                    MyConn2.Close();
                }
                MessageBox.Show("Account Created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string encrypt(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getServerStatus)) { IsBackground = true }.Start();
        }
        private void getServerStatus()
        {
            toolStrip1.Renderer = new MySR();
        }
    }
}
