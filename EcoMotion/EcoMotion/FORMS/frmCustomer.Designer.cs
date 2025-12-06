
namespace EcoMotion.FORMS
{
    partial class frmCustomer
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
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.firstName_txtbox = new System.Windows.Forms.TextBox();
            this.lastName_txtbox = new System.Windows.Forms.TextBox();
            this.citiy_txtbox = new System.Windows.Forms.TextBox();
            this.street_txtbox = new System.Windows.Forms.TextBox();
            this.phoneNumber_txtbox = new System.Windows.Forms.TextBox();
            this.houseNumber_txtbox = new System.Windows.Forms.TextBox();
            this.mail_txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clearScr_btn = new System.Windows.Forms.Button();
            this.deleteRecord_btn = new System.Windows.Forms.Button();
            this.upDateRecord_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.idSearch_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.active_cmbox = new System.Windows.Forms.ComboBox();
            this.addRecord_btn = new System.Windows.Forms.Button();
            this.fixing_btn = new System.Windows.Forms.Button();
            this.purchase_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(130, 118);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(245, 20);
            this.id_txtbox.TabIndex = 1;
            // 
            // firstName_txtbox
            // 
            this.firstName_txtbox.Location = new System.Drawing.Point(130, 169);
            this.firstName_txtbox.Name = "firstName_txtbox";
            this.firstName_txtbox.Size = new System.Drawing.Size(245, 20);
            this.firstName_txtbox.TabIndex = 2;
            // 
            // lastName_txtbox
            // 
            this.lastName_txtbox.Location = new System.Drawing.Point(130, 219);
            this.lastName_txtbox.Name = "lastName_txtbox";
            this.lastName_txtbox.Size = new System.Drawing.Size(245, 20);
            this.lastName_txtbox.TabIndex = 3;
            // 
            // citiy_txtbox
            // 
            this.citiy_txtbox.Location = new System.Drawing.Point(130, 265);
            this.citiy_txtbox.Name = "citiy_txtbox";
            this.citiy_txtbox.Size = new System.Drawing.Size(245, 20);
            this.citiy_txtbox.TabIndex = 4;
            // 
            // street_txtbox
            // 
            this.street_txtbox.Location = new System.Drawing.Point(130, 311);
            this.street_txtbox.Name = "street_txtbox";
            this.street_txtbox.Size = new System.Drawing.Size(245, 20);
            this.street_txtbox.TabIndex = 5;
            // 
            // phoneNumber_txtbox
            // 
            this.phoneNumber_txtbox.Location = new System.Drawing.Point(130, 353);
            this.phoneNumber_txtbox.Name = "phoneNumber_txtbox";
            this.phoneNumber_txtbox.Size = new System.Drawing.Size(245, 20);
            this.phoneNumber_txtbox.TabIndex = 6;
            // 
            // houseNumber_txtbox
            // 
            this.houseNumber_txtbox.Location = new System.Drawing.Point(130, 402);
            this.houseNumber_txtbox.Name = "houseNumber_txtbox";
            this.houseNumber_txtbox.Size = new System.Drawing.Size(245, 20);
            this.houseNumber_txtbox.TabIndex = 7;
            // 
            // mail_txtbox
            // 
            this.mail_txtbox.Location = new System.Drawing.Point(130, 455);
            this.mail_txtbox.Name = "mail_txtbox";
            this.mail_txtbox.Size = new System.Drawing.Size(245, 20);
            this.mail_txtbox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearScr_btn
            // 
            this.clearScr_btn.Location = new System.Drawing.Point(752, 127);
            this.clearScr_btn.Name = "clearScr_btn";
            this.clearScr_btn.Size = new System.Drawing.Size(91, 62);
            this.clearScr_btn.TabIndex = 10;
            this.clearScr_btn.Text = "Clear Scr";
            this.clearScr_btn.UseVisualStyleBackColor = true;
            this.clearScr_btn.Click += new System.EventHandler(this.clearScr_btn_Click);
            // 
            // deleteRecord_btn
            // 
            this.deleteRecord_btn.Location = new System.Drawing.Point(587, 219);
            this.deleteRecord_btn.Name = "deleteRecord_btn";
            this.deleteRecord_btn.Size = new System.Drawing.Size(91, 62);
            this.deleteRecord_btn.TabIndex = 11;
            this.deleteRecord_btn.Text = "Delete Record";
            this.deleteRecord_btn.UseVisualStyleBackColor = true;
            this.deleteRecord_btn.Click += new System.EventHandler(this.deleteRecord_btn_Click);
            // 
            // upDateRecord_btn
            // 
            this.upDateRecord_btn.Location = new System.Drawing.Point(669, 311);
            this.upDateRecord_btn.Name = "upDateRecord_btn";
            this.upDateRecord_btn.Size = new System.Drawing.Size(91, 62);
            this.upDateRecord_btn.TabIndex = 13;
            this.upDateRecord_btn.Text = "UpDate Record";
            this.upDateRecord_btn.UseVisualStyleBackColor = true;
            this.upDateRecord_btn.Click += new System.EventHandler(this.upDateRecord_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(303, 550);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(141, 62);
            this.search_btn.TabIndex = 14;
            this.search_btn.Text = "Search Record";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // idSearch_txtbox
            // 
            this.idSearch_txtbox.Location = new System.Drawing.Point(33, 592);
            this.idSearch_txtbox.Name = "idSearch_txtbox";
            this.idSearch_txtbox.Size = new System.Drawing.Size(245, 20);
            this.idSearch_txtbox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Citiy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Street:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "House Number:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mail:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 647);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 281);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(601, 467);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 39);
            this.button7.TabIndex = 26;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(734, 467);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 39);
            this.button8.TabIndex = 27;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(669, 436);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 39);
            this.button9.TabIndex = 28;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(669, 498);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 39);
            this.button10.TabIndex = 29;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Active:";
            // 
            // active_cmbox
            // 
            this.active_cmbox.FormattingEnabled = true;
            this.active_cmbox.Items.AddRange(new object[] {
            "כן",
            "לא"});
            this.active_cmbox.Location = new System.Drawing.Point(130, 498);
            this.active_cmbox.Name = "active_cmbox";
            this.active_cmbox.Size = new System.Drawing.Size(245, 21);
            this.active_cmbox.TabIndex = 32;
            // 
            // addRecord_btn
            // 
            this.addRecord_btn.Location = new System.Drawing.Point(752, 223);
            this.addRecord_btn.Name = "addRecord_btn";
            this.addRecord_btn.Size = new System.Drawing.Size(91, 62);
            this.addRecord_btn.TabIndex = 33;
            this.addRecord_btn.Text = "Add Record";
            this.addRecord_btn.UseVisualStyleBackColor = true;
            this.addRecord_btn.Click += new System.EventHandler(this.addRecord_btn_Click);
            // 
            // fixing_btn
            // 
            this.fixing_btn.Location = new System.Drawing.Point(443, 219);
            this.fixing_btn.Name = "fixing_btn";
            this.fixing_btn.Size = new System.Drawing.Size(91, 62);
            this.fixing_btn.TabIndex = 34;
            this.fixing_btn.Text = "Fixing";
            this.fixing_btn.UseVisualStyleBackColor = true;
            // 
            // purchase_btn
            // 
            this.purchase_btn.Location = new System.Drawing.Point(443, 127);
            this.purchase_btn.Name = "purchase_btn";
            this.purchase_btn.Size = new System.Drawing.Size(91, 62);
            this.purchase_btn.TabIndex = 35;
            this.purchase_btn.Text = "Purchase";
            this.purchase_btn.UseVisualStyleBackColor = true;
            this.purchase_btn.Click += new System.EventHandler(this.purchase_btn_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 948);
            this.Controls.Add(this.purchase_btn);
            this.Controls.Add(this.fixing_btn);
            this.Controls.Add(this.addRecord_btn);
            this.Controls.Add(this.active_cmbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idSearch_txtbox);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.upDateRecord_btn);
            this.Controls.Add(this.deleteRecord_btn);
            this.Controls.Add(this.clearScr_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mail_txtbox);
            this.Controls.Add(this.houseNumber_txtbox);
            this.Controls.Add(this.phoneNumber_txtbox);
            this.Controls.Add(this.street_txtbox);
            this.Controls.Add(this.citiy_txtbox);
            this.Controls.Add(this.lastName_txtbox);
            this.Controls.Add(this.firstName_txtbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.TextBox firstName_txtbox;
        private System.Windows.Forms.TextBox lastName_txtbox;
        private System.Windows.Forms.TextBox citiy_txtbox;
        private System.Windows.Forms.TextBox street_txtbox;
        private System.Windows.Forms.TextBox phoneNumber_txtbox;
        private System.Windows.Forms.TextBox houseNumber_txtbox;
        private System.Windows.Forms.TextBox mail_txtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearScr_btn;
        private System.Windows.Forms.Button deleteRecord_btn;
        private System.Windows.Forms.Button upDateRecord_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox idSearch_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox active_cmbox;
        private System.Windows.Forms.Button addRecord_btn;
        private System.Windows.Forms.Button fixing_btn;
        private System.Windows.Forms.Button purchase_btn;
    }
}