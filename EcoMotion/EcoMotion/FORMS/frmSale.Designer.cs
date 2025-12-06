
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.code_txtbox = new System.Windows.Forms.TextBox();
            this.customerID_txtbox = new System.Windows.Forms.TextBox();
            this.companyNumber_txtbox = new System.Windows.Forms.TextBox();
            this.totalCost_txtbox = new System.Windows.Forms.TextBox();
            this.paymentMethod_txtbox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.moveLast_btn = new System.Windows.Forms.Button();
            this.moveFirst_btn = new System.Windows.Forms.Button();
            this.moveNext_btn = new System.Windows.Forms.Button();
            this.MovePrev_btn = new System.Windows.Forms.Button();
            this.saleDetails_dgv = new System.Windows.Forms.DataGridView();
            this.sales_dgv = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetails_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(59, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(59, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(59, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Cost:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(59, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Sale:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(59, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payment Method:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // code_txtbox
            // 
            this.code_txtbox.Location = new System.Drawing.Point(165, 75);
            this.code_txtbox.Name = "code_txtbox";
            this.code_txtbox.Size = new System.Drawing.Size(169, 20);
            this.code_txtbox.TabIndex = 8;
            this.code_txtbox.TextChanged += new System.EventHandler(this.code_txtbox_TextChanged);
            // 
            // customerID_txtbox
            // 
            this.customerID_txtbox.Location = new System.Drawing.Point(165, 114);
            this.customerID_txtbox.Name = "customerID_txtbox";
            this.customerID_txtbox.Size = new System.Drawing.Size(169, 20);
            this.customerID_txtbox.TabIndex = 9;
            // 
            // companyNumber_txtbox
            // 
            this.companyNumber_txtbox.Location = new System.Drawing.Point(165, 163);
            this.companyNumber_txtbox.Name = "companyNumber_txtbox";
            this.companyNumber_txtbox.Size = new System.Drawing.Size(169, 20);
            this.companyNumber_txtbox.TabIndex = 10;
            // 
            // totalCost_txtbox
            // 
            this.totalCost_txtbox.Location = new System.Drawing.Point(165, 202);
            this.totalCost_txtbox.Name = "totalCost_txtbox";
            this.totalCost_txtbox.Size = new System.Drawing.Size(169, 20);
            this.totalCost_txtbox.TabIndex = 11;
            // 
            // paymentMethod_txtbox
            // 
            this.paymentMethod_txtbox.Location = new System.Drawing.Point(165, 285);
            this.paymentMethod_txtbox.Name = "paymentMethod_txtbox";
            this.paymentMethod_txtbox.Size = new System.Drawing.Size(169, 20);
            this.paymentMethod_txtbox.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(62, 442);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 20);
            this.textBox7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(59, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Code:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // moveLast_btn
            // 
            this.moveLast_btn.Location = new System.Drawing.Point(534, 343);
            this.moveLast_btn.Name = "moveLast_btn";
            this.moveLast_btn.Size = new System.Drawing.Size(62, 32);
            this.moveLast_btn.TabIndex = 22;
            this.moveLast_btn.Text = "<<";
            this.moveLast_btn.UseVisualStyleBackColor = true;
            this.moveLast_btn.Click += new System.EventHandler(this.moveLast_btn_Click);
            // 
            // moveFirst_btn
            // 
            this.moveFirst_btn.Location = new System.Drawing.Point(636, 343);
            this.moveFirst_btn.Name = "moveFirst_btn";
            this.moveFirst_btn.Size = new System.Drawing.Size(62, 32);
            this.moveFirst_btn.TabIndex = 23;
            this.moveFirst_btn.Text = ">>";
            this.moveFirst_btn.UseVisualStyleBackColor = true;
            this.moveFirst_btn.Click += new System.EventHandler(this.moveFirst_btn_Click);
            // 
            // moveNext_btn
            // 
            this.moveNext_btn.Location = new System.Drawing.Point(594, 305);
            this.moveNext_btn.Name = "moveNext_btn";
            this.moveNext_btn.Size = new System.Drawing.Size(42, 32);
            this.moveNext_btn.TabIndex = 24;
            this.moveNext_btn.Text = "+";
            this.moveNext_btn.UseVisualStyleBackColor = true;
            this.moveNext_btn.Click += new System.EventHandler(this.moveNext_btn_Click);
            // 
            // MovePrev_btn
            // 
            this.MovePrev_btn.Location = new System.Drawing.Point(594, 380);
            this.MovePrev_btn.Name = "MovePrev_btn";
            this.MovePrev_btn.Size = new System.Drawing.Size(42, 32);
            this.MovePrev_btn.TabIndex = 25;
            this.MovePrev_btn.Text = "-";
            this.MovePrev_btn.UseVisualStyleBackColor = true;
            this.MovePrev_btn.Click += new System.EventHandler(this.MovePrev_btn_Click);
            // 
            // saleDetails_dgv
            // 
            this.saleDetails_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDetails_dgv.Location = new System.Drawing.Point(398, 72);
            this.saleDetails_dgv.Name = "saleDetails_dgv";
            this.saleDetails_dgv.Size = new System.Drawing.Size(432, 200);
            this.saleDetails_dgv.TabIndex = 26;
            // 
            // sales_dgv
            // 
            this.sales_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_dgv.Location = new System.Drawing.Point(396, 475);
            this.sales_dgv.Name = "sales_dgv";
            this.sales_dgv.Size = new System.Drawing.Size(433, 213);
            this.sales_dgv.TabIndex = 27;
            this.sales_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_dgv_CellContentClick);
            this.sales_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.inventory_dgv_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // addSale
            // 
            this.addSale.Location = new System.Drawing.Point(185, 351);
            this.addSale.Name = "addSale";
            this.addSale.Size = new System.Drawing.Size(102, 38);
            this.addSale.TabIndex = 29;
            this.addSale.Text = "New Sale";
            this.addSale.UseVisualStyleBackColor = true;
            this.addSale.Click += new System.EventHandler(this.addSale_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 697);
            this.Controls.Add(this.addSale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sales_dgv);
            this.Controls.Add(this.saleDetails_dgv);
            this.Controls.Add(this.MovePrev_btn);
            this.Controls.Add(this.moveNext_btn);
            this.Controls.Add(this.moveFirst_btn);
            this.Controls.Add(this.moveLast_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.paymentMethod_txtbox);
            this.Controls.Add(this.totalCost_txtbox);
            this.Controls.Add(this.companyNumber_txtbox);
            this.Controls.Add(this.customerID_txtbox);
            this.Controls.Add(this.code_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSale_FormClosing);
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDetails_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox code_txtbox;
        private System.Windows.Forms.TextBox customerID_txtbox;
        private System.Windows.Forms.TextBox companyNumber_txtbox;
        private System.Windows.Forms.TextBox totalCost_txtbox;
        private System.Windows.Forms.TextBox paymentMethod_txtbox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button moveLast_btn;
        private System.Windows.Forms.Button moveFirst_btn;
        private System.Windows.Forms.Button moveNext_btn;
        private System.Windows.Forms.Button MovePrev_btn;
        private System.Windows.Forms.DataGridView saleDetails_dgv;
        private System.Windows.Forms.DataGridView sales_dgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addSale;
    }
}