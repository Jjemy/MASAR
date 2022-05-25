using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MASAR
{
    public partial class Passenger1 : Form
    {
        public Passenger1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gamal\Documents\Airline.mdf;Integrated Security=True;Connect Timeout=30");
        internal static string seatNumber;
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (seatNum.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                seatNumber = seatNum.Text;
                this.Hide();
                tickets ticket = new tickets();
                ticket.ShowDialog();
            }
        }

        private void Passenger1_Load(object sender, EventArgs e)
        {

        }
    }
}
