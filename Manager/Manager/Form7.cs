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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
    
            groupBox1.Enabled = true;
            int id = Form5.id;
            DBconnectioncs s = new DBconnectioncs();
            s.Inserts("update Talent_acquisition_specialist set no_of_connections=no_of_connections+'" + int.Parse(textBox1.Text) + "' where id_TA='" + id + "'");
            string dt_to = dateTimePicker1.Value.ToString("yyyy/MM/dd");



            string query_signups = "select count(idStudent) from Student where signedup = 1 and ID_TAS = '" + id + "' and signup_date <= Cast('" + dt_to + "' as date)";
            DataTable name = s.Select(query_signups);
            listBox1.Items.Clear();
            listBox1.Items.Add(name.Rows[0][0].ToString());

            string dt = "select count(idStudent) from Student where ID_TAS ='" + id + "'and reply_date <= Cast('" + dt_to + "'as date)";
            DataTable date_q = s.Select(dt);
            listBox2.Items.Clear();
            listBox2.Items.Add((date_q.Rows[0][0].ToString()));

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
