using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int id = Form5.id;
            DBconnectioncs s = new DBconnectioncs();
            string dt_to = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string dt_from = dateTimePicker2.Value.ToString("yyyy/MM/dd");

            string query_connections = "select No_Of_Connections from Talent_acquisition_specialist where ID_TA = '" + id + "'";
            DataTable conn = s.Select(query_connections);
            listBox1.Items.Clear();
            listBox1.Items.Add(conn.Rows[0][0].ToString());

            string query_signups = "select count(idStudent) from Student where signedup = 1 and ID_TAS = '" + id + "' and signup_date <= Cast('" + dt_to + "' as date) and signup_date>= Cast('" + dt_from + "' as date)";
            DataTable name = s.Select(query_signups);
            listBox2.Items.Clear();
            listBox2.Items.Add(name.Rows[0][0].ToString());

            string urm = "select count(idStudent) from Student where signedup=1 and under_represented_minority=1 and ID_TAS = '" + id + "'and signup_date <= Cast('" + dt_to + "'as date) and signup_date> =Cast('" + dt_from + "'as date)";
            DataTable urm_q = s.Select(urm);
            listBox3.Items.Clear();
            listBox3.Items.Add((urm_q.Rows[0][0].ToString()));

            string dt = "select count(idStudent) from Student where ID_TAS ='" + id + "'and reply_date <= Cast('" + dt_to + "'as date) and reply_date> =Cast('" + dt_from + "'as date)";
            DataTable date_q = s.Select(dt);
            listBox4.Items.Clear();
            listBox4.Items.Add((date_q.Rows[0][0].ToString()));

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
