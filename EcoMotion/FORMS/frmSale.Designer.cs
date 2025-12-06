
namespace EcoMotion.FORMS
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.code_txtbox = new System.Windows.Forms.TextBox();
            this.customerID_txtbox = new System.Windows.Forms.TextBox();
            this.totalCost_txtbox = new System.Windows.Forms.TextBox();
            this.paymentMethod_txtbox = new System.Windows.Forms.TextBox();
            this.searchCode_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saleDetails_dgv = new System.Windows.Forms.DataGridView();
            this.sales_dgv = new System.Windows.Forms.DataGridView();
            this.addSale = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.time_txtbox = new System.Windows.Forms.TextBox();
            this.date_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.moveFirst = new System.Windows.Forms.PictureBox();
            this.moveNext = new System.Windows.Forms.PictureBox();
            this.moveLast = new System.Windows.Forms.PictureBox();
            this.movePrev = new System.Windows.Forms.PictureBox();
            this.clearScreen = new System.Windows.Forms.PictureBox();
            this.refreshDisplay = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetails_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(44, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Cost:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(44, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Sale:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(34, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payment Method:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // code_txtbox
            // 
            this.code_txtbox.Location = new System.Drawing.Point(150, 117);
            this.code_txtbox.Name = "code_txtbox";
            this.code_txtbox.ReadOnly = true;
            this.code_txtbox.Size = new System.Drawing.Size(169, 20);
            this.code_txtbox.TabIndex = 8;
            this.code_txtbox.TextChanged += new System.EventHandler(this.code_txtbox_TextChanged);
            // 
            // customerID_txtbox
            // 
            this.customerID_txtbox.Location = new System.Drawing.Point(150, 156);
            this.customerID_txtbox.Name = "customerID_txtbox";
            this.customerID_txtbox.ReadOnly = true;
            this.customerID_txtbox.Size = new System.Drawing.Size(169, 20);
            this.customerID_txtbox.TabIndex = 9;
            // 
            // totalCost_txtbox
            // 
            this.totalCost_txtbox.Location = new System.Drawing.Point(150, 194);
            this.totalCost_txtbox.Name = "totalCost_txtbox";
            this.totalCost_txtbox.ReadOnly = true;
            this.totalCost_txtbox.Size = new System.Drawing.Size(169, 20);
            this.totalCost_txtbox.TabIndex = 11;
            // 
            // paymentMethod_txtbox
            // 
            this.paymentMethod_txtbox.Location = new System.Drawing.Point(152, 320);
            this.paymentMethod_txtbox.Name = "paymentMethod_txtbox";
            this.paymentMethod_txtbox.ReadOnly = true;
            this.paymentMethod_txtbox.Size = new System.Drawing.Size(169, 20);
            this.paymentMethod_txtbox.TabIndex = 13;
            // 
            // searchCode_txtbox
            // 
            this.searchCode_txtbox.Location = new System.Drawing.Point(47, 484);
            this.searchCode_txtbox.Name = "searchCode_txtbox";
            this.searchCode_txtbox.Size = new System.Drawing.Size(169, 20);
            this.searchCode_txtbox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(44, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Code:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saleDetails_dgv
            // 
            this.saleDetails_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDetails_dgv.Location = new System.Drawing.Point(616, 142);
            this.saleDetails_dgv.Name = "saleDetails_dgv";
            this.saleDetails_dgv.Size = new System.Drawing.Size(432, 200);
            this.saleDetails_dgv.TabIndex = 26;
            // 
            // sales_dgv
            // 
            this.sales_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_dgv.Location = new System.Drawing.Point(615, 431);
            this.sales_dgv.Name = "sales_dgv";
            this.sales_dgv.Size = new System.Drawing.Size(433, 213);
            this.sales_dgv.TabIndex = 27;
            this.sales_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sales_dgv_RowHeaderMouseClick);
            // 
            // addSale
            // 
            this.addSale.Location = new System.Drawing.Point(434, 310);
            this.addSale.Name = "addSale";
            this.addSale.Size = new System.Drawing.Size(102, 38);
            this.addSale.TabIndex = 29;
            this.addSale.Text = "New Sale";
            this.addSale.UseVisualStyleBackColor = true;
            this.addSale.Click += new System.EventHandler(this.addSale_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(44, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Time Sale:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time_txtbox
            // 
            this.time_txtbox.Location = new System.Drawing.Point(150, 274);
            this.time_txtbox.Name = "time_txtbox";
            this.time_txtbox.ReadOnly = true;
            this.time_txtbox.Size = new System.Drawing.Size(169, 20);
            this.time_txtbox.TabIndex = 32;
            // 
            // date_txtbox
            // 
            this.date_txtbox.Location = new System.Drawing.Point(150, 236);
            this.date_txtbox.Name = "date_txtbox";
            this.date_txtbox.ReadOnly = true;
            this.date_txtbox.Size = new System.Drawing.Size(169, 20);
            this.date_txtbox.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 35);
            this.label4.TabIndex = 36;
            this.label4.Text = "Sale Details:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveFirst
            // 
            this.moveFirst.Image = ((System.Drawing.Image)(resources.GetObject("moveFirst.Image")));
            this.moveFirst.Location = new System.Drawing.Point(768, 3);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(76, 62);
            this.moveFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveFirst.TabIndex = 63;
            this.moveFirst.TabStop = false;
            this.moveFirst.Click += new System.EventHandler(this.moveFirst_Click);
            // 
            // moveNext
            // 
            this.moveNext.Image = ((System.Drawing.Image)(resources.GetObject("moveNext.Image")));
            this.moveNext.Location = new System.Drawing.Point(687, 3);
            this.moveNext.Name = "moveNext";
            this.moveNext.Size = new System.Drawing.Size(75, 62);
            this.moveNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveNext.TabIndex = 62;
            this.moveNext.TabStop = false;
            this.moveNext.Click += new System.EventHandler(this.moveNext_Click);
            // 
            // moveLast
            // 
            this.moveLast.Image = ((System.Drawing.Image)(resources.GetObject("moveLast.Image")));
            this.moveLast.Location = new System.Drawing.Point(511, 3);
            this.moveLast.Name = "moveLast";
            this.moveLast.Size = new System.Drawing.Size(80, 62);
            this.moveLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveLast.TabIndex = 61;
            this.moveLast.TabStop = false;
            this.moveLast.Click += new System.EventHandler(this.moveLast_Click);
            // 
            // movePrev
            // 
            this.movePrev.Image = ((System.Drawing.Image)(resources.GetObject("movePrev.Image")));
            this.movePrev.Location = new System.Drawing.Point(597, 3);
            this.movePrev.Name = "movePrev";
            this.movePrev.Size = new System.Drawing.Size(84, 62);
            this.movePrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movePrev.TabIndex = 60;
            this.movePrev.TabStop = false;
            this.movePrev.Click += new System.EventHandler(this.movePrev_Click);
            // 
            // clearScreen
            // 
            this.clearScreen.Image = ((System.Drawing.Image)(resources.GetObject("clearScreen.Image")));
            this.clearScreen.Location = new System.Drawing.Point(849, 3);
            this.clearScreen.Name = "clearScreen";
            this.clearScreen.Size = new System.Drawing.Size(74, 62);
            this.clearScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearScreen.TabIndex = 59;
            this.clearScreen.TabStop = false;
            this.clearScreen.Click += new System.EventHandler(this.clearScreen_Click);
            // 
            // refreshDisplay
            // 
            this.refreshDisplay.Image = ((System.Drawing.Image)(resources.GetObject("refreshDisplay.Image")));
            this.refreshDisplay.Location = new System.Drawing.Point(929, 3);
            this.refreshDisplay.Name = "refreshDisplay";
            this.refreshDisplay.Size = new System.Drawing.Size(62, 62);
            this.refreshDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshDisplay.TabIndex = 58;
            this.refreshDisplay.TabStop = false;
            this.refreshDisplay.Click += new System.EventHandler(this.refreshDisplay_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(997, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 62);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 57;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(235, 457);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(46, 47);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 64;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(594, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 35);
            this.label10.TabIndex = 65;
            this.label10.Text = "Sale:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 657);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.search);
            this.Controls.Add(this.moveFirst);
            this.Controls.Add(this.moveNext);
            this.Controls.Add(this.moveLast);
            this.Controls.Add(this.movePrev);
            this.Controls.Add(this.clearScreen);
            this.Controls.Add(this.refreshDisplay);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.date_txtbox);
            this.Controls.Add(this.time_txtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addSale);
            this.Controls.Add(this.sales_dgv);
            this.Controls.Add(this.saleDetails_dgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchCode_txtbox);
            this.Controls.Add(this.paymentMethod_txtbox);
            this.Controls.Add(this.totalCost_txtbox);
            this.Controls.Add(this.customerID_txtbox);
            this.Controls.Add(this.code_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSale_FormClosing);
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDetails_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox code_txtbox;
        private System.Windows.Forms.TextBox customerID_txtbox;
        private System.Windows.Forms.TextBox totalCost_txtbox;
        private System.Windows.Forms.TextBox paymentMethod_txtbox;
        private System.Windows.Forms.TextBox searchCode_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView saleDetails_dgv;
        private System.Windows.Forms.DataGridView sales_dgv;
        private System.Windows.Forms.Button addSale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox time_txtbox;
        private System.Windows.Forms.TextBox date_txtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox moveFirst;
        private System.Windows.Forms.PictureBox moveNext;
        private System.Windows.Forms.PictureBox moveLast;
        private System.Windows.Forms.PictureBox movePrev;
        private System.Windows.Forms.PictureBox clearScreen;
        private System.Windows.Forms.PictureBox refreshDisplay;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.Label label10;
    }
}