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
    
    public partial class Performance : Form
    {
        
        public Performance()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Action_Click(object sender, EventArgs e)
        {
            Action secondForm = new Action();
            secondForm.Show();

        }

        private void Compare_Click(object sender, EventArgs e)
        {
            compare thirdform = new compare();
            thirdform.Show();
        }

        public void OK_Click(object sender, EventArgs e)
        {
            nm = TAS.SelectedItem.ToString();
            DBconnectioncs s = new DBconnectioncs();
            string dt_to = to.Value.ToString("yyyy/MM/dd");
            string dt_from = from.Value.ToString("yyyy/MM/dd");
           
            string query_connections = "select No_Of_Connections from Talent_acquisition_specialist where [Name] = '" + TAS.SelectedItem+"'";
            DataTable name = s.Select(query_connections);
            connectionNumber.Items.Clear();
            connectionNumber.Items.Add(name.Rows[0][0].ToString());
            //HERE REPLY_DATE WILL BE CHANGED TO SIGNED UP DATE vvv
            string signedup = "select count(idStudent) from Student where signedup=1 and ID_TAS = (select ID_TA from Talent_acquisition_specialist where [Name] = '" + TAS.SelectedItem + "') and signup_date <= Cast('" + dt_to + "'as date) and signup_date>=Cast('" + dt_from + "'as date)";
            DataTable signup_q = s.Select(signedup);
            signupsNumber.Items.Clear();
            signupsNumber.Items.Add(signup_q.Rows[0][0].ToString());
            string urm = "select sum(Under_represented_minority) from Student where signedup=1 and ID_TAS = (select ID_TA from Talent_acquisition_specialist where [Name] = '" + TAS.SelectedItem + "')and signup_date <= Cast('" + dt_to + "'as date) and signup_date> =Cast('" + dt_from + "'as date)";
            DataTable urm_q = s.Select(urm);
            dsignup.Items.Clear();
            dsignup.Items.Add((urm_q.Rows[0][0].ToString()));
    
            string dt = "select count(idStudent) from Student where ID_TAS =(select ID_TA from Talent_acquisition_specialist where [Name] = '" + TAS.SelectedItem + "')and reply_date <= Cast('" + dt_to + "'as date) and reply_date> =Cast('" + dt_from + "'as date)";
            DataTable date_q = s.Select(dt);
            replies.Items.Clear();
            replies.Items.Add((date_q.Rows[0][0].ToString()));

            //datagrid viewsig
            //[0][0] rows columns
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int g= int.Parse(signup_q.Rows[0][0].ToString());
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Student name";
            dataGridView1.Columns[1].Name = "Major";
            dataGridView1.Columns[2].Name = "College";
            //dataGridView1.Columns[3].Name = "Under Represented Minority";
            string x = "select [Name],Major,University from Student where ID_TAS =(select ID_TA from Talent_acquisition_specialist where [Name] = '" + TAS.SelectedItem + "')";
            DataTable query_student = s.Select(x);
            int a = 0;
             while (a != g)
            {
                string row = (query_student.Rows[a][0].ToString() + query_student.Rows[a][1].ToString() + query_student.Rows[a][2].ToString());
                dataGridView1.Rows.Add(row);
                a++;
            }
            
           
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);


            //string quer1 = "select "
        }

        public void TAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            nm = TAS.SelectedItem.ToString();  
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Performance_Load(object sender, EventArgs e)
        {
            DBconnectioncs d = new DBconnectioncs();
            TAS.Items.Clear();
            
                string query = "select ID_TA,[Name] from Talent_acquisition_specialist";
                DataTable name= d.Select(query);
               for(int i = 0; i < name.Rows.Count; i++)
               {
                TAS.Items.Add(name.Rows[i]["name"].ToString());
                    //TAS.DisplayMember = "name";
                    //TAS.ValueMember = "ID_TA";
                    //TAS.DataSource = name;
               }

                
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form5 login = new Form5();
            //login.Show();
        }

        private void ConnectionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SignupsNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dsignup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Replies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string nm = "";
    }
}
