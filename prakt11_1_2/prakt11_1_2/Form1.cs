using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt11_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Customer
        {
            private string name;
            private string lastName;
            private string midle;
            private string address;
            private int numberCards;
            private int numberBank;

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }
            public string Lastname
            {
                get
                {
                    return this.lastName;
                }
                set
                {
                    this.lastName = value;
                }
            }
            public string Midle
            {
                get
                {
                    return this.midle;
                }
                set
                {
                    this.midle = value;
                }
            }
            public string Address
            {
                get
                {
                    return this.address;
                }
                set
                {
                    this.address = value;
                }
            }
            public int NumberCards
            {
                get
                {
                    return this.numberCards;
                }
                set
                {
                    this.numberCards = value;
                }
            }
            public int NumberBank
            {
                get
                {
                    return this.numberBank;
                }
                set
                {
                    this.numberBank = value;
                }
            }

            public Customer(string name, string lastName, string midle, string address, int numberCards, int numberBank)
            {
                this.name = name;
                this.lastName = lastName;
                this.midle = midle;
                this.address = address;
                this.numberCards = numberCards;
                this.numberBank = numberBank;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Customer cus1 = new Customer();
            cus1.name = textBox2.Text;
            cus1.Lastname = textBox1.Text;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
