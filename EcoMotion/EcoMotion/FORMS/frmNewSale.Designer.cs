
namespace EcoMotion.FORMS
{
    partial class frmNewSale
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
            this.saleDetails_dgv = new System.Windows.Forms.DataGridView();
            this.inventory_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codeSale_txt = new System.Windows.Forms.TextBox();
            this.customerId_txtbox = new System.Windows.Forms.TextBox();
            this.totalCost_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentMethod_cbm = new System.Windows.Forms.ComboBox();
            this.createNewSale_btn = new System.Windows.Forms.Button();
            this.timeSale_txt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetails_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(340, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saleDetails_dgv
            // 
            this.saleDetails_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDetails_dgv.Location = new System.Drawing.Point(487, 110);
            this.saleDetails_dgv.Name = "saleDetails_dgv";
            this.saleDetails_dgv.Size = new System.Drawing.Size(330, 174);
            this.saleDetails_dgv.TabIndex = 1;
            // 
            // inventory_dgv
            // 
            this.inventory_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_dgv.Location = new System.Drawing.Point(389, 369);
            this.inventory_dgv.Name = "inventory_dgv";
            this.inventory_dgv.Size = new System.Drawing.Size(428, 126);
            this.inventory_dgv.TabIndex = 2;
            this.inventory_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.inventory_dgv_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code sale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Sale:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time  Sale:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Payment Method:";
            // 
            // codeSale_txt
            // 
            this.codeSale_txt.Location = new System.Drawing.Point(154, 110);
            this.codeSale_txt.Name = "codeSale_txt";
            this.codeSale_txt.ReadOnly = true;
            this.codeSale_txt.Size = new System.Drawing.Size(200, 20);
            this.codeSale_txt.TabIndex = 9;
            // 
            // customerId_txtbox
            // 
            this.customerId_txtbox.Location = new System.Drawing.Point(154, 168);
            this.customerId_txtbox.Name = "customerId_txtbox";
            this.customerId_txtbox.ReadOnly = true;
            this.customerId_txtbox.Size = new System.Drawing.Size(200, 20);
            this.customerId_txtbox.TabIndex = 10;
            // 
            // totalCost_txt
            // 
            this.totalCost_txt.Location = new System.Drawing.Point(154, 228);
            this.totalCost_txt.Name = "totalCost_txt";
            this.totalCost_txt.ReadOnly = true;
            this.totalCost_txt.Size = new System.Drawing.Size(200, 20);
            this.totalCost_txt.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(154, 271);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // paymentMethod_cbm
            // 
            this.paymentMethod_cbm.FormattingEnabled = true;
            this.paymentMethod_cbm.Items.AddRange(new object[] {
            "אשראי",
            "מזומן"});
            this.paymentMethod_cbm.Location = new System.Drawing.Point(154, 348);
            this.paymentMethod_cbm.Name = "paymentMethod_cbm";
            this.paymentMethod_cbm.Size = new System.Drawing.Size(200, 21);
            this.paymentMethod_cbm.TabIndex = 16;
            // 
            // createNewSale_btn
            // 
            this.createNewSale_btn.Location = new System.Drawing.Point(61, 406);
            this.createNewSale_btn.Name = "createNewSale_btn";
            this.createNewSale_btn.Size = new System.Drawing.Size(83, 40);
            this.createNewSale_btn.TabIndex = 17;
            this.createNewSale_btn.Text = "Create New Recipt";
            this.createNewSale_btn.UseVisualStyleBackColor = true;
            this.createNewSale_btn.Click += new System.EventHandler(this.createNewSale_btn_Click);
            // 
            // timeSale_txt
            // 
            this.timeSale_txt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeSale_txt.Location = new System.Drawing.Point(154, 311);
            this.timeSale_txt.Name = "timeSale_txt";
            this.timeSale_txt.Size = new System.Drawing.Size(200, 20);
            this.timeSale_txt.TabIndex = 18;
            // 
            // frmNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 507);
            this.Controls.Add(this.timeSale_txt);
            this.Controls.Add(this.createNewSale_btn);
            this.Controls.Add(this.paymentMethod_cbm);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.totalCost_txt);
            this.Controls.Add(this.customerId_txtbox);
            this.Controls.Add(this.codeSale_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inventory_dgv);
            this.Controls.Add(this.saleDetails_dgv);
            this.Controls.Add(this.label1);
            this.Name = "frmNewSale";
            this.Text = "frmNewSale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewSale_FormClosing);
            this.Load += new System.EventHandler(this.frmNewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDetails_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView saleDetails_dgv;
        private System.Windows.Forms.DataGridView inventory_dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codeSale_txt;
        private System.Windows.Forms.TextBox customerId_txtbox;
        private System.Windows.Forms.TextBox totalCost_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox paymentMethod_cbm;
        private System.Windows.Forms.Button createNewSale_btn;
        private System.Windows.Forms.DateTimePicker timeSale_txt;
    }
}