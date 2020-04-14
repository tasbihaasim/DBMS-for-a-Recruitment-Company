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
    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DBconnectioncs s = new DBconnectioncs();
            if (star.Checked)
            {
                string q = "update talent_acquisition_specialist set TAS_Status  = 'STAR' where [Name] = '"+ Performance.nm +"' ";
                s.Inserts(q);
            }
            if (medium.Checked)
            {
                string q = "update talent_acquisition_specialist set TAS_Status  = 'MEDIUM' where [Name] = '" + Performance.nm + "' ";
                s.Inserts(q);
            }
            if (low.Checked)
            {
                string q = "update talent_acquisition_specialist set TAS_Status  = 'LOW' where [Name] = '" + Performance.nm + "' ";
                s.Inserts(q);
            }
            this.Close();

        }

        private void Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void Action_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Performance.nm);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Star_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Low_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
