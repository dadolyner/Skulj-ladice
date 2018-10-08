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
}
