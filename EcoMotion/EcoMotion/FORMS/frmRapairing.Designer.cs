
namespace EcoMotion.FORMS
{
    partial class frmRapairing
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
            this.workerID_txtbox = new System.Windows.Forms.TextBox();
            this.motorSerialNumber_txtbox = new System.Windows.Forms.TextBox();
            this.startDate_txtbox = new System.Windows.Forms.TextBox();
            this.endDate_txtbox = new System.Windows.Forms.TextBox();
            this.repairingDescription_txtbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.moveLast_btn = new System.Windows.Forms.Button();
            this.moveFirst_btn = new System.Windows.Forms.Button();
            this.moveNext_btn = new System.Windows.Forms.Button();
            this.movePrev_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repairing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(79, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Worker ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(79, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor Serial Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(79, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(79, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(79, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Repairing Description:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workerID_txtbox
            // 
            this.workerID_txtbox.Location = new System.Drawing.Point(185, 116);
            this.workerID_txtbox.Name = "workerID_txtbox";
            this.workerID_txtbox.Size = new System.Drawing.Size(179, 20);
            this.workerID_txtbox.TabIndex = 6;
            // 
            // motorSerialNumber_txtbox
            // 
            this.motorSerialNumber_txtbox.Location = new System.Drawing.Point(185, 159);
            this.motorSerialNumber_txtbox.Name = "motorSerialNumber_txtbox";
            this.motorSerialNumber_txtbox.Size = new System.Drawing.Size(179, 20);
            this.motorSerialNumber_txtbox.TabIndex = 7;
            // 
            // startDate_txtbox
            // 
            this.startDate_txtbox.Location = new System.Drawing.Point(185, 212);
            this.startDate_txtbox.Name = "startDate_txtbox";
            this.startDate_txtbox.Size = new System.Drawing.Size(179, 20);
            this.startDate_txtbox.TabIndex = 8;
            // 
            // endDate_txtbox
            // 
            this.endDate_txtbox.Location = new System.Drawing.Point(185, 260);
            this.endDate_txtbox.Name = "endDate_txtbox";
            this.endDate_txtbox.Size = new System.Drawing.Size(179, 20);
            this.endDate_txtbox.TabIndex = 9;
            // 
            // repairingDescription_txtbox
            // 
            this.repairingDescription_txtbox.Location = new System.Drawing.Point(185, 304);
            this.repairingDescription_txtbox.Name = "repairingDescription_txtbox";
            this.repairingDescription_txtbox.Size = new System.Drawing.Size(179, 20);
            this.repairingDescription_txtbox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 509);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 191);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 37);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // moveLast_btn
            // 
            this.moveLast_btn.Location = new System.Drawing.Point(507, 373);
            this.moveLast_btn.Name = "moveLast_btn";
            this.moveLast_btn.Size = new System.Drawing.Size(43, 22);
            this.moveLast_btn.TabIndex = 17;
            this.moveLast_btn.Text = "<<";
            this.moveLast_btn.UseVisualStyleBackColor = true;
            this.moveLast_btn.Click += new System.EventHandler(this.moveLast_btn_Click);
            // 
            // moveFirst_btn
            // 
            this.moveFirst_btn.Location = new System.Drawing.Point(632, 373);
            this.moveFirst_btn.Name = "moveFirst_btn";
            this.moveFirst_btn.Size = new System.Drawing.Size(43, 22);
            this.moveFirst_btn.TabIndex = 18;
            this.moveFirst_btn.Text = ">>";
            this.moveFirst_btn.UseVisualStyleBackColor = true;
            this.moveFirst_btn.Click += new System.EventHandler(this.moveFirst_btn_Click);
            // 
            // moveNext_btn
            // 
            this.moveNext_btn.Location = new System.Drawing.Point(571, 338);
            this.moveNext_btn.Name = "moveNext_btn";
            this.moveNext_btn.Size = new System.Drawing.Size(28, 22);
            this.moveNext_btn.TabIndex = 19;
            this.moveNext_btn.Text = "+";
            this.moveNext_btn.UseVisualStyleBackColor = true;
            this.moveNext_btn.Click += new System.EventHandler(this.moveNext_btn_Click);
            // 
            // movePrev_btn
            // 
            this.movePrev_btn.Location = new System.Drawing.Point(571, 408);
            this.movePrev_btn.Name = "movePrev_btn";
            this.movePrev_btn.Size = new System.Drawing.Size(28, 22);
            this.movePrev_btn.TabIndex = 20;
            this.movePrev_btn.Text = "-";
            this.movePrev_btn.UseVisualStyleBackColor = true;
            this.movePrev_btn.Click += new System.EventHandler(this.movePrev_btn_Click);
            // 
            // frmRapairing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 728);
            this.Controls.Add(this.movePrev_btn);
            this.Controls.Add(this.moveNext_btn);
            this.Controls.Add(this.moveFirst_btn);
            this.Controls.Add(this.moveLast_btn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.repairingDescription_txtbox);
            this.Controls.Add(this.endDate_txtbox);
            this.Controls.Add(this.startDate_txtbox);
            this.Controls.Add(this.motorSerialNumber_txtbox);
            this.Controls.Add(this.workerID_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRapairing";
            this.Text = "frmRapairing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRapairing_FormClosing);
            this.Load += new System.EventHandler(this.frmRapairing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox workerID_txtbox;
        private System.Windows.Forms.TextBox motorSerialNumber_txtbox;
        private System.Windows.Forms.TextBox startDate_txtbox;
        private System.Windows.Forms.TextBox endDate_txtbox;
        private System.Windows.Forms.TextBox repairingDescription_txtbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button moveLast_btn;
        private System.Windows.Forms.Button moveFirst_btn;
        private System.Windows.Forms.Button moveNext_btn;
        private System.Windows.Forms.Button movePrev_btn;
    }
}