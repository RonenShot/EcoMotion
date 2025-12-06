
namespace EcoMotion.FORMS
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inventoryId_txtbox = new System.Windows.Forms.TextBox();
            this.supplier_txtbox = new System.Windows.Forms.TextBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.active_cmbox = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manuDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.quntityInstock_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.motorID_cmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.moveFirst = new System.Windows.Forms.PictureBox();
            this.moveNext = new System.Windows.Forms.PictureBox();
            this.moveLast = new System.Windows.Forms.PictureBox();
            this.movePrev = new System.Windows.Forms.PictureBox();
            this.updateRecord = new System.Windows.Forms.PictureBox();
            this.addRecord = new System.Windows.Forms.PictureBox();
            this.deleteRecord = new System.Windows.Forms.PictureBox();
            this.clearScreen = new System.Windows.Forms.PictureBox();
            this.refreshDisplay = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(99, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(99, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(99, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacture Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(99, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(99, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(99, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Price:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(99, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Active:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inventoryId_txtbox
            // 
            this.inventoryId_txtbox.Location = new System.Drawing.Point(224, 142);
            this.inventoryId_txtbox.Name = "inventoryId_txtbox";
            this.inventoryId_txtbox.Size = new System.Drawing.Size(183, 20);
            this.inventoryId_txtbox.TabIndex = 12;
            // 
            // supplier_txtbox
            // 
            this.supplier_txtbox.Location = new System.Drawing.Point(224, 237);
            this.supplier_txtbox.Name = "supplier_txtbox";
            this.supplier_txtbox.Size = new System.Drawing.Size(183, 20);
            this.supplier_txtbox.TabIndex = 15;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(224, 394);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(183, 20);
            this.quantity_txt.TabIndex = 17;
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(224, 313);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(183, 20);
            this.price_txtbox.TabIndex = 21;
            // 
            // active_cmbox
            // 
            this.active_cmbox.FormattingEnabled = true;
            this.active_cmbox.Items.AddRange(new object[] {
            "כן",
            "לא"});
            this.active_cmbox.Location = new System.Drawing.Point(224, 352);
            this.active_cmbox.Name = "active_cmbox";
            this.active_cmbox.Size = new System.Drawing.Size(183, 21);
            this.active_cmbox.TabIndex = 22;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(36, 541);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(183, 20);
            this.search_txt.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 493);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Inventory ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 280);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // manuDate_dtp
            // 
            this.manuDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.manuDate_dtp.Location = new System.Drawing.Point(228, 276);
            this.manuDate_dtp.Name = "manuDate_dtp";
            this.manuDate_dtp.Size = new System.Drawing.Size(183, 20);
            this.manuDate_dtp.TabIndex = 36;
            // 
            // quntityInstock_txt
            // 
            this.quntityInstock_txt.Location = new System.Drawing.Point(224, 438);
            this.quntityInstock_txt.Name = "quntityInstock_txt";
            this.quntityInstock_txt.Size = new System.Drawing.Size(183, 20);
            this.quntityInstock_txt.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(99, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Quantity in Stock:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // motorID_cmb
            // 
            this.motorID_cmb.FormattingEnabled = true;
            this.motorID_cmb.Location = new System.Drawing.Point(224, 190);
            this.motorID_cmb.Name = "motorID_cmb";
            this.motorID_cmb.Size = new System.Drawing.Size(183, 21);
            this.motorID_cmb.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // moveFirst
            // 
            this.moveFirst.Image = ((System.Drawing.Image)(resources.GetObject("moveFirst.Image")));
            this.moveFirst.Location = new System.Drawing.Point(706, 12);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(76, 62);
            this.moveFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveFirst.TabIndex = 67;
            this.moveFirst.TabStop = false;
            this.moveFirst.Click += new System.EventHandler(this.moveFirst_Click);
            // 
            // moveNext
            // 
            this.moveNext.Image = ((System.Drawing.Image)(resources.GetObject("moveNext.Image")));
            this.moveNext.Location = new System.Drawing.Point(625, 12);
            this.moveNext.Name = "moveNext";
            this.moveNext.Size = new System.Drawing.Size(75, 62);
            this.moveNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveNext.TabIndex = 66;
            this.moveNext.TabStop = false;
            this.moveNext.Click += new System.EventHandler(this.moveNext_Click);
            // 
            // moveLast
            // 
            this.moveLast.Image = ((System.Drawing.Image)(resources.GetObject("moveLast.Image")));
            this.moveLast.Location = new System.Drawing.Point(449, 12);
            this.moveLast.Name = "moveLast";
            this.moveLast.Size = new System.Drawing.Size(80, 62);
            this.moveLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveLast.TabIndex = 65;
            this.moveLast.TabStop = false;
            this.moveLast.Click += new System.EventHandler(this.moveLast_Click);
            // 
            // movePrev
            // 
            this.movePrev.Image = ((System.Drawing.Image)(resources.GetObject("movePrev.Image")));
            this.movePrev.Location = new System.Drawing.Point(535, 12);
            this.movePrev.Name = "movePrev";
            this.movePrev.Size = new System.Drawing.Size(84, 62);
            this.movePrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movePrev.TabIndex = 64;
            this.movePrev.TabStop = false;
            this.movePrev.Click += new System.EventHandler(this.movePrev_Click);
            // 
            // updateRecord
            // 
            this.updateRecord.Image = ((System.Drawing.Image)(resources.GetObject("updateRecord.Image")));
            this.updateRecord.Location = new System.Drawing.Point(651, 530);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(95, 93);
            this.updateRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateRecord.TabIndex = 63;
            this.updateRecord.TabStop = false;
            this.updateRecord.Click += new System.EventHandler(this.updateRecord_Click);
            // 
            // addRecord
            // 
            this.addRecord.Image = ((System.Drawing.Image)(resources.GetObject("addRecord.Image")));
            this.addRecord.Location = new System.Drawing.Point(766, 530);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(95, 93);
            this.addRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addRecord.TabIndex = 62;
            this.addRecord.TabStop = false;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("deleteRecord.Image")));
            this.deleteRecord.Location = new System.Drawing.Point(550, 530);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(95, 93);
            this.deleteRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteRecord.TabIndex = 61;
            this.deleteRecord.TabStop = false;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // clearScreen
            // 
            this.clearScreen.Image = ((System.Drawing.Image)(resources.GetObject("clearScreen.Image")));
            this.clearScreen.Location = new System.Drawing.Point(787, 12);
            this.clearScreen.Name = "clearScreen";
            this.clearScreen.Size = new System.Drawing.Size(74, 62);
            this.clearScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearScreen.TabIndex = 60;
            this.clearScreen.TabStop = false;
            this.clearScreen.Click += new System.EventHandler(this.clearScreen_Click);
            // 
            // refreshDisplay
            // 
            this.refreshDisplay.Image = ((System.Drawing.Image)(resources.GetObject("refreshDisplay.Image")));
            this.refreshDisplay.Location = new System.Drawing.Point(867, 12);
            this.refreshDisplay.Name = "refreshDisplay";
            this.refreshDisplay.Size = new System.Drawing.Size(62, 62);
            this.refreshDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshDisplay.TabIndex = 59;
            this.refreshDisplay.TabStop = false;
            this.refreshDisplay.Click += new System.EventHandler(this.refreshDisplay_Click);
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(246, 514);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(46, 47);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 58;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(935, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 62);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 57;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 640);
            this.Controls.Add(this.moveFirst);
            this.Controls.Add(this.moveNext);
            this.Controls.Add(this.moveLast);
            this.Controls.Add(this.movePrev);
            this.Controls.Add(this.updateRecord);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.clearScreen);
            this.Controls.Add(this.refreshDisplay);
            this.Controls.Add(this.search);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.motorID_cmb);
            this.Controls.Add(this.quntityInstock_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manuDate_dtp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.active_cmbox);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.supplier_txtbox);
            this.Controls.Add(this.inventoryId_txtbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventory_FormClosing);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inventoryId_txtbox;
        private System.Windows.Forms.TextBox supplier_txtbox;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.ComboBox active_cmbox;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker manuDate_dtp;
        private System.Windows.Forms.TextBox quntityInstock_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox motorID_cmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox moveFirst;
        private System.Windows.Forms.PictureBox moveNext;
        private System.Windows.Forms.PictureBox moveLast;
        private System.Windows.Forms.PictureBox movePrev;
        private System.Windows.Forms.PictureBox updateRecord;
        private System.Windows.Forms.PictureBox addRecord;
        private System.Windows.Forms.PictureBox deleteRecord;
        private System.Windows.Forms.PictureBox clearScreen;
        private System.Windows.Forms.PictureBox refreshDisplay;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.PictureBox exit;
    }
}