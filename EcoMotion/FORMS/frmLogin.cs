using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoMotion.FORMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName_txt.Text == "ronen")
            {
                if (password_txt.Text == "123")
                {
                    frmMangerInterface f1 = new frmMangerInterface();
                    f1.ShowDialog();
                    this.Hide();
                }
                else if (password_txt.Text == "1234")
                {
                    frmWorkerInterface f2 = new frmWorkerInterface();
                    f2.ShowDialog();
                    this.Hide();
                }
                else if (password_txt.Text == "12345")
                {
                    frmSellerrInterface f3 = new frmSellerrInterface();
                    f3.ShowDialog();
                    this.Hide();
                }
                else
                    MessageBox.Show("password is incorrect");



            }
            else
                MessageBox.Show("password or username are incorrect");
                
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable type;
            bool found = false;
            if (userName_txt.Text == "ronen" && password_txt.Text == "123")
            {
                frmMangerInterface f1 = new frmMangerInterface();
                f1.ShowDialog();
                this.Hide();
                found = true;
            }
            else if (!found)
            {
                string strSql = "Select * from Worker where type='1'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                type = DAL.dbEcoMotion.ds.Tables[0];
                for (int i = 0; i < type.Rows.Count; i++)
                {
                    if (userName_txt.Text == type.Rows[i][10].ToString() && password_txt.Text == type.Rows[i][11].ToString())
                    {
                        frmWorkerInterface f2 = new frmWorkerInterface();
                        f2.ShowDialog();
                        this.Hide();
                        found = true;
                    }
                }

            }
            if (!found)
            {
                string strSql = "Select * from Worker where type='2'";
                DAL.dbEcoMotion.GetDataSet(strSql);
                type = DAL.dbEcoMotion.ds.Tables[0];
                for (int i = 0; i < type.Rows.Count; i++)
                {
                    if (userName_txt.Text == type.Rows[i][10].ToString() && password_txt.Text == type.Rows[i][11].ToString())
                    {
                        frmSellerrInterface f3 = new frmSellerrInterface();
                        f3.ShowDialog();
                        this.Hide();
                        found = true;
                    }
                }
            }
            if (!found)
                MessageBox.Show("password or username might be wrong");

        }


    }
}

