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
    public partial class rptMotorList : Form
    {
        public rptMotorList()
        {
            InitializeComponent();
        }

        DataTable Tmotor;
        RadioButton[] mySql = new RadioButton[5];
        int s;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen P = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));

            e.Graphics.DrawString("דוח פירוט תוכניות מנועים ", new Font("Tahoma", 14,
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



        private void rptMotorList_Load(object sender, EventArgs e)
        {

            Location = new Point(240, 135);
            
            Tmotor = DAL.dbEcoMotion.OpenTable("Motor");
        }


        public void PresntSql(int r)
        {
            string stSql = "";
            // dataGridView1.Rows.Clear();
            switch (r)
            {
                case 1:
                    stSql = "SELECT * FROM Motor ORDER BY hp ASC"; // סדר עולה
                    break;
                case 2:
                    stSql = "SELECT * FROM Motor ORDER BY hp DESC";//  סדר יורד 
                    break;
                case 3:
                    stSql = "SELECT * FROM Repairing where status='בשיפוץ'";
                    break;

            }
            dbEcoMotion.GetDataSet((stSql));
            Tmotor = dbEcoMotion.ds.Tables[0];
            dataGridView1.DataSource = Tmotor;


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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void stillInFixing_btn_Click(object sender, EventArgs e)
        {
            s = 3;
            PresntSql(s);
        }
    }
}
