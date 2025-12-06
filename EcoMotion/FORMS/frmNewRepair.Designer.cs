
namespace EcoMotion.FORMS
{
    partial class frmNewRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewRepair));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.repairingCode_txt = new System.Windows.Forms.TextBox();
            this.customerID_txt = new System.Windows.Forms.TextBox();
            this.motorSerialNumber_txt = new System.Windows.Forms.TextBox();
            this.faultDescription_txt = new System.Windows.Forms.TextBox();
            this.possibleCauses_txt = new System.Windows.Forms.TextBox();
            this.history_txt = new System.Windows.Forms.TextBox();
            this.startDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.endDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.status_cbm = new System.Windows.Forms.ComboBox();
            this.motorID_cbm = new System.Windows.Forms.ComboBox();
            this.warrenty_cbm = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.i_Cbox = new System.Windows.Forms.CheckBox();
            this.le_Cbox = new System.Windows.Forms.CheckBox();
            this.haMe_Cbox = new System.Windows.Forms.CheckBox();
            this.ye_Cbox = new System.Windows.Forms.CheckBox();
            this.h_Cbox = new System.Windows.Forms.CheckBox();
            this.p_Cbox = new System.Windows.Forms.CheckBox();
            this.addWorkerOperations_btn = new System.Windows.Forms.Button();
            this.saveFixing_btn = new System.Windows.Forms.Button();
            this.usage_dgv = new System.Windows.Forms.DataGridView();
            this.repair_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOperations_dgv = new System.Windows.Forms.DataGridView();
            this.repairCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairingDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareParts_dgv = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.refreshDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usage_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOperations_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareParts_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repairing Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor Serial Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(53, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motor ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(53, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fault Description:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(53, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Possible Causes:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(53, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Warranty:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(53, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "History:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(53, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Begining Date:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(53, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "End Date:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // repairingCode_txt
            // 
            this.repairingCode_txt.Location = new System.Drawing.Point(165, 117);
            this.repairingCode_txt.Name = "repairingCode_txt";
            this.repairingCode_txt.ReadOnly = true;
            this.repairingCode_txt.Size = new System.Drawing.Size(183, 20);
            this.repairingCode_txt.TabIndex = 11;
            // 
            // customerID_txt
            // 
            this.customerID_txt.Location = new System.Drawing.Point(165, 163);
            this.customerID_txt.Name = "customerID_txt";
            this.customerID_txt.ReadOnly = true;
            this.customerID_txt.Size = new System.Drawing.Size(183, 20);
            this.customerID_txt.TabIndex = 12;
            // 
            // motorSerialNumber_txt
            // 
            this.motorSerialNumber_txt.Location = new System.Drawing.Point(165, 203);
            this.motorSerialNumber_txt.Name = "motorSerialNumber_txt";
            this.motorSerialNumber_txt.Size = new System.Drawing.Size(183, 20);
            this.motorSerialNumber_txt.TabIndex = 13;
            // 
            // faultDescription_txt
            // 
            this.faultDescription_txt.Location = new System.Drawing.Point(165, 342);
            this.faultDescription_txt.Name = "faultDescription_txt";
            this.faultDescription_txt.Size = new System.Drawing.Size(183, 20);
            this.faultDescription_txt.TabIndex = 14;
            // 
            // possibleCauses_txt
            // 
            this.possibleCauses_txt.Location = new System.Drawing.Point(165, 383);
            this.possibleCauses_txt.Name = "possibleCauses_txt";
            this.possibleCauses_txt.Size = new System.Drawing.Size(183, 20);
            this.possibleCauses_txt.TabIndex = 15;
            // 
            // history_txt
            // 
            this.history_txt.Location = new System.Drawing.Point(165, 468);
            this.history_txt.Name = "history_txt";
            this.history_txt.Size = new System.Drawing.Size(183, 20);
            this.history_txt.TabIndex = 16;
            // 
            // startDate_dtp
            // 
            this.startDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate_dtp.Location = new System.Drawing.Point(165, 513);
            this.startDate_dtp.Name = "startDate_dtp";
            this.startDate_dtp.Size = new System.Drawing.Size(183, 20);
            this.startDate_dtp.TabIndex = 18;
            // 
            // endDate_dtp
            // 
            this.endDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate_dtp.Location = new System.Drawing.Point(165, 561);
            this.endDate_dtp.Name = "endDate_dtp";
            this.endDate_dtp.Size = new System.Drawing.Size(183, 20);
            this.endDate_dtp.TabIndex = 19;
            // 
            // status_cbm
            // 
            this.status_cbm.FormattingEnabled = true;
            this.status_cbm.Items.AddRange(new object[] {
            "בשיפוץ",
            "נמסר"});
            this.status_cbm.Location = new System.Drawing.Point(165, 250);
            this.status_cbm.Name = "status_cbm";
            this.status_cbm.Size = new System.Drawing.Size(183, 21);
            this.status_cbm.TabIndex = 20;
            // 
            // motorID_cbm
            // 
            this.motorID_cbm.FormattingEnabled = true;
            this.motorID_cbm.Location = new System.Drawing.Point(165, 291);
            this.motorID_cbm.Name = "motorID_cbm";
            this.motorID_cbm.Size = new System.Drawing.Size(183, 21);
            this.motorID_cbm.TabIndex = 21;
            // 
            // warrenty_cbm
            // 
            this.warrenty_cbm.FormattingEnabled = true;
            this.warrenty_cbm.Items.AddRange(new object[] {
            "כן",
            "לא"});
            this.warrenty_cbm.Location = new System.Drawing.Point(165, 419);
            this.warrenty_cbm.Name = "warrenty_cbm";
            this.warrenty_cbm.Size = new System.Drawing.Size(183, 21);
            this.warrenty_cbm.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(53, 599);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Repairing Description:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // i_Cbox
            // 
            this.i_Cbox.AutoSize = true;
            this.i_Cbox.Location = new System.Drawing.Point(180, 723);
            this.i_Cbox.Name = "i_Cbox";
            this.i_Cbox.Size = new System.Drawing.Size(54, 17);
            this.i_Cbox.TabIndex = 58;
            this.i_Cbox.Text = "איזון";
            this.i_Cbox.UseVisualStyleBackColor = true;
            // 
            // le_Cbox
            // 
            this.le_Cbox.AutoSize = true;
            this.le_Cbox.Location = new System.Drawing.Point(180, 700);
            this.le_Cbox.Name = "le_Cbox";
            this.le_Cbox.Size = new System.Drawing.Size(57, 17);
            this.le_Cbox.TabIndex = 57;
            this.le_Cbox.Text = "ליפוף";
            this.le_Cbox.UseVisualStyleBackColor = true;
            // 
            // haMe_Cbox
            // 
            this.haMe_Cbox.AutoSize = true;
            this.haMe_Cbox.Location = new System.Drawing.Point(180, 677);
            this.haMe_Cbox.Name = "haMe_Cbox";
            this.haMe_Cbox.Size = new System.Drawing.Size(102, 17);
            this.haMe_Cbox.TabIndex = 56;
            this.haMe_Cbox.Text = "החלפת מיסבים";
            this.haMe_Cbox.UseVisualStyleBackColor = true;
            // 
            // ye_Cbox
            // 
            this.ye_Cbox.AutoSize = true;
            this.ye_Cbox.Location = new System.Drawing.Point(180, 654);
            this.ye_Cbox.Name = "ye_Cbox";
            this.ye_Cbox.Size = new System.Drawing.Size(57, 17);
            this.ye_Cbox.TabIndex = 55;
            this.ye_Cbox.Text = "ייבוש";
            this.ye_Cbox.UseVisualStyleBackColor = true;
            // 
            // h_Cbox
            // 
            this.h_Cbox.AutoSize = true;
            this.h_Cbox.Location = new System.Drawing.Point(180, 628);
            this.h_Cbox.Name = "h_Cbox";
            this.h_Cbox.Size = new System.Drawing.Size(60, 17);
            this.h_Cbox.TabIndex = 54;
            this.h_Cbox.Text = "הרכבה";
            this.h_Cbox.UseVisualStyleBackColor = true;
            // 
            // p_Cbox
            // 
            this.p_Cbox.AutoSize = true;
            this.p_Cbox.Location = new System.Drawing.Point(180, 605);
            this.p_Cbox.Name = "p_Cbox";
            this.p_Cbox.Size = new System.Drawing.Size(56, 17);
            this.p_Cbox.TabIndex = 53;
            this.p_Cbox.Text = "פירוק";
            this.p_Cbox.UseVisualStyleBackColor = true;
            // 
            // addWorkerOperations_btn
            // 
            this.addWorkerOperations_btn.Location = new System.Drawing.Point(470, 151);
            this.addWorkerOperations_btn.Name = "addWorkerOperations_btn";
            this.addWorkerOperations_btn.Size = new System.Drawing.Size(110, 46);
            this.addWorkerOperations_btn.TabIndex = 59;
            this.addWorkerOperations_btn.Text = "Add worker operations";
            this.addWorkerOperations_btn.UseVisualStyleBackColor = true;
            this.addWorkerOperations_btn.Click += new System.EventHandler(this.addWorkerOperations_btn_Click);
            // 
            // saveFixing_btn
            // 
            this.saveFixing_btn.Location = new System.Drawing.Point(56, 780);
            this.saveFixing_btn.Name = "saveFixing_btn";
            this.saveFixing_btn.Size = new System.Drawing.Size(110, 46);
            this.saveFixing_btn.TabIndex = 60;
            this.saveFixing_btn.Text = "Save Fixing";
            this.saveFixing_btn.UseVisualStyleBackColor = true;
            this.saveFixing_btn.Click += new System.EventHandler(this.saveFixing_btn_Click);
            // 
            // usage_dgv
            // 
            this.usage_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usage_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repair_Code,
            this.partCode,
            this.partName,
            this.totalPrice,
            this.quantity});
            this.usage_dgv.Location = new System.Drawing.Point(664, 342);
            this.usage_dgv.Name = "usage_dgv";
            this.usage_dgv.Size = new System.Drawing.Size(645, 178);
            this.usage_dgv.TabIndex = 62;
            // 
            // repair_Code
            // 
            this.repair_Code.HeaderText = "Repair_code";
            this.repair_Code.Name = "repair_Code";
            // 
            // partCode
            // 
            this.partCode.HeaderText = "Part_code";
            this.partCode.Name = "partCode";
            // 
            // partName
            // 
            this.partName.HeaderText = "Part_name";
            this.partName.Name = "partName";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total_price";
            this.totalPrice.Name = "totalPrice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // totalOperations_dgv
            // 
            this.totalOperations_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalOperations_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairCode,
            this.workerID,
            this.workerName,
            this.hoursCount,
            this.repairingDescription});
            this.totalOperations_dgv.Location = new System.Drawing.Point(664, 69);
            this.totalOperations_dgv.Name = "totalOperations_dgv";
            this.totalOperations_dgv.Size = new System.Drawing.Size(645, 178);
            this.totalOperations_dgv.TabIndex = 63;
            // 
            // repairCode
            // 
            this.repairCode.HeaderText = "Repair_code";
            this.repairCode.Name = "repairCode";
            // 
            // workerID
            // 
            this.workerID.HeaderText = "Worker_ID";
            this.workerID.Name = "workerID";
            // 
            // workerName
            // 
            this.workerName.HeaderText = "Worker_name";
            this.workerName.Name = "workerName";
            // 
            // hoursCount
            // 
            this.hoursCount.HeaderText = "Hours_count";
            this.hoursCount.Name = "hoursCount";
            // 
            // repairingDescription
            // 
            this.repairingDescription.HeaderText = "Repairin_description";
            this.repairingDescription.Name = "repairingDescription";
            // 
            // spareParts_dgv
            // 
            this.spareParts_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spareParts_dgv.Location = new System.Drawing.Point(664, 616);
            this.spareParts_dgv.Name = "spareParts_dgv";
            this.spareParts_dgv.Size = new System.Drawing.Size(645, 178);
            this.spareParts_dgv.TabIndex = 64;
            this.spareParts_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.spareParts_dgv_RowHeaderMouseClick);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(661, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 23);
            this.label13.TabIndex = 65;
            this.label13.Text = "Wokers Operations:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(661, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 23);
            this.label14.TabIndex = 66;
            this.label14.Text = "Spare Parts Usage:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(661, 543);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 23);
            this.label15.TabIndex = 67;
            this.label15.Text = "Spare Parts Stock:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1283, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 62);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 70;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // refreshDisplay
            // 
            this.refreshDisplay.Image = ((System.Drawing.Image)(resources.GetObject("refreshDisplay.Image")));
            this.refreshDisplay.Location = new System.Drawing.Point(1215, 1);
            this.refreshDisplay.Name = "refreshDisplay";
            this.refreshDisplay.Size = new System.Drawing.Size(62, 62);
            this.refreshDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshDisplay.TabIndex = 71;
            this.refreshDisplay.TabStop = false;
            this.refreshDisplay.Click += new System.EventHandler(this.refreshDisplay_Click);
            // 
            // frmNewRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1345, 861);
            this.Controls.Add(this.refreshDisplay);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.spareParts_dgv);
            this.Controls.Add(this.totalOperations_dgv);
            this.Controls.Add(this.usage_dgv);
            this.Controls.Add(this.saveFixing_btn);
            this.Controls.Add(this.addWorkerOperations_btn);
            this.Controls.Add(this.i_Cbox);
            this.Controls.Add(this.le_Cbox);
            this.Controls.Add(this.haMe_Cbox);
            this.Controls.Add(this.ye_Cbox);
            this.Controls.Add(this.h_Cbox);
            this.Controls.Add(this.p_Cbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.warrenty_cbm);
            this.Controls.Add(this.motorID_cbm);
            this.Controls.Add(this.status_cbm);
            this.Controls.Add(this.endDate_dtp);
            this.Controls.Add(this.startDate_dtp);
            this.Controls.Add(this.history_txt);
            this.Controls.Add(this.possibleCauses_txt);
            this.Controls.Add(this.faultDescription_txt);
            this.Controls.Add(this.motorSerialNumber_txt);
            this.Controls.Add(this.customerID_txt);
            this.Controls.Add(this.repairingCode_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewRepair";
            this.Text = "frmNewRepair";
            this.Load += new System.EventHandler(this.frmNewRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usage_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalOperations_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareParts_dgv)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox repairingCode_txt;
        private System.Windows.Forms.TextBox customerID_txt;
        private System.Windows.Forms.TextBox motorSerialNumber_txt;
        private System.Windows.Forms.TextBox faultDescription_txt;
        private System.Windows.Forms.TextBox possibleCauses_txt;
        private System.Windows.Forms.TextBox history_txt;
        private System.Windows.Forms.DateTimePicker startDate_dtp;
        private System.Windows.Forms.DateTimePicker endDate_dtp;
        private System.Windows.Forms.ComboBox status_cbm;
        private System.Windows.Forms.ComboBox motorID_cbm;
        private System.Windows.Forms.ComboBox warrenty_cbm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox i_Cbox;
        private System.Windows.Forms.CheckBox le_Cbox;
        private System.Windows.Forms.CheckBox haMe_Cbox;
        private System.Windows.Forms.CheckBox ye_Cbox;
        private System.Windows.Forms.CheckBox h_Cbox;
        private System.Windows.Forms.CheckBox p_Cbox;
        private System.Windows.Forms.Button addWorkerOperations_btn;
        private System.Windows.Forms.Button saveFixing_btn;
        private System.Windows.Forms.DataGridView usage_dgv;
        private System.Windows.Forms.DataGridView totalOperations_dgv;
        private System.Windows.Forms.DataGridView spareParts_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairingDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn repair_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox refreshDisplay;
    }
}