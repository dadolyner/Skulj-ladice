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

namespace ladice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox7.PasswordChar = '*';

        }

        public static string user1;
        public static string user2;
        public bool prijava1;
        public bool prijava2;

        //login player 1
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    using (SQLiteConnection connect = new SQLiteConnection("data source=prijava.db"))
                    {
                        connect.Open();
                        using (SQLiteCommand com = new SQLiteCommand(connect))
                        {
                            com.CommandText = "SELECT * FROM uporabniki WHERE user = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "';";
                            using (System.Data.SQLite.SQLiteDataReader reader = com.ExecuteReader())
                            {
                                user1 = textBox1.Text;

                                if (reader.HasRows)
                                {
                                    if (groupBox3.Enabled == false)
                                    {
                                        prijava1 = true;
                                    }
                                    else
                                    {
                                        groupBox1.Enabled = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("You are not registerd!");
                                }

                            }
                            com.Dispose();
                        }
                        connect.Close();
                    }

                    if(prijava1 == true)
                    {
                        this.Hide();
                        Form1 f2 = new Form1();
                        f2.ShowDialog();
                    }
                }
            }

            else
            {
                MessageBox.Show("Incorrect Login");
            }


        }

        //register
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();
            f1.ShowDialog();
        }

        //login player 2
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (textBox7.Text != "")
                {
                    using (SQLiteConnection connect = new SQLiteConnection("data source=prijava.db"))
                    {
                        connect.Open();
                        using (SQLiteCommand com = new SQLiteCommand(connect))
                        {
                            com.CommandText = "SELECT * FROM uporabniki WHERE user = '" + textBox6.Text + "' AND password = '" + textBox7.Text + "';";
                            using (System.Data.SQLite.SQLiteDataReader reader = com.ExecuteReader())
                            {
                                user2 = textBox6.Text;

                                if (reader.HasRows)
                                {
                                    if (groupBox1.Enabled == false)
                                    {
                                        prijava2 = true;
                                    }
                                    else
                                    {
                                        groupBox3.Enabled = false;
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("You are not registerd!");
                                }
                            }
                            com.Dispose();                     
                        }
                        connect.Close();
                    }

                    if (prijava2 == true)
                    {
                        this.Hide();
                        Form1 f2 = new Form1();
                        f2.ShowDialog();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
