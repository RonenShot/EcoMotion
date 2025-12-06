
namespace EcoMotion.REPORTS
{
    partial class rptSaleIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptSaleIncome));
            this.PPrintView = new System.Windows.Forms.PictureBox();
            this.pPrint = new System.Windows.Forms.PictureBox();
            this.pOrderAsc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.monthSelector_txt = new System.Windows.Forms.TextBox();
            this.yearSelector_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PPrintView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOrderAsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // PPrintView
            // 
            this.PPrintView.BackColor = System.Drawing.Color.Transparent;
            this.PPrintView.Image = ((System.Drawing.Image)(resources.GetObject("PPrintView.Image")));
            this.PPrintView.Location = new System.Drawing.Point(345, 368);
            this.PPrintView.Name = "PPrintView";
            this.PPrintView.Size = new System.Drawing.Size(51, 45);
            this.PPrintView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPrintView.TabIndex = 15;
            this.PPrintView.TabStop = false;
            this.PPrintView.Click += new System.EventHandler(this.PPrintView_Click);
            // 
            // pPrint
            // 
            this.pPrint.BackColor = System.Drawing.Color.Transparent;
            this.pPrint.Image = ((System.Drawing.Image)(resources.GetObject("pPrint.Image")));
            this.pPrint.Location = new System.Drawing.Point(269, 368);
            this.pPrint.Name = "pPrint";
            this.pPrint.Size = new System.Drawing.Size(51, 45);
            this.pPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPrint.TabIndex = 14;
            this.pPrint.TabStop = false;
            this.pPrint.Click += new System.EventHandler(this.pPrint_Click);
            // 
            // pOrderAsc
            // 
            this.pOrderAsc.BackColor = System.Drawing.Color.Transparent;
            this.pOrderAsc.Image = ((System.Drawing.Image)(resources.GetObject("pOrderAsc.Image")));
            this.pOrderAsc.Location = new System.Drawing.Point(575, 283);
            this.pOrderAsc.Name = "pOrderAsc";
            this.pOrderAsc.Size = new System.Drawing.Size(51, 45);
            this.pOrderAsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pOrderAsc.TabIndex = 12;
            this.pOrderAsc.TabStop = false;
            this.pOrderAsc.Click += new System.EventHandler(this.pOrderAsc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "דוח הכנסות ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 252);
            this.dataGridView1.TabIndex = 8;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // monthSelector_txt
            // 
            this.monthSelector_txt.Location = new System.Drawing.Point(6, 19);
            this.monthSelector_txt.Name = "monthSelector_txt";
            this.monthSelector_txt.Size = new System.Drawing.Size(93, 20);
            this.monthSelector_txt.TabIndex = 17;
            // 
            // yearSelector_txt
            // 
            this.yearSelector_txt.Location = new System.Drawing.Point(12, 19);
            this.yearSelector_txt.Name = "yearSelector_txt";
            this.yearSelector_txt.Size = new System.Drawing.Size(93, 20);
            this.yearSelector_txt.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yearSelector_txt);
            this.groupBox1.Location = new System.Drawing.Point(547, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 58);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthSelector_txt);
            this.groupBox2.Location = new System.Drawing.Point(550, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 56);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Month:";
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(673, -2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 62);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 48;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // rptSaleIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 461);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PPrintView);
            this.Controls.Add(this.pPrint);
            this.Controls.Add(this.pOrderAsc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "rptSaleIncome";
            this.Text = "rptSaleIncome";
            this.Load += new System.EventHandler(this.rptSaleIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PPrintView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOrderAsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PPrintView;
        private System.Windows.Forms.PictureBox pPrint;
        private System.Windows.Forms.PictureBox pOrderAsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox monthSelector_txt;
        private System.Windows.Forms.TextBox yearSelector_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox exit;
    }
}