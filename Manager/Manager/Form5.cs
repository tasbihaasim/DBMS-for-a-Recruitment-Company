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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form4 student_form = new Form4();
            student_form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Performance manager_form = new Performance();
            manager_form.Show();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            id = int.Parse(textBox1.Text);

            if (radioButton1.Checked)
            {
                DBconnectioncs LOL = new DBconnectioncs();

                {
                    string query = "select Manager_ID from Manager where Manager_ID = '" + textBox1.Text + "'";
                    string query2 = "select Password from Manager where Manager_ID = '" + textBox1.Text + "'and Password = '" + textBox2.Text + "'";
                    DataTable id = LOL.Select(query);
                    DataTable pass = LOL.Select(query2);
                    try
                    {
                        if (id.Rows[0][0] != null && pass.Rows[0][0] != null)
                        {
                            //this.Hide();
                            Performance form_ta = new Performance();
                            form_ta.Show();
                        }

                        else
                        {
                            MessageBox.Show("Access Denied: ID Password not matched!");

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Access Denied: ID Password not matched!");
                    }
                }


            }
            if (radioButton2.Checked)
            {
                DBconnectioncs LOL = new DBconnectioncs();

                {
                    string query = "select ID_TA from Talent_acquisition_specialist where ID_TA = '" + textBox1.Text + "'";
                    string query2 = "select Password from Talent_acquisition_specialist where ID_TA = '" + textBox1.Text + "'and Password = '" + textBox2.Text + "'";
                    DataTable id = LOL.Select(query);
                    DataTable pass = LOL.Select(query2);
                    try
                    {
                        if (id.Rows[0][0] != null && pass.Rows[0][0] != null)
                        {
                            groupBox3.Enabled = true;
                        }

                        else
                        {
                            MessageBox.Show("Access Denied: ID Password not matched!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Access Denied: ID Password not matched!");
                    }
                }


            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {

            this.Close();
          
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form4 form_student = new Form4();
            form_student.Show();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form6 my_performance = new Form6();
            my_performance.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form7 edit_performance = new Form7();
            edit_performance.Show();
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        public static int id = 0;
    }
}
