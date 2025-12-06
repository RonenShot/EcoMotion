
namespace EcoMotion.FORMS
{
    partial class frmSaleDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.codeSale_txtbox = new System.Windows.Forms.TextBox();
            this.motorSerialNumber_txtbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moveLast_btn = new System.Windows.Forms.Button();
            this.moveFirst_btn = new System.Windows.Forms.Button();
            this.moveNext_btn = new System.Windows.Forms.Button();
            this.movePrev_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Sale:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor Serial Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // codeSale_txtbox
            // 
            this.codeSale_txtbox.Location = new System.Drawing.Point(188, 108);
            this.codeSale_txtbox.Name = "codeSale_txtbox";
            this.codeSale_txtbox.Size = new System.Drawing.Size(136, 20);
            this.codeSale_txtbox.TabIndex = 9;
            // 
            // motorSerialNumber_txtbox
            // 
            this.motorSerialNumber_txtbox.Location = new System.Drawing.Point(188, 171);
            this.motorSerialNumber_txtbox.Name = "motorSerialNumber_txtbox";
            this.motorSerialNumber_txtbox.Size = new System.Drawing.Size(136, 20);
            this.motorSerialNumber_txtbox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 462);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 161);
            this.dataGridView1.TabIndex = 11;
            // 
            // moveLast_btn
            // 
            this.moveLast_btn.Location = new System.Drawing.Point(499, 330);
            this.moveLast_btn.Name = "moveLast_btn";
            this.moveLast_btn.Size = new System.Drawing.Size(49, 26);
            this.moveLast_btn.TabIndex = 12;
            this.moveLast_btn.Text = "<<";
            this.moveLast_btn.UseVisualStyleBackColor = true;
            this.moveLast_btn.Click += new System.EventHandler(this.moveLast_btn_Click);
            // 
            // moveFirst_btn
            // 
            this.moveFirst_btn.Location = new System.Drawing.Point(615, 330);
            this.moveFirst_btn.Name = "moveFirst_btn";
            this.moveFirst_btn.Size = new System.Drawing.Size(49, 26);
            this.moveFirst_btn.TabIndex = 13;
            this.moveFirst_btn.Text = ">>";
            this.moveFirst_btn.UseVisualStyleBackColor = true;
            this.moveFirst_btn.Click += new System.EventHandler(this.moveFirst_btn_Click);
            // 
            // moveNext_btn
            // 
            this.moveNext_btn.Location = new System.Drawing.Point(567, 298);
            this.moveNext_btn.Name = "moveNext_btn";
            this.moveNext_btn.Size = new System.Drawing.Size(37, 26);
            this.moveNext_btn.TabIndex = 14;
            this.moveNext_btn.Text = "+";
            this.moveNext_btn.UseVisualStyleBackColor = true;
            this.moveNext_btn.Click += new System.EventHandler(this.moveNext_btn_Click);
            // 
            // movePrev_btn
            // 
            this.movePrev_btn.Location = new System.Drawing.Point(567, 367);
            this.movePrev_btn.Name = "movePrev_btn";
            this.movePrev_btn.Size = new System.Drawing.Size(37, 26);
            this.movePrev_btn.TabIndex = 15;
            this.movePrev_btn.Text = "-";
            this.movePrev_btn.UseVisualStyleBackColor = true;
            this.movePrev_btn.Click += new System.EventHandler(this.movePrev_btn_Click);
            // 
            // frmSaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.movePrev_btn);
            this.Controls.Add(this.moveNext_btn);
            this.Controls.Add(this.moveFirst_btn);
            this.Controls.Add(this.moveLast_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.motorSerialNumber_txtbox);
            this.Controls.Add(this.codeSale_txtbox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSaleDetails";
            this.Text = "frmSaleDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSaleDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmSaleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox codeSale_txtbox;
        private System.Windows.Forms.TextBox motorSerialNumber_txtbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button moveLast_btn;
        private System.Windows.Forms.Button moveFirst_btn;
        private System.Windows.Forms.Button moveNext_btn;
        private System.Windows.Forms.Button movePrev_btn;
    }
}