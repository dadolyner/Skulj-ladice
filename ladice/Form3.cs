using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace ladice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            checkpassword.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text.Contains("SELECT") || nametextBox.Text.Contains("UPDATE") || nametextBox.Text.Contains("DELETE") || nametextBox.Text.Contains("INSERT"))
            {
                nametextBox.Text = "";
                usertextBox.Text = "";
                password.Text = "";
                checkpassword.Text = "";
                MessageBox.Show("Opale");
            }

            else
            {

                if (nametextBox.Text == "" || usertextBox.Text == "" || password.Text == "" || checkpassword.Text == "")
                {
                    MessageBox.Show("Nobeno polje ne sme biti prazno!");
                }

                if (password.Text != checkpassword.Text)
                {
                    if (checkpassword.Text != "")
                    {
                        MessageBox.Show("Gesli se ne ujemata!");
                    }
                }
                else
                {
                    using (SQLiteConnection connect = new SQLiteConnection("data source=prijava.db"))
                    {
                        connect.Open();
                        using (SQLiteCommand com = new SQLiteCommand(connect))
                        {
                            com.CommandText = "INSERT INTO uporabniki (ime, user, password) VALUES('" + nametextBox.Text + "' , '" + usertextBox.Text + "' , '" + password.Text + "')";
                            com.ExecuteNonQuery();
                            com.Dispose();
                        }
                        connect.Close();
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            /*
            try
            {
                string myconnection = "datasource=den1.mysql3.gear.host;port=3306;username=uporabniki;password=-techdeck12345;";
                MySqlConnection connect = new MySqlConnection(myconnection);
                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = new MySqlCommand("SELECT * uporabniki.accounts;", connect);
                connect.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connected");
                connect.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex);
            }
            */
        }
    }
}
