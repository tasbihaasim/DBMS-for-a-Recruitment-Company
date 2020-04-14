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
    public partial class compare : Form
    {
        public compare()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DBconnectioncs s = new DBconnectioncs();
            int a = 0;
            string sup = "select T.[Name], count(idStudent) from Student, Talent_acquisition_specialist T where T.ID_TA = Student.ID_TAS group by T.[Name]";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            while (a != 15)
            {
                DataTable signup_q = s.Select(sup);
                string x = signup_q.Rows[a][0].ToString();
                string y = signup_q.Rows[a][1].ToString();
                int g = 0;
                Int32.TryParse(y, out g);
                this.chart1.Series["Series1"].Points.AddXY(x, g);
                a++;

            }

            DBconnectioncs g1 = new DBconnectioncs();
            //int  = 0;
            string low = "select count(ID_TA) from Talent_acquisition_specialist where TAS_Status = 'LOW'";
            string high = "select count(ID_TA) from Talent_acquisition_specialist where TAS_Status = 'STAR'";
            string medium = "select count(ID_TA) from Talent_acquisition_specialist where TAS_Status = 'MEDIUM'";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            DataTable l = g1.Select(low);
            DataTable h = g1.Select(high);
            DataTable m = g1.Select(medium);
            string lo = l.Rows[0][0].ToString();
            string hi = h.Rows[0][0].ToString();
            string me = m.Rows[0][0].ToString();
            int x1 = 0;
            Int32.TryParse(lo, out x1);
            int y1 = 0;
            Int32.TryParse(hi, out y1);
            int z1 = 0;
            Int32.TryParse(me, out z1);
            this.chart2.Series["Series1"].Points.AddXY("Star Employees", x1);
            this.chart2.Series["Series1"].Points.AddXY("Medium grade", y1);
            this.chart2.Series["Series1"].Points.AddXY("Low performing", z1);


        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
