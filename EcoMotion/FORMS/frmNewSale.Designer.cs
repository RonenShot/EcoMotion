
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewSale));
            this.label1 = new System.Windows.Forms.Label();
            this.saleDetailsAid_dgv = new System.Windows.Forms.DataGridView();
            this.codeSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dateSale_dtp = new System.Windows.Forms.DateTimePicker();
            this.paymentMethod_cbm = new System.Windows.Forms.ComboBox();
            this.createNewSale_btn = new System.Windows.Forms.Button();
            this.timeSale_dtp = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.refreshDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsAid_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDisplay)).BeginInit();
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
            // saleDetailsAid_dgv
            // 
            this.saleDetailsAid_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDetailsAid_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeSale,
            this.inventoryId,
            this.price,
            this.quantity});
            this.saleDetailsAid_dgv.Location = new System.Drawing.Point(455, 110);
            this.saleDetailsAid_dgv.Name = "saleDetailsAid_dgv";
            this.saleDetailsAid_dgv.Size = new System.Drawing.Size(443, 174);
            this.saleDetailsAid_dgv.TabIndex = 1;
            // 
            // codeSale
            // 
            this.codeSale.HeaderText = "Code_sale";
            this.codeSale.Name = "codeSale";
            this.codeSale.ReadOnly = true;
            // 
            // inventoryId
            // 
            this.inventoryId.HeaderText = "Inventory_ID";
            this.inventoryId.Name = "inventoryId";
            this.inventoryId.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // inventory_dgv
            // 
            this.inventory_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_dgv.Location = new System.Drawing.Point(389, 369);
            this.inventory_dgv.Name = "inventory_dgv";
            this.inventory_dgv.Size = new System.Drawing.Size(506, 273);
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
            // dateSale_dtp
            // 
            this.dateSale_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSale_dtp.Location = new System.Drawing.Point(154, 271);
            this.dateSale_dtp.Name = "dateSale_dtp";
            this.dateSale_dtp.Size = new System.Drawing.Size(200, 20);
            this.dateSale_dtp.TabIndex = 15;
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
            // timeSale_dtp
            // 
            this.timeSale_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeSale_dtp.Location = new System.Drawing.Point(154, 311);
            this.timeSale_dtp.Name = "timeSale_dtp";
            this.timeSale_dtp.Size = new System.Drawing.Size(200, 20);
            this.timeSale_dtp.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(386, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 23);
            this.label15.TabIndex = 68;
            this.label15.Text = "Inventroy:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(95, 470);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(846, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 62);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 71;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // refreshDisplay
            // 
            this.refreshDisplay.Image = ((System.Drawing.Image)(resources.GetObject("refreshDisplay.Image")));
            this.refreshDisplay.Location = new System.Drawing.Point(778, 1);
            this.refreshDisplay.Name = "refreshDisplay";
            this.refreshDisplay.Size = new System.Drawing.Size(62, 62);
            this.refreshDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshDisplay.TabIndex = 72;
            this.refreshDisplay.TabStop = false;
            this.refreshDisplay.Click += new System.EventHandler(this.refreshDisplay_Click);
            // 
            // frmNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 654);
            this.Controls.Add(this.refreshDisplay);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.timeSale_dtp);
            this.Controls.Add(this.createNewSale_btn);
            this.Controls.Add(this.paymentMethod_cbm);
            this.Controls.Add(this.dateSale_dtp);
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
            this.Controls.Add(this.saleDetailsAid_dgv);
            this.Controls.Add(this.label1);
            this.Name = "frmNewSale";
            this.Text = "frmNewSale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewSale_FormClosing);
            this.Load += new System.EventHandler(this.frmNewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsAid_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView saleDetailsAid_dgv;
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
        private System.Windows.Forms.DateTimePicker dateSale_dtp;
        private System.Windows.Forms.ComboBox paymentMethod_cbm;
        private System.Windows.Forms.Button createNewSale_btn;
        private System.Windows.Forms.DateTimePicker timeSale_dtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox refreshDisplay;
    }
}