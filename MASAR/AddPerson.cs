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
    public partial class AddPerson:Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gamal\Documents\Airline.mdf;Integrated Security=True;Connect Timeout=30");
        internal static string perID,perName,perPhone,perNation,perGender,perAirID;

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || phone.Text == "" ||  nation.Text == "" || gender.Text == "" || airline_id.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    perID = id.Text;
                    perName = name.Text;
                    perPhone = phone.Text;
                    perNation = nation.Text;
                    perGender = gender.Text;
                    perAirID = airline_id.Text;
                    this.Hide();
                    Passenger1 passenger1 = new Passenger1();
                    passenger1.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || phone.Text == "" || nation.Text == "" || gender.Text == "" || airline_id.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    perID = id.Text;
                    perName = name.Text;
                    perPhone = phone.Text;
                    perNation = nation.Text;
                    perGender = gender.Text;
                    perAirID = airline_id.Text;
                    this.Hide();
                    Attendant Attendant = new Attendant();
                    Attendant.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || phone.Text == "" || nation.Text == "" || gender.Text == "" || airline_id.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    perID = id.Text;
                    perName = name.Text;
                    perPhone = phone.Text;
                    perNation = nation.Text;
                    perGender = gender.Text;
                    perAirID = airline_id.Text;
                    this.Hide();
                    pilot pilot = new pilot();
                    pilot.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
