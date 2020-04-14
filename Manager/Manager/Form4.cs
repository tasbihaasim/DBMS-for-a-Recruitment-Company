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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("United States");
            comboBox1.Items.Add("Canada");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox1.Enabled==false){
                groupBox1.Enabled = true;
                return;
            }
            groupBox1.Enabled = false;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DBconnectioncs c = new DBconnectioncs();
            int urm = 0;
            int sup = 0;
            if (checkBox1.Checked) { urm = 1; }
            if (checkBox2.Checked) { sup = 1; }
            if (sup == 1)
            {

            }
            //c.Inserts("insert Location (Name, City,country) values('" + comboBox2.SelectedItem + "','" + comboBox2.SelectedItem + "','" + comboBox1.SelectedItem + "')");
            //int x= '" +c.Select("select Location_id from Location where Name='" + comboBox2.SelectedItem + "'")+ "';
            c.Inserts("insert Student (Name, Major, email,university,Under_Represented_Minority,Graduationyear,signedup,reply_date) values ('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + urm + "','" + textBox7.Text + "','" + sup + "',getdate())");
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }
    }
}
