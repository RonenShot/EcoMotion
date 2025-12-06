
namespace EcoMotion.FORMS
{
    partial class frmSpareParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpareParts));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idPart_txt = new System.Windows.Forms.TextBox();
            this.namePart_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.manufcturCountry_txt = new System.Windows.Forms.TextBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.quantityInStock_txt = new System.Windows.Forms.TextBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.refreshDisplay_btn = new System.Windows.Forms.Button();
            this.clearScr_btn = new System.Windows.Forms.Button();
            this.deleteRecord_btn = new System.Windows.Forms.Button();
            this.addRecord_btn = new System.Windows.Forms.Button();
            this.updateRecord_btn = new System.Windows.Forms.Button();
            this.moveLast_btn = new System.Windows.Forms.Button();
            this.moveFirst_btn = new System.Windows.Forms.Button();
            this.movePrev_btn = new System.Windows.Forms.Button();
            this.moveNext_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.active_cmb = new System.Windows.Forms.ComboBox();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spare Parts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Part:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Part Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manufctur Country:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(37, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(37, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity In Stock:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idPart_txt
            // 
            this.idPart_txt.Location = new System.Drawing.Point(237, 128);
            this.idPart_txt.Name = "idPart_txt";
            this.idPart_txt.Size = new System.Drawing.Size(181, 20);
            this.idPart_txt.TabIndex = 10;
            // 
            // namePart_txt
            // 
            this.namePart_txt.Location = new System.Drawing.Point(237, 166);
            this.namePart_txt.Name = "namePart_txt";
            this.namePart_txt.Size = new System.Drawing.Size(181, 20);
            this.namePart_txt.TabIndex = 11;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(237, 207);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(181, 20);
            this.price_txt.TabIndex = 12;
            // 
            // manufcturCountry_txt
            // 
            this.manufcturCountry_txt.Location = new System.Drawing.Point(237, 256);
            this.manufcturCountry_txt.Name = "manufcturCountry_txt";
            this.manufcturCountry_txt.Size = new System.Drawing.Size(181, 20);
            this.manufcturCountry_txt.TabIndex = 13;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(237, 297);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(181, 20);
            this.quantity_txt.TabIndex = 14;
            // 
            // quantityInStock_txt
            // 
            this.quantityInStock_txt.Location = new System.Drawing.Point(237, 336);
            this.quantityInStock_txt.Name = "quantityInStock_txt";
            this.quantityInStock_txt.Size = new System.Drawing.Size(181, 20);
            this.quantityInStock_txt.TabIndex = 15;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(42, 474);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(181, 20);
            this.search_txt.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID Part:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(327, 666);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(124, 33);
            this.search_btn.TabIndex = 21;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // refreshDisplay_btn
            // 
            this.refreshDisplay_btn.Location = new System.Drawing.Point(55, 647);
            this.refreshDisplay_btn.Name = "refreshDisplay_btn";
            this.refreshDisplay_btn.Size = new System.Drawing.Size(58, 59);
            this.refreshDisplay_btn.TabIndex = 22;
            this.refreshDisplay_btn.Text = "Refresh Display";
            this.refreshDisplay_btn.UseVisualStyleBackColor = true;
            this.refreshDisplay_btn.Click += new System.EventHandler(this.refreshDisplay_btn_Click);
            // 
            // clearScr_btn
            // 
            this.clearScr_btn.Location = new System.Drawing.Point(162, 647);
            this.clearScr_btn.Name = "clearScr_btn";
            this.clearScr_btn.Size = new System.Drawing.Size(58, 59);
            this.clearScr_btn.TabIndex = 23;
            this.clearScr_btn.Text = "Clear Scr";
            this.clearScr_btn.UseVisualStyleBackColor = true;
            this.clearScr_btn.Click += new System.EventHandler(this.clearScr_btn_Click);
            // 
            // deleteRecord_btn
            // 
            this.deleteRecord_btn.Location = new System.Drawing.Point(55, 737);
            this.deleteRecord_btn.Name = "deleteRecord_btn";
            this.deleteRecord_btn.Size = new System.Drawing.Size(58, 59);
            this.deleteRecord_btn.TabIndex = 24;
            this.deleteRecord_btn.Text = "Delete Record";
            this.deleteRecord_btn.UseVisualStyleBackColor = true;
            this.deleteRecord_btn.Click += new System.EventHandler(this.deleteRecord_btn_Click);
            // 
            // addRecord_btn
            // 
            this.addRecord_btn.Location = new System.Drawing.Point(162, 737);
            this.addRecord_btn.Name = "addRecord_btn";
            this.addRecord_btn.Size = new System.Drawing.Size(58, 59);
            this.addRecord_btn.TabIndex = 25;
            this.addRecord_btn.Text = "Add Record";
            this.addRecord_btn.UseVisualStyleBackColor = true;
            this.addRecord_btn.Click += new System.EventHandler(this.addRecord_btn_Click);
            // 
            // updateRecord_btn
            // 
            this.updateRecord_btn.Location = new System.Drawing.Point(303, 750);
            this.updateRecord_btn.Name = "updateRecord_btn";
            this.updateRecord_btn.Size = new System.Drawing.Size(58, 59);
            this.updateRecord_btn.TabIndex = 26;
            this.updateRecord_btn.Text = "Update Record";
            this.updateRecord_btn.UseVisualStyleBackColor = true;
            this.updateRecord_btn.Click += new System.EventHandler(this.updateRecord_btn_Click);
            // 
            // moveLast_btn
            // 
            this.moveLast_btn.Location = new System.Drawing.Point(171, 705);
            this.moveLast_btn.Name = "moveLast_btn";
            this.moveLast_btn.Size = new System.Drawing.Size(60, 32);
            this.moveLast_btn.TabIndex = 27;
            this.moveLast_btn.Text = "<<";
            this.moveLast_btn.UseVisualStyleBackColor = true;
            this.moveLast_btn.Click += new System.EventHandler(this.moveLast_btn_Click);
            // 
            // moveFirst_btn
            // 
            this.moveFirst_btn.Location = new System.Drawing.Point(301, 705);
            this.moveFirst_btn.Name = "moveFirst_btn";
            this.moveFirst_btn.Size = new System.Drawing.Size(60, 32);
            this.moveFirst_btn.TabIndex = 28;
            this.moveFirst_btn.Text = ">>";
            this.moveFirst_btn.UseVisualStyleBackColor = true;
            this.moveFirst_btn.Click += new System.EventHandler(this.moveFirst_btn_Click);
            // 
            // movePrev_btn
            // 
            this.movePrev_btn.Location = new System.Drawing.Point(249, 757);
            this.movePrev_btn.Name = "movePrev_btn";
            this.movePrev_btn.Size = new System.Drawing.Size(37, 32);
            this.movePrev_btn.TabIndex = 29;
            this.movePrev_btn.Text = "-";
            this.movePrev_btn.UseVisualStyleBackColor = true;
            this.movePrev_btn.Click += new System.EventHandler(this.movePrev_btn_Click);
            // 
            // moveNext_btn
            // 
            this.moveNext_btn.Location = new System.Drawing.Point(249, 674);
            this.moveNext_btn.Name = "moveNext_btn";
            this.moveNext_btn.Size = new System.Drawing.Size(37, 32);
            this.moveNext_btn.TabIndex = 30;
            this.moveNext_btn.Text = "+";
            this.moveNext_btn.UseVisualStyleBackColor = true;
            this.moveNext_btn.Click += new System.EventHandler(this.moveNext_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(486, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 208);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(37, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Active:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // active_cmb
            // 
            this.active_cmb.FormattingEnabled = true;
            this.active_cmb.Items.AddRange(new object[] {
            "כן ",
            "לא"});
            this.active_cmb.Location = new System.Drawing.Point(237, 381);
            this.active_cmb.Name = "active_cmb";
            this.active_cmb.Size = new System.Drawing.Size(180, 21);
            this.active_cmb.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(646, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // moveFirst
            // 
            this.moveFirst.Image = ((System.Drawing.Image)(resources.GetObject("moveFirst.Image")));
            this.moveFirst.Location = new System.Drawing.Point(756, 2);
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
            this.moveNext.Location = new System.Drawing.Point(675, 2);
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
            this.moveLast.Location = new System.Drawing.Point(499, 2);
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
            this.movePrev.Location = new System.Drawing.Point(585, 2);
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
            this.updateRecord.Location = new System.Drawing.Point(709, 488);
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
            this.addRecord.Location = new System.Drawing.Point(810, 488);
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
            this.deleteRecord.Location = new System.Drawing.Point(608, 488);
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
            this.clearScreen.Location = new System.Drawing.Point(837, 2);
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
            this.refreshDisplay.Location = new System.Drawing.Point(917, 2);
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
            this.search.Location = new System.Drawing.Point(249, 461);
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
            this.exit.Location = new System.Drawing.Point(985, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 62);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 57;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // frmSpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 594);
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
            this.Controls.Add(this.active_cmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.moveNext_btn);
            this.Controls.Add(this.movePrev_btn);
            this.Controls.Add(this.moveFirst_btn);
            this.Controls.Add(this.moveLast_btn);
            this.Controls.Add(this.updateRecord_btn);
            this.Controls.Add(this.addRecord_btn);
            this.Controls.Add(this.deleteRecord_btn);
            this.Controls.Add(this.clearScr_btn);
            this.Controls.Add(this.refreshDisplay_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.quantityInStock_txt);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.manufcturCountry_txt);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.namePart_txt);
            this.Controls.Add(this.idPart_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSpareParts";
            this.Text = "frmFactory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSpareParts_FormClosing);
            this.Load += new System.EventHandler(this.frmSpareParts_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idPart_txt;
        private System.Windows.Forms.TextBox namePart_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox manufcturCountry_txt;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.TextBox quantityInStock_txt;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button refreshDisplay_btn;
        private System.Windows.Forms.Button clearScr_btn;
        private System.Windows.Forms.Button deleteRecord_btn;
        private System.Windows.Forms.Button addRecord_btn;
        private System.Windows.Forms.Button updateRecord_btn;
        private System.Windows.Forms.Button moveLast_btn;
        private System.Windows.Forms.Button moveFirst_btn;
        private System.Windows.Forms.Button movePrev_btn;
        private System.Windows.Forms.Button moveNext_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox active_cmb;
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