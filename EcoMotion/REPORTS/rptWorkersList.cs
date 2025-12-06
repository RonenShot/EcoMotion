using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoMotion.UTILITIES;
using EcoMotion.DAL;
using System.Windows.Forms;

namespace EcoMotion.REPORTS
{
    public partial class rptWorkersList : Form
    {
        public rptWorkersList()
        {
            InitializeComponent();
        }
        DataTable Tworker;
        DataTable Trepairing;
        DataTable TworkerRP;
        
        RadioButton[] mySql = new RadioButton[5];
        int s;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen P = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));

            e.Graphics.DrawString("דוח פירוט עובדים ", new Font("Tahoma", 14,
             FontStyle.Bold), Brushes.Red, new Point(420, 100));


            e.Graphics.DrawLine(P, new Point(420, 120), new Point(683, 120));


            int i = 0, j;
            int w = 50, h = 150;
            //לולאה שסופרת מספר עמודות, מציירת ריבוע, מציירת מסגרת ורושמת כותרות

            while (i < dataGridView1.Columns.Count)
            {
                // ציור ריבוע בצבע אפור

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(w, h, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

                //ציור מסגרת לריבוע בצבע אפור

                e.Graphics.DrawRectangle(P, new Rectangle(w, h, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

                //הדפסת טקסט בתוך הכותרת
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(w + 30, h, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

                i++;
                w = w + 100;
            }

            i = 0;
            while (i < dataGridView1.Rows.Count - 1)
            {

                //חישוב הפיקסלים-שמציינים מיקום הטבלה בדוח, גובה כל שורה הוא 22 פיקסלים

                w = 50; h += 23;
                j = 0;
                while (j < dataGridView1.Columns.Count)
                {
                    e.Graphics.DrawRectangle(P, new Rectangle(w, h,
                    dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[j].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(w + 4, h + 3, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

                    j++;
                    w = w + 100;
                }
                i++;
            }
        }

        private void btnPrintView_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult prbutton = printDialog1.ShowDialog();
            if (prbutton.Equals(DialogResult.OK))
                printDocument1.Print();

        }



        private void rptWorkersList_Load(object sender, EventArgs e)
        {

            Location = new Point(240, 135);
            
            Tworker = DAL.dbEcoMotion.OpenTable("Worker");
            for(int i=0;i<Tworker.Rows.Count;i++)
            {
                workers_cmb.Items.Add(Tworker.Rows[i][0].ToString()+" "+ Tworker.Rows[i][1].ToString()+" "+ Tworker.Rows[i][2].ToString());
            }
        }


        public void PresntSql(int r)
        {
            string stSql = "";
            // dataGridView1.Rows.Clear();
            switch (r)
            {
                case 1:
                    stSql = "SELECT * FROM Worker ORDER BY ID ASC"; // סדר עולה
                    break;
                case 2:
                    stSql = "SELECT * FROM Worker ORDER BY ID DESC";//  סדר יורד 
                    break;
                case 3:
                    stSql = "select * from Worker where Active='כן'";
                    break;
                case 4:
                    stSql = "select * from Worker where Active='לא'";
                    break;
                

            }
            dbEcoMotion.GetDataSet((stSql));
            Tworker = dbEcoMotion.ds.Tables[0];
            dataGridView1.DataSource = Tworker;


        }

        private void pPrint_Click(object sender, EventArgs e)
        {
            DialogResult prbutton = printDialog1.ShowDialog();
            if (prbutton.Equals(DialogResult.OK))
                printDocument1.Print();
        }
        private void PPrintView_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }
        private void pSqlNotActive_Click(object sender, EventArgs e)
        {
            s = 4;
            PresntSql(s);
        }

        private void pSqlActive_Click(object sender, EventArgs e)
        {
            s = 3;
            PresntSql(s);
        }



        private void pOrederDes_Click(object sender, EventArgs e)
        {
            s = 2;
            PresntSql(s);
        }

        private void pOrderAsc_Click(object sender, EventArgs e)
        {
            s = 1;
            PresntSql(s);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string stSql = "select * from Repairing where Month(beginingDate)= '" + monthSelector_txt.Text + "' AND Year(beginingDate)= '" + yearSelector_txt.Text + "'";
            dbEcoMotion.GetDataSet((stSql));
            Trepairing = dbEcoMotion.ds.Tables[0];
            int houersCount = 0;
            string idWorker = workers_cmb.Text.Substring(0,10);
            TworkerRP = DAL.dbEcoMotion.OpenTable("WorkerRp");
            string repairCode;
            for (int i = 0; i < Trepairing.Rows.Count; i++)
            {
                repairCode = Trepairing.Rows[i][0].ToString();
                for (int y = 0; y < TworkerRP.Rows.Count; y++)
                {
                    if (TworkerRP.Rows[y][1].ToString() == repairCode && TworkerRP.Rows[y][0].ToString() == idWorker)
                        houersCount += int.Parse(TworkerRP.Rows[y][3].ToString());
                }

            }
            MessageBox.Show("The Worker: " + idWorker + " worked for: " + houersCount.ToString()+" hours.");

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
