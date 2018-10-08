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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Player ONE, please set your SHIPS";
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox2.Enabled = false;
            resetButton.Visible = false;
            submitbutton.Visible = false;

            groupBox1.Text = Form2.user1;
            groupBox2.Text = Form2.user2;
        }

        public int a = 1;
        public int b = 1;
        public int c = 1;
        public int d = 1;
        public int stzmag;
        public int win = 1;

        //Streljanje ladijc NA LEVI STRANI
        private void button1_Click(object sender, EventArgs e)
        {


            if (label10.Text == "X")
            {
                textBox1.Text = "BOOM!";
                label10.Visible = true;
                button1.BackColor = Color.Gray;
                button1.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }

                else
                {
                    c++;
                }

            }
            else
            {
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
                label10.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label11.Text == "X")
            {
                label11.Visible = true;
                textBox1.Text = "BOOM!";
                button2.BackColor = Color.Gray;
                button2.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    c++;
                }

            }
            else
            {
                button2.Enabled = false;
                button2.BackColor = Color.Gray;
                label11.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label12.Text == "X")
            {
                label12.Visible = true;
                textBox1.Text = "BOOM!";
                button3.BackColor = Color.Gray;
                button3.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    c++;
                }

            }
            else
            {
                button3.Enabled = false;
                button3.BackColor = Color.Gray;
                label12.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label13.Text == "X")
            {
                label13.Visible = true;
                textBox1.Text = "BOOM!";
                button4.BackColor = Color.Gray;
                button4.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    c++;
                }

            }
            else
            {
                button4.Enabled = false;
                label13.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label14.Text == "X")
            {
                label14.Visible = true;
                textBox1.Text = "BOOM!";
                button5.BackColor = Color.Gray;
                button5.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    c++;
                }

            }
            else
            {
                button5.Enabled = false;
                button5.BackColor = Color.Gray;
                label14.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label15.Text == "X")
            {
                label15.Visible = true;
                textBox1.Text = "BOOM!";
                button6.BackColor = Color.Gray;
                button6.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    c++;
                }

            }
            else
            {
                button6.Enabled = false;
                button6.BackColor = Color.Gray;
                label15.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label16.Text == "X")
            {
                label16.Visible = true;
                textBox1.Text = "BOOM!";
                button7.BackColor = Color.Gray;
                button7.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }

                else
                {
                    c++;
                }

            }
            else
            {
                button7.Enabled = false;
                button7.BackColor = Color.Gray;
                label16.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label17.Text == "X")
            {
                label17.Visible = true;
                textBox1.Text = "BOOM!";
                button8.BackColor = Color.Gray;
                button8.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    c++;
                }

            }
            else
            {
                button8.Enabled = false;
                button8.BackColor = Color.Gray;
                label17.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label18.Text == "X")
            {
                label18.Visible = true;
                textBox1.Text = "BOOM!";
                button9.BackColor = Color.Gray;
                button9.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                if (c == 3)
                {
                    textBox1.Text = "Player ONE is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    c++;
                }

            }
            else
            {
                button9.Enabled = false;
                button9.BackColor = Color.Gray;
                label18.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }



        //Postavitev ladijc NA LEVI STRANI
        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label2.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label3.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label4.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label5.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label6.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label7.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label8.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label9.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label1.Text = "X";
                if (a == 3)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    textBox1.Text = "Player TWO, please set your SHIPS";
                }
                else
                {
                    a++;
                }
            }
        }





        //Streljanje ladijc na DESNI strani
        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                label1.Visible = true;
                textBox1.Text = "BOOM!";
                button10.BackColor = Color.Gray;
                button10.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;
                }
                else
                {
                    d++;
                }
            }

            else
            {
                button10.BackColor = Color.Gray;
                button10.Enabled = false;
                label1.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                label2.Visible = true;
                textBox1.Text = "BOOM!";
                button11.BackColor = Color.Gray;
                button11.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;
                }
                else
                {
                    d++;
                }
            }
            else
            {
                button11.BackColor = Color.Gray;
                button11.Enabled = false;
                label2.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label3.Text == "X")
            {
                label3.Visible = true;
                textBox1.Text = "BOOM!";
                button12.BackColor = Color.Gray;
                button12.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;

                }
                else
                {
                    d++;
                }
            }
            else
            {
                button12.BackColor = Color.Gray;
                button12.Enabled = false;
                label3.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                label4.Visible = true;
                textBox1.Text = "BOOM!";
                button13.BackColor = Color.Gray;
                button13.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;
                }
                else
                {
                    d++;
                }
            }
            else
            {
                button13.BackColor = Color.Gray;
                button13.Enabled = false;
                label4.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label5.Text == "X")
            {
                label5.Visible = true;
                textBox1.Text = "BOOM!";
                button14.BackColor = Color.Gray;
                button14.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;
                }
                else
                {
                    d++;
                }
            }
            else
            {
                button14.BackColor = Color.Gray;
                button14.Enabled = false;
                label5.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label6.Text == "X")
            {
                label6.Visible = true;
                textBox1.Text = "BOOM!";
                button15.BackColor = Color.Gray;
                button15.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                }
                else
                {
                    d++;
                }
            }
            else
            {
                button15.BackColor = Color.Gray;
                button15.Enabled = false;
                label6.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label7.Text == "X")
            {
                label7.Visible = true;
                textBox1.Text = "BOOM!";
                button16.BackColor = Color.Gray;
                button16.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;
                }
                else
                {
                    d++;
                }
            }
            else
            {
                button16.BackColor = Color.Gray;
                button16.Enabled = false;
                label7.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label8.Text == "X")
            {
                label8.Visible = true;
                textBox1.Text = "BOOM!";
                button17.BackColor = Color.Gray;
                button17.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;
                }
                else
                {
                    d++;
                }
            }
            else
            {
                button17.BackColor = Color.Gray;
                button17.Enabled = false;
                label8.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label9.Text == "X")
            {
                label9.Visible = true;
                textBox1.Text = "BOOM!";
                button18.BackColor = Color.Gray;
                button18.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;

                if (d == 3)
                {
                    textBox1.Text = "Player TWO is a WINNER!";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    submitbutton.Visible = true;
                    win = win + 1;
                }
                else
                {
                    d++;
                }
            }
            else
            {
                button18.BackColor = Color.Gray;
                button18.Enabled = false;
                label9.Visible = true;
                label9.Visible = false;
                textBox1.Text = "You missed the ship!";
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }



        //Postavljanje ladijc na DESNI strani
        private void label10_Click(object sender, EventArgs e)
        {
            if (label10.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label10.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (label11.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label11.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (label12.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label12.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (label13.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label13.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (label14.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label14.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (label15.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label15.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (label16.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label16.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (label17.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label17.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (label18.Text == "X")
            {
                textBox1.Text = "This ship is already selected!";
            }
            else
            {

                label18.Text = "X";
                if (b == 3)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                    textBox1.Text = "BATTLE!";
                }
                else
                {
                    b++;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            label1.Visible = true;
            label1.Text = " ";
            label2.Visible = true;
            label2.Text = " ";
            label3.Visible = true;
            label3.Text = " ";
            label4.Visible = true;
            label4.Text = " ";
            label5.Visible = true;
            label5.Text = " ";
            label6.Visible = true;
            label6.Text = " ";
            label7.Visible = true;
            label7.Text = " ";
            label8.Visible = true;
            label8.Text = " ";
            label9.Visible = true;
            label9.Text = " ";

            groupBox1.Enabled = true;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox2.Enabled = false;
            resetButton.Visible = false;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;


            //Desna stran
            button10.BackColor = Color.Gainsboro;
            button11.BackColor = Color.Gainsboro;
            button12.BackColor = Color.Gainsboro;
            button13.BackColor = Color.Gainsboro;
            button14.BackColor = Color.Gainsboro;
            button15.BackColor = Color.Gainsboro;
            button16.BackColor = Color.Gainsboro;
            button17.BackColor = Color.Gainsboro;
            button18.BackColor = Color.Gainsboro;

            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;

            label10.Visible = true;
            label10.Text = " ";
            label11.Visible = true;
            label11.Text = " ";
            label12.Visible = true;
            label12.Text = " ";
            label13.Visible = true;
            label13.Text = " ";
            label14.Visible = true;
            label14.Text = " ";
            label15.Visible = true;
            label15.Text = " ";
            label16.Visible = true;
            label16.Text = " ";
            label17.Visible = true;
            label17.Text = " ";
            label18.Visible = true;
            label18.Text = " ";

            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;

            a = 1;
            b = 1;
            c = 1;
            d = 1;
            win = 1;

            textBox1.Text = "Player ONE, please set your SHIPS";

            submitbutton.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            submitbutton.Visible = false;
            resetButton.Visible = true;



            if (win == 1)
            {
                using (SQLiteConnection connect = new SQLiteConnection("data source=prijava.db"))
                {
                    connect.Open();
                    using (SQLiteCommand com = new SQLiteCommand(connect))
                    {
                        com.CommandText = "SELECT zmage FROM uporabniki WHERE ime='" + Form2.user1 + "';";
                        SQLiteDataReader reader = com.ExecuteReader();

                        while (reader.Read())
                        {
                            stzmag = reader.GetInt32(0);
                            stzmag++;
                        }
                        com.Dispose();
                    }
                    connect.Close();
                }

                using (SQLiteConnection connect1 = new SQLiteConnection("data source=prijava.db"))
                {
                    connect1.Open();
                    using (SQLiteCommand com = new SQLiteCommand(connect1))
                    {
                        com.CommandText = "UPDATE uporabniki SET zmage = " +stzmag+ " WHERE ime='" + Form2.user1 + "';";
                        com.ExecuteNonQuery();
                        com.Dispose();
                    }
                    connect1.Close();
                }                
            }

            else
            {
                using (SQLiteConnection connect = new SQLiteConnection("data source=prijava.db"))
                {
                    connect.Open();
                    using (SQLiteCommand com = new SQLiteCommand(connect))
                    {
                        com.CommandText = "SELECT zmage FROM uporabniki WHERE ime='" + Form2.user2 + "';";
                        SQLiteDataReader reader = com.ExecuteReader();

                        while (reader.Read())
                        {
                            stzmag = reader.GetInt32(0);
                            stzmag++;
                        }
                        com.Dispose();
                    }
                    connect.Close();
                }


                    using (SQLiteConnection connect1 = new SQLiteConnection("data source=prijava.db"))
                    {
                        connect1.Open();
                        using (SQLiteCommand com = new SQLiteCommand(connect1))
                        {
                            com.CommandText = "UPDATE uporabniki SET zmage = " +stzmag+ " WHERE ime='" + Form2.user2 + "';";
                            com.ExecuteNonQuery();
                            com.Dispose();
                        }
                        connect1.Close();
                    }
                }
            }
        }
    }
