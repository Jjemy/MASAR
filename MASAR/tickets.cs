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
    public partial class tickets : Form
    {
        public tickets()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gamal\Documents\Airline.mdf;Integrated Security=True;Connect Timeout=30");

        private void tickets_Load(object sender, EventArgs e)
        {

        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || payment.Text == "" || flightID.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string perID = AddPerson.perID;
                    string perName = AddPerson.perName;
                    string perPhone = AddPerson.perPhone;
                    string perNation = AddPerson.perNation;
                    string perGender = AddPerson.perGender;
                    string perAirID = AddPerson.perAirID;
                    string seatNum = Passenger1.seatNumber;
                    string query1 = "insert into Person values (" + perID + ",'" + perName + "','" + perPhone + "','" + perNation + "','" + perGender + "','" + perAirID + "')";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                    string query2 = "insert into Passenger values (" + perID + ",'" + seatNum + "')";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();
                    string query = "insert into Ticket values (" + id.Text + ",'" + flightID.Text + "','" + perID + "','" + payment.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record added successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
